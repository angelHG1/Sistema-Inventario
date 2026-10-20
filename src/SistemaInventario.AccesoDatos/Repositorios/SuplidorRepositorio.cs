using Microsoft.Data.SqlClient;
using SistemaInventario.AccesoDatos.AccesoDatos;
using SistemaInventario.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SistemaInventario.AccesoDatos.Repositorios
{
    public class SuplidorRepositorio : RepositorioBase<Suplidor>
    {
        public SuplidorRepositorio(AccesoDatosBD accesoDatos) : base(accesoDatos)
        {
        }
        public override List<Suplidor> ObtenerTodos()
        {
            List<Suplidor> suplidores = new List<Suplidor>();
            DataTable consulta = _accesoDatos.EjecutarConsulta("SELECT * FROM Suplidor where Activo = 1");
            foreach (DataRow fila in consulta.Rows)
            {
                Suplidor suplidor = new Suplidor
                {
                    Id_Suplidor = Convert.ToInt32(fila["Id_Suplidor"]),
                    Nombre_Empresa = fila["Nombre_Empresa"].ToString(),
                    Nombre_contacto = fila["Nombre_Contacto"].ToString(),
                    Telefono = fila["Telefono"].ToString(),
                    Correo = fila["Correo"].ToString(),
                    web = fila["Web"].ToString(),
                    FechaCreacion = Convert.ToDateTime(fila["Fecha_Creacion"]),
                    FechaModificacion = fila.IsNull("Fecha_Modificacion") ? (DateTime?)null : Convert.ToDateTime(fila["Fecha_Modificacion"]),
                    Activo = Convert.ToBoolean(fila["Activo"])
                };
                suplidores.Add(suplidor);
            }
            return suplidores;
        }

        public override Suplidor ObtenerPorId(int id)
        {

            DataTable consulta = _accesoDatos.EjecutarConsulta("SELECT * FROM Suplidor WHERE Id_Suplidor = @Id AND Activo = 1",
                new SqlParameter("@Id", id));

            if (consulta.Rows.Count == 0)
            {
                return null;
            }
            DataRow fila = consulta.Rows[0];
            return new Suplidor
            {
                Id_Suplidor = Convert.ToInt32(fila["Id_Suplidor"]),
                Nombre_Empresa = fila["Nombre_Empresa"].ToString(),
                Nombre_contacto = fila["Nombre_Contacto"].ToString(),
                Telefono = fila["Telefono"].ToString(),
                Correo = fila["Correo"].ToString(),
                web = fila["Web"].ToString(),
                FechaCreacion = Convert.ToDateTime(fila["Fecha_Creacion"]),
                FechaModificacion = fila.IsNull("Fecha_Modificacion") ? (DateTime?)null : Convert.ToDateTime(fila["Fecha_Modificacion"]),
                Activo = Convert.ToBoolean(fila["Activo"])
            };
        }

        public override bool Agregar(Suplidor entidad)
        {
            string consulta = "exec CreateSuplidor @Nombre_Empresa, @Nombre_Contacto, @Telefono, @Correo, @Web, @Fecha_Creacion, @Activo";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre_Empresa", entidad.Nombre_Empresa),
                new SqlParameter("@Nombre_Contacto", entidad.Nombre_contacto),
                new SqlParameter("@Telefono", entidad.Telefono),
                new SqlParameter("@Correo", entidad.Correo),
                new SqlParameter("@Web", entidad.web),
                new SqlParameter("@Fecha_Creacion", entidad.FechaCreacion),
                new SqlParameter("@Activo", entidad.Activo)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override bool Actualizar(Suplidor entidad)
        {
            string consulta = "exec UpdateSuplidor @Id, @Nombre_Empresa, @Nombre_Contacto, @Telefono, @Correo, @Web, @Fecha_Modificacion, @Activo";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", entidad.Id_Suplidor),
                new SqlParameter("@Nombre_Empresa", entidad.Nombre_Empresa),
                new SqlParameter("@Nombre_Contacto", entidad.Nombre_contacto),
                new SqlParameter("@Telefono", entidad.Telefono),
                new SqlParameter("@Correo", entidad.Correo),
                new SqlParameter("@Web", entidad.web),
                new SqlParameter("@Fecha_Modificacion", entidad.FechaModificacion ?? (object)DBNull.Value),
                new SqlParameter("@Activo", entidad.Activo)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override bool EliminarLogico(int id)
        {
            string consulta = "exec SoftDeleteSuplidor @Id";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override bool Restaurar(int id)
        {
            string consulta = "Update Suplidor set Activo = 1 where Id_Suplidor = @Id";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Id", id)
            };
            return _accesoDatos.EjecutarComando(consulta, parametros);
        }

        public override List<Suplidor> ObtenerEliminados()
        {
            List<Suplidor> lista = new List<Suplidor>();
            DataTable tabla = _accesoDatos.EjecutarConsulta("SELECT * FROM Suplidor where Activo = 0");
            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Suplidor
                {
                    Id_Suplidor = Convert.ToInt32(fila["Id_Suplidor"]), 
                    Nombre_Empresa = fila["Nombre_Empresa"].ToString(),
                    Nombre_contacto = fila["Nombre_Contacto"].ToString(),
                    Telefono = fila["Telefono"].ToString(),
                    Correo = fila["Correo"].ToString(),
                    web = fila["Web"].ToString(),
                    FechaCreacion = Convert.ToDateTime(fila["Fecha_Creacion"]),
                    Activo = false
                });
            }
            return lista;
        }
    }
}