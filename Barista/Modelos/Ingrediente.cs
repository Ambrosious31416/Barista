using System;
using System.Collections.Generic;
using System.Text;


namespace Barista.Modelos
{
    public class Ingrediente
    {
        public int IdIngrediente { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Unidad { get; set; } = string.Empty;

        public decimal StockActual { get; set; } = 0;

        public decimal StockMinimo { get; set; } = 0;

        public decimal CostoUnitario { get; set; } = 0;
    }
}

