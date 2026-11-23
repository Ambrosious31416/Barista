using Barista.Data;
using Barista.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Barista.Servicios
{
    public class Receta_Servicio
    {
        private readonly Contexto _contexto;

        public Receta_Servicio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<Categoria>> ObtenerCategoriasAsync()
        {
            return await _contexto.Categorias
                .AsNoTracking()
                .OrderBy(c => c.Nombre)
                .ToListAsync();
        }

        public async Task<List<Bebida>> ObtenerBebidasAsync(int? idCategoria = null, string? filtro = null)
        {
            IQueryable<Bebida> query = _contexto.Bebidas
                .Include(b => b.Categoria)
                .Include(b => b.Recetas)
                .Where(b => b.Estado)
                .AsNoTracking();

            if (idCategoria.HasValue && idCategoria.Value > 0)
            {
                query = query.Where(b => b.IdCategoria == idCategoria.Value);
            }

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                string f = filtro.Trim().ToLower();
                query = query.Where(b => b.Nombre.ToLower().Contains(f) || b.Descripcion.ToLower().Contains(f));
            }

            return await query.OrderBy(b => b.Nombre).ToListAsync();
        }

        public async Task<List<Receta>> ObtenerRecetasPorBebidaAsync(int idBebida)
        {
            return await _contexto.Recetas
                .Where(r => r.IdBebida == idBebida)
                .AsNoTracking()
                .OrderBy(r => r.Tamaño)
                .ToListAsync();
        }

        public async Task<Receta?> ObtenerDetalleRecetaAsync(int idReceta)
        {
            return await _contexto.Recetas
                .Include(r => r.Bebida!)
                    .ThenInclude(b => b.Categoria)
                .Include(r => r.RecetaIngredientes)
                    .ThenInclude(ri => ri.Ingrediente)
                .Include(r => r.PasosPreparacion)
                .AsNoTracking()
                .FirstOrDefaultAsync(r => r.IdReceta == idReceta);
        }
    }
}
