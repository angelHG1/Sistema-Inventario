using System;
using System.Collections.Generic;
using System.Text;
using SistemaInventario.Entidades;
using SistemaInventario.AccesoDatos.Repositorios;
using System.Text.RegularExpressions;

namespace SistemaInventario.LogicaNegocio
{
    public class SuplidorServicio
    {
        private readonly RepositorioBase<Suplidor> _repositorio;



        public SuplidorServicio(RepositorioBase<Suplidor> repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Suplidor> ObtenerEliminadas() => _repositorio.ObtenerEliminados();
        public List<Suplidor> ObtenerTodos()
        {
            return _repositorio.ObtenerTodos();
        }
        public bool AgregarSuplidor(Suplidor suplidor)
        {
            if (suplidor == null)
            {
                throw new ArgumentNullException(nameof(suplidor), "El suplidor no puede ser nulo.");
            }
            else if (string.IsNullOrWhiteSpace(suplidor.Nombre_Empresa))
            {
                throw new ArgumentException("El nombre de la empresa del suplidor no puede estar vacío.", nameof(suplidor.Nombre_Empresa));
            }
            else if (suplidor.Nombre_Empresa.Length > 100 || suplidor.Nombre_Empresa.Length < 3)
            {
                throw new ArgumentException("El nombre de la empresa del suplidor debe tener entre 3 y 100 caracteres.", nameof(suplidor.Nombre_Empresa));
            }
            else if (string.IsNullOrWhiteSpace(suplidor.Nombre_contacto))
            {
                throw new ArgumentException("El nombre del contacto del suplidor no puede estar vacío.", nameof(suplidor.Nombre_contacto));
            }
            else if (suplidor.Nombre_contacto.Length > 100 || suplidor.Nombre_contacto.Length < 3)
            {
                throw new ArgumentException("El nombre del contacto del suplidor debe tener entre 3 y 100 caracteres.", nameof(suplidor.Nombre_contacto));
            }

            //validar Telefono
            else if (suplidor.Telefono == null || suplidor.Telefono == "")
            {
                throw new ArgumentException("El teléfono del suplidor no puede estar vacío.", nameof(suplidor.Telefono));
            }
            else if (!Regex.IsMatch(suplidor.Telefono, @"^(809|829|849)-\d{3}-\d{4}$"))
            {
                throw new ArgumentException(
                    "El teléfono debe tener el formato 809-555-1234.", nameof(suplidor.Telefono));
            }


            // Validar correo electrónico
            else if (!Regex.IsMatch(suplidor.Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("El correo electrónico no tiene un formato válido.", nameof(suplidor.Correo));
            }
            else if (string.IsNullOrWhiteSpace(suplidor.Correo))
            {
                throw new ArgumentException("El correo del suplidor no puede estar vacío.", nameof(suplidor.Correo));
            }


            //Validar URL
            else if (string.IsNullOrWhiteSpace(suplidor.web))
            {
                throw new ArgumentException("La web del suplidor no puede estar vacía.", nameof(suplidor.web));
            }

            else if (!Uri.IsWellFormedUriString(suplidor.web, UriKind.Absolute))
            {
                throw new ArgumentException("La web del suplidor no tiene un formato válido.", nameof(suplidor.web));
            }
            // Sin Suplidor repetido    
            List<Suplidor> suplidoresExistentes = _repositorio.ObtenerTodos().ToList();
            if (suplidoresExistentes.Any(s => s.Nombre_Empresa.Trim().Equals(suplidor.Nombre_Empresa.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("El suplidor ya existe.", nameof(suplidor.Nombre_Empresa));
            }
            suplidor.Nombre_Empresa = suplidor.Nombre_Empresa.Trim();
            suplidor.Nombre_contacto = suplidor.Nombre_contacto.Trim();
            suplidor.Telefono = suplidor.Telefono.Trim();
            suplidor.Correo = suplidor.Correo.Trim();
            suplidor.web = suplidor.web.Trim();
            suplidor.Activo = true;
            suplidor.FechaCreacion = DateTime.Now;
            return _repositorio.Agregar(suplidor);

        }


        public bool ActualizarSuplidor(Suplidor suplidor)
        {
            if (suplidor == null)
            {
                throw new ArgumentNullException(nameof(suplidor), "El suplidor no puede ser nulo.");
            }
            else if (string.IsNullOrWhiteSpace(suplidor.Nombre_Empresa))
            {
                throw new ArgumentException("El nombre del suplidor no puede estar vacío.", nameof(suplidor.Nombre_Empresa));
            }
            else if (suplidor.Nombre_Empresa.Length > 100 || suplidor.Nombre_Empresa.Length < 3)
            {
                throw new ArgumentException("El nombre del suplidor debe tener entre 3 y 100 caracteres.", nameof(suplidor.Nombre_Empresa));
            }
            else if (string.IsNullOrWhiteSpace(suplidor.Nombre_contacto))
            {
                throw new ArgumentException("El nombre del contacto no puede estar vacío.", nameof(suplidor.Nombre_contacto));
            }
            else if (suplidor.Nombre_contacto.Length > 100 || suplidor.Nombre_contacto.Length < 3)
            {
                throw new ArgumentException("El nombre del contacto debe tener entre 3 y 100 caracteres.", nameof(suplidor.Nombre_contacto));
            }

            // Validar teléfono
            else if (string.IsNullOrWhiteSpace(suplidor.Telefono))
            {
                throw new ArgumentException("El teléfono no puede estar vacío.", nameof(suplidor.Telefono));
            }
            else if (!Regex.IsMatch(suplidor.Telefono, @"^(809|829|849)-\d{3}-\d{4}$"))
            {
                throw new ArgumentException(
                    "El teléfono debe tener el formato 809-555-1234.", nameof(suplidor.Telefono));
            }

            // Validar correo electrónico
            else if (!Regex.IsMatch(suplidor.Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("El correo electrónico no tiene un formato válido.", nameof(suplidor.Correo));
            }
            else if (string.IsNullOrWhiteSpace(suplidor.Correo))
            {
                throw new ArgumentException("El correo no puede estar vacío.", nameof(suplidor.Correo));
            }
            else if (suplidor.Correo.Length > 100)
            {
                throw new ArgumentException("El correo no puede exceder los 100 caracteres.", nameof(suplidor.Correo));
            }

            // Validar URL
            else if (string.IsNullOrWhiteSpace(suplidor.web))
            {
                throw new ArgumentException("El sitio web no puede estar vacío.", nameof(suplidor.web));
            }
            else if (!Uri.IsWellFormedUriString(suplidor.web, UriKind.Absolute))
            {
                throw new ArgumentException("El sitio web no tiene un formato válido.", nameof(suplidor.web));
            }
            else if (suplidor.web.Length > 200)
            {
                throw new ArgumentException("El sitio web no puede exceder los 200 caracteres.", nameof(suplidor.web));
            }

            List<Suplidor> suplidorExistentes = _repositorio.ObtenerTodos().ToList();
            if (suplidorExistentes.Any(p => p.Id_Suplidor != suplidor.Id_Suplidor && p.Nombre_Empresa.Trim().Equals(suplidor.Nombre_Empresa.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("El nombre del suplidor ya existe.", nameof(suplidor.Nombre_Empresa));
            }
            suplidor.Nombre_Empresa = suplidor.Nombre_Empresa.Trim();
            suplidor.Nombre_contacto = suplidor.Nombre_contacto.Trim();
            suplidor.Telefono = suplidor.Telefono.Trim();
            suplidor.Correo = suplidor.Correo.Trim();
            suplidor.web = suplidor.web.Trim();
            suplidor.Activo = true;
            suplidor.FechaModificacion = DateTime.Now;
            return _repositorio.Actualizar(suplidor);

        }

        public bool EliminarSuplidor(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException(
                    "El ID del suplidor debe ser positivo.", nameof(id));
            }
            return _repositorio.EliminarLogico(id);
        }

        public Suplidor? ObtenerSuplidorPorId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del suplidor debe ser un número positivo.", nameof(id));
            }
            return _repositorio.ObtenerPorId(id);
        }

        public bool RestaurarSuplidor(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del suplidor debe ser un número positivo.", nameof(id));
            }
            return _repositorio.Restaurar(id);
        }
    }
}
