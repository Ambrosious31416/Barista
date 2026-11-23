using System;
using System.Collections.Generic;
using System.Text;


namespace Barista.Modelos
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string PasswordHash { get; set; } = string.Empty;

        public string Rol { get; set; } = "Empleado";

        public bool PuedeEditarRecetas { get; set; } = false;
    }
}

