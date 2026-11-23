using Barista.Data;
using Barista.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Barista.UI
{
    public partial class Frm_Reportes : Form
    {
        private readonly Contexto _contexto;

        public Frm_Reportes()
        {
            InitializeComponent();

            var factory = new ContextoFactory();
            _contexto = factory.CreateDbContext(Array.Empty<string>());

            Cmb_Periodo.SelectedIndex = 0;
            Load += Frm_Reportes_Load;
            FormClosed += (s, e) => _contexto.Dispose();
        }

        private async void Frm_Reportes_Load(object? sender, EventArgs e)
        {
            await CargarReportesAsync();
        }

        private async void Btn_Actualizar_Click(object? sender, EventArgs e)
        {
            await CargarReportesAsync();
        }

        private async void Cmb_Periodo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (IsHandleCreated)
            {
                await CargarReportesAsync();
            }
        }

        private async Task CargarReportesAsync()
        {
            try
            {
                Btn_Actualizar.Enabled = false;

                DateTime desde = Cmb_Periodo.SelectedIndex switch
                {
                    1 => DateTime.Today,
                    2 => DateTime.Today.AddDays(-7),
                    3 => DateTime.Today.AddDays(-30),
                    _ => DateTime.MinValue
                };

                var movimientos = await _contexto.MovimientosInventario
                    .AsNoTracking()
                    .Include(m => m.Ingrediente)
                    .Where(m => desde == DateTime.MinValue || m.Fecha >= desde)
                    .OrderByDescending(m => m.Fecha)
                    .ToListAsync();

                var ingredientes = await _contexto.Ingredientes
                    .AsNoTracking()
                    .OrderBy(i => i.Nombre)
                    .ToListAsync();

                CargarMovimientos(movimientos);
                CargarConsumos(movimientos);
                CargarReabastecimiento(ingredientes);

                Lbl_Movimientos.Text = $"↔️ Movimientos: {movimientos.Count}";
                Lbl_Consumo.Text = $"📉 Consumos: {movimientos.Count(m => m.Tipo == "Consumo")}";
                Lbl_Reabastecer.Text = $"⚠️ Reabastecer: {ingredientes.Count(i => i.StockActual <= i.StockMinimo)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar reportes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Btn_Actualizar.Enabled = true;
            }
        }

        private void CargarMovimientos(List<MovimientoInventario> movimientos)
        {
            Dgv_Movimientos.Rows.Clear();
            foreach (var movimiento in movimientos)
            {
                Dgv_Movimientos.Rows.Add(
                    movimiento.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    movimiento.Ingrediente?.Nombre ?? "Insumo eliminado",
                    movimiento.Tipo,
                    $"{movimiento.Cantidad:0.##} {movimiento.Ingrediente?.Unidad ?? ""}",
                    $"{movimiento.StockAnterior:0.##} → {movimiento.StockPosterior:0.##}",
                    movimiento.Referencia);
            }
        }

        private void CargarConsumos(List<MovimientoInventario> movimientos)
        {
            Dgv_Consumos.Rows.Clear();

            var consumos = movimientos
                .Where(m => m.Tipo == "Consumo")
                .GroupBy(m => m.Ingrediente?.Nombre ?? "Insumo eliminado")
                .Select(g => new
                {
                    Nombre = g.Key,
                    Unidad = g.First().Ingrediente?.Unidad ?? "",
                    Cantidad = g.Sum(m => m.Cantidad),
                    Preparaciones = g.Count()
                })
                .OrderByDescending(c => c.Cantidad)
                .ToList();

            foreach (var consumo in consumos)
            {
                Dgv_Consumos.Rows.Add(consumo.Nombre, $"{consumo.Cantidad:0.##} {consumo.Unidad}", consumo.Preparaciones);
            }
        }

        private void CargarReabastecimiento(List<Ingrediente> ingredientes)
        {
            Dgv_Reabastecer.Rows.Clear();

            foreach (var ingrediente in ingredientes.Where(i => i.StockActual <= i.StockMinimo)
                .OrderBy(i => i.StockActual - i.StockMinimo))
            {
                decimal faltante = Math.Max(0, ingrediente.StockMinimo - ingrediente.StockActual);
                Dgv_Reabastecer.Rows.Add(
                    ingrediente.Nombre,
                    $"{ingrediente.StockActual:0.##} {ingrediente.Unidad}",
                    $"{ingrediente.StockMinimo:0.##} {ingrediente.Unidad}",
                    $"{faltante:0.##} {ingrediente.Unidad}");
            }
        }

        private async void Btn_Exportar_Click(object? sender, EventArgs e)
        {
            using var dialogo = new SaveFileDialog
            {
                Title = "Exportar reporte",
                Filter = "Archivo CSV (*.csv)|*.csv",
                FileName = "Reporte_Barista_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv"
            };

            if (dialogo.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            var movimientos = await _contexto.MovimientosInventario
                .AsNoTracking()
                .Include(m => m.Ingrediente)
                .OrderByDescending(m => m.Fecha)
                .ToListAsync();

            var sb = new StringBuilder();
            sb.AppendLine("sep=,");
            sb.AppendLine(string.Join(",", new[]
            {
                "Fecha", "Insumo", "Tipo", "Cantidad", "Stock anterior", "Stock posterior", "Referencia"
            }.Select(EscaparCampoCsv)));

            foreach (var m in movimientos)
            {
                sb.AppendLine(string.Join(",", new[]
                {
                    m.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    m.Ingrediente?.Nombre ?? "Insumo eliminado",
                    m.Tipo,
                    m.Cantidad.ToString("0.##"),
                    m.StockAnterior.ToString("0.##"),
                    m.StockPosterior.ToString("0.##"),
                    m.Referencia
                }.Select(EscaparCampoCsv)));
            }

            await File.WriteAllTextAsync(dialogo.FileName, sb.ToString(), Encoding.UTF8);
            MessageBox.Show("Reporte exportado correctamente.", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string EscaparCampoCsv(string? valor)
        {
            return $"\"{(valor ?? string.Empty).Replace("\"", "\"\"")}\"";
        }
    }
}
