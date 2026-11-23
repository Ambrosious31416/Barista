using Barista.Data;
using Barista.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Barista.Servicios
{
    public class Bebida_Servicio
    {
        private readonly Contexto _contexto;

        public Bebida_Servicio(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<List<Bebida>> ObtenerBebidasAsync(
            string? filtro = null,
            bool incluirInactivas = false)
        {
            IQueryable<Bebida> query = _contexto.Bebidas
                .Include(b => b.Categoria)
                .AsNoTracking();

            if (!incluirInactivas)
            {
                query = query.Where(b => b.Estado);
            }

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                string f = filtro.Trim().ToLower();
                query = query.Where(b =>
                    b.Nombre.ToLower().Contains(f) ||
                    b.Descripcion.ToLower().Contains(f) ||
                    (b.Categoria != null && b.Categoria.Nombre.ToLower().Contains(f)));
            }

            return await query
                .OrderBy(b => b.Nombre)
                .ToListAsync();
        }

        public async Task<Bebida?> ObtenerPorIdAsync(int id)
        {
            return await _contexto.Bebidas
                .Include(b => b.Categoria)
                .FirstOrDefaultAsync(b => b.IdBebida == id);
        }

        public async Task CrearAsync(Bebida bebida)
        {
            ArgumentNullException.ThrowIfNull(bebida);

            if (string.IsNullOrWhiteSpace(bebida.Nombre))
            {
                throw new ArgumentException(
                    "El nombre de la bebida es obligatorio.");
            }

            bool categoriaExiste = await _contexto.Categorias
                .AnyAsync(c => c.IdCategoria == bebida.IdCategoria);

            if (!categoriaExiste)
            {
                throw new ArgumentException(
                    "La categoría seleccionada no existe.");
            }

            bebida.Nombre = bebida.Nombre.Trim();

            _contexto.Bebidas.Add(bebida);

            await _contexto.SaveChangesAsync();
        }

        public async Task ActualizarAsync(Bebida bebida)
        {
            ArgumentNullException.ThrowIfNull(bebida);

            if (string.IsNullOrWhiteSpace(bebida.Nombre))
            {
                throw new ArgumentException(
                    "El nombre de la bebida es obligatorio.");
            }

            var existe = await _contexto.Bebidas
                .FindAsync(bebida.IdBebida);

            if (existe == null)
            {
                throw new ArgumentException(
                    "La bebida que intentas modificar no existe.");
            }

            bool categoriaExiste = await _contexto.Categorias
                .AnyAsync(c => c.IdCategoria == bebida.IdCategoria);

            if (!categoriaExiste)
            {
                throw new ArgumentException(
                    "La categoría seleccionada no existe.");
            }

            existe.Nombre = bebida.Nombre.Trim();
            existe.Descripcion = bebida.Descripcion;
            existe.Imagen = bebida.Imagen;
            existe.Estado = bebida.Estado;
            existe.IdCategoria = bebida.IdCategoria;

            await _contexto.SaveChangesAsync();
        }

        public async Task CambiarEstadoAsync(int id, bool estado)
        {
            var bebida = await _contexto.Bebidas.FindAsync(id);

            if (bebida == null)
            {
                throw new ArgumentException(
                    "La bebida no existe.");
            }

            bebida.Estado = estado;

            await _contexto.SaveChangesAsync();
        }
    }
}
