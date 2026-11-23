
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Barista.Data
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {
            string Ruta_Base = AppContext.BaseDirectory;

            IConfiguration Configuracion = new ConfigurationBuilder()
                .SetBasePath(Ruta_Base)
                .AddJsonFile("DB_Configuracion.json", optional: false)
                .Build();

            string String_Conexion = Configuracion
                .GetConnectionString("BaristaConnection")
                ?? "Data Source=Barista.db";

            if (String_Conexion.StartsWith("Data Source=", StringComparison.OrdinalIgnoreCase))
            {
                string archivoDb = String_Conexion.Substring("Data Source=".Length).Trim();
                if (!Path.IsPathRooted(archivoDb))
                {
                    archivoDb = Path.Combine(Ruta_Base, archivoDb);
                    String_Conexion = $"Data Source={archivoDb}";
                }
            }

            var Opciones = new DbContextOptionsBuilder<Contexto>();

            Opciones.UseSqlite(String_Conexion);

            return new Contexto(Opciones.Options);
        }
    }
}
