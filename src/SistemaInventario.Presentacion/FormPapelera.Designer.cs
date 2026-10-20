namespace SistemaInventario.Presentación
{
    partial class FormPapelera
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            label1 = new Label();
            comboEntidad = new ComboBox();
            BotonVolver = new Button();
            labelTitulo = new Label();
            labelListado = new Label();
            GridPapelera = new DataGridView();
            Tipo = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            BotonRestaurar = new Button();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridPapelera).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPrincipal.BackColor = Color.FromArgb(220, 245, 242);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Controls.Add(comboEntidad);
            panelPrincipal.Controls.Add(BotonVolver);
            panelPrincipal.Controls.Add(labelTitulo);
            panelPrincipal.Controls.Add(labelListado);
            panelPrincipal.Controls.Add(GridPapelera);
            panelPrincipal.Controls.Add(BotonRestaurar);
            panelPrincipal.Location = new Point(22, 36);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(950, 578);
            panelPrincipal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(14, 84, 75);
            label1.Location = new Point(641, 103);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 9;
            label1.Text = "Entidad";
            // 
            // comboEntidad
            // 
            comboEntidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboEntidad.Font = new Font("Segoe UI", 10F);
            comboEntidad.FormattingEnabled = true;
            comboEntidad.Location = new Point(740, 103);
            comboEntidad.Name = "comboEntidad";
            comboEntidad.Size = new Size(180, 31);
            comboEntidad.TabIndex = 8;
            comboEntidad.SelectedIndexChanged += comboEntidad_SelectedIndexChanged;
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
            labelTitulo.Size = new Size(305, 41);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Papelera de reciclaje";
            // 
            // labelListado
            // 
            labelListado.AutoSize = true;
            labelListado.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelListado.ForeColor = Color.FromArgb(14, 84, 75);
            labelListado.Location = new Point(30, 100);
            labelListado.Name = "labelListado";
            labelListado.Size = new Size(250, 30);
            labelListado.TabIndex = 2;
            labelListado.Text = "Registros desactivados";
            // 
            // GridPapelera
            // 
            GridPapelera.AllowUserToAddRows = false;
            GridPapelera.AllowUserToDeleteRows = false;
            GridPapelera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridPapelera.BackgroundColor = Color.White;
            GridPapelera.BorderStyle = BorderStyle.None;
            GridPapelera.ColumnHeadersHeight = 40;
            GridPapelera.Columns.AddRange(new DataGridViewColumn[] { Tipo, ID, Nombre, Estado });
            GridPapelera.Location = new Point(30, 150);
            GridPapelera.MultiSelect = false;
            GridPapelera.Name = "GridPapelera";
            GridPapelera.ReadOnly = true;
            GridPapelera.RowHeadersVisible = false;
            GridPapelera.RowHeadersWidth = 51;
            GridPapelera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridPapelera.Size = new Size(890, 330);
            GridPapelera.TabIndex = 6;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // BotonRestaurar
            // 
            BotonRestaurar.BackColor = Color.FromArgb(14, 84, 75);
            BotonRestaurar.FlatAppearance.BorderSize = 0;
            BotonRestaurar.FlatStyle = FlatStyle.Flat;
            BotonRestaurar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            BotonRestaurar.ForeColor = Color.White;
            BotonRestaurar.Location = new Point(350, 505);
            BotonRestaurar.Name = "BotonRestaurar";
            BotonRestaurar.Size = new Size(230, 40);
            BotonRestaurar.TabIndex = 7;
            BotonRestaurar.Text = "Restaurar seleccionado";
            BotonRestaurar.UseVisualStyleBackColor = false;
            BotonRestaurar.Click += BotonRestaurar_Click;
            // 
            // FormPapelera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 84, 75);
            ClientSize = new Size(995, 626);
            Controls.Add(panelPrincipal);
            Name = "FormPapelera";
            Text = "Papelera";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridPapelera).EndInit();
            ResumeLayout(false);
        }

        private Panel panelPrincipal;
        private Button BotonVolver;
        private Label labelTitulo;
        private Label labelListado;
        private DataGridView GridPapelera;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Estado;
        private Button BotonRestaurar;
        private ComboBox comboEntidad;
        private Label label1;
    }
}