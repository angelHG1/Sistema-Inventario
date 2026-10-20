using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventario.AccesoDatos.Repositorios
{
    public interface IRepositorio<T>
    {
        List<T> ObtenerTodos();
        T? ObtenerPorId(int id);
        bool Agregar(T entidad);
        bool Actualizar(T entidad);
        bool EliminarLogico(int id);
        bool Restaurar(int id);
    }
}
