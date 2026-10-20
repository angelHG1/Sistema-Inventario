using Microsoft.Data.SqlClient;
using System;
using System.Data;
using SistemaInventario.AccesoDatos.Conexion;

namespace SistemaInventario.AccesoDatos.AccesoDatos
{
    public class AccesoDatosBD
    {
        public bool EjecutarComando(string Consulta,params SqlParameter[] parametros)
        {
            using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(Consulta, conexion))
            {
                comando.Parameters.AddRange(parametros);

                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }

        public DataTable EjecutarConsulta(string Consulta, params SqlParameter[] parametros)
        {
            DataTable Resultado = new DataTable();
            using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(Consulta, conexion))
            {
                comando.Parameters.AddRange(parametros);

                using (SqlDataAdapter Adaptador = new SqlDataAdapter(comando))
                {
                    Adaptador.Fill(Resultado);
                }
            }

            return Resultado;
        }

        public object? EjecutarEscalar(string Consulta, params SqlParameter[] parametros)
        {
            using (SqlConnection conexion = ConexionBD.Instancia.ObtenerConexion())
            using (SqlCommand comando = new SqlCommand(Consulta, conexion))
            {
                comando.Parameters.AddRange(parametros);
                conexion.Open();
                return comando.ExecuteScalar();
            }
        }
    }
}