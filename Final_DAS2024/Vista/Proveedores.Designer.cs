﻿namespace Vista
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            dgv_Proveedores = new DataGridView();
            lbl_CodigoProveedor = new Label();
            lbl_NombreProveedor = new Label();
            lbl_Contacto = new Label();
            txt_CodigoProveedor = new TextBox();
            txt_NombreProveedor = new TextBox();
            txt_ContactoProveedor = new TextBox();
            rtxt_Descripcion = new RichTextBox();
            lbl_Descripcion = new Label();
            gb_Proovedores = new GroupBox();
            pb_EliminarProducto = new PictureBox();
            pb_AgregarProducto = new PictureBox();
            pb_EliminarProveedor = new PictureBox();
            pb_EditarProveedor = new PictureBox();
            pb_AgregarProveedor = new PictureBox();
            dgv_Productos = new DataGridView();
            lbl_Categorias = new Label();
            lbl_Productos = new Label();
            cb_Categorias = new ComboBox();
            clb_Productos = new CheckedListBox();
            notificacion_Catalogo = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)dgv_Proveedores).BeginInit();
            gb_Proovedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EditarProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarProveedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).BeginInit();
            SuspendLayout();
            // 
            // dgv_Proveedores
            // 
            dgv_Proveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Proveedores.Location = new Point(31, 285);
            dgv_Proveedores.Name = "dgv_Proveedores";
            dgv_Proveedores.Size = new Size(422, 220);
            dgv_Proveedores.TabIndex = 0;
            dgv_Proveedores.CellClick += dgv_Proveedores_CellClick;
            // 
            // lbl_CodigoProveedor
            // 
            lbl_CodigoProveedor.AutoSize = true;
            lbl_CodigoProveedor.Location = new Point(31, 35);
            lbl_CodigoProveedor.Name = "lbl_CodigoProveedor";
            lbl_CodigoProveedor.Size = new Size(46, 15);
            lbl_CodigoProveedor.TabIndex = 4;
            lbl_CodigoProveedor.Text = "Codigo";
            // 
            // lbl_NombreProveedor
            // 
            lbl_NombreProveedor.AutoSize = true;
            lbl_NombreProveedor.Location = new Point(6, 64);
            lbl_NombreProveedor.Name = "lbl_NombreProveedor";
            lbl_NombreProveedor.Size = new Size(73, 15);
            lbl_NombreProveedor.TabIndex = 5;
            lbl_NombreProveedor.Text = "Razón Social";
            // 
            // lbl_Contacto
            // 
            lbl_Contacto.AutoSize = true;
            lbl_Contacto.Location = new Point(21, 91);
            lbl_Contacto.Name = "lbl_Contacto";
            lbl_Contacto.Size = new Size(56, 15);
            lbl_Contacto.TabIndex = 6;
            lbl_Contacto.Text = "Contacto";
            // 
            // txt_CodigoProveedor
            // 
            txt_CodigoProveedor.Location = new Point(83, 32);
            txt_CodigoProveedor.Name = "txt_CodigoProveedor";
            txt_CodigoProveedor.Size = new Size(100, 23);
            txt_CodigoProveedor.TabIndex = 8;
            // 
            // txt_NombreProveedor
            // 
            txt_NombreProveedor.Location = new Point(83, 61);
            txt_NombreProveedor.Name = "txt_NombreProveedor";
            txt_NombreProveedor.Size = new Size(100, 23);
            txt_NombreProveedor.TabIndex = 9;
            // 
            // txt_ContactoProveedor
            // 
            txt_ContactoProveedor.Location = new Point(83, 88);
            txt_ContactoProveedor.Name = "txt_ContactoProveedor";
            txt_ContactoProveedor.Size = new Size(100, 23);
            txt_ContactoProveedor.TabIndex = 10;
            // 
            // rtxt_Descripcion
            // 
            rtxt_Descripcion.Location = new Point(216, 38);
            rtxt_Descripcion.Name = "rtxt_Descripcion";
            rtxt_Descripcion.Size = new Size(220, 62);
            rtxt_Descripcion.TabIndex = 11;
            rtxt_Descripcion.Text = "";
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Location = new Point(216, 20);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(69, 15);
            lbl_Descripcion.TabIndex = 12;
            lbl_Descripcion.Text = "Descripción";
            // 
            // gb_Proovedores
            // 
            gb_Proovedores.Controls.Add(pb_EliminarProducto);
            gb_Proovedores.Controls.Add(pb_AgregarProducto);
            gb_Proovedores.Controls.Add(pb_EliminarProveedor);
            gb_Proovedores.Controls.Add(pb_EditarProveedor);
            gb_Proovedores.Controls.Add(pb_AgregarProveedor);
            gb_Proovedores.Controls.Add(dgv_Productos);
            gb_Proovedores.Controls.Add(lbl_Categorias);
            gb_Proovedores.Controls.Add(lbl_Productos);
            gb_Proovedores.Controls.Add(cb_Categorias);
            gb_Proovedores.Controls.Add(clb_Productos);
            gb_Proovedores.Controls.Add(rtxt_Descripcion);
            gb_Proovedores.Controls.Add(dgv_Proveedores);
            gb_Proovedores.Controls.Add(lbl_Descripcion);
            gb_Proovedores.Controls.Add(lbl_CodigoProveedor);
            gb_Proovedores.Controls.Add(lbl_NombreProveedor);
            gb_Proovedores.Controls.Add(txt_ContactoProveedor);
            gb_Proovedores.Controls.Add(lbl_Contacto);
            gb_Proovedores.Controls.Add(txt_NombreProveedor);
            gb_Proovedores.Controls.Add(txt_CodigoProveedor);
            gb_Proovedores.Location = new Point(-2, 12);
            gb_Proovedores.Name = "gb_Proovedores";
            gb_Proovedores.Size = new Size(1007, 534);
            gb_Proovedores.TabIndex = 13;
            gb_Proovedores.TabStop = false;
            gb_Proovedores.Text = "Administración Proveedores";
            // 
            // pb_EliminarProducto
            // 
            pb_EliminarProducto.Cursor = Cursors.Hand;
            pb_EliminarProducto.Image = (Image)resources.GetObject("pb_EliminarProducto.Image");
            pb_EliminarProducto.Location = new Point(750, 156);
            pb_EliminarProducto.Name = "pb_EliminarProducto";
            pb_EliminarProducto.Size = new Size(45, 49);
            pb_EliminarProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pb_EliminarProducto.TabIndex = 26;
            pb_EliminarProducto.TabStop = false;
            pb_EliminarProducto.Click += pb_EliminarProducto_Click;
            // 
            // pb_AgregarProducto
            // 
            pb_AgregarProducto.Image = (Image)resources.GetObject("pb_AgregarProducto.Image");
            pb_AgregarProducto.Location = new Point(654, 156);
            pb_AgregarProducto.Name = "pb_AgregarProducto";
            pb_AgregarProducto.Size = new Size(63, 50);
            pb_AgregarProducto.SizeMode = PictureBoxSizeMode.Zoom;
            pb_AgregarProducto.TabIndex = 25;
            pb_AgregarProducto.TabStop = false;
            pb_AgregarProducto.Click += pb_AgregarProducto_Click;
            // 
            // pb_EliminarProveedor
            // 
            pb_EliminarProveedor.BackColor = Color.Transparent;
            pb_EliminarProveedor.BackgroundImage = (Image)resources.GetObject("pb_EliminarProveedor.BackgroundImage");
            pb_EliminarProveedor.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EliminarProveedor.Cursor = Cursors.Hand;
            pb_EliminarProveedor.Location = new Point(213, 154);
            pb_EliminarProveedor.Name = "pb_EliminarProveedor";
            pb_EliminarProveedor.Size = new Size(49, 52);
            pb_EliminarProveedor.TabIndex = 24;
            pb_EliminarProveedor.TabStop = false;
            pb_EliminarProveedor.Click += pb_EliminarProveedor_Click;
            // 
            // pb_EditarProveedor
            // 
            pb_EditarProveedor.BackColor = Color.Transparent;
            pb_EditarProveedor.BackgroundImage = (Image)resources.GetObject("pb_EditarProveedor.BackgroundImage");
            pb_EditarProveedor.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EditarProveedor.Cursor = Cursors.Hand;
            pb_EditarProveedor.Location = new Point(134, 152);
            pb_EditarProveedor.Name = "pb_EditarProveedor";
            pb_EditarProveedor.Size = new Size(60, 53);
            pb_EditarProveedor.TabIndex = 23;
            pb_EditarProveedor.TabStop = false;
            pb_EditarProveedor.Click += pb_EditarProveedor_Click;
            // 
            // pb_AgregarProveedor
            // 
            pb_AgregarProveedor.BackColor = Color.Transparent;
            pb_AgregarProveedor.BackgroundImage = (Image)resources.GetObject("pb_AgregarProveedor.BackgroundImage");
            pb_AgregarProveedor.BackgroundImageLayout = ImageLayout.Zoom;
            pb_AgregarProveedor.Cursor = Cursors.Hand;
            pb_AgregarProveedor.Image = (Image)resources.GetObject("pb_AgregarProveedor.Image");
            pb_AgregarProveedor.Location = new Point(64, 153);
            pb_AgregarProveedor.Name = "pb_AgregarProveedor";
            pb_AgregarProveedor.Size = new Size(49, 52);
            pb_AgregarProveedor.TabIndex = 22;
            pb_AgregarProveedor.TabStop = false;
            pb_AgregarProveedor.Click += pb_AgregarProveedor_Click;
            // 
            // dgv_Productos
            // 
            dgv_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Productos.Location = new Point(534, 285);
            dgv_Productos.Name = "dgv_Productos";
            dgv_Productos.Size = new Size(422, 220);
            dgv_Productos.TabIndex = 17;
            dgv_Productos.CellClick += dgv_Productos_CellClick;
            // 
            // lbl_Categorias
            // 
            lbl_Categorias.AutoSize = true;
            lbl_Categorias.Location = new Point(800, 28);
            lbl_Categorias.Name = "lbl_Categorias";
            lbl_Categorias.Size = new Size(63, 15);
            lbl_Categorias.TabIndex = 16;
            lbl_Categorias.Text = "Categorias";
            // 
            // lbl_Productos
            // 
            lbl_Productos.AutoSize = true;
            lbl_Productos.Location = new Point(464, 28);
            lbl_Productos.Name = "lbl_Productos";
            lbl_Productos.Size = new Size(61, 15);
            lbl_Productos.TabIndex = 15;
            lbl_Productos.Text = "Productos";
            // 
            // cb_Categorias
            // 
            cb_Categorias.FormattingEnabled = true;
            cb_Categorias.Items.AddRange(new object[] { "Todas" });
            cb_Categorias.Location = new Point(800, 41);
            cb_Categorias.Name = "cb_Categorias";
            cb_Categorias.Size = new Size(121, 23);
            cb_Categorias.TabIndex = 14;
            cb_Categorias.SelectedIndexChanged += cb_Categorias_SelectedIndexChanged;
            // 
            // clb_Productos
            // 
            clb_Productos.FormattingEnabled = true;
            clb_Productos.Location = new Point(464, 41);
            clb_Productos.Name = "clb_Productos";
            clb_Productos.Size = new Size(304, 58);
            clb_Productos.TabIndex = 13;
            // 
            // notificacion_Catalogo
            // 
            notificacion_Catalogo.Icon = (Icon)resources.GetObject("notificacion_Catalogo.Icon");
            notificacion_Catalogo.Text = "Noticias del Catalogo";
            notificacion_Catalogo.Visible = true;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 577);
            Controls.Add(gb_Proovedores);
            Name = "Proveedores";
            Text = "Proveedores";
            Load += Proveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Proveedores).EndInit();
            gb_Proovedores.ResumeLayout(false);
            gb_Proovedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EditarProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarProveedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Productos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Proveedores;
        private Label lbl_CodigoProveedor;
        private Label lbl_NombreProveedor;
        private Label lbl_Contacto;
        private TextBox txt_CodigoProveedor;
        private TextBox txt_NombreProveedor;
        private TextBox txt_ContactoProveedor;
        private RichTextBox rtxt_Descripcion;
        private Label lbl_Descripcion;
        private GroupBox gb_Proovedores;
        private ComboBox cb_Categorias;
        private CheckedListBox clb_Productos;
        private Label lbl_Categorias;
        private Label lbl_Productos;
        private DataGridView dgv_Productos;
        private PictureBox pb_EliminarProveedor;
        private PictureBox pb_EditarProveedor;
        private PictureBox pb_AgregarProveedor;
        private NotifyIcon notificacion_Catalogo;
        private PictureBox pb_AgregarProducto;
        private PictureBox pb_EliminarProducto;
    }
}