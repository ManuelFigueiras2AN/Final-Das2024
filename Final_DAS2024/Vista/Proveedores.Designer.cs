namespace Vista
{
    partial class Proveedores
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
            dgv_Proveedores = new DataGridView();
            lbl_CodigoProveedor = new Label();
            lbl_NombreProveedor = new Label();
            lbl_Contacto = new Label();
            txt_CodigoProveedor = new TextBox();
            txt_NombreProveedor = new TextBox();
            txt_ContactoProveedor = new TextBox();
            richTextBox1 = new RichTextBox();
            lbl_Descripcion = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Proveedores).BeginInit();
            SuspendLayout();
            // 
            // dgv_Proveedores
            // 
            dgv_Proveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Proveedores.Location = new Point(12, 168);
            dgv_Proveedores.Name = "dgv_Proveedores";
            dgv_Proveedores.Size = new Size(422, 220);
            dgv_Proveedores.TabIndex = 0;
            dgv_Proveedores.CellClick += dgv_Proveedores_CellClick;
            // 
            // lbl_CodigoProveedor
            // 
            lbl_CodigoProveedor.AutoSize = true;
            lbl_CodigoProveedor.Location = new Point(12, 22);
            lbl_CodigoProveedor.Name = "lbl_CodigoProveedor";
            lbl_CodigoProveedor.Size = new Size(46, 15);
            lbl_CodigoProveedor.TabIndex = 4;
            lbl_CodigoProveedor.Text = "Codigo";
            // 
            // lbl_NombreProveedor
            // 
            lbl_NombreProveedor.AutoSize = true;
            lbl_NombreProveedor.Location = new Point(12, 49);
            lbl_NombreProveedor.Name = "lbl_NombreProveedor";
            lbl_NombreProveedor.Size = new Size(73, 15);
            lbl_NombreProveedor.TabIndex = 5;
            lbl_NombreProveedor.Text = "Razón Social";
            // 
            // lbl_Contacto
            // 
            lbl_Contacto.AutoSize = true;
            lbl_Contacto.Location = new Point(12, 77);
            lbl_Contacto.Name = "lbl_Contacto";
            lbl_Contacto.Size = new Size(56, 15);
            lbl_Contacto.TabIndex = 6;
            lbl_Contacto.Text = "Contacto";
            // 
            // txt_CodigoProveedor
            // 
            txt_CodigoProveedor.Location = new Point(91, 20);
            txt_CodigoProveedor.Name = "txt_CodigoProveedor";
            txt_CodigoProveedor.Size = new Size(100, 23);
            txt_CodigoProveedor.TabIndex = 8;
            // 
            // txt_NombreProveedor
            // 
            txt_NombreProveedor.Location = new Point(91, 49);
            txt_NombreProveedor.Name = "txt_NombreProveedor";
            txt_NombreProveedor.Size = new Size(100, 23);
            txt_NombreProveedor.TabIndex = 9;
            // 
            // txt_ContactoProveedor
            // 
            txt_ContactoProveedor.Location = new Point(91, 76);
            txt_ContactoProveedor.Name = "txt_ContactoProveedor";
            txt_ContactoProveedor.Size = new Size(100, 23);
            txt_ContactoProveedor.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(224, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(220, 62);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Location = new Point(224, 9);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(69, 15);
            lbl_Descripcion.TabIndex = 12;
            lbl_Descripcion.Text = "Descripción";
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 450);
            Controls.Add(lbl_Descripcion);
            Controls.Add(richTextBox1);
            Controls.Add(txt_ContactoProveedor);
            Controls.Add(txt_NombreProveedor);
            Controls.Add(txt_CodigoProveedor);
            Controls.Add(lbl_Contacto);
            Controls.Add(lbl_NombreProveedor);
            Controls.Add(lbl_CodigoProveedor);
            Controls.Add(dgv_Proveedores);
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Proveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Proveedores;
        private Label lbl_CodigoProveedor;
        private Label lbl_NombreProveedor;
        private Label lbl_Contacto;
        private TextBox txt_CodigoProveedor;
        private TextBox txt_NombreProveedor;
        private TextBox txt_ContactoProveedor;
        private RichTextBox richTextBox1;
        private Label lbl_Descripcion;
    }
}