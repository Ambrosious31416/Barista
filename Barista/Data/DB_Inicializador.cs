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

            return;

            if (Contexto.Recetas.Any())
            {
                return;
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

            var ingCafe = Obtener_Actualizar_Ingrediente(Contexto, "Café de Especialidad (Grano)", "g", 4500m, 1000m);
            var ingLecheEntera = Obtener_Actualizar_Ingrediente(Contexto, "Leche Entera", "ml", 12000m, 3000m);
            var ingLecheAvena = Obtener_Actualizar_Ingrediente(Contexto, "Leche de Avena", "ml", 800m, 1200m);
            var ingAgua = Obtener_Actualizar_Ingrediente(Contexto, "Agua Purificada", "ml", 25000m, 5000m);
            var ingJarabeVainilla = Obtener_Actualizar_Ingrediente(Contexto, "Jarabe de Vainilla", "ml", 1800m, 500m);
            var ingJarabeCaramelo = Obtener_Actualizar_Ingrediente(Contexto, "Jarabe de Caramelo", "ml", 350m, 500m);
            var ingHielo = Obtener_Actualizar_Ingrediente(Contexto, "Hielo", "g", 15000m, 3000m);
            var ingChocolate = Obtener_Actualizar_Ingrediente(Contexto, "Salsa de Chocolate / Mocha", "g", 2000m, 500m);


            var espresso = new Bebida
            {
                Nombre = "Espresso Doble (Doppio)",
                Descripcion = "La base de toda la coctelería de café. Doble extracción de 36-40g con crema densa color avellana.",
                Imagen = "",
                Estado = true,
                IdCategoria = Categoria_Frias.IdCategoria
            };
            Contexto.Bebidas.Add(espresso);
            Contexto.SaveChanges();

            var recEspresso = new Receta
            {
                IdBebida = espresso.IdBebida,
                Tamaño = "Doble (2 oz)"
            };
            Contexto.Recetas.Add(recEspresso);
            Contexto.SaveChanges();

            Contexto.RecetaIngredientes.AddRange(
                new RecetaIngrediente { IdReceta = recEspresso.IdReceta, IdIngrediente = ingCafe.IdIngrediente, Cantidad = 18m },
                new RecetaIngrediente { IdReceta = recEspresso.IdReceta, IdIngrediente = ingAgua.IdIngrediente, Cantidad = 40m }
            );

            Contexto.PasosPreparacion.AddRange(
                new PasoPreparacion { IdReceta = recEspresso.IdReceta, NumeroPaso = 1, Instruccion = "Purgar el grupo de la máquina durante 2 segundos para limpiar residuos y estabilizar la temperatura." },
                new PasoPreparacion { IdReceta = recEspresso.IdReceta, NumeroPaso = 2, Instruccion = "Secar con paño el canastillo del portafiltro. Moler exactamente 18 gramos de café con molienda fina." },
                new PasoPreparacion { IdReceta = recEspresso.IdReceta, NumeroPaso = 3, Instruccion = "Distribuir el café con herramienta WDT o toques suaves y compactar (tamping) firme a 90° nivelado (15-20 kg)." },
                new PasoPreparacion { IdReceta = recEspresso.IdReceta, NumeroPaso = 4, Instruccion = "Colocar el portafiltro e iniciar extracción de inmediato. Debe fluir como cola de ratón en 25-30 segundos para obtener 36 a 40 gramos de espresso." },
                new PasoPreparacion { IdReceta = recEspresso.IdReceta, NumeroPaso = 5, Instruccion = "Servir de inmediato en taza precalentada de espresso. Limpiar y purgar el grupo de nuevo." }
            );

            var cappuccino = new Bebida
            {
                Nombre = "Cappuccino Clásico",
                Descripcion = "Equilibrio perfecto entre espresso doble y leche con microespuma sedosa y elástica.",
                Imagen = "",
                Estado = true,
                IdCategoria = Categoria_Frias.IdCategoria
            };
            Contexto.Bebidas.Add(cappuccino);
            Contexto.SaveChanges();

            var recCapMediano = new Receta
            {
                IdBebida = cappuccino.IdBebida,
                Tamaño = "Mediano (8 oz)"
            };
            Contexto.Recetas.Add(recCapMediano);
            Contexto.SaveChanges();

            Contexto.RecetaIngredientes.AddRange(
                new RecetaIngrediente { IdReceta = recCapMediano.IdReceta, IdIngrediente = ingCafe.IdIngrediente, Cantidad = 18m },
                new RecetaIngrediente { IdReceta = recCapMediano.IdReceta, IdIngrediente = ingLecheEntera.IdIngrediente, Cantidad = 160m }
            );

            Contexto.PasosPreparacion.AddRange(
                new PasoPreparacion { IdReceta = recCapMediano.IdReceta, NumeroPaso = 1, Instruccion = "Extraer un espresso doble (36g) directo en una taza precalentada de 8 oz." },
                new PasoPreparacion { IdReceta = recCapMediano.IdReceta, NumeroPaso = 2, Instruccion = "Llenar la jarra de acero con 160ml de leche entera bien fría (4°C) hasta la base del pico." },
                new PasoPreparacion { IdReceta = recCapMediano.IdReceta, NumeroPaso = 3, Instruccion = "Purgar lanceta. Colocar la punta apenas bajo la superficie para inyectar aire suave (siseo controlado) hasta que la jarra alcance temperatura ambiente (~37°C)." },
                new PasoPreparacion { IdReceta = recCapMediano.IdReceta, NumeroPaso = 4, Instruccion = "Sumergir la punta 1 cm más inclinando la jarra para crear el remolino/vórtice y texturizar hasta 60°C - 65°C." },
                new PasoPreparacion { IdReceta = recCapMediano.IdReceta, NumeroPaso = 5, Instruccion = "Limpiar y purgar lanceta. Dar un golpe seco con la jarra en la barra y mover en círculos para dar brillo brillante." },
                new PasoPreparacion { IdReceta = recCapMediano.IdReceta, NumeroPaso = 6, Instruccion = "Verter desde el centro integrando la microespuma con la crema del espresso, finalizando con corazón o tulipán." }
            );

            var latte = new Bebida
            {
                Nombre = "Caffè Latte Vainilla",
                Descripcion = "Bebida suave y cremosa con notas dulces de vainilla y un toque sutil de café.",
                Imagen = "",
                Estado = true,
                IdCategoria = Categoria_Frias.IdCategoria
            };
            Contexto.Bebidas.Add(latte);
            Contexto.SaveChanges();

            var recLatteGrande = new Receta
            {
                IdBebida = latte.IdBebida,
                Tamaño = "Grande (12 oz)"
            };
            Contexto.Recetas.Add(recLatteGrande);
            Contexto.SaveChanges();

            Contexto.RecetaIngredientes.AddRange(
                new RecetaIngrediente { IdReceta = recLatteGrande.IdReceta, IdIngrediente = ingCafe.IdIngrediente, Cantidad = 18m },
                new RecetaIngrediente { IdReceta = recLatteGrande.IdReceta, IdIngrediente = ingLecheEntera.IdIngrediente, Cantidad = 250m },
                new RecetaIngrediente { IdReceta = recLatteGrande.IdReceta, IdIngrediente = ingJarabeVainilla.IdIngrediente, Cantidad = 20m }
            );

            Contexto.PasosPreparacion.AddRange(
                new PasoPreparacion { IdReceta = recLatteGrande.IdReceta, NumeroPaso = 1, Instruccion = "Dosificar 20ml de jarabe de vainilla en el fondo de la taza grande de 12 oz." },
                new PasoPreparacion { IdReceta = recLatteGrande.IdReceta, NumeroPaso = 2, Instruccion = "Extraer espresso doble (36g) sobre el jarabe y revolver con cuchara para disolver homogéneamente." },
                new PasoPreparacion { IdReceta = recLatteGrande.IdReceta, NumeroPaso = 3, Instruccion = "Texturizar 250ml de leche a 65°C con una capa fina de microespuma (menos aire que el cappuccino)." },
                new PasoPreparacion { IdReceta = recLatteGrande.IdReceta, NumeroPaso = 4, Instruccion = "Verter con flujo constante a una altura media para mezclar y bajar al final para dibujar arte latte." }
            );

            var icedCaramel = new Bebida
            {
                Nombre = "Iced Caramel Macchiato",
                Descripcion = "Refrescante bebida en capas visuales: vainilla, leche fría, hielo, espresso flotante y salsa de caramelo.",
                Imagen = "",
                Estado = true,
                IdCategoria = Categoria_Calientes.IdCategoria
            };
            Contexto.Bebidas.Add(icedCaramel);
            Contexto.SaveChanges();

            var recIcedCaramel = new Receta
            {
                IdBebida = icedCaramel.IdBebida,
                Tamaño = "Grande (16 oz)"
            };
            Contexto.Recetas.Add(recIcedCaramel);
            Contexto.SaveChanges();

            Contexto.RecetaIngredientes.AddRange(
                new RecetaIngrediente { IdReceta = recIcedCaramel.IdReceta, IdIngrediente = ingCafe.IdIngrediente, Cantidad = 18m },
                new RecetaIngrediente { IdReceta = recIcedCaramel.IdReceta, IdIngrediente = ingLecheEntera.IdIngrediente, Cantidad = 200m },
                new RecetaIngrediente { IdReceta = recIcedCaramel.IdReceta, IdIngrediente = ingHielo.IdIngrediente, Cantidad = 120m },
                new RecetaIngrediente { IdReceta = recIcedCaramel.IdReceta, IdIngrediente = ingJarabeVainilla.IdIngrediente, Cantidad = 15m },
                new RecetaIngrediente { IdReceta = recIcedCaramel.IdReceta, IdIngrediente = ingJarabeCaramelo.IdIngrediente, Cantidad = 15m }
            );

            Contexto.PasosPreparacion.AddRange(
                new PasoPreparacion { IdReceta = recIcedCaramel.IdReceta, NumeroPaso = 1, Instruccion = "Verter 15ml de jarabe de vainilla en un vaso transparente de 16 oz." },
                new PasoPreparacion { IdReceta = recIcedCaramel.IdReceta, NumeroPaso = 2, Instruccion = "Llenar el vaso con cubos de hielo limpios (aprox. 120g) hasta 3/4 de la altura." },
                new PasoPreparacion { IdReceta = recIcedCaramel.IdReceta, NumeroPaso = 3, Instruccion = "Añadir 200ml de leche entera fría sobre el hielo dejando 3 cm libres arriba." },
                new PasoPreparacion { IdReceta = recIcedCaramel.IdReceta, NumeroPaso = 4, Instruccion = "Extraer un espresso doble en una jarrita de servicio." },
                new PasoPreparacion { IdReceta = recIcedCaramel.IdReceta, NumeroPaso = 5, Instruccion = "Verter el espresso suavemente sobre el hielo para que quede flotando en la parte superior ('macchiato' = manchado)." },
                new PasoPreparacion { IdReceta = recIcedCaramel.IdReceta, NumeroPaso = 6, Instruccion = "Decorar la superficie con un patrón de rejilla cruzada usando el jarabe de caramelo." }
            );

            var v60 = new Bebida
            {
                Nombre = "Filtrado Artesanal V60",
                Descripcion = "Método de goteo cónico que resalta notas florales, cítricas y la acidez brillante del café de especialidad.",
                Imagen = "",
                Estado = true,
                IdCategoria = Categoria_Alcohol.IdCategoria
            };
            Contexto.Bebidas.Add(v60);
            Contexto.SaveChanges();

            var recV60 = new Receta
            {
                IdBebida = v60.IdBebida,
                Tamaño = "Tetera (10 oz / 300ml)"
            };
            Contexto.Recetas.Add(recV60);
            Contexto.SaveChanges();

            Contexto.RecetaIngredientes.AddRange(
                new RecetaIngrediente { IdReceta = recV60.IdReceta, IdIngrediente = ingCafe.IdIngrediente, Cantidad = 18m },
                new RecetaIngrediente { IdReceta = recV60.IdReceta, IdIngrediente = ingAgua.IdIngrediente, Cantidad = 300m }
            );

            Contexto.PasosPreparacion.AddRange(
                new PasoPreparacion { IdReceta = recV60.IdReceta, NumeroPaso = 1, Instruccion = "Colocar papel filtro en el V60, enjuagar con agua a 92°C para quitar sabor a celulosa y calentar el recipiente; descartar agua." },
                new PasoPreparacion { IdReceta = recV60.IdReceta, NumeroPaso = 2, Instruccion = "Agregar 18g de café con molienda media (tipo sal kosher). Tara la báscula a 0g." },
                new PasoPreparacion { IdReceta = recV60.IdReceta, NumeroPaso = 3, Instruccion = "Bloom (Pre-infusión): Verter 50g de agua en espiral cubriendo todo el grano. Esperar 35 a 40 segundos mientras se liberan los gases." },
                new PasoPreparacion { IdReceta = recV60.IdReceta, NumeroPaso = 4, Instruccion = "Segundo vertido: Verter suavemente en círculos concéntricos hasta llegar a 180g de agua." },
                new PasoPreparacion { IdReceta = recV60.IdReceta, NumeroPaso = 5, Instruccion = "Tercer vertido: Completar el flujo hasta alcanzar 300g antes del minuto 2:00." },
                new PasoPreparacion { IdReceta = recV60.IdReceta, NumeroPaso = 6, Instruccion = "Dejar que filtre por gravedad. El tiempo final de extracción debe rondar entre 2:45 y 3:15 min. Oxigenar en jarra antes de servir." }
            );

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
