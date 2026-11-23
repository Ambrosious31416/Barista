using System;
using System.Collections.Generic;
using System.Text;


namespace Barista.Modelos
{
    public class Bebida
    {
        public int IdBebida { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public string Imagen { get; set; } = string.Empty;

        public bool Estado { get; set; } = true;

        public int IdCategoria { get; set; }

        public Categoria? Categoria { get; set; }

        public List<Receta> Recetas { get; set; } = new();
    }
}

