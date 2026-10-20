using SistemaInventario.Entidades;
using SistemaInventario.AccesoDatos.Repositorios;
using System.Linq;
using System.ComponentModel;

namespace SistemaInventario.LogicaNegocio
{
    public class ProductosServicio
    {
        private readonly RepositorioBase<Producto> _repositorio;
        private readonly RepositorioBase<Producto> _repositorioProducto;
        

        public ProductosServicio(RepositorioBase<Producto> repositorio)
        {
            _repositorio = repositorio;

        }
        public List<Producto> ObtenerEliminadas()
        {
            return _repositorio.ObtenerEliminados();
        }

        public bool AgregarProducto(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto), "El producto no puede ser nulo.");
            }
            else if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacío.", nameof(producto.Nombre));
            }
            else if (producto.Nombre.Length > 100 || producto.Nombre.Length < 3)
            {
                throw new ArgumentException("El nombre del producto debe tener entre 3 y 100 caracteres.", nameof(producto.Nombre));
            }
            else if (producto.PrecioUnitario <= 0)
            {
                throw new ArgumentException("El precio unitario del producto debe ser mayor que cero.", nameof(producto.PrecioUnitario));
            }
            // Sin productos repetidos
            List<Producto> productosExistentes = _repositorio.ObtenerTodos().ToList();
            if (productosExistentes.Any(p => p.Nombre.Trim().Equals(producto.Nombre.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("El producto ya existe.", nameof(producto.Nombre));
            }
            producto.FechaCreacion = DateTime.Now;
            producto.Activo = true;
            producto.Nombre = producto.Nombre.Trim();
            return _repositorio.Agregar(producto);
        }

        public bool ActualizarProducto(Producto producto)
        {
            if (producto == null)
            {
                throw new ArgumentNullException(nameof(producto), "El producto no puede ser nulo.");
            }
            else if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacío.", nameof(producto.Nombre));
            }
            else if (producto.Nombre.Length > 100 || producto.Nombre.Length < 3)
            {
                throw new ArgumentException("El nombre del producto debe tener entre 3 y 100 caracteres.", nameof(producto.Nombre));
            }
            else if (producto.PrecioUnitario <= 0)
            {
                throw new ArgumentException("El precio unitario del producto debe ser mayor que cero.", nameof(producto.PrecioUnitario));
            }
            List<Producto> productosExistentes = _repositorio.ObtenerTodos().ToList();
            if (productosExistentes.Any(p => p.IdProducto != producto.IdProducto && p.Nombre.Trim().Equals(producto.Nombre.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("El nombre del producto ya existe.", nameof(producto.Nombre));
            }
            producto.Nombre = producto.Nombre.Trim();
            producto.Activo = true;
            producto.FechaModificacion = DateTime.Now;
            
            return _repositorio.Actualizar(producto);
        }

        public List<Producto> ObtenerTodosProductos()
        {
            return _repositorio.ObtenerTodos();
        }

       public Producto ObtenerPorId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del producto debe ser mayor que cero.", nameof(id));
            }
            return _repositorio.ObtenerPorId(id);
        }

        public bool EliminarProducto(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del producto debe ser mayor que cero.", nameof(id));
            }
            return _repositorio.EliminarLogico(id);
        }

        public bool RestaurarProducto(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del producto debe ser mayor que cero.", nameof(id));
            }
            return _repositorio.Restaurar(id);
        }
        public List<Producto> ObtenerProductosEliminados()
        {
            return _repositorio.ObtenerEliminados();
        }
    }
}
