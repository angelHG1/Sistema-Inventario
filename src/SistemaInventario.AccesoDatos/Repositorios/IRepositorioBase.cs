using System;
using System.Collections.Generic;
using System.Text;
using SistemaInventario.AccesoDatos.AccesoDatos;

namespace SistemaInventario.AccesoDatos.Repositorios
{
    public abstract class RepositorioBase<T>
    {
        protected AccesoDatosBD _accesoDatos;

        protected RepositorioBase(AccesoDatosBD accesoDatos)
        {
            _accesoDatos = accesoDatos;
        }

        public abstract List<T> ObtenerTodos();
            
        public abstract T? ObtenerPorId(int id);
        public abstract bool Agregar(T entidad);
        public abstract bool Actualizar(T entidad);
        public abstract bool EliminarLogico(int id);
        public abstract bool Restaurar(int id);
        public abstract List<T> ObtenerEliminados();
    }
}
