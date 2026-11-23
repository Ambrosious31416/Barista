using Barista.Data;
using Barista.Modelos;
using Barista.Servicios;

namespace Barista.UI
{
    public partial class Frm_Catalogo : Form
    {
        private readonly Contexto _contexto;
        private readonly Bebida_Servicio _bebidaServicio;
        private List<Bebida> _bebidasTodas = new();
        private bool _cargando = false;

        public Frm_Catalogo()
        {
            InitializeComponent();

            var factory = new ContextoFactory();
            _contexto = factory.CreateDbContext(Array.Empty<string>());

            _bebidaServicio = new Bebida_Servicio(_contexto);

            Load += Frm_Catalogo_Load;
            FormClosed += (s, e) => _contexto.Dispose();
        }

        private async void Frm_Catalogo_Load(object? sender, EventArgs e)
        {
            await CargarBebidasAsync();
        }

        private async void Btn_Actualizar_Click(object? sender, EventArgs e)
        {
            await CargarBebidasAsync();
        }

        private async Task CargarBebidasAsync()
        {
            if (_cargando)
            {
                return;
            }

            _cargando = true;

            try
            {
                Btn_Actualizar.Enabled = false;

                _bebidasTodas = await _bebidaServicio.ObtenerBebidasAsync();

                AplicarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar listado de bebidas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargando = false;
                Btn_Actualizar.Enabled = true;
            }
        }

        private void AplicarFiltro()
        {
            string texto = Txt_Buscar.Text.Trim().ToLower();

            var filtradas = _bebidasTodas.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(texto))
            {
                filtradas = filtradas.Where(b =>
                    b.Nombre.ToLower().Contains(texto) ||
                    b.Descripcion.ToLower().Contains(texto) ||
                    (b.Categoria != null && b.Categoria.Nombre.ToLower().Contains(texto)));
            }

            var lista = filtradas.ToList();

            Lbl_TotalBebidas.Text = $"📦 Total: {lista.Count}";

            Dgv_Bebidas.Rows.Clear();
            foreach (var b in lista)
            {
                Dgv_Bebidas.Rows.Add(
                    b.IdBebida,
                    b.Nombre,
                    b.Descripcion,
                    b.Categoria?.Nombre ?? "-",
                    b.Estado ? "✅ Activa" : "❌ Inactiva"
                );
            }
        }

        private void Dgv_Bebidas_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Formatear semáforo de estado
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                string estado = e.Value.ToString() ?? "";
                if (estado.Contains("Inactiva"))
                {
                    e.CellStyle!.BackColor = Color.FromArgb(240, 238, 235);
                    e.CellStyle.ForeColor = Color.FromArgb(120, 110, 105);
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

        private void Txt_Buscar_TextChanged(object? sender, EventArgs e)
        {
            AplicarFiltro();
        }
    }
}
