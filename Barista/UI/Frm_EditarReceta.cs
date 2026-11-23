using Barista.Data;
using Barista.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Barista.UI
{
    public partial class Frm_EditarReceta : Form
    {
        private readonly Contexto _contexto;
        private readonly int _idReceta;

        private List<Bebida> _bebidas = new();
        private List<Ingrediente> _ingredientes = new();
        private readonly List<string> _listaPasos = new();

        public Frm_EditarReceta(Contexto contexto, int idReceta = 0)
        {
            InitializeComponent();
            _contexto = contexto;
            _idReceta = idReceta;

            Load += Frm_EditarReceta_Load;
        }

        private async void Frm_EditarReceta_Load(object? sender, EventArgs e)
        {
            if (_idReceta > 0)
            {
                Lbl_Titulo.Text = "✏️ Modificar Receta Existente";
                Text = "Modificar Receta";
            }
            else
            {
                Lbl_Titulo.Text = "➕ Nueva Receta de Barista";
                Text = "Nueva Receta";
            }

            await CargarDatosBaseAsync();

            if (_idReceta > 0)
            {
                await CargarRecetaParaEditarAsync();
            }
        }

        private async Task CargarDatosBaseAsync()
        {
            try
            {
                _bebidas = await _contexto.Bebidas
                    .Where(b => b.Estado)
                    .OrderBy(b => b.Nombre)
                    .ToListAsync();

                // Sugerencias de nombres existentes: también se puede escribir uno nuevo
                var nombresBebidas = new AutoCompleteStringCollection();
                nombresBebidas.AddRange(_bebidas.Select(b => b.Nombre).ToArray());
                Txt_Bebida.AutoCompleteCustomSource = nombresBebidas;

                // Categorías existentes: también se puede escribir una categoría nueva
                var categorias = await _contexto.Categorias
                    .OrderBy(c => c.Nombre)
                    .ToListAsync();

                Cmb_Categoria.DisplayMember = "Nombre";
                Cmb_Categoria.ValueMember = "IdCategoria";
                Cmb_Categoria.DataSource = categorias;

                _ingredientes = await _contexto.Ingredientes
                    .OrderBy(i => i.Nombre)
                    .ToListAsync();

                Cmb_Ingredientes.DisplayMember = "Nombre";
                Cmb_Ingredientes.ValueMember = "IdIngrediente";
                Cmb_Ingredientes.DataSource = _ingredientes;

                ActualizarEtiquetaUnidad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos base: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarRecetaParaEditarAsync()
        {
            try
            {
                var receta = await _contexto.Recetas
                    .Include(r => r.Bebida!)
                        .ThenInclude(b => b.Categoria)
                    .Include(r => r.RecetaIngredientes)
                        .ThenInclude(ri => ri.Ingrediente)
                    .Include(r => r.PasosPreparacion)
                    .FirstOrDefaultAsync(r => r.IdReceta == _idReceta);

                if (receta == null)
                {
                    MessageBox.Show("No se encontró la receta a editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                Txt_Bebida.Text = receta.Bebida?.Nombre ?? "";
                Cmb_Categoria.Text = receta.Bebida?.Categoria?.Nombre ?? "";
                Cmb_Tamano.Text = receta.Tamaño;

                // Cargar ingredientes
                Dgv_Ingredientes.Rows.Clear();
                foreach (var ri in receta.RecetaIngredientes)
                {
                    string nombre = ri.Ingrediente?.Nombre ?? $"Insumo #{ri.IdIngrediente}";
                    string unidad = ri.Ingrediente?.Unidad ?? "";
                    Dgv_Ingredientes.Rows.Add(ri.IdIngrediente, nombre, ri.Cantidad.ToString("0.##"), unidad);
                }

                // Cargar pasos
                _listaPasos.Clear();
                var pasosOrdenados = receta.PasosPreparacion.OrderBy(p => p.NumeroPaso).ToList();
                foreach (var paso in pasosOrdenados)
                {
                    _listaPasos.Add(paso.Instruccion);
                }
                RefrescarListaPasos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la receta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cmb_Ingredientes_SelectedIndexChanged(object? sender, EventArgs e)
        {
            ActualizarEtiquetaUnidad();
        }

        private void ActualizarEtiquetaUnidad()
        {
            if (Cmb_Ingredientes.SelectedItem is Ingrediente ing)
            {
                Lbl_Unidad.Text = ing.Unidad;
            }
            else
            {
                Lbl_Unidad.Text = "-";
            }
        }

        private void Btn_AgregarIngrediente_Click(object? sender, EventArgs e)
        {
            if (Cmb_Ingredientes.SelectedItem is not Ingrediente ing)
            {
                MessageBox.Show("Selecciona un insumo de la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal cantidad = Num_Cantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("Ingresa una cantidad mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Comprobar si ya está agregado
            foreach (DataGridViewRow row in Dgv_Ingredientes.Rows)
            {
                if (row.Cells[0].Value is int id && id == ing.IdIngrediente)
                {
                    row.Cells[2].Value = cantidad.ToString("0.##");
                    return;
                }
            }

            Dgv_Ingredientes.Rows.Add(ing.IdIngrediente, ing.Nombre, cantidad.ToString("0.##"), ing.Unidad);
        }

        private void Dgv_Ingredientes_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4) // Columna Eliminar
            {
                Dgv_Ingredientes.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void Btn_AgregarPaso_Click(object? sender, EventArgs e)
        {
            string instruccion = Txt_NuevaInstruccion.Text.Trim();
            if (string.IsNullOrWhiteSpace(instruccion))
            {
                MessageBox.Show("Escribe la indicación o instrucción del paso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _listaPasos.Add(instruccion);
            Txt_NuevaInstruccion.Clear();
            RefrescarListaPasos();
            Lst_Pasos.SelectedIndex = _listaPasos.Count - 1;
            Txt_NuevaInstruccion.Focus();
        }

        private void Btn_SubirPaso_Click(object? sender, EventArgs e)
        {
            int idx = Lst_Pasos.SelectedIndex;
            if (idx > 0)
            {
                string temp = _listaPasos[idx];
                _listaPasos[idx] = _listaPasos[idx - 1];
                _listaPasos[idx - 1] = temp;
                RefrescarListaPasos();
                Lst_Pasos.SelectedIndex = idx - 1;
            }
        }

        private void Btn_BajarPaso_Click(object? sender, EventArgs e)
        {
            int idx = Lst_Pasos.SelectedIndex;
            if (idx >= 0 && idx < _listaPasos.Count - 1)
            {
                string temp = _listaPasos[idx];
                _listaPasos[idx] = _listaPasos[idx + 1];
                _listaPasos[idx + 1] = temp;
                RefrescarListaPasos();
                Lst_Pasos.SelectedIndex = idx + 1;
            }
        }

        private void Btn_EliminarPaso_Click(object? sender, EventArgs e)
        {
            int idx = Lst_Pasos.SelectedIndex;
            if (idx >= 0 && idx < _listaPasos.Count)
            {
                _listaPasos.RemoveAt(idx);
                RefrescarListaPasos();
                if (_listaPasos.Count > 0)
                {
                    Lst_Pasos.SelectedIndex = Math.Min(idx, _listaPasos.Count - 1);
                }
            }
        }

        private void RefrescarListaPasos()
        {
            Lst_Pasos.Items.Clear();
            for (int i = 0; i < _listaPasos.Count; i++)
            {
                Lst_Pasos.Items.Add($"Paso {i + 1}: {_listaPasos[i]}");
            }
        }

        private async void Btn_Guardar_Click(object? sender, EventArgs e)
        {
            string nombreBebida = Txt_Bebida.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreBebida))
            {
                MessageBox.Show("Por favor escribe el nombre de la bebida de la receta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_Bebida.Focus();
                return;
            }

            string nombreCategoria = Cmb_Categoria.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreCategoria))
            {
                MessageBox.Show("Por favor selecciona o escribe la categoría de la receta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmb_Categoria.Focus();
                return;
            }

            string tamano = Cmb_Tamano.Text.Trim();
            if (string.IsNullOrWhiteSpace(tamano))
            {
                MessageBox.Show("Por favor ingresa o selecciona el tamaño de la receta (ej. Chico (250 ml), Mediano, etc.).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Cmb_Tamano.Focus();
                return;
            }

            if (Dgv_Ingredientes.Rows.Count == 0)
            {
                MessageBox.Show("Debes agregar al menos un ingrediente a la receta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_listaPasos.Count == 0)
            {
                MessageBox.Show("Debes redactar al menos un paso de preparación para enseñar al barista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Txt_NuevaInstruccion.Focus();
                return;
            }

            try
            {
                Btn_Guardar.Enabled = false;

                // Resolver la categoría (si no existe, se crea automáticamente)
                var categoria = await _contexto.Categorias
                    .FirstOrDefaultAsync(c => c.Nombre.ToLower() == nombreCategoria.ToLower());

                if (categoria == null)
                {
                    categoria = new Categoria { Nombre = nombreCategoria };
                    _contexto.Categorias.Add(categoria);
                    await _contexto.SaveChangesAsync();
                }

                // Resolver la bebida por nombre: si ya existe se reutiliza
                // (aunque esté escrita con otras mayúsculas/minúsculas), si no se crea.
                var bebida = await _contexto.Bebidas
                    .FirstOrDefaultAsync(b => b.Nombre.ToLower() == nombreBebida.ToLower());

                if (bebida == null)
                {
                    bebida = new Bebida { Nombre = nombreBebida };
                    _contexto.Bebidas.Add(bebida);
                }

                bebida.IdCategoria = categoria.IdCategoria;

                await _contexto.SaveChangesAsync(); // Genera el Id de la bebida si es nueva

                Receta receta;
                if (_idReceta > 0)
                {
                    // Modo Edición
                    var existente = await _contexto.Recetas
                        .Include(r => r.RecetaIngredientes)
                        .Include(r => r.PasosPreparacion)
                        .FirstOrDefaultAsync(r => r.IdReceta == _idReceta);

                    if (existente == null)
                    {
                        MessageBox.Show("La receta que intentas modificar ya no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    receta = existente;
                    receta.IdBebida = bebida.IdBebida;
                    receta.Tamaño = tamano;

                    // Remover ingredientes y pasos anteriores
                    _contexto.RecetaIngredientes.RemoveRange(receta.RecetaIngredientes);
                    _contexto.PasosPreparacion.RemoveRange(receta.PasosPreparacion);
                }
                else
                {
                    // Modo Creación
                    receta = new Receta
                    {
                        IdBebida = bebida.IdBebida,
                        Tamaño = tamano
                    };
                    _contexto.Recetas.Add(receta);
                    await _contexto.SaveChangesAsync(); // Genera IdReceta
                }

                // Asignar ingredientes
                foreach (DataGridViewRow row in Dgv_Ingredientes.Rows)
                {
                    int idIng = row.Cells[0].Value is int val ? val : 0;
                    decimal cant = decimal.TryParse(row.Cells[2].Value?.ToString(), out var c) ? c : 0m;

                    receta.RecetaIngredientes.Add(new RecetaIngrediente
                    {
                        IdReceta = receta.IdReceta,
                        IdIngrediente = idIng,
                        Cantidad = cant
                    });
                }

                // Asignar pasos
                for (int i = 0; i < _listaPasos.Count; i++)
                {
                    receta.PasosPreparacion.Add(new PasoPreparacion
                    {
                        IdReceta = receta.IdReceta,
                        NumeroPaso = i + 1,
                        Instruccion = _listaPasos[i]
                    });
                }

                await _contexto.SaveChangesAsync();

                MessageBox.Show("¡Receta guardada exitosamente!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la receta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Btn_Guardar.Enabled = true;
            }
        }

        private void Btn_Cancelar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
