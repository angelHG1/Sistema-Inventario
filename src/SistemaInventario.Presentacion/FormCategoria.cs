using SistemaInventario.AccesoDatos.AccesoDatos;
using SistemaInventario.AccesoDatos.Repositorios;
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
    public partial class FormCategoria : Form
    {
        private readonly AccesoDatosBD _bd = new AccesoDatosBD();
        private readonly CategoriaServicio _categoriaServicio;

        public FormCategoria()
        {
            InitializeComponent();
            _categoriaServicio = new CategoriaServicio(new CategoriaRepositorio(_bd), new ProductoRepositorio(_bd));

            Load += (s, e) => InicializarFormulario();
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
        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarDatosGrid(string filtro = "")
        {
            GridProductos.Rows.Clear();



            var categorias = _categoriaServicio.ObtenerCategorias()
                .Where(c => c.Nombre.Contains(filtro) || c.Descripcion.Contains(filtro));

            foreach (var c in categorias)
            {
                GridProductos.Rows.Add(
                    c.Id,
                    c.Nombre,
                    c.Descripcion,
                    c.Activo ? "Activo" : "Inactivo");
            }
        }

        private void LimpiarCampos()
        {
            textNombre.Text = string.Empty;
            textDescripcion.Text = string.Empty;
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria
            {
                Nombre = textNombre.Text,
                Descripcion = textDescripcion.Text,

            };

            try
            {
                _categoriaServicio.AgregarCategoria(categoria);
                MessageBox.Show("Categoría guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatosGrid();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = Convert.ToInt32(GridProductos.CurrentRow.Cells["ID"].Value);
                _categoriaServicio.EliminarCategoria(idCategoria);
                MessageBox.Show("Categoría eliminada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = GridProductos.Rows[e.RowIndex];
                textNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                textDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == string.Empty || textDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de modificar una Categoría.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int idCategoria = Convert.ToInt32(GridProductos.CurrentRow.Cells["ID"].Value);
                Categoria categoria = new Categoria
                {
                    Id = idCategoria,
                    Nombre = textNombre.Text,
                    Descripcion = textDescripcion.Text
                };
                _categoriaServicio.ActualizarCategoria(categoria);
                MessageBox.Show("Categoría modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la categoría: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al buscar Categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
                  