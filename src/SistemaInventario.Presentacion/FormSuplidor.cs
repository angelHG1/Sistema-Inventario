using SistemaInventario.AccesoDatos.AccesoDatos;
using SistemaInventario.Entidades;
using SistemaInventario.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaInventario.Presentación
{
    public partial class FormSuplidor : Form
    {
        private readonly AccesoDatosBD _bd = new AccesoDatosBD();
        private readonly SuplidorServicio _suplidorServicio;
        public FormSuplidor()
        {
            InitializeComponent();

            _suplidorServicio = new SuplidorServicio(new AccesoDatos.Repositorios.SuplidorRepositorio(_bd));
            Load += (s, e) => InicializarFormulario();
        }

        private void LimpiarCampos()
        {
            textNombreEmpresa.Clear();
            textContacto.Clear();
            textTelefono.Clear();
            textCorreo.Clear();
            textWeb.Clear();
        }
        private void InicializarFormulario()
        {
            try
            {
                CargarDatosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void CargarDatosGrid(string filtro = "")
        {
            GridProductos.Rows.Clear();
            var suplidores = _suplidorServicio.ObtenerTodos()
                .Where(s => s.Nombre_Empresa.Contains(filtro) || s.Nombre_contacto.Contains(filtro));
            foreach (var s in suplidores)
            {
                GridProductos.Rows.Add(
                    s.Id_Suplidor,
                    s.Nombre_Empresa,
                    s.Nombre_contacto,
                    s.Telefono,
                    s.Correo,
                    s.web,
                    s.Activo ? "Activo" : "Desactivado"
                );
            }
        }

        private void GridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = GridProductos.Rows[e.RowIndex];
                textNombreEmpresa.Text = filaSeleccionada.Cells["Empresa"].Value.ToString();
                textContacto.Text = filaSeleccionada.Cells["Contacto"].Value.ToString();
                textTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
                textCorreo.Text = filaSeleccionada.Cells["Correo"].Value.ToString();
                textWeb.Text = filaSeleccionada.Cells["Web"].Value.ToString();
            }
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Suplidor suplidor = new Suplidor
            {
                Nombre_Empresa = textNombreEmpresa.Text,
                Nombre_contacto = textContacto.Text,
                Telefono = textTelefono.Text,
                Correo = textCorreo.Text,
                web = textWeb.Text
            };

            try
            {
                _suplidorServicio.AgregarSuplidor(suplidor);
                MessageBox.Show("Suplidor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idSuplidor = Convert.ToInt32(GridProductos.CurrentRow.Cells["ID"].Value);
                _suplidorServicio.EliminarSuplidor(idSuplidor);
                MessageBox.Show("Suplidor eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el suplidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            if (textNombreEmpresa.Text == string.Empty || textContacto.Text == string.Empty || textTelefono.Text == string.Empty || textCorreo.Text == string.Empty)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de modificar un Suplidor.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int idSuplidor = Convert.ToInt32(GridProductos.CurrentRow.Cells["ID"].Value);
                Suplidor suplidor = new Suplidor
                {
                    Id_Suplidor = idSuplidor,
                    Nombre_Empresa = textNombreEmpresa.Text,
                    Nombre_contacto = textContacto.Text,
                    Telefono = textTelefono.Text,
                    Correo = textCorreo.Text,
                    web = textWeb.Text
                };
                _suplidorServicio.ActualizarSuplidor(suplidor);
                MessageBox.Show("Suplidor modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el suplidor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                CargarDatosGrid(textBuscar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar Suplidores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
