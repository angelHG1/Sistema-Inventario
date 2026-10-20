
namespace SistemaInventario.Presentación
{
    partial class FormProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            botonModificar = new Button();
            button1 = new Button();
            textPrecio = new TextBox();
            BotonVolver = new Button();
            labelTitulo = new Label();
            labelNombre = new Label();
            textNombre = new TextBox();
            labelPrecio = new Label();
            labelCategoria = new Label();
            comboCategoria = new ComboBox();
            labelSuplidor = new Label();
            comboSuplidor = new ComboBox();
            BotonGuardar = new Button();
            BotonLimpiar = new Button();
            labelListado = new Label();
            textBuscar = new TextBox();
            BotonBuscar = new Button();
            GridProductos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Suplidor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridProductos).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPrincipal.BackColor = Color.FromArgb(220, 245, 242);
            panelPrincipal.Controls.Add(botonModificar);
            panelPrincipal.Controls.Add(button1);
            panelPrincipal.Controls.Add(textPrecio);
            panelPrincipal.Controls.Add(BotonVolver);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(textNombre);
            panelPrincipal.Controls.Add(labelPrecio);
            panelPrincipal.Controls.Add(labelCategoria);
            panelPrincipal.Controls.Add(comboCategoria);
            panelPrincipal.Controls.Add(labelSuplidor);
            panelPrincipal.Controls.Add(comboSuplidor);
            panelPrincipal.Controls.Add(BotonGuardar);
            panelPrincipal.Controls.Add(BotonLimpiar);
            panelPrincipal.Controls.Add(labelListado);
            panelPrincipal.Controls.Add(textBuscar);
            panelPrincipal.Controls.Add(BotonBuscar);
            panelPrincipal.Controls.Add(GridProductos);
            panelPrincipal.Location = new Point(25, 25);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(950, 554);
            panelPrincipal.TabIndex = 0;
            // 
            // botonModificar
            // 
            botonModificar.BackColor = Color.White;
            botonModificar.FlatAppearance.BorderColor = Color.FromArgb(14, 84, 75);
            botonModificar.FlatAppearance.BorderSize = 2;
            botonModificar.FlatStyle = FlatStyle.Flat;
            botonModificar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            botonModificar.Location = new Point(339, 170);
            botonModificar.Name = "botonModificar";
            botonModificar.Size = new Size(99, 35);
            botonModificar.TabIndex = 20;
            botonModificar.Text = "Modificar";
            botonModificar.UseVisualStyleBackColor = false;
            botonModificar.Click += botonModificar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(132, 170);
            button1.Name = "button1";
            button1.Size = new Size(96, 35);
            button1.TabIndex = 19;
            button1.Text = "Eliminar ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textPrecio
            // 
            textPrecio.Font = new Font("Segoe UI", 10F);
            textPrecio.Location = new Point(325, 106);
            textPrecio.MaxLength = 100;
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(154, 30);
            textPrecio.TabIndex = 18;
            // 
            // BotonVolver
            // 
            BotonVolver.BackColor = Color.White;
            BotonVolver.FlatAppearance.BorderColor = Color.FromArgb(14, 84, 75);
            BotonVolver.FlatAppearance.BorderSize = 2;
            BotonVolver.FlatStyle = FlatStyle.Flat;
            BotonVolver.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BotonVolver.Location = new Point(20, 18);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(120, 41);
            BotonVolver.TabIndex = 0;
            BotonVolver.Text = "← Volver";
            BotonVolver.UseVisualStyleBackColor = false;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.FromArgb(14, 84, 75);
            labelTitulo.Location = new Point(300, 18);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(319, 41);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Gestión de productos";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelNombre.Location = new Point(30, 80);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(73, 23);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Segoe UI", 10F);
            textNombre.Location = new Point(30, 106);
            textNombre.MaxLength = 100;
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(270, 30);
            textNombre.TabIndex = 3;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPrecio.Location = new Point(325, 80);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(57, 23);
            labelPrecio.TabIndex = 4;
            labelPrecio.Text = "Precio";
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelCategoria.Location = new Point(530, 80);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(84, 23);
            labelCategoria.TabIndex = 6;
            labelCategoria.Text = "Categoría";
            // 
            // comboCategoria
            // 
            comboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCategoria.Font = new Font("Segoe UI", 10F);
            comboCategoria.FormattingEnabled = true;
            comboCategoria.Location = new Point(530, 106);
            comboCategoria.Name = "comboCategoria";
            comboCategoria.Size = new Size(180, 31);
            comboCategoria.TabIndex = 7;
            // 
            // labelSuplidor
            // 
            labelSuplidor.AutoSize = true;
            labelSuplidor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelSuplidor.Location = new Point(735, 80);
            labelSuplidor.Name = "labelSuplidor";
            labelSuplidor.Size = new Size(73, 23);
            labelSuplidor.TabIndex = 8;
            labelSuplidor.Text = "Suplidor";
            // 
            // comboSuplidor
            // 
            comboSuplidor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSuplidor.Font = new Font("Segoe UI", 10F);
            comboSuplidor.FormattingEnabled = true;
            comboSuplidor.Location = new Point(735, 106);
            comboSuplidor.Name = "comboSuplidor";
            comboSuplidor.Size = new Size(185, 31);
            comboSuplidor.TabIndex = 9;
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.FromArgb(14, 84, 75);
            BotonGuardar.FlatAppearance.BorderSize = 0;
            BotonGuardar.FlatStyle = FlatStyle.Flat;
            BotonGuardar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BotonGuardar.ForeColor = Color.White;
            BotonGuardar.Location = new Point(30, 170);
            BotonGuardar.Name = "BotonGuardar";
            BotonGuardar.Size = new Size(96, 35);
            BotonGuardar.TabIndex = 12;
            BotonGuardar.Text = "Guardar";
            BotonGuardar.UseVisualStyleBackColor = false;
            BotonGuardar.Click += BotonGuardar_Click;
            // 
            // BotonLimpiar
            // 
            BotonLimpiar.BackColor = Color.White;
            BotonLimpiar.FlatAppearance.BorderColor = Color.FromArgb(14, 84, 75);
            BotonLimpiar.FlatAppearance.BorderSize = 2;
            BotonLimpiar.FlatStyle = FlatStyle.Flat;
            BotonLimpiar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BotonLimpiar.Location = new Point(234, 170);
            BotonLimpiar.Name = "BotonLimpiar";
            BotonLimpiar.Size = new Size(99, 35);
            BotonLimpiar.TabIndex = 13;
            BotonLimpiar.Text = "Limpiar";
            BotonLimpiar.UseVisualStyleBackColor = false;
            BotonLimpiar.Click += BotonLimpiar_Click;
            // 
            // labelListado
            // 
            labelListado.AutoSize = true;
            labelListado.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelListado.ForeColor = Color.FromArgb(14, 84, 75);
            labelListado.Location = new Point(30, 217);
            labelListado.Name = "labelListado";
            labelListado.Size = new Size(232, 30);
            labelListado.TabIndex = 14;
            labelListado.Text = "Listado de productos";
            // 
            // textBuscar
            // 
            textBuscar.Font = new Font("Segoe UI", 10F);
            textBuscar.Location = new Point(530, 217);
            textBuscar.Name = "textBuscar";
            textBuscar.PlaceholderText = "Buscar producto...";
            textBuscar.Size = new Size(270, 30);
            textBuscar.TabIndex = 15;
            // 
            // BotonBuscar
            // 
            BotonBuscar.BackColor = Color.White;
            BotonBuscar.FlatAppearance.BorderColor = Color.FromArgb(14, 84, 75);
            BotonBuscar.FlatAppearance.BorderSize = 2;
            BotonBuscar.FlatStyle = FlatStyle.Flat;
            BotonBuscar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BotonBuscar.Location = new Point(810, 214);
            BotonBuscar.Name = "BotonBuscar";
            BotonBuscar.Size = new Size(110, 35);
            BotonBuscar.TabIndex = 16;
            BotonBuscar.Text = "Buscar";
            BotonBuscar.UseVisualStyleBackColor = false;
            BotonBuscar.Click += BotonBuscar_Click;
            // 
            // GridProductos
            // 
            GridProductos.AllowUserToAddRows = false;
            GridProductos.AllowUserToDeleteRows = false;
            GridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridProductos.BackgroundColor = Color.White;
            GridProductos.BorderStyle = BorderStyle.None;
            GridProductos.ColumnHeadersHeight = 40;
            GridProductos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Precio, Categoria, Suplidor, Estado });
            GridProductos.Location = new Point(30, 261);
            GridProductos.MultiSelect = false;
            GridProductos.Name = "GridProductos";
            GridProductos.ReadOnly = true;
            GridProductos.RowHeadersVisible = false;
            GridProductos.RowHeadersWidth = 51;
            GridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridProductos.Size = new Size(890, 248);
            GridProductos.TabIndex = 17;
            GridProductos.CellClick += GridProductos_CellClick;
            // 
            // Id
            // 
            Id.FillWeight = 40F;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoría";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Suplidor
            // 
            Suplidor.HeaderText = "Suplidor";
            Suplidor.MinimumWidth = 6;
            Suplidor.Name = "Suplidor";
            Suplidor.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 84, 75);
            ClientSize = new Size(1000, 610);
            Controls.Add(panelPrincipal);
            MinimumSize = new Size(900, 600);
            Name = "FormProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de productos";
            Load += FormProductos_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button BotonVolver;
        private Label labelTitulo;
        private Label labelNombre;
        private TextBox textNombre;
        private Label labelPrecio;
        private Label labelCategoria;
        private ComboBox comboCategoria;
        private Label labelSuplidor;
        private ComboBox comboSuplidor;
        private Button BotonGuardar;
        private Button BotonLimpiar;
        private Label labelListado;
        private TextBox textBuscar;
        private Button BotonBuscar;
        private DataGridView GridProductos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Suplidor;
        private DataGridViewTextBoxColumn Estado;
        private Button button1;
        private TextBox textPrecio;
        private Button botonModificar;
    }
}
