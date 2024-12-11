namespace Vista
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            gb_Productos = new GroupBox();
            pb_CargarImagen = new PictureBox();
            lbl_Imagen = new Label();
            txt_RutaImagen = new TextBox();
            pb_ImagenProducto = new PictureBox();
            lbl_Importados = new Label();
            label1 = new Label();
            Logo_Empresa = new PictureBox();
            pb_EliminarProducto = new PictureBox();
            pb_EditarProducto = new PictureBox();
            pb_AgregarProducto = new PictureBox();
            lbl_Descripcion = new Label();
            rtxt_Descripcion = new RichTextBox();
            lbl_StockMinimo = new Label();
            lbl_Stock = new Label();
            lbl_Precio = new Label();
            lbl_Nombre = new Label();
            lbl_Codigo = new Label();
            txt_StockMinimo = new TextBox();
            txt_Stock = new TextBox();
            txt_Precio = new TextBox();
            txt_Nombre = new TextBox();
            txt_Codigo = new TextBox();
            dgv_ProductosNacionales = new DataGridView();
            dgv_ProductosImportados = new DataGridView();
            lbl_Categorias = new Label();
            lbl_Nacionalidad = new Label();
            cb_Categorias = new ComboBox();
            chk_Importado = new CheckBox();
            cb_Nacionalidad = new ComboBox();
            ofd_CargarImagen = new OpenFileDialog();
            gb_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_CargarImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_ImagenProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo_Empresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EditarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ProductosNacionales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ProductosImportados).BeginInit();
            SuspendLayout();
            // 
            // gb_Productos
            // 
            gb_Productos.Controls.Add(pb_CargarImagen);
            gb_Productos.Controls.Add(lbl_Imagen);
            gb_Productos.Controls.Add(txt_RutaImagen);
            gb_Productos.Controls.Add(pb_ImagenProducto);
            gb_Productos.Controls.Add(lbl_Importados);
            gb_Productos.Controls.Add(label1);
            gb_Productos.Controls.Add(Logo_Empresa);
            gb_Productos.Controls.Add(pb_EliminarProducto);
            gb_Productos.Controls.Add(pb_EditarProducto);
            gb_Productos.Controls.Add(pb_AgregarProducto);
            gb_Productos.Controls.Add(lbl_Descripcion);
            gb_Productos.Controls.Add(rtxt_Descripcion);
            gb_Productos.Controls.Add(lbl_StockMinimo);
            gb_Productos.Controls.Add(lbl_Stock);
            gb_Productos.Controls.Add(lbl_Precio);
            gb_Productos.Controls.Add(lbl_Nombre);
            gb_Productos.Controls.Add(lbl_Codigo);
            gb_Productos.Controls.Add(txt_StockMinimo);
            gb_Productos.Controls.Add(txt_Stock);
            gb_Productos.Controls.Add(txt_Precio);
            gb_Productos.Controls.Add(txt_Nombre);
            gb_Productos.Controls.Add(txt_Codigo);
            gb_Productos.Controls.Add(dgv_ProductosNacionales);
            gb_Productos.Controls.Add(dgv_ProductosImportados);
            gb_Productos.Controls.Add(lbl_Categorias);
            gb_Productos.Controls.Add(lbl_Nacionalidad);
            gb_Productos.Controls.Add(cb_Categorias);
            gb_Productos.Controls.Add(chk_Importado);
            gb_Productos.Controls.Add(cb_Nacionalidad);
            gb_Productos.FlatStyle = FlatStyle.System;
            gb_Productos.Font = new Font("Microsoft YaHei", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_Productos.Location = new Point(-1, 24);
            gb_Productos.Name = "gb_Productos";
            gb_Productos.Size = new Size(1421, 571);
            gb_Productos.TabIndex = 5;
            gb_Productos.TabStop = false;
            gb_Productos.Text = "Administración de Productos";
            // 
            // pb_CargarImagen
            // 
            pb_CargarImagen.Image = (Image)resources.GetObject("pb_CargarImagen.Image");
            pb_CargarImagen.Location = new Point(234, 269);
            pb_CargarImagen.Name = "pb_CargarImagen";
            pb_CargarImagen.Size = new Size(428, 252);
            pb_CargarImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pb_CargarImagen.TabIndex = 33;
            pb_CargarImagen.TabStop = false;
            // 
            // lbl_Imagen
            // 
            lbl_Imagen.AutoSize = true;
            lbl_Imagen.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Imagen.Location = new Point(29, 131);
            lbl_Imagen.Name = "lbl_Imagen";
            lbl_Imagen.Size = new Size(125, 19);
            lbl_Imagen.TabIndex = 32;
            lbl_Imagen.Text = "Imagen Producto";
            // 
            // txt_RutaImagen
            // 
            txt_RutaImagen.BackColor = SystemColors.InactiveCaption;
            txt_RutaImagen.ForeColor = Color.MediumBlue;
            txt_RutaImagen.Location = new Point(32, 146);
            txt_RutaImagen.Name = "txt_RutaImagen";
            txt_RutaImagen.Size = new Size(122, 27);
            txt_RutaImagen.TabIndex = 31;
            // 
            // pb_ImagenProducto
            // 
            pb_ImagenProducto.BackColor = Color.Transparent;
            pb_ImagenProducto.BackgroundImage = (Image)resources.GetObject("pb_ImagenProducto.BackgroundImage");
            pb_ImagenProducto.BackgroundImageLayout = ImageLayout.Zoom;
            pb_ImagenProducto.Cursor = Cursors.Hand;
            pb_ImagenProducto.Image = (Image)resources.GetObject("pb_ImagenProducto.Image");
            pb_ImagenProducto.Location = new Point(6, 145);
            pb_ImagenProducto.Name = "pb_ImagenProducto";
            pb_ImagenProducto.Size = new Size(26, 28);
            pb_ImagenProducto.TabIndex = 30;
            pb_ImagenProducto.TabStop = false;
            pb_ImagenProducto.Click += pb_ImagenProducto_Click;
            // 
            // lbl_Importados
            // 
            lbl_Importados.AutoSize = true;
            lbl_Importados.BackColor = Color.MediumBlue;
            lbl_Importados.ForeColor = SystemColors.Control;
            lbl_Importados.Location = new Point(963, 302);
            lbl_Importados.Name = "lbl_Importados";
            lbl_Importados.Size = new Size(214, 19);
            lbl_Importados.TabIndex = 29;
            lbl_Importados.Text = "PRODUCTOS IMPORTADOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumBlue;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(967, 29);
            label1.Name = "label1";
            label1.Size = new Size(210, 19);
            label1.TabIndex = 28;
            label1.Text = "PRODUCTOS NACIONALES";
            // 
            // Logo_Empresa
            // 
            Logo_Empresa.BackColor = Color.Transparent;
            Logo_Empresa.BackgroundImage = (Image)resources.GetObject("Logo_Empresa.BackgroundImage");
            Logo_Empresa.BackgroundImageLayout = ImageLayout.Zoom;
            Logo_Empresa.Image = (Image)resources.GetObject("Logo_Empresa.Image");
            Logo_Empresa.Location = new Point(-3, 511);
            Logo_Empresa.Name = "Logo_Empresa";
            Logo_Empresa.Size = new Size(193, 54);
            Logo_Empresa.TabIndex = 27;
            Logo_Empresa.TabStop = false;
            // 
            // pb_EliminarProducto
            // 
            pb_EliminarProducto.BackColor = Color.Transparent;
            pb_EliminarProducto.BackgroundImage = (Image)resources.GetObject("pb_EliminarProducto.BackgroundImage");
            pb_EliminarProducto.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EliminarProducto.Cursor = Cursors.Hand;
            pb_EliminarProducto.Location = new Point(644, 184);
            pb_EliminarProducto.Name = "pb_EliminarProducto";
            pb_EliminarProducto.Size = new Size(49, 52);
            pb_EliminarProducto.TabIndex = 26;
            pb_EliminarProducto.TabStop = false;
            pb_EliminarProducto.Click += pb_EliminarProducto_Click;
            // 
            // pb_EditarProducto
            // 
            pb_EditarProducto.BackColor = Color.Transparent;
            pb_EditarProducto.BackgroundImage = (Image)resources.GetObject("pb_EditarProducto.BackgroundImage");
            pb_EditarProducto.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EditarProducto.Cursor = Cursors.Hand;
            pb_EditarProducto.Location = new Point(564, 182);
            pb_EditarProducto.Name = "pb_EditarProducto";
            pb_EditarProducto.Size = new Size(60, 53);
            pb_EditarProducto.TabIndex = 25;
            pb_EditarProducto.TabStop = false;
            pb_EditarProducto.Click += pb_EditarProducto_Click;
            // 
            // pb_AgregarProducto
            // 
            pb_AgregarProducto.BackColor = Color.Transparent;
            pb_AgregarProducto.BackgroundImage = (Image)resources.GetObject("pb_AgregarProducto.BackgroundImage");
            pb_AgregarProducto.BackgroundImageLayout = ImageLayout.Zoom;
            pb_AgregarProducto.Cursor = Cursors.Hand;
            pb_AgregarProducto.Image = (Image)resources.GetObject("pb_AgregarProducto.Image");
            pb_AgregarProducto.Location = new Point(495, 183);
            pb_AgregarProducto.Name = "pb_AgregarProducto";
            pb_AgregarProducto.Size = new Size(49, 52);
            pb_AgregarProducto.TabIndex = 24;
            pb_AgregarProducto.TabStop = false;
            pb_AgregarProducto.Click += pb_AgregarProducto_Click;
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Descripcion.Location = new Point(468, 29);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(87, 19);
            lbl_Descripcion.TabIndex = 23;
            lbl_Descripcion.Text = "Descripción";
            // 
            // rtxt_Descripcion
            // 
            rtxt_Descripcion.BackColor = SystemColors.InactiveCaption;
            rtxt_Descripcion.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            rtxt_Descripcion.ForeColor = Color.MediumBlue;
            rtxt_Descripcion.Location = new Point(468, 47);
            rtxt_Descripcion.Name = "rtxt_Descripcion";
            rtxt_Descripcion.Size = new Size(259, 117);
            rtxt_Descripcion.TabIndex = 22;
            rtxt_Descripcion.Text = "";
            // 
            // lbl_StockMinimo
            // 
            lbl_StockMinimo.AutoSize = true;
            lbl_StockMinimo.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_StockMinimo.Location = new Point(328, 76);
            lbl_StockMinimo.Name = "lbl_StockMinimo";
            lbl_StockMinimo.Size = new Size(101, 19);
            lbl_StockMinimo.TabIndex = 21;
            lbl_StockMinimo.Text = "Stock Minimo";
            // 
            // lbl_Stock
            // 
            lbl_Stock.AutoSize = true;
            lbl_Stock.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Stock.Location = new Point(328, 29);
            lbl_Stock.Name = "lbl_Stock";
            lbl_Stock.Size = new Size(46, 19);
            lbl_Stock.TabIndex = 20;
            lbl_Stock.Text = "Stock";
            // 
            // lbl_Precio
            // 
            lbl_Precio.AutoSize = true;
            lbl_Precio.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Precio.Location = new Point(181, 130);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(52, 19);
            lbl_Precio.TabIndex = 19;
            lbl_Precio.Text = "Precio";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Nombre.Location = new Point(181, 76);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(65, 19);
            lbl_Nombre.TabIndex = 18;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Codigo.Location = new Point(181, 29);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(58, 19);
            lbl_Codigo.TabIndex = 17;
            lbl_Codigo.Text = "Codigo";
            // 
            // txt_StockMinimo
            // 
            txt_StockMinimo.BackColor = SystemColors.InactiveCaption;
            txt_StockMinimo.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            txt_StockMinimo.ForeColor = Color.MediumBlue;
            txt_StockMinimo.Location = new Point(328, 93);
            txt_StockMinimo.Name = "txt_StockMinimo";
            txt_StockMinimo.Size = new Size(100, 25);
            txt_StockMinimo.TabIndex = 16;
            // 
            // txt_Stock
            // 
            txt_Stock.BackColor = SystemColors.InactiveCaption;
            txt_Stock.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            txt_Stock.ForeColor = Color.MediumBlue;
            txt_Stock.Location = new Point(328, 47);
            txt_Stock.Name = "txt_Stock";
            txt_Stock.Size = new Size(100, 25);
            txt_Stock.TabIndex = 15;
            // 
            // txt_Precio
            // 
            txt_Precio.BackColor = SystemColors.InactiveCaption;
            txt_Precio.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            txt_Precio.ForeColor = Color.MediumBlue;
            txt_Precio.Location = new Point(181, 148);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(100, 25);
            txt_Precio.TabIndex = 14;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = SystemColors.InactiveCaption;
            txt_Nombre.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            txt_Nombre.ForeColor = Color.MediumBlue;
            txt_Nombre.Location = new Point(181, 93);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 25);
            txt_Nombre.TabIndex = 13;
            // 
            // txt_Codigo
            // 
            txt_Codigo.BackColor = SystemColors.InactiveCaption;
            txt_Codigo.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            txt_Codigo.ForeColor = Color.MediumBlue;
            txt_Codigo.Location = new Point(181, 47);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(100, 25);
            txt_Codigo.TabIndex = 12;
            // 
            // dgv_ProductosNacionales
            // 
            dgv_ProductosNacionales.BackgroundColor = SystemColors.Info;
            dgv_ProductosNacionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ProductosNacionales.Location = new Point(781, 47);
            dgv_ProductosNacionales.Name = "dgv_ProductosNacionales";
            dgv_ProductosNacionales.Size = new Size(586, 233);
            dgv_ProductosNacionales.TabIndex = 11;
            dgv_ProductosNacionales.CellClick += dgv_ProductosNacionales_CellClick;
            // 
            // dgv_ProductosImportados
            // 
            dgv_ProductosImportados.BackgroundColor = SystemColors.Info;
            dgv_ProductosImportados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ProductosImportados.Location = new Point(781, 321);
            dgv_ProductosImportados.Name = "dgv_ProductosImportados";
            dgv_ProductosImportados.Size = new Size(586, 233);
            dgv_ProductosImportados.TabIndex = 10;
            dgv_ProductosImportados.CellClick += dgv_ProductosImportados_CellClick;
            // 
            // lbl_Categorias
            // 
            lbl_Categorias.AutoSize = true;
            lbl_Categorias.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Categorias.Location = new Point(327, 131);
            lbl_Categorias.Name = "lbl_Categorias";
            lbl_Categorias.Size = new Size(81, 19);
            lbl_Categorias.TabIndex = 9;
            lbl_Categorias.Text = "Categorias";
            // 
            // lbl_Nacionalidad
            // 
            lbl_Nacionalidad.AutoSize = true;
            lbl_Nacionalidad.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Nacionalidad.Location = new Point(33, 73);
            lbl_Nacionalidad.Name = "lbl_Nacionalidad";
            lbl_Nacionalidad.Size = new Size(98, 19);
            lbl_Nacionalidad.TabIndex = 8;
            lbl_Nacionalidad.Text = "Nacionalidad";
            // 
            // cb_Categorias
            // 
            cb_Categorias.BackColor = SystemColors.InactiveCaption;
            cb_Categorias.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            cb_Categorias.ForeColor = Color.MediumBlue;
            cb_Categorias.FormattingEnabled = true;
            cb_Categorias.Location = new Point(328, 149);
            cb_Categorias.Name = "cb_Categorias";
            cb_Categorias.Size = new Size(117, 27);
            cb_Categorias.TabIndex = 7;
            // 
            // chk_Importado
            // 
            chk_Importado.AutoSize = true;
            chk_Importado.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            chk_Importado.Location = new Point(42, 49);
            chk_Importado.Name = "chk_Importado";
            chk_Importado.Size = new Size(100, 23);
            chk_Importado.TabIndex = 6;
            chk_Importado.Text = "Importado";
            chk_Importado.UseVisualStyleBackColor = true;
            // 
            // cb_Nacionalidad
            // 
            cb_Nacionalidad.BackColor = SystemColors.InactiveCaption;
            cb_Nacionalidad.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            cb_Nacionalidad.ForeColor = Color.MediumBlue;
            cb_Nacionalidad.FormattingEnabled = true;
            cb_Nacionalidad.Items.AddRange(new object[] { "Alemania", "Australia", "Bélgica", "Brasil", "Canadá", "China", "Corea del Sur", "España", "Estados Unidos", "Francia", "Hong Kong", "India", "Italia", "Japón", "México", "Países Bajos", "Reino Unido", "Singapur", "Suiza", "Tailandia" });
            cb_Nacionalidad.Location = new Point(33, 91);
            cb_Nacionalidad.Name = "cb_Nacionalidad";
            cb_Nacionalidad.Size = new Size(121, 27);
            cb_Nacionalidad.TabIndex = 5;
            // 
            // ofd_CargarImagen
            // 
            ofd_CargarImagen.FileName = "CargarImagen";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LawnGreen;
            ClientSize = new Size(1415, 620);
            Controls.Add(gb_Productos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Productos";
            Text = "Productos";
            Load += Productos_Load;
            MouseDown += Productos_MouseDown;
            gb_Productos.ResumeLayout(false);
            gb_Productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_CargarImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_ImagenProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo_Empresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EditarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ProductosNacionales).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ProductosImportados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Productos;
        private DataGridView dgv_ProductosNacionales;
        private DataGridView dgv_ProductosImportados;
        private Label lbl_Categorias;
        private Label lbl_Nacionalidad;
        private ComboBox cb_Categorias;
        private CheckBox chk_Importado;
        private ComboBox cb_Nacionalidad;
        private TextBox txt_StockMinimo;
        private TextBox txt_Stock;
        private TextBox txt_Precio;
        private TextBox txt_Nombre;
        private TextBox txt_Codigo;
        private Label lbl_StockMinimo;
        private Label lbl_Stock;
        private Label lbl_Precio;
        private Label lbl_Nombre;
        private Label lbl_Codigo;
        private Label lbl_Descripcion;
        private RichTextBox rtxt_Descripcion;
        private PictureBox Logo_Empresa;
        private PictureBox pb_EliminarProducto;
        private PictureBox pb_EditarProducto;
        private PictureBox pb_AgregarProducto;
        private Label lbl_Importados;
        private Label label1;
        private TextBox txt_RutaImagen;
        private PictureBox pb_ImagenProducto;
        private Label lbl_Imagen;
        private OpenFileDialog ofd_CargarImagen;
        private PictureBox pb_CargarImagen;
    }
}