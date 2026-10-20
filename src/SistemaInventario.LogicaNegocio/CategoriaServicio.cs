using SistemaInventario.Entidades;
using SistemaInventario.AccesoDatos.Repositorios;
using System.Linq;

namespace SistemaInventario.LogicaNegocio
{
    public class CategoriaServicio
    {
        private readonly RepositorioBase<Categoria> _repositorioCategoria;
        private readonly RepositorioBase<Producto> _repositorioProducto;
        public CategoriaServicio(RepositorioBase<Categoria> repositorioCategoria, RepositorioBase<Producto> repositorioProducto)
        {
            _repositorioCategoria = repositorioCategoria;
            _repositorioProducto = repositorioProducto;
        }
        public List<Categoria> ObtenerEliminadas() => _repositorioCategoria.ObtenerEliminados();


        //Comprobaciones antes de agregar una categoría
        public bool AgregarCategoria(Categoria categoria)
        {
            if (categoria == null)
            {
                throw new ArgumentNullException(nameof(categoria), "La categoría no puede ser nula.");
            }
            else if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.", nameof(categoria.Nombre));
            }
            else if (categoria.Nombre.Length > 100 || categoria.Nombre.Length < 3)
            {
                throw new ArgumentException("El nombre de la categoría debe tener entre 3 y 100 caracteres.", nameof(categoria.Nombre));
            }
            else if (string.IsNullOrWhiteSpace(categoria.Descripcion))
            {
                throw new ArgumentException("La descripción de la categoría no puede estar vacía.", nameof(categoria.Descripcion));
            }
            else if (categoria.Descripcion.Length > 500)
            {
                throw new ArgumentException("La descripción de la categoría no puede exceder los 500 caracteres.", nameof(categoria.Descripcion));
            }
            //Sin categoria repetida    

            List<Categoria> categoriasExistentes = _repositorioCategoria.ObtenerTodos().ToList();
            if (categoriasExistentes.Any(c => c.Nombre.Trim().Equals(categoria.Nombre.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("La categoría ya existe.", nameof(categoria.Nombre));
            }

            categoria.FechaCreacion = DateTime.Now;
            categoria.Nombre = categoria.Nombre.Trim();
            categoria.Descripcion = categoria.Descripcion.Trim();
            categoria.Activo = true;
            return _repositorioCategoria.Agregar(categoria);
            
        }

        //Comprobaciones antes de actualizar una categoría

        public bool ActualizarCategoria(Categoria categoria)
        {
            if (categoria == null)
            {
                throw new ArgumentNullException(nameof(categoria), "La categoría no puede ser nula.");
            }
            else if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.", nameof(categoria.Nombre));
            }
            else if (categoria.Nombre.Length > 100 || categoria.Nombre.Length < 3)
            {
                throw new ArgumentException("El nombre de la categoría debe tener entre 3 y 100 caracteres.", nameof(categoria.Nombre));
            }
            else if (string.IsNullOrWhiteSpace(categoria.Descripcion))
            {
                throw new ArgumentException("La descripción de la categoría no puede estar vacía.", nameof(categoria.Descripcion));
            }
            else if (categoria.Descripcion.Length > 500)
            {
                throw new ArgumentException("La descripción de la categoría no puede exceder los 500 caracteres.", nameof(categoria.Descripcion));
            }

            List<Categoria> categoriasExistentes = _repositorioCategoria.ObtenerTodos().ToList();
            if (categoriasExistentes.Any(c => c.Nombre.Trim().Equals(categoria.Nombre.Trim(),StringComparison.OrdinalIgnoreCase)&& c.Id != categoria.Id))
            {
                throw new ArgumentException(
                    "Ya existe otra categoría con ese nombre.",
                    nameof(categoria.Nombre));
            }
            categoria.Activo = true;
            categoria.FechaModificacion = DateTime.Now;
            categoria.Nombre = categoria.Nombre.Trim();
            categoria.Descripcion = categoria.Descripcion.Trim();
            return _repositorioCategoria.Actualizar(categoria);
        }

        public List<Categoria> ObtenerCategorias()
        {
            return _repositorioCategoria.ObtenerTodos();
        }

        public Categoria? ObtenerCategoriaPorId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID de la categoría debe ser un número positivo.", nameof(id));
            }
            return _repositorioCategoria.ObtenerPorId(id);
        }

        public bool EliminarCategoria(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(
                    "El ID de la categoría debe ser positivo.", nameof(id));
            }

            bool tieneProductosActivos = _repositorioProducto
                .ObtenerTodos()
                .Any(p => p.IdCategoria == id && p.Activo);

            if (tieneProductosActivos)
            {
                throw new InvalidOperationException(
                    "No se puede desactivar la categoría porque tiene productos activos.");
            }
            return _repositorioCategoria.EliminarLogico(id);
        }

        public bool RestaurarCategoria(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID de la categoría debe ser un número positivo.", nameof(id));
            }
            return _repositorioCategoria.Restaurar(id);
        }

       
    }
}
