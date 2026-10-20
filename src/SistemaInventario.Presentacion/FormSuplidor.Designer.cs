namespace SistemaInventario.Presentación
{
    partial class FormSuplidor
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
            textTelefono = new TextBox();
            label1 = new Label();
            textWeb = new TextBox();
            labelContacto = new Label();
            textContacto = new TextBox();
            botonModificar = new Button();
            botonEliminar = new Button();
            textCorreo = new TextBox();
            BotonVolver = new Button();
            labelTitulo = new Label();
            labelNombre = new Label();
            textNombreEmpresa = new TextBox();
            labelPrecio = new Label();
            labelWeb = new Label();
            BotonGuardar = new Button();
            BotonLimpiar = new Button();
            labelListado = new Label();
            textBuscar = new TextBox();
            BotonBuscar = new Button();
            GridProductos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            Contacto = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Web = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridProductos).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPrincipal.BackColor = Color.FromArgb(220, 245, 242);
            panelPrincipal.Controls.Add(textTelefono);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(textWeb);
            panelPrincipal.Controls.Add(labelContacto);
            panelPrincipal.Controls.Add(textContacto);
            panelPrincipal.Controls.Add(botonModificar);
            panelPrincipal.Controls.Add(botonEliminar);
            panelPrincipal.Controls.Add(textCorreo);
            panelPrincipal.Controls.Add(BotonVolver);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(textNombreEmpresa);
            panelPrincipal.Controls.Add(labelPrecio);
            panelPrincipal.Controls.Add(labelWeb);
            panelPrincipal.Controls.Add(BotonGuardar);
            panelPrincipal.Controls.Add(BotonLimpiar);
            panelPrincipal.Controls.Add(labelListado);
            panelPrincipal.Controls.Add(textBuscar);
            panelPrincipal.Controls.Add(BotonBuscar);
            panelPrincipal.Controls.Add(GridProductos);
            panelPrincipal.Location = new Point(22, 36);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(950, 578);
            panelPrincipal.TabIndex = 1;
            // 
            // textTelefono
            // 
            textTelefono.Font = new Font("Segoe UI", 10F);
            textTelefono.Location = new Point(325, 166);
            textTelefono.MaxLength = 100;
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(301, 30);
            textTelefono.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(325, 140);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 24;
            label1.Text = "Telefono";
            // 
            // textWeb
            // 
            textWeb.Font = new Font("Segoe UI", 10F);
            textWeb.Location = new Point(646, 106);
            textWeb.MaxLength = 100;
            textWeb.Name = "textWeb";
            textWeb.Size = new Size(301, 30);
            textWeb.TabIndex = 23;
            // 
            // labelContacto
            // 
            labelContacto.AutoSize = true;
            labelContacto.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelContacto.Location = new Point(30, 140);
            labelContacto.Name = "labelContacto";
            labelContacto.Size = new Size(148, 23);
            labelContacto.TabIndex = 21;
            labelContacto.Text = "Nombre Contacto";
            // 
            // textContacto
            // 
            textContacto.Font = new Font("Segoe UI", 10F);
            textContacto.Location = new Point(30, 166);
            textContacto.MaxLength = 100;
            textContacto.Name = "textContacto";
            textContacto.Size = new Size(270, 30);
            textContacto.TabIndex = 22;
            // 
            // botonModificar
            // 
            botonModificar.BackColor = Color.White;
            botonModificar.FlatAppearance.BorderColor = Color.FromArgb(14, 84, 75);
            botonModificar.FlatAppearance.BorderSize = 2;
            botonModificar.FlatStyle = FlatStyle.Flat;
            botonModificar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            botonModificar.Location = new Point(339, 219);
            botonModificar.Name = "botonModificar";
            botonModificar.Size = new Size(99, 35);
            botonModificar.TabIndex = 20;
            botonModificar.Text = "Modificar";
            botonModificar.UseVisualStyleBackColor = false;
            botonModificar.Click += botonModificar_Click;
            // 
            // botonEliminar
            // 
            botonEliminar.BackColor = Color.White;
            botonEliminar.FlatAppearance.BorderColor = Color.Red;
            botonEliminar.FlatAppearance.BorderSize = 2;
            botonEliminar.FlatStyle = FlatStyle.Flat;
            botonEliminar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            botonEliminar.ForeColor = Color.Red;
            botonEliminar.Location = new Point(132, 219);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(96, 35);
            botonEliminar.TabIndex = 19;
            botonEliminar.Text = "Eliminar ";
            botonEliminar.UseVisualStyleBackColor = false;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // textCorreo
            // 
            textCorreo.Font = new Font("Segoe UI", 10F);
            textCorreo.Location = new Point(325, 106);
            textCorreo.MaxLength = 100;
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(301, 30);
            textCorreo.TabIndex = 18;
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
            labelTitulo.Size = new Size(326, 41);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Gestión de Suplidores";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelNombre.Location = new Point(30, 80);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(75, 23);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Empresa";
            // 
            // textNombreEmpresa
            // 
            textNombreEmpresa.Font = new Font("Segoe UI", 10F);
            textNombreEmpresa.Location = new Point(30, 106);
            textNombreEmpresa.MaxLength = 100;
            textNombreEmpresa.Name = "textNombreEmpresa";
            textNombreEmpresa.Size = new Size(270, 30);
            textNombreEmpresa.TabIndex = 3;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPrecio.Location = new Point(325, 80);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(62, 23);
            labelPrecio.TabIndex = 4;
            labelPrecio.Text = "Correo";
            // 
            // labelWeb
            // 
            labelWeb.AutoSize = true;
            labelWeb.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelWeb.Location = new Point(646, 79);
            labelWeb.Name = "labelWeb";
            labelWeb.Size = new Size(45, 23);
            labelWeb.TabIndex = 6;
            labelWeb.Text = "Web";
            // 
            // BotonGuardar
            // 
            BotonGuardar.BackColor = Color.FromArgb(14, 84, 75);
            BotonGuardar.FlatAppearance.BorderSize = 0;
            BotonGuardar.FlatStyle = FlatStyle.Flat;
            BotonGuardar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BotonGuardar.ForeColor = Color.White;
            BotonGuardar.Location = new Point(30, 219);
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
            BotonLimpiar.Location = new Point(234, 219);
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
            labelListado.Location = new Point(30, 266);
            labelListado.Name = "labelListado";
            labelListado.Size = new Size(211, 30);
            labelListado.TabIndex = 14;
            labelListado.Text = "Listado de suplidor";
            // 
            // textBuscar
            // 
            textBuscar.Font = new Font("Segoe UI", 10F);
            textBuscar.Location = new Point(530, 266);
            textBuscar.Name = "textBuscar";
            textBuscar.PlaceholderText = "Buscar Suplidor...";
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
            BotonBuscar.Location = new Point(810, 263);
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
            GridProductos.Columns.AddRange(new DataGridViewColumn[] { Id, Empresa, Contacto, Telefono, Correo, Web, Estado });
            GridProductos.Location = new Point(30, 315);
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
            // Empresa
            // 
            Empresa.HeaderText = "Empresa";
            Empresa.MinimumWidth = 6;
            Empresa.Name = "Empresa";
            Empresa.ReadOnly = true;
            // 
            // Contacto
            // 
            Contacto.HeaderText = "Contacto";
            Contacto.MinimumWidth = 6;
            Contacto.Name = "Contacto";
            Contacto.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Web
            // 
            Web.HeaderText = "Web";
            Web.MinimumWidth = 6;
            Web.Name = "Web";
            Web.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // FormSuplidor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 84, 75);
            ClientSize = new Size(995, 626);
            Controls.Add(panelPrincipal);
            Name = "FormSuplidor";
            Text = "FormSuplidor";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button botonModificar;
        private Button botonEliminar;
        private TextBox textCorreo;
        private Button BotonVolver;
        private Label labelTitulo;
        private Label labelNombre;
        private TextBox textNombreEmpresa;
        private Label labelPrecio;
        private Label labelWeb;
        private Button BotonGuardar;
        private Button BotonLimpiar;
        private Label labelListado;
        private TextBox textBuscar;
        private Button BotonBuscar;
        private DataGridView GridProductos;
        private Label labelContacto;
        private TextBox textContacto;
        private TextBox textWeb;
        private TextBox textTelefono;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn Contacto;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Web;
        private DataGridViewTextBoxColumn Estado;
    }
}