using System;
using System.Linq;
using System.Windows.Forms;
using SistemaInventario.AccesoDatos.Repositorios;
using SistemaInventario.Entidades;
using SistemaInventario.LogicaNegocio;
using SistemaInventario.AccesoDatos.AccesoDatos;

namespace SistemaInventario.Presentación
{
    public partial class FormProductos : Form
    {
        private readonly AccesoDatosBD _bd = new AccesoDatosBD();
        private readonly CategoriaServicio _categoriaServicio;
        private readonly SuplidorServicio _suplidorServicio;
        private readonly ProductosServicio _productosServicio;

        public FormProductos()
        {
            InitializeComponent();

            _categoriaServicio = new CategoriaServicio(new CategoriaRepositorio(_bd), new ProductoRepositorio(_bd));
            _suplidorServicio = new SuplidorServicio(new SuplidorRepositorio(_bd));
            _productosServicio = new ProductosServicio(new ProductoRepositorio(_bd));

            Load += (s, e) => InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            try
            {
                CargarCategorias();
                CargarSuplidores();
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

        private void CargarCategorias()
        {
            comboCategoria.DataSource = _categoriaServicio.ObtenerCategorias();
            comboCategoria.DisplayMember = "Nombre";   // lo que se ve
            comboCategoria.ValueMember = "Id";         // lo que se guarda
            comboCategoria.SelectedIndex = -1;


        }

        private void CargarSuplidores()
        {
            comboSuplidor.DataSource = _suplidorServicio.ObtenerTodos();
            comboSuplidor.DisplayMember = "Nombre_Empresa";
            comboSuplidor.ValueMember = "Id_Suplidor";
            comboSuplidor.SelectedIndex = -1;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto
            {
                Nombre = textNombre.Text,
                PrecioUnitario = decimal.TryParse(textPrecio.Text, out decimal precio) ? precio : 0,
                IdCategoria = comboCategoria.SelectedValue is int idCategoria ? idCategoria : 0,
                IdSuplidor = comboSuplidor.SelectedValue is int idSuplidor ? idSuplidor : 0
            };

            try
            {
                _productosServicio.AgregarProducto(producto);
                MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al buscar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            foreach (Control control in panelPrincipal.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }

        }

        private void CargarDatosGrid(string filtro = "")
        {
            GridProductos.Rows.Clear();

            var categorias = _categoriaServicio.ObtenerCategorias();
            var suplidores = _suplidorServicio.ObtenerTodos();

            var productos = _productosServicio.ObtenerTodosProductos()
        .Where(p => p.Nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase));

            foreach (var p in productos)
            {
                GridProductos.Rows.Add(
                    p.IdProducto,
                    p.Nombre,
                    p.PrecioUnitario.ToString("N2"),
                    categorias.FirstOrDefault(c => c.Id == p.IdCategoria)?.Nombre,
                    suplidores.FirstOrDefault(s => s.Id_Suplidor == p.IdSuplidor)?.Nombre_Empresa,
                    p.Activo ? "Activo" : "Inactivo");
            }
        }



        private void botonModificar_Click(object sender, EventArgs e)
        {
            if (textNombre.Text == string.Empty || textPrecio.Text == string.Empty || comboCategoria.SelectedIndex == -1 || comboSuplidor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de modificar un producto.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int idProducto = Convert.ToInt32(GridProductos.CurrentRow.Cells["ID"].Value);
                Producto producto = new Producto
                {
                    IdProducto = idProducto,
                    Nombre = textNombre.Text,
                    PrecioUnitario = decimal.TryParse(textPrecio.Text, out decimal precio) ? precio : 0,
                    IdCategoria = comboCategoria.SelectedValue is int idCategoria ? idCategoria : 0,
                    IdSuplidor = comboSuplidor.SelectedValue is int idSuplidor ? idSuplidor : 0
                };
                _productosServicio.ActualizarProducto(producto);
                MessageBox.Show("Producto modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = GridProductos.Rows[e.RowIndex];
                textNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                textPrecio.Text = filaSeleccionada.Cells["Precio"].Value.ToString();
                comboCategoria.SelectedValue = filaSeleccionada.Cells["Categoria"].Value;
                comboSuplidor.SelectedValue = filaSeleccionada.Cells["Suplidor"].Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(GridProductos.CurrentRow.Cells["ID"].Value);
                _productosServicio.EliminarProducto(idProducto);
                MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarDatosGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }
    }
}