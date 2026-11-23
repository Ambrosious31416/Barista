using Barista.Data;
using Barista.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Barista.UI
{
    public partial class Frm_GestionRecetas : Form
    {
        private readonly Contexto _contexto;
        private Usuario? _usuarioAutorizado = null;

        public Frm_GestionRecetas()
        {
            InitializeComponent();

            var factory = new ContextoFactory();
            _contexto = factory.CreateDbContext(Array.Empty<string>());

            Load += Frm_GestionRecetas_Load;
            FormClosed += (s, e) => _contexto.Dispose();
        }

        private async void Frm_GestionRecetas_Load(object? sender, EventArgs e)
        {
            await CargarRecetasAsync();
        }

        private async Task CargarRecetasAsync()
        {
            try
            {
                string filtro = Txt_Buscar.Text.Trim().ToLower();

                var query = _contexto.Recetas
                    .Include(r => r.Bebida)
                        .ThenInclude(b => b!.Categoria)
                    .Include(r => r.RecetaIngredientes)
                    .Include(r => r.PasosPreparacion)
                    .AsNoTracking();

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    query = query.Where(r =>
                        (r.Bebida != null && r.Bebida.Nombre.ToLower().Contains(filtro)) ||
                        (r.Bebida != null && r.Bebida.Categoria != null && r.Bebida.Categoria.Nombre.ToLower().Contains(filtro)) ||
                        r.Tamaño.ToLower().Contains(filtro));
                }

                var recetas = await query
                    .OrderBy(r => r.Bebida != null ? r.Bebida.Nombre : "")
                    .ThenBy(r => r.Tamaño)
                    .ToListAsync();

                Dgv_Recetas.Rows.Clear();
                foreach (var r in recetas)
                {
                    string nombreBebida = r.Bebida?.Nombre ?? "Sin bebida";
                    string categoria = r.Bebida?.Categoria?.Nombre ?? "-";
                    int cantIngredientes = r.RecetaIngredientes?.Count ?? 0;
                    int cantPasos = r.PasosPreparacion?.Count ?? 0;

                    Dgv_Recetas.Rows.Add(
                        r.IdReceta,
                        nombreBebida,
                        categoria,
                        r.Tamaño,
                        $"{cantIngredientes} insumo(s)",
                        $"{cantPasos} paso(s)"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listado de recetas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SolicitarAutorizacion()
        {
            // Si ya se autenticó previamente en esta ventana, se permite continuar
            if (_usuarioAutorizado != null && _usuarioAutorizado.PuedeEditarRecetas)
            {
                return true;
            }

            // Solo al momento de agregar, editar o eliminar se solicitan las credenciales
            using var dlg = new Frm_Autorizacion(_contexto);
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.UsuarioAutorizado != null)
            {
                _usuarioAutorizado = dlg.UsuarioAutorizado;
                return true;
            }

            return false;
        }

        private async void Btn_NuevaReceta_Click(object? sender, EventArgs e)
        {
            if (!SolicitarAutorizacion())
            {
                return;
            }

            using var editor = new Frm_EditarReceta(_contexto, 0);
            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                await CargarRecetasAsync();
            }
        }

        private async void Btn_EditarReceta_Click(object? sender, EventArgs e)
        {
            if (Dgv_Recetas.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una receta de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!SolicitarAutorizacion())
            {
                return;
            }

            int idReceta = Dgv_Recetas.CurrentRow.Cells[0].Value is int id ? id : 0;

            using var editor = new Frm_EditarReceta(_contexto, idReceta);
            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                await CargarRecetasAsync();
            }
        }

        private async void Btn_EliminarReceta_Click(object? sender, EventArgs e)
        {
            if (Dgv_Recetas.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona una receta de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!SolicitarAutorizacion())
            {
                return;
            }

            int idReceta = Dgv_Recetas.CurrentRow.Cells[0].Value is int id ? id : 0;
            string bebida = Dgv_Recetas.CurrentRow.Cells[1].Value?.ToString() ?? "";
            string tamano = Dgv_Recetas.CurrentRow.Cells[3].Value?.ToString() ?? "";

            var confirm = MessageBox.Show(
                $"¿Está seguro de que desea eliminar permanentemente la receta de:\n\n'{bebida} - {tamano}'?\n\nEsta acción eliminará sus pasos e ingredientes asociados y no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var receta = await _contexto.Recetas
                    .Include(r => r.RecetaIngredientes)
                    .Include(r => r.PasosPreparacion)
                    .FirstOrDefaultAsync(r => r.IdReceta == idReceta);

                if (receta == null)
                {
                    MessageBox.Show("La receta ya no existe o fue eliminada previamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarRecetasAsync();
                    return;
                }

                _contexto.RecetaIngredientes.RemoveRange(receta.RecetaIngredientes);
                _contexto.PasosPreparacion.RemoveRange(receta.PasosPreparacion);
                _contexto.Recetas.Remove(receta);

                await _contexto.SaveChangesAsync();

                MessageBox.Show($"La receta '{bebida} - {tamano}' ha sido eliminada correctamente.", "Receta Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarRecetasAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la receta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Txt_Buscar_TextChanged(object? sender, EventArgs e)
        {
            await CargarRecetasAsync();
        }
    }
}
