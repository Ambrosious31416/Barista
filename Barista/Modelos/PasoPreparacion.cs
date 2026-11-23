using Barista.Modelos;
using System;
using System.Collections.Generic;
using System.Text;


namespace Barista.Modelos
{
    public class PasoPreparacion
    {
        public int IdPaso { get; set; }

        public int IdReceta { get; set; }

        public Receta? Receta { get; set; }

        public int NumeroPaso { get; set; }

        public string Instruccion { get; set; } = string.Empty;

        public string? Imagen { get; set; }
    }
}

