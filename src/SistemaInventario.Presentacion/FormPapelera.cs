using SistemaInventario.AccesoDatos.AccesoDatos;
using SistemaInventario.AccesoDatos.Repositorios;
using SistemaInventario.LogicaNegocio;

namespace SistemaInventario.Presentación
{
    public partial class FormPapelera : Form
    {
        private readonly AccesoDatosBD _bd = new AccesoDatosBD();
        private readonly CategoriaServicio _categoriaServicio;
        private readonly ProductosServicio _productosServicio;
        private readonly SuplidorServicio _suplidorServicio;

        public FormPapelera()
        {
            InitializeComponent();

            _categoriaServicio = new CategoriaServicio(new CategoriaRepositorio(_bd), new ProductoRepositorio(_bd));
            _productosServicio = new ProductosServicio(new ProductoRepositorio(_bd));
            _suplidorServicio = new SuplidorServicio(new SuplidorRepositorio(_bd));

            Load += FormPapelera_Load;   // conecta el evento
        }

        private void FormPapelera_Load(object sender, EventArgs e)
        {
            comboEntidad.Items.AddRange(new[] { "Productos", "Categorías", "Suplidores" });
            comboEntidad.SelectedIndex = 0;
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEliminados();
        }

        private void CargarEliminados()
        {
            if (comboEntidad.SelectedItem == null) return;

            GridPapelera.Rows.Clear();

            try
            {
                switch (comboEntidad.SelectedItem.ToString())
                {
                    case "Productos":
                        foreach (var p in _productosServicio.ObtenerEliminadas())
                        {
                            GridPapelera.Rows.Add(
                                "Producto",
                                p.IdProducto,
                                p.Nombre,
                                "Desactivado"
                            );
                        }
                        break;

                    case "Categorías":
                        foreach (var c in _categoriaServicio.ObtenerEliminadas())
                        {
                            GridPapelera.Rows.Add(
                                "Categoría",
                                c.Id,
                                c.Nombre,
                                "Desactivado"
                            );
                        }
                        break;

                    case "Suplidores":
                        foreach (var s in _suplidorServicio.ObtenerEliminadas())
                        {
                            GridPapelera.Rows.Add(
                                "Suplidor",
                                s.Id_Suplidor,
                                s.Nombre_Empresa,
                                "Desactivado"
                            );
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la papelera: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonRestaurar_Click(object sender, EventArgs e)
        {
            if (GridPapelera.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un registro primero.");
                return;
            }

            int id = Convert.ToInt32(GridPapelera.CurrentRow.Cells[1].Value);

            try
            {
                switch (comboEntidad.SelectedItem.ToString())
                {
                    case "Productos": _productosServicio.RestaurarProducto(id); break;
                    case "Categorías": _categoriaServicio.RestaurarCategoria(id); break;
                    case "Suplidores": _suplidorServicio.RestaurarSuplidor(id); break;
                }
                CargarEliminados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}