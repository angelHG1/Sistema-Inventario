using System;
using System.Collections.Generic;
using System.Text;
using SistemaInventario.Entidades;
using SistemaInventario.AccesoDatos.AccesoDatos;
using System.Data;
using Microsoft.Data.SqlClient;

namespace SistemaInventario.AccesoDatos.Repositorios
{
    public class ProductoRepositorio : RepositorioBase<Producto>
    {
        public ProductoRepositorio(AccesoDatosBD accesoDatos) : base(accesoDatos)
        {
        }
        public override List<Producto> ObtenerTodos()
        {
            List<Producto> productos = new List<Producto>();
            DataTable consulta = _accesoDatos.EjecutarConsulta("SELECT * FROM Producto where Activo = 1");
            foreach (DataRow fila in consulta.Rows)
            {
                Producto producto = new Producto
                {
                    IdProducto = Convert.ToInt32(fila["Id_Producto"]),
                    IdCategoria = Convert.ToInt32(fila["Id_Categoria"]),
                    IdSuplidor = Convert.ToInt32(fila["Id_Suplidor"]),
                    Nombre = fila["Nombre"].ToString(),
                    PrecioUnitario = Convert.ToDecimal(fila["Precio_Unitario"]),
                    FechaCreacion = Convert.ToDateTime(fila["Fecha_Creacion"]),
                    FechaModificacion = fila.IsNull("Fecha_Modificacion") ? (DateTime?)null : Convert.ToDateTime(fila["Fecha_Modificacion"]),
                    Activo = Convert.ToBoolean(fila["Activo"])
                };
                productos.Add(producto);        
            }
            return productos;
        }

        public override Producto ObtenerPorId(int id)
        {

            DataTable consulta = _accesoDatos.EjecutarConsulta("SELECT * FROM Producto WHERE Id_Producto = @Id_Producto AND Activo = 1",
                new SqlParameter("@Id_Producto", id));

            if (consulta.Rows.Count == 0)
            {
                return null;
            }
            DataRow fila = consulta.Rows[0];
            return new Producto
            {
                IdProducto = Convert.ToInt32(fila["Id_Producto"]),
                IdCategoria = Convert.ToInt32(fila["Id_Categoria"]),
                IdSuplidor = Convert.ToInt32(fila["Id_Suplidor"]),
                Nombre = fila["Nombre"].ToString(),
                PrecioUnitario = Convert.ToDecimal(fila["Precio_Unitario"]),
                FechaCreacion = Convert.ToDateTime(fila["Fecha_Creacion"]),
                FechaModificacion = fila.IsNull("Fecha_Modificacion") ? (DateTime?)null : Convert.ToDateTime(fila["Fecha_Modificacion"]),
                Activo = Convert.ToBoolean(fila["Activo"])
            };
        }

        public override bool Agregar(Producto entidad)
        {
            string consulta = "exec CreateProducto @Id_Categoria, @Id_Suplidor, @Nombre, @Precio_Unitario, @Fecha_Creacion, @Activo";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id_Categoria", entidad.IdCategoria),
                new SqlParameter("@Id_Suplidor", entidad.IdSuplidor),
                new SqlParameter("@Nombre", entidad.Nombre),
                new SqlParameter("@Precio_Unitario", entidad.PrecioUnitario),
                new SqlParameter("@Fecha_Creacion", entidad.FechaCreacion),
                new SqlParameter("@Activo", entidad.Activo)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override bool Actualizar(Producto entidad)
        {
            string consulta = "exec UpdateProducto " +
                    "@Id_Producto = @Id_Producto, " +
                    "@Id_Categoria = @Id_Categoria, " +
                    "@Id_Suplidor = @Id_Suplidor, " +
                    "@Nombre = @Nombre, " +
                    "@Precio_Unitario = @Precio_Unitario, " +
                    "@Fecha_Modificacion = @Fecha_Modificacion, " +
                    "@Activo = @Activo";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id_Producto", entidad.IdProducto),
                new SqlParameter("@Id_Categoria", entidad.IdCategoria),
                new SqlParameter("@Id_Suplidor", entidad.IdSuplidor),
                new SqlParameter("@Nombre", entidad.Nombre),
                new SqlParameter("@Precio_Unitario", entidad.PrecioUnitario),
                new SqlParameter("@Fecha_Modificacion", entidad.FechaModificacion ?? (object)DBNull.Value),
                new SqlParameter("@Activo", entidad.Activo)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override bool EliminarLogico(int id)
        {
            string consulta = "exec SoftDeleteProducto @Id_Producto";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id_Producto", id)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override bool Restaurar(int id)
        {
            string consulta = "Update Producto set Activo = 1 where Id_Producto = @Id_Producto";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id_Producto", id)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override List<Producto> ObtenerEliminados()
        {
            List<Producto> lista = new List<Producto>();
            DataTable tabla = _accesoDatos.EjecutarConsulta("SELECT * FROM Producto where Activo = 0");
            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Producto
                {
                    IdProducto = Convert.ToInt32(fila["Id_Producto"]),
                    IdCategoria = Convert.ToInt32(fila["Id_Categoria"]),
                    IdSuplidor = Convert.ToInt32(fila["Id_Suplidor"]),
                    Nombre = fila["Nombre"].ToString(),
                    PrecioUnitario = Convert.ToDecimal(fila["Precio_Unitario"]),
                    FechaModificacion = fila["Fecha_Modificacion"] == DBNull.Value ? null
                         : Convert.ToDateTime(fila["Fecha_Modificacion"]),
                    Activo = false
                });
            }
            return lista;
        }
    }
}
