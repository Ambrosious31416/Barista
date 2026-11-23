using Barista.Data;
using Barista.Modelos;
using Barista.Servicios;

namespace Barista.UI
{
    public partial class Frm_GuiaBarista : Form
    {
        private readonly Contexto _contexto;
        private readonly Receta_Servicio _recetaServicio;

        private List<Bebida> _bebidasActuales = new();
        private List<Receta> _recetasBebidaActual = new();
        private Receta? _recetaSeleccionada;

        private int _segundosTimer = 0;
        private bool _cargando = false;

        public Frm_GuiaBarista()
        {
            InitializeComponent();

            var factory = new ContextoFactory();
            _contexto = factory.CreateDbContext(Array.Empty<string>());
            _recetaServicio = new Receta_Servicio(_contexto);

            Load += Frm_GuiaBarista_Load;
            FormClosed += (s, e) =>
            {
                Timer_Extraccion.Stop();
                _contexto.Dispose();
            };
        }

        private async void Frm_GuiaBarista_Load(object? sender, EventArgs e)
        {
            await CargarCategoriasAsync();
            await CargarBebidasAsync();
        }

        private async Task CargarCategoriasAsync()
        {
            try
            {
                var categorias = await _recetaServicio.ObtenerCategoriasAsync();

                var listaItems = new List<CategoriaItem>
                {
                    new CategoriaItem { IdCategoria = 0, Nombre = "⭐ Todas las Categorías" }
                };

                foreach (var cat in categorias)
                {
                    listaItems.Add(new CategoriaItem
                    {
                        IdCategoria = cat.IdCategoria,
                        Nombre = cat.Nombre
                    });
                }

                Cmb_Categorias.DisplayMember = "Nombre";
                Cmb_Categorias.ValueMember = "IdCategoria";
                Cmb_Categorias.DataSource = listaItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarBebidasAsync()
        {
            if (_cargando) return;
            _cargando = true;

            try
            {
                int idCat = 0;
                if (Cmb_Categorias.SelectedItem is CategoriaItem item)
                {
                    idCat = item.IdCategoria;
                }

                string filtro = Txt_Buscar.Text.Trim();

                _bebidasActuales = await _recetaServicio.ObtenerBebidasAsync(idCat > 0 ? idCat : null, filtro);

                Lst_Bebidas.DataSource = null;
                Lst_Bebidas.DataSource = _bebidasActuales;

                if (_bebidasActuales.Count > 0)
                {
                    Lst_Bebidas.SelectedIndex = 0;
                }
                else
                {
                    LimpiarDetalle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar bebidas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargando = false;
            }
        }

        private async void Lst_Bebidas_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (Lst_Bebidas.SelectedItem is not Bebida bebida)
            {
                LimpiarDetalle();
                return;
            }

            Lbl_TituloBebida.Text = bebida.Nombre;
            Lbl_CategoriaBebida.Text = bebida.Categoria?.Nombre ?? "Sin Categoría";
            Lbl_DescripcionBebida.Text = string.IsNullOrWhiteSpace(bebida.Descripcion)
                ? "Sin descripción disponible para esta bebida."
                : bebida.Descripcion;

            try
            {
                _recetasBebidaActual = await _recetaServicio.ObtenerRecetasPorBebidaAsync(bebida.IdBebida);

                Cmb_Tamanos.DataSource = null;
                if (_recetasBebidaActual.Count > 0)
                {
                    Cmb_Tamanos.DisplayMember = "Tamaño";
                    Cmb_Tamanos.ValueMember = "IdReceta";
                    Cmb_Tamanos.DataSource = _recetasBebidaActual;
                    Cmb_Tamanos.Enabled = true;
                }
                else
                {
                    Cmb_Tamanos.Enabled = false;
                    Dgv_Ingredientes.Rows.Clear();
                    Lst_Pasos.Items.Clear();
                    Lst_Pasos.Items.Add(new PasoItem(0, "⚠️ Esta bebida aún no tiene recetas registradas en el sistema."));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar recetas de la bebida: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Cmb_Tamanos_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (Cmb_Tamanos.SelectedItem is not Receta receta)
            {
                return;
            }

            try
            {
                _recetaSeleccionada = await _recetaServicio.ObtenerDetalleRecetaAsync(receta.IdReceta);
                MostrarDetalleReceta(_recetaSeleccionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle de la receta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDetalleReceta(Receta? receta)
        {
            Dgv_Ingredientes.Rows.Clear();
            Lst_Pasos.Items.Clear();

            if (receta == null) return;

            if (receta.RecetaIngredientes != null && receta.RecetaIngredientes.Count > 0)
            {
                foreach (var ri in receta.RecetaIngredientes)
                {
                    string nombreInsumo = ri.Ingrediente?.Nombre ?? $"Insumo #{ri.IdIngrediente}";
                    string cantidad = ri.Cantidad.ToString("0.##");
                    string unidad = ri.Ingrediente?.Unidad ?? "";

                    Dgv_Ingredientes.Rows.Add(nombreInsumo, cantidad, unidad);
                }
            }
            else
            {
                Dgv_Ingredientes.Rows.Add("No hay ingredientes registrados", "-", "-");
            }

            if (receta.PasosPreparacion != null && receta.PasosPreparacion.Count > 0)
            {
                var pasosOrdenados = receta.PasosPreparacion.OrderBy(p => p.NumeroPaso).ToList();
                foreach (var paso in pasosOrdenados)
                {
                    Lst_Pasos.Items.Add(new PasoItem(paso.NumeroPaso, paso.Instruccion));
                }
            }
            else
            {
                Lst_Pasos.Items.Add(new PasoItem(0, "No hay pasos de preparación definidos para esta receta."));
            }
        }

        private void LimpiarDetalle()
        {
            Lbl_TituloBebida.Text = "Selecciona una bebida";
            Lbl_CategoriaBebida.Text = "---";
            Lbl_DescripcionBebida.Text = "";
            Cmb_Tamanos.DataSource = null;
            Cmb_Tamanos.Enabled = false;
            Dgv_Ingredientes.Rows.Clear();
            Lst_Pasos.Items.Clear();
        }

        private async void Txt_Buscar_TextChanged(object? sender, EventArgs e)
        {
            await CargarBebidasAsync();
        }

        private async void Cmb_Categorias_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (!_cargando)
            {
                await CargarBebidasAsync();
            }
        }

        #region Dibujado personalizado de listas (Estilo visual)

        private void Lst_Bebidas_MeasureItem(object? sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 48;
        }

        private void Lst_Bebidas_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= _bebidasActuales.Count) return;

            var bebida = _bebidasActuales[e.Index];
            bool seleccionada = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            Color bgColor = seleccionada ? Color.FromArgb(242, 233, 224) : Color.White;
            Color textColor = seleccionada ? Color.FromArgb(43, 30, 26) : Color.FromArgb(30, 30, 30);
            Color subColor = Color.FromArgb(120, 110, 105);

            using var brushBg = new SolidBrush(bgColor);
            e.Graphics.FillRectangle(brushBg, e.Bounds);

            if (seleccionada)
            {
                using var brushBar = new SolidBrush(Color.FromArgb(140, 75, 45));
                e.Graphics.FillRectangle(brushBar, e.Bounds.Left, e.Bounds.Top, 5, e.Bounds.Height);
            }

            using var fontTitulo = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            using var fontSub = new Font("Segoe UI", 8F);
            using var brushText = new SolidBrush(textColor);
            using var brushSub = new SolidBrush(subColor);

            int x = e.Bounds.Left + 12;
            int y = e.Bounds.Top + 6;

            e.Graphics.DrawString(bebida.Nombre, fontTitulo, brushText, x, y);
            e.Graphics.DrawString(bebida.Categoria?.Nombre ?? "Sin categoría", fontSub, brushSub, x, y + 18);

            using var penDiv = new Pen(Color.FromArgb(235, 235, 235));
            e.Graphics.DrawLine(penDiv, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
        }

        private void Lst_Pasos_MeasureItem(object? sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= Lst_Pasos.Items.Count) return;

            if (Lst_Pasos.Items[e.Index] is PasoItem item)
            {
                using var font = new Font("Segoe UI", 9.5F);
                int anchoTexto = Lst_Pasos.ClientSize.Width - 95;
                if (anchoTexto < 100) anchoTexto = 200;

                var size = e.Graphics.MeasureString(item.Instruccion, font, anchoTexto);
                e.ItemHeight = Math.Max(46, (int)size.Height + 20);
            }
        }

        private void Lst_Pasos_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= Lst_Pasos.Items.Count) return;

            if (Lst_Pasos.Items[e.Index] is not PasoItem paso) return;

            using var brushBg = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(brushBg, e.Bounds);

            if (paso.NumeroPaso > 0)
            {
                Rectangle badgeRect = new Rectangle(e.Bounds.Left + 8, e.Bounds.Top + 8, 62, 24);
                using var brushBadge = new SolidBrush(Color.FromArgb(240, 230, 220));
                using var brushBadgeText = new SolidBrush(Color.FromArgb(120, 60, 30));
                using var fontBadge = new Font("Segoe UI", 8F, FontStyle.Bold);

                e.Graphics.FillRectangle(brushBadge, badgeRect);
                using var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                e.Graphics.DrawString($"PASO {paso.NumeroPaso}", fontBadge, brushBadgeText, badgeRect, sf);
            }

            int xTexto = paso.NumeroPaso > 0 ? e.Bounds.Left + 80 : e.Bounds.Left + 12;
            int yTexto = e.Bounds.Top + 8;
            int anchoTexto = e.Bounds.Width - xTexto - 10;
            if (anchoTexto < 50) anchoTexto = 200;

            RectangleF rectTexto = new RectangleF(xTexto, yTexto, anchoTexto, e.Bounds.Height - 12);
            using var fontTexto = new Font("Segoe UI", 9.5F);
            using var brushTexto = new SolidBrush(Color.FromArgb(40, 40, 40));

            e.Graphics.DrawString(paso.Instruccion, fontTexto, brushTexto, rectTexto);

            using var penSep = new Pen(Color.FromArgb(242, 240, 238));
            e.Graphics.DrawLine(penSep, e.Bounds.Left + 8, e.Bounds.Bottom - 1, e.Bounds.Right - 8, e.Bounds.Bottom - 1);
        }

        #endregion

        #region Cronómetro de Barista

        private void Btn_TimerStart_Click(object? sender, EventArgs e)
        {
            Timer_Extraccion.Start();
            ActualizarEstiloTimer();
        }

        private void Btn_TimerPause_Click(object? sender, EventArgs e)
        {
            Timer_Extraccion.Stop();
            ActualizarEstiloTimer();
        }

        private void Btn_TimerReset_Click(object? sender, EventArgs e)
        {
            Timer_Extraccion.Stop();
            _segundosTimer = 0;
            Lbl_TimerDisplay.Text = "00:00";
            Lbl_TimerDisplay.ForeColor = Color.FromArgb(43, 30, 26);
        }

        private void Timer_Extraccion_Tick(object? sender, EventArgs e)
        {
            _segundosTimer++;
            int minutos = _segundosTimer / 60;
            int seg = _segundosTimer % 60;
            Lbl_TimerDisplay.Text = $"{minutos:D2}:{seg:D2}";

            ActualizarEstiloTimer();
        }

        private void ActualizarEstiloTimer()
        {
            if (_segundosTimer >= 25 && _segundosTimer <= 30)
            {
                Lbl_TimerDisplay.ForeColor = Color.FromArgb(46, 125, 50);
            }
            else if (_segundosTimer > 30)
            {
                Lbl_TimerDisplay.ForeColor = Color.FromArgb(198, 40, 40);
            }
            else
            {
                Lbl_TimerDisplay.ForeColor = Color.FromArgb(43, 30, 26);
            }
        }

        #endregion

        private class CategoriaItem
        {
            public int IdCategoria { get; set; }
            public string Nombre { get; set; } = string.Empty;
        }

        private class PasoItem
        {
            public int NumeroPaso { get; set; }
            public string Instruccion { get; set; } = string.Empty;

            public PasoItem(int numeroPaso, string instruccion)
            {
                NumeroPaso = numeroPaso;
                Instruccion = instruccion;
            }
        }
    }
}
