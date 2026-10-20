namespace SistemaInventario.Presentación
{
    partial class FormCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            botonModificar = new Button();
            button1 = new Button();
            textDescripcion = new TextBox();
            BotonVolver = new Button();
            labelTitulo = new Label();
            labelNombre = new Label();
            textNombre = new TextBox();
            labelDescripcion = new Label();
            BotonGuardar = new Button();
            BotonLimpiar = new Button();
            labelListado = new Label();
            textBuscar = new TextBox();
            BotonBuscar = new Button();
            GridProductos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
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
            panelPrincipal.Controls.Add(textDescripcion);
            panelPrincipal.Controls.Add(BotonVolver);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(textNombre);
            panelPrincipal.Controls.Add(labelDescripcion);
            panelPrincipal.Controls.Add(BotonGuardar);
            panelPrincipal.Controls.Add(BotonLimpiar);
            panelPrincipal.Controls.Add(labelListado);
            panelPrincipal.Controls.Add(textBuscar);
            panelPrincipal.Controls.Add(BotonBuscar);
            panelPrincipal.Controls.Add(GridProductos);
            panelPrincipal.Location = new Point(58, 12);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(950, 548);
            panelPrincipal.TabIndex = 1;
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
            // textDescripcion
            // 
            textDescripcion.Font = new Font("Segoe UI", 10F);
            textDescripcion.Location = new Point(325, 106);
            textDescripcion.MaxLength = 100;
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(595, 30);
            textDescripcion.TabIndex = 18;
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
            labelTitulo.Location = new Point(274, 18);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(326, 41);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Gestión de Categorias";
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
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelDescripcion.Location = new Point(325, 80);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(98, 23);
            labelDescripcion.TabIndex = 4;
            labelDescripcion.Text = "Descripción";
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
            labelListado.Size = new Size(234, 30);
            labelListado.TabIndex = 14;
            labelListado.Text = "Listado de categorias";
            // 
            // textBuscar
            // 
            textBuscar.Font = new Font("Segoe UI", 10F);
            textBuscar.Location = new Point(530, 217);
            textBuscar.Name = "textBuscar";
            textBuscar.PlaceholderText = "Buscar Categoria...";
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
            GridProductos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripcion, Estado });
            GridProductos.Location = new Point(30, 261);
            GridProductos.MultiSelect = false;
            GridProductos.Name = "GridProductos";
            GridProductos.ReadOnly = true;
            GridProductos.RowHeadersVisible = false;
            GridProductos.RowHeadersWidth = 51;
            GridProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridProductos.Size = new Size(890, 250);
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
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 84, 75);
            ClientSize = new Size(1066, 572);
            Controls.Add(panelPrincipal);
            Name = "FormCategoria";
            Text = "FormCategoria";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button botonModificar;
        private Button button1;
        private TextBox textDescripcion;
        private Button BotonVolver;
        private Label labelTitulo;
        private Label labelNombre;
        private TextBox textNombre;
        private Label labelDescripcion;
        private Button BotonGuardar;
        private Button BotonLimpiar;
        private Label labelListado;
        private TextBox textBuscar;
        private Button BotonBuscar;
        private DataGridView GridProductos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
    }
}