namespace Barista.Modelos
{
    public class MovimientoInventario
    {
        public int IdMovimiento { get; set; }
        public int IdIngrediente { get; set; }
        public Ingrediente? Ingrediente { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Tipo { get; set; } = string.Empty;
        public decimal Cantidad { get; set; }
        public decimal StockAnterior { get; set; }
        public decimal StockPosterior { get; set; }
        public string Referencia { get; set; } = string.Empty;
    }
}
