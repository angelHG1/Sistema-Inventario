using Microsoft.Data.SqlClient;
using SistemaInventario.AccesoDatos.AccesoDatos;
using SistemaInventario.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaInventario.AccesoDatos.Repositorios
{
    public class CategoriaRepositorio : RepositorioBase<Categoria>
    {
        public CategoriaRepositorio(AccesoDatosBD accesoDatos) : base(accesoDatos)
        {
        }
        public override List<Categoria> ObtenerTodos()
        {
            List<Categoria> categorias = new List<Categoria>();

            DataTable consulta = _accesoDatos.EjecutarConsulta("SELECT * FROM Categoria where Activo = 1");

            foreach (DataRow fila in consulta.Rows)
            {
                Categoria categoria = new Categoria
                {
                    Id = Convert.ToInt32(fila["Id_Categoria"]),
                    Nombre = fila["Nombre"].ToString(),
                    Descripcion = fila["Descripcion"].ToString(),
                    FechaCreacion = Convert.ToDateTime(fila["Fecha_Creacion"]),
                    FechaModificacion = fila.IsNull("Fecha_Modificacion") ? (DateTime?)null : Convert.ToDateTime(fila["Fecha_Modificacion"]),
                    Activo = Convert.ToBoolean(fila["Activo"])
                };
                categorias.Add(categoria);
            }

            return categorias;
        }

        public override Categoria ObtenerPorId(int id)
        {

            DataTable consulta = _accesoDatos.EjecutarConsulta("SELECT * FROM Categoria WHERE Id_Categoria = @Id AND Activo = 1",
                new SqlParameter("@Id", id));

            if (consulta.Rows.Count == 0)
            {
                return null;
            }
            DataRow fila = consulta.Rows[0];
            return new Categoria
            {
                Id = Convert.ToInt32(fila["Id_Categoria"]),
                Nombre = fila["Nombre"].ToString(),
                Descripcion = fila["Descripcion"].ToString(),
                FechaCreacion = Convert.ToDateTime(fila["Fecha_Creacion"]),
                FechaModificacion = fila.IsNull("Fecha_Modificacion") ? (DateTime?)null : Convert.ToDateTime(fila["Fecha_Modificacion"]),
                Activo = Convert.ToBoolean(fila["Activo"])
            };
        }

        public override bool Agregar(Categoria entidad)
        {
            string consulta = "exec CreateCategoria @Nombre, @Descripcion, @Fecha_Creacion, @Activo";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", entidad.Nombre),
                new SqlParameter("@Descripcion", entidad.Descripcion),
                new SqlParameter("@Fecha_Creacion", entidad.FechaCreacion),
                new SqlParameter("@Activo", entidad.Activo)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override bool Actualizar(Categoria entidad)
        {
            string consulta = "exec UpdateCategoria " +
                    "@Id_Categoria = @Id_Categoria, " +
                    "@Nombre = @Nombre, " +
                    "@Descripcion = @Descripcion, " +
                    "@Fecha_Modificacion = @Fecha_Modificacion, " +
                    "@Activo = @Activo";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id_Categoria", entidad.Id),
                new SqlParameter("@Nombre", entidad.Nombre),
                new SqlParameter("@Descripcion", entidad.Descripcion),
                new SqlParameter("@Fecha_Modificacion", entidad.FechaModificacion ?? (object)DBNull.Value),
                new SqlParameter("@Activo", entidad.Activo)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override bool EliminarLogico(int id)
        {
            string consulta = "exec SoftDeleteCategoria @Id";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override bool Restaurar(int id)
        {
            string consulta = "Update Categoria set Activo = 1 where Id_Categoria = @Id";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override List<Categoria> ObtenerEliminados()
        {
            List<Categoria> lista = new List<Categoria>();
            DataTable tabla = _accesoDatos.EjecutarConsulta("SELECT * FROM Categoria where Activo = 0");
            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Categoria
                {
                    Id = Convert.ToInt32(fila["Id_Categoria"]),
                    Nombre = fila["Nombre"].ToString(),
                    Descripcion = fila["Descripcion"].ToString(),
                    FechaModificacion = fila["Fecha_Modificacion"] == DBNull.Value ? null
                                 : Convert.ToDateTime(fila["Fecha_Modificacion"]),
                    Activo = false
                });
            }
            return lista;
        }
    }
}