namespace SistemaInventario.Presentación
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BotonCategoria = new Button();
            button1 = new Button();
            BotonProductos = new Button();
            button3 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BotonCategoria
            // 
            BotonCategoria.BackColor = Color.White;
            BotonCategoria.FlatAppearance.BorderColor = Color.FromArgb(14, 84, 75);
            BotonCategoria.FlatAppearance.BorderSize = 2;
            BotonCategoria.FlatStyle = FlatStyle.Flat;
            BotonCategoria.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BotonCategoria.Location = new Point(53, 123);
            BotonCategoria.Name = "BotonCategoria";
            BotonCategoria.Size = new Size(224, 64);
            BotonCategoria.TabIndex = 0;
            BotonCategoria.Text = "Categorias";
            BotonCategoria.UseVisualStyleBackColor = false;
            BotonCategoria.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(14, 84, 75);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Location = new Point(53, 193);
            button1.Name = "button1";
            button1.Size = new Size(224, 64);
            button1.TabIndex = 1;
            button1.Text = "Suplidores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // BotonProductos
            // 
            BotonProductos.BackColor = Color.White;
            BotonProductos.FlatAppearance.BorderColor = Color.FromArgb(14, 84, 75);
            BotonProductos.FlatAppearance.BorderSize = 2;
            BotonProductos.FlatStyle = FlatStyle.Flat;
            BotonProductos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            BotonProductos.Location = new Point(290, 123);
            BotonProductos.Name = "BotonProductos";
            BotonProductos.Size = new Size(224, 64);
            BotonProductos.TabIndex = 2;
            BotonProductos.Text = "Productos";
            BotonProductos.UseVisualStyleBackColor = false;
            BotonProductos.Click += BotonProductos_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.FromArgb(14, 84, 75);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.Location = new Point(290, 193);
            button3.Name = "button3";
            button3.Size = new Size(224, 64);
            button3.TabIndex = 3;
            button3.Text = "Papelera";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 51);
            label1.Name = "label1";
            label1.Size = new Size(323, 41);
            label1.TabIndex = 4;
            label1.Text = "Sistema de inventario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(220, 245, 242);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(BotonProductos);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BotonCategoria);
            panel1.Location = new Point(110, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 335);
            panel1.TabIndex = 5;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 84, 75);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormMenu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BotonCategoria;
        private Button button1;
        private Button BotonProductos;
        private Button button3;
        private Label label1;
        private Panel panel1;
    }
}
