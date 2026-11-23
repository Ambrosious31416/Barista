using System;
using System.Collections.Generic;
using System.Text;

namespace Barista.Modelos
{
    public class Receta
    {
        public int IdReceta { get; set; }

        public int IdBebida { get; set; }

        public Bebida? Bebida { get; set; }

        public string Tamaño { get; set; } = string.Empty;

        public List<RecetaIngrediente> RecetaIngredientes { get; set; } = new();

        public List<PasoPreparacion> PasosPreparacion { get; set; } = new();
    }
}
