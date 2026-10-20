using Microsoft.Data.SqlClient;

namespace SistemaInventario.AccesoDatos.Conexion
{
    public class ConexionBD
    {
        //Singleton, Lazy para solo crear la instancia cuando se necesite
        private static readonly Lazy<ConexionBD> _instancia= new Lazy<ConexionBD>(() => new ConexionBD());
        private readonly string _cadenaConexion =
            "Server=ANGELH;" +
            "Database=Sistema_Inventario;" +
            "User ID=angel;" +
            "Password=Diciembre2006;" +
            "TrustServerCertificate=True;" +
            "Encrypt=True;";

        private ConexionBD()
        { }

        public static ConexionBD Instancia => _instancia.Value;

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }
    }
}
