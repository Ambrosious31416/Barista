using Barista.Data;
using Barista.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Barista.UI
{
    public partial class Frm_Inventario : Form
    {
        private readonly Contexto _contexto;
        private Usuario? _usuarioAutorizado = null;
        private List<Ingrediente> _ingredientesTodos = new();

        public Frm_Inventario()
        {
            InitializeComponent();

            var factory = new ContextoFactory();
            _contexto = factory.CreateDbContext(Array.Empty<string>());

            Cmb_FiltroStock.SelectedIndex = 0;
            Load += Frm_Inventario_Load;
            FormClosed += (s, e) => _contexto.Dispose();
        }

        private async void Frm_Inventario_Load(object? sender, EventArgs e)
        {
            await CargarInventarioAsync();
        }

        private async Task CargarInventarioAsync()
        {
            try
            {
                _ingredientesTodos = await _contexto.Ingredientes
                    .AsNoTracking()
                    .OrderBy(i => i.Nombre)
                    .ToListAsync();

                int total = _ingredientesTodos.Count;
                int bajos = _ingredientesTodos.Count(i => i.StockActual <= i.StockMinimo);
                int optimos = total - bajos;

                Lbl_TotalInsumos.Text = $"📦 Total: {total}";
                Lbl_InsumosOptimos.Text = $"✅ Óptimos: {optimos}";
                Lbl_InsumosBajos.Text = $"⚠️ Stock Bajo: {bajos}";

                AplicarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltro()
        {
            string texto = Txt_Buscar.Text.Trim().ToLower();
            int filtroEstado = Cmb_FiltroStock.SelectedIndex;

            var filtrados = _ingredientesTodos.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                filtrados = filtrados.Where(i => i.Nombre.ToLower().Contains(texto));
            }

            if (filtroEstado == 1)
            {
                filtrados = filtrados.Where(i => i.StockActual <= i.StockMinimo);
            }
            else if (filtroEstado == 2)
            {
                filtrados = filtrados.Where(i => i.StockActual > i.StockMinimo);
            }

            Dgv_Inventario.Rows.Clear();
            foreach (var ing in filtrados)
            {
                bool esBajo = ing.StockActual <= ing.StockMinimo;
                string estadoTexto = esBajo ? "⚠️ STOCK BAJO" : "✅ Óptimo";

                Dgv_Inventario.Rows.Add(
                    ing.IdIngrediente,
                    ing.Nombre,
                    ing.Unidad,
                    $"{ing.StockActual:0.##} {ing.Unidad}",
                    $"{ing.StockMinimo:0.##} {ing.Unidad}",
                    estadoTexto
                );
            }
        }

        private void Dgv_Inventario_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 5 && e.Value != null)
            {
                string estado = e.Value.ToString() ?? "";
                if (estado.Contains("BAJO"))
                {
                    e.CellStyle!.BackColor = Color.FromArgb(255, 235, 235);
                    e.CellStyle.ForeColor = Color.FromArgb(198, 40, 40);
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle!.BackColor = Color.FromArgb(235, 248, 235);
                    e.CellStyle.ForeColor = Color.FromArgb(46, 125, 50);
                    e.CellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
            }
        }

        private bool SolicitarAutorizacion()
        {
            if (_usuarioAutorizado != null && _usuarioAutorizado.PuedeEditarRecetas)
            {
                return true;
            }

            using var dlg = new Frm_Autorizacion(_contexto);
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.UsuarioAutorizado != null)
            {
                _usuarioAutorizado = dlg.UsuarioAutorizado;
                return true;
            }

            return false;
        }

        #region Acciones para TODO el personal (Libres de contraseña)

        private async void Btn_NuevoInsumo_Click(object? sender, EventArgs e)
        {
            using var dlg = new Frm_NuevoIngrediente(_contexto);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                await CargarInventarioAsync();
            }
        }

        private async void Btn_RegistrarEntrada_Click(object? sender, EventArgs e)
        {
            if (Dgv_Inventario.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un insumo de la lista para registrar la entrada de mercancía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idIngrediente = Dgv_Inventario.CurrentRow.Cells[0].Value is int id ? id : 0;
            var ingrediente = _ingredientesTodos.FirstOrDefault(i => i.IdIngrediente == idIngrediente);

            if (ingrediente == null)
            {
                MessageBox.Show("No se encontró el insumo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var dlg = new Frm_EntradaInventario(_contexto, ingrediente);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                await CargarInventarioAsync();
            }
        }

        #endregion

        #region Acciones restringidas para Administrador

        private async void Btn_ModificarInsumo_Click(object? sender, EventArgs e)
        {
            if (Dgv_Inventario.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un insumo de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!SolicitarAutorizacion())
            {
                return;
            }

            int idIngrediente = Dgv_Inventario.CurrentRow.Cells[0].Value is int id ? id : 0;

            using var editor = new Frm_EditarIngredienteAdmin(_contexto, idIngrediente);
            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                await CargarInventarioAsync();
            }
        }

        private async void Btn_EliminarInsumo_Click(object? sender, EventArgs e)
        {
            if (Dgv_Inventario.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un insumo de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!SolicitarAutorizacion())
            {
                return;
            }

            int idIngrediente = Dgv_Inventario.CurrentRow.Cells[0].Value is int id ? id : 0;
            string nombre = Dgv_Inventario.CurrentRow.Cells[1].Value?.ToString() ?? "";

            bool enUso = await _contexto.RecetaIngredientes.AnyAsync(ri => ri.IdIngrediente == idIngrediente);
            if (enUso)
            {
                MessageBox.Show(
                    $"No se puede eliminar el insumo '{nombre}' porque actualmente está asignado a recetas activas de la cafetería.\n\nPara eliminarlo, primero debes quitarlo de las recetas que lo utilizan en el módulo de recetas.",
                    "Insumo en Uso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Está seguro de que desea eliminar permanentemente el insumo '{nombre}' de la base de datos?",
                "Confirmar Eliminación de Insumo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var ing = await _contexto.Ingredientes.FindAsync(idIngrediente);
                if (ing != null)
                {
                    _contexto.Ingredientes.Remove(ing);
                    await _contexto.SaveChangesAsync();
                    MessageBox.Show($"El insumo '{nombre}' ha sido eliminado exitosamente.", "Insumo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarInventarioAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el insumo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void Txt_Buscar_TextChanged(object? sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void Cmb_FiltroStock_SelectedIndexChanged(object? sender, EventArgs e)
        {
            AplicarFiltro();
        }
    }
}
