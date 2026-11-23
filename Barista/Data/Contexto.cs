
using Barista.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Barista.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> Opciones)
            : base(Opciones)
        {
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<RecetaIngrediente> RecetaIngredientes { get; set; }
        public DbSet<PasoPreparacion> PasosPreparacion { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            base.OnModelCreating(ModelBuilder);

            ModelBuilder.Entity<Categoria>()
                .HasKey(c => c.IdCategoria);

            ModelBuilder.Entity<Bebida>()
                .HasKey(b => b.IdBebida);

            ModelBuilder.Entity<Ingrediente>()
                .HasKey(i => i.IdIngrediente);

            ModelBuilder.Entity<Receta>()
                .HasKey(r => r.IdReceta);

            ModelBuilder.Entity<PasoPreparacion>()
                .HasKey(p => p.IdPaso);

            ModelBuilder.Entity<Usuario>()
                .HasKey(u => u.IdUsuario);

            ModelBuilder.Entity<RecetaIngrediente>()
                .HasKey(ri => new
                {
                    ri.IdReceta,
                    ri.IdIngrediente
                });

            ModelBuilder.Entity<RecetaIngrediente>()
                .Property(ri => ri.Cantidad)
                .HasPrecision(10, 2);

            ModelBuilder.Entity<Bebida>()
                .HasOne(b => b.Categoria)
                .WithMany()
                .HasForeignKey(b => b.IdCategoria)
                .OnDelete(DeleteBehavior.Restrict);

            ModelBuilder.Entity<Receta>()
                .HasOne(r => r.Bebida)
                .WithMany(b => b.Recetas)
                .HasForeignKey(r => r.IdBebida)
                .OnDelete(DeleteBehavior.Cascade);

            ModelBuilder.Entity<PasoPreparacion>()
                .HasOne(p => p.Receta)
                .WithMany(r => r.PasosPreparacion)
                .HasForeignKey(p => p.IdReceta)
                .OnDelete(DeleteBehavior.Cascade);

            ModelBuilder.Entity<RecetaIngrediente>()
                .HasOne(ri => ri.Receta)
                .WithMany(r => r.RecetaIngredientes)
                .HasForeignKey(ri => ri.IdReceta)
                .OnDelete(DeleteBehavior.Cascade);

            ModelBuilder.Entity<RecetaIngrediente>()
                .HasOne(ri => ri.Ingrediente)
                .WithMany()
                .HasForeignKey(ri => ri.IdIngrediente)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
