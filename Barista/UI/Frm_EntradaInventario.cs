using Barista.Data;
using Barista.Modelos;

namespace Barista.UI
{
    public partial class Frm_EntradaInventario : Form
    {
        private readonly Contexto _contexto;
        private readonly Ingrediente _ingrediente;
        private decimal _totalCalculadoEnUnidadBase = 0;

        public Frm_EntradaInventario(Contexto contexto, Ingrediente ingrediente)
        {
            InitializeComponent();
            _contexto = contexto;
            _ingrediente = ingrediente;

            ConfigurarVistaInsumo();
            ConfigurarUnidadesPresentacion();
            CalcularConversion();
        }

        private void ConfigurarVistaInsumo()
        {
            Lbl_InsumoNombre.Text = _ingrediente.Nombre;
            Lbl_UnidadBaseInfo.Text = $"Unidad base para recetas: {_ingrediente.Unidad}";
            Lbl_StockActualInfo.Text = $"Stock Actual: {_ingrediente.StockActual:0.##} {_ingrediente.Unidad}";
        }

        private void ConfigurarUnidadesPresentacion()
        {
            Cmb_UnidadPresentacion.Items.Clear();

            string u = _ingrediente.Unidad.ToLower().Trim();

            if (u == "ml" || u.Contains("mili"))
            {
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("L (Litros)", 1000m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("ml (Mililitros)", 1m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("oz (Onzas líquidas fl oz)", 29.57m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("gal (Galones)", 3785.41m));
                Cmb_UnidadPresentacion.SelectedIndex = 0;
            }
            else if (u == "g" || u.Contains("gram"))
            {
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("kg (Kilogramos)", 1000m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("g (Gramos)", 1m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("lb (Libras)", 453.59m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("oz (Onzas de peso)", 28.35m));
                Cmb_UnidadPresentacion.SelectedIndex = 0;
            }
            else if (u == "l" || u.Contains("litr"))
            {
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("L (Litros)", 1m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("ml (Mililitros)", 0.001m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("gal (Galones)", 3.785m));
                Cmb_UnidadPresentacion.SelectedIndex = 0;
            }
            else if (u == "kg" || u.Contains("kilo"))
            {
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("kg (Kilogramos)", 1m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("g (Gramos)", 0.001m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("lb (Libras)", 0.45359m));
                Cmb_UnidadPresentacion.SelectedIndex = 0;
            }
            else
            {
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem($"{_ingrediente.Unidad} (Directo)", 1m));
                Cmb_UnidadPresentacion.Items.Add(new UnidadPresentacionItem("caja / paquete", 1m));
                Cmb_UnidadPresentacion.SelectedIndex = 0;
            }
        }

        private void ValoresEntrada_Changed(object? sender, EventArgs e)
        {
            CalcularConversion();
        }

        private void CalcularConversion()
        {
            decimal paquetes = Num_CantidadPaquetes.Value;
            decimal tamano = Num_TamanoPorPaquete.Value;
            decimal factor = 1m;
            string nombrePresentacion = _ingrediente.Unidad;

            if (Cmb_UnidadPresentacion.SelectedItem is UnidadPresentacionItem item)
            {
                factor = item.FactorAUnidadBase;
                nombrePresentacion = item.Nombre.Split(' ')[0];
            }

            _totalCalculadoEnUnidadBase = paquetes * (tamano * factor);

            decimal nuevoStock = _ingrediente.StockActual + _totalCalculadoEnUnidadBase;

            Lbl_FormulaExplicada.Text = $"📦 Cálculo: {paquetes:0.##} producto(s) × {tamano:0.##} {nombrePresentacion} = {_totalCalculadoEnUnidadBase:N2} {_ingrediente.Unidad}";
            Lbl_NuevoStockResultante.Text = $"Stock actual: {_ingrediente.StockActual:N2} {_ingrediente.Unidad}  ➔  Nuevo Total: {nuevoStock:N2} {_ingrediente.Unidad}";
        }

        private async void Btn_Guardar_Click(object? sender, EventArgs e)
        {
            if (_totalCalculadoEnUnidadBase <= 0)
            {
                MessageBox.Show("La cantidad a ingresar calculada debe ser mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var ing = await _contexto.Ingredientes.FindAsync(_ingrediente.IdIngrediente);
                if (ing == null)
                {
                    MessageBox.Show("El insumo no se encontró en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal stockAnterior = ing.StockActual;
                ing.StockActual += _totalCalculadoEnUnidadBase;

                _contexto.MovimientosInventario.Add(new MovimientoInventario
                {
                    IdIngrediente = ing.IdIngrediente,
                    Fecha = DateTime.Now,
                    Tipo = "Entrada",
                    Cantidad = _totalCalculadoEnUnidadBase,
                    StockAnterior = stockAnterior,
                    StockPosterior = ing.StockActual,
                    Referencia = "Reabastecimiento de inventario"
                });

                await _contexto.SaveChangesAsync();

                string nombrePresentacion = (Cmb_UnidadPresentacion.SelectedItem as UnidadPresentacionItem)?.Nombre.Split(' ')[0] ?? _ingrediente.Unidad;

                MessageBox.Show(
                    $"¡Entrada de mercancía registrada con éxito!\n\n" +
                    $"Insumo: {ing.Nombre}\n" +
                    $"Ingresaron: {Num_CantidadPaquetes.Value:0.##} producto(s) de {Num_TamanoPorPaquete.Value:0.##} {nombrePresentacion}\n" +
                    $"Equivalencia sumada: +{_totalCalculadoEnUnidadBase:N2} {ing.Unidad}\n\n" +
                    $"Stock en almacén actualizado de {stockAnterior:N2} a {ing.StockActual:N2} {ing.Unidad}.",
                    "Reabastecimiento Exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar inventario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Cancelar_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private class UnidadPresentacionItem
        {
            public string Nombre { get; }
            public decimal FactorAUnidadBase { get; }

            public UnidadPresentacionItem(string nombre, decimal factor)
            {
                Nombre = nombre;
                FactorAUnidadBase = factor;
            }

            public override string ToString() => Nombre;
        }
    }
}
