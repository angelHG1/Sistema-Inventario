namespace SistemaInventario.Presentación
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCategoria categoria = new FormCategoria();
            categoria.ShowDialog();
        }

        private void BotonProductos_Click(object sender, EventArgs e)
        {
            FormProductos productos = new FormProductos();
            productos.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormSuplidor suplidores = new FormSuplidor();
            suplidores.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPapelera papelera = new FormPapelera();
            papelera.ShowDialog();
        }
    }
}
