using Barista.Modelos;
using System;
using System.Collections.Generic;
using System.Text;


namespace Barista.Modelos
{
    public class RecetaIngrediente
    {
        public int IdReceta { get; set; }

        public int IdIngrediente { get; set; }

        public Receta? Receta { get; set; }

        public Ingrediente? Ingrediente { get; set; }

        public decimal Cantidad { get; set; }
    }
}

