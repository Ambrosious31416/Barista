using Barista.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Barista.Data
{
    public static class DatabaseInitializer
    {
        public static void Inicializar(Contexto Contexto)
        {
            Contexto.Database.EnsureCreated();

            Asegurar_Columnas_Inventario(Contexto);
            Asegurar_Tabla_Movimientos(Contexto);
            Cargar_Datos(Contexto);
        }

        private static void Asegurar_Columnas_Inventario(Contexto contexto)
        {
            try
            {
                contexto.Database.ExecuteSqlRaw("ALTER TABLE Ingredientes ADD COLUMN StockActual TEXT DEFAULT '0' NOT NULL;");
            }
            catch { }

            try
            {
                contexto.Database.ExecuteSqlRaw("ALTER TABLE Ingredientes ADD COLUMN StockMinimo TEXT DEFAULT '0' NOT NULL;");
            }
            catch { }

            try
            {
                contexto.Database.ExecuteSqlRaw("ALTER TABLE Ingredientes ADD COLUMN CostoUnitario TEXT DEFAULT '0' NOT NULL;");
            }
            catch { }
        }

        private static void Asegurar_Tabla_Movimientos(Contexto contexto)
        {
            contexto.Database.ExecuteSqlRaw(@"
                CREATE TABLE IF NOT EXISTS MovimientosInventario (
                    IdMovimiento INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    IdIngrediente INTEGER NOT NULL,
                    Fecha TEXT NOT NULL,
                    Tipo TEXT NOT NULL,
                    Cantidad TEXT NOT NULL DEFAULT '0',
                    StockAnterior TEXT NOT NULL DEFAULT '0',
                    StockPosterior TEXT NOT NULL DEFAULT '0',
                    Referencia TEXT NOT NULL DEFAULT '',
                    FOREIGN KEY(IdIngrediente) REFERENCES Ingredientes(IdIngrediente) ON DELETE RESTRICT
                );");
        }

        public static void Cargar_Datos(Contexto Contexto)
        {
            if (!Contexto.Usuarios.Any())
            {
                Contexto.Usuarios.AddRange(
                    new Usuario
                    {
                        Nombre = "Administrador",
                        PasswordHash = "admin123",
                        Rol = "Administrador",
                        PuedeEditarRecetas = true
                    },
                    new Usuario
                    {
                        Nombre = "Barista",
                        PasswordHash = "barista123",
                        Rol = "Empleado",
                        PuedeEditarRecetas = false
                    }
                );
                Contexto.SaveChanges();
            }

            var Categoria_Frias = Contexto.Categorias.FirstOrDefault(c => c.Nombre == "Bebidas Frias");
            if (Categoria_Frias == null)
            {
                Categoria_Frias = new Categoria { Nombre = "Bebidas Frias" };
                Contexto.Categorias.Add(Categoria_Frias);
            }

            var Categoria_Calientes = Contexto.Categorias.FirstOrDefault(c => c.Nombre == "Bebidas Calientes");
            if (Categoria_Calientes == null)
            {
                Categoria_Calientes = new Categoria { Nombre = "Bebidas Calientes" };
                Contexto.Categorias.Add(Categoria_Calientes);
            }

            var Categoria_Alcohol = Contexto.Categorias.FirstOrDefault(c => c.Nombre == "Bebidas alcohólicas");
            if (Categoria_Alcohol == null)
            {
                Categoria_Alcohol = new Categoria { Nombre = "Bebidas alcohólicas" };
                Contexto.Categorias.Add(Categoria_Alcohol);
            }

            Contexto.SaveChanges();

        }

        private static Ingrediente Obtener_Actualizar_Ingrediente(Contexto contexto, string nombre, string unidad, decimal stockInicial, decimal stockMinimo)
        {
            var existente = contexto.Ingredientes.FirstOrDefault(i => i.Nombre == nombre);
            if (existente != null)
            {
                if (existente.StockActual == 0 && existente.StockMinimo == 0)
                {
                    existente.StockActual = stockInicial;
                    existente.StockMinimo = stockMinimo;
                    contexto.SaveChanges();
                }
                return existente;
            }

            var nuevo = new Ingrediente
            {
                Nombre = nombre,
                Unidad = unidad,
                StockActual = stockInicial,
                StockMinimo = stockMinimo
            };
            contexto.Ingredientes.Add(nuevo);
            contexto.SaveChanges();
            return nuevo;
        }
    }
}
