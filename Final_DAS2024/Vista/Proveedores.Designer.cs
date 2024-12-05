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
            btn_CrearProveedor = new Button();
            btn_EditarProveedor = new Button();
            btn_EliminarProveedor = new Button();
            lbl_CodigoProveedor = new Label();
            lbl_NombreProveedor = new Label();
            lbl_Contacto = new Label();
            lbl_DescripcionProveedor = new Label();
            txt_CodigoProveedor = new TextBox();
            txt_NombreProveedor = new TextBox();
            txt_ContactoProveedor = new TextBox();
            txt_DescripcionProveedor = new TextBox();
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
            // btn_CrearProveedor
            // 
            btn_CrearProveedor.Location = new Point(241, 20);
            btn_CrearProveedor.Name = "btn_CrearProveedor";
            btn_CrearProveedor.Size = new Size(125, 43);
            btn_CrearProveedor.TabIndex = 1;
            btn_CrearProveedor.Text = "Nuevo Proveedor";
            btn_CrearProveedor.UseVisualStyleBackColor = true;
            btn_CrearProveedor.Click += btn_CrearProveedor_Click;
            // 
            // btn_EditarProveedor
            // 
            btn_EditarProveedor.Location = new Point(241, 69);
            btn_EditarProveedor.Name = "btn_EditarProveedor";
            btn_EditarProveedor.Size = new Size(125, 23);
            btn_EditarProveedor.TabIndex = 2;
            btn_EditarProveedor.Text = "Editar Proveedor";
            btn_EditarProveedor.UseVisualStyleBackColor = true;
            btn_EditarProveedor.Click += btn_EditarProveedor_Click;
            // 
            // btn_EliminarProveedor
            // 
            btn_EliminarProveedor.Location = new Point(241, 98);
            btn_EliminarProveedor.Name = "btn_EliminarProveedor";
            btn_EliminarProveedor.Size = new Size(125, 23);
            btn_EliminarProveedor.TabIndex = 3;
            btn_EliminarProveedor.Text = "Eliminar Proveedor";
            btn_EliminarProveedor.UseVisualStyleBackColor = true;
            btn_EliminarProveedor.Click += btn_EliminarProveedor_Click;
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
            // lbl_DescripcionProveedor
            // 
            lbl_DescripcionProveedor.AutoSize = true;
            lbl_DescripcionProveedor.Location = new Point(12, 108);
            lbl_DescripcionProveedor.Name = "lbl_DescripcionProveedor";
            lbl_DescripcionProveedor.Size = new Size(69, 15);
            lbl_DescripcionProveedor.TabIndex = 7;
            lbl_DescripcionProveedor.Text = "Descripción";
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
            // txt_DescripcionProveedor
            // 
            txt_DescripcionProveedor.Location = new Point(91, 105);
            txt_DescripcionProveedor.Name = "txt_DescripcionProveedor";
            txt_DescripcionProveedor.Size = new Size(100, 23);
            txt_DescripcionProveedor.TabIndex = 11;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 450);
            Controls.Add(txt_DescripcionProveedor);
            Controls.Add(txt_ContactoProveedor);
            Controls.Add(txt_NombreProveedor);
            Controls.Add(txt_CodigoProveedor);
            Controls.Add(lbl_DescripcionProveedor);
            Controls.Add(lbl_Contacto);
            Controls.Add(lbl_NombreProveedor);
            Controls.Add(lbl_CodigoProveedor);
            Controls.Add(btn_EliminarProveedor);
            Controls.Add(btn_EditarProveedor);
            Controls.Add(btn_CrearProveedor);
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
        private Button btn_CrearProveedor;
        private Button btn_EditarProveedor;
        private Button btn_EliminarProveedor;
        private Label lbl_CodigoProveedor;
        private Label lbl_NombreProveedor;
        private Label lbl_Contacto;
        private Label lbl_DescripcionProveedor;
        private TextBox txt_CodigoProveedor;
        private TextBox txt_NombreProveedor;
        private TextBox txt_ContactoProveedor;
        private TextBox txt_DescripcionProveedor;
    }
}