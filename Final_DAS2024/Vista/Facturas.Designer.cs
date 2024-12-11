namespace Vista
{
    partial class Facturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            gb_Facturacion = new GroupBox();
            pb_EliminarDetalle = new PictureBox();
            pb_ActualizarDetalle = new PictureBox();
            pb_AgregarDetalle = new PictureBox();
            pb_EliminarFactura = new PictureBox();
            pb_EditarFactura = new PictureBox();
            pb_AgregarFactura = new PictureBox();
            lbl_Cantidad = new Label();
            txt_Cantidad = new TextBox();
            lbl_Productos = new Label();
            lbl_ClienteMayorista = new Label();
            lbl_ClienteMinorista = new Label();
            lbl_FechaFactura = new Label();
            lbl_CodigoFactura = new Label();
            txt_CodigoFactura = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dgv_DetalleFactura = new DataGridView();
            dgv_Facturas = new DataGridView();
            comboBox3 = new ComboBox();
            cb_ClienteMayorista = new ComboBox();
            cb_ClienteMinorista = new ComboBox();
            gb_Facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_ActualizarDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EditarFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DetalleFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Facturas).BeginInit();
            SuspendLayout();
            // 
            // gb_Facturacion
            // 
            gb_Facturacion.Controls.Add(pb_EliminarDetalle);
            gb_Facturacion.Controls.Add(pb_ActualizarDetalle);
            gb_Facturacion.Controls.Add(pb_AgregarDetalle);
            gb_Facturacion.Controls.Add(pb_EliminarFactura);
            gb_Facturacion.Controls.Add(pb_EditarFactura);
            gb_Facturacion.Controls.Add(pb_AgregarFactura);
            gb_Facturacion.Controls.Add(lbl_Cantidad);
            gb_Facturacion.Controls.Add(txt_Cantidad);
            gb_Facturacion.Controls.Add(lbl_Productos);
            gb_Facturacion.Controls.Add(lbl_ClienteMayorista);
            gb_Facturacion.Controls.Add(lbl_ClienteMinorista);
            gb_Facturacion.Controls.Add(lbl_FechaFactura);
            gb_Facturacion.Controls.Add(lbl_CodigoFactura);
            gb_Facturacion.Controls.Add(txt_CodigoFactura);
            gb_Facturacion.Controls.Add(dateTimePicker1);
            gb_Facturacion.Controls.Add(dgv_DetalleFactura);
            gb_Facturacion.Controls.Add(dgv_Facturas);
            gb_Facturacion.Controls.Add(comboBox3);
            gb_Facturacion.Controls.Add(cb_ClienteMayorista);
            gb_Facturacion.Controls.Add(cb_ClienteMinorista);
            gb_Facturacion.Location = new Point(0, 12);
            gb_Facturacion.Name = "gb_Facturacion";
            gb_Facturacion.Size = new Size(800, 523);
            gb_Facturacion.TabIndex = 0;
            gb_Facturacion.TabStop = false;
            gb_Facturacion.Text = "Generador de Facturas";
            // 
            // pb_EliminarDetalle
            // 
            pb_EliminarDetalle.BackColor = Color.Transparent;
            pb_EliminarDetalle.BackgroundImage = (Image)resources.GetObject("pb_EliminarDetalle.BackgroundImage");
            pb_EliminarDetalle.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EliminarDetalle.Cursor = Cursors.Hand;
            pb_EliminarDetalle.Location = new Point(678, 320);
            pb_EliminarDetalle.Name = "pb_EliminarDetalle";
            pb_EliminarDetalle.Size = new Size(49, 36);
            pb_EliminarDetalle.TabIndex = 32;
            pb_EliminarDetalle.TabStop = false;
            pb_EliminarDetalle.Click += pb_EliminarDetalle_Click;
            // 
            // pb_ActualizarDetalle
            // 
            pb_ActualizarDetalle.BackColor = Color.Transparent;
            pb_ActualizarDetalle.BackgroundImage = (Image)resources.GetObject("pb_ActualizarDetalle.BackgroundImage");
            pb_ActualizarDetalle.BackgroundImageLayout = ImageLayout.Zoom;
            pb_ActualizarDetalle.Cursor = Cursors.Hand;
            pb_ActualizarDetalle.Location = new Point(678, 269);
            pb_ActualizarDetalle.Name = "pb_ActualizarDetalle";
            pb_ActualizarDetalle.Size = new Size(49, 45);
            pb_ActualizarDetalle.TabIndex = 31;
            pb_ActualizarDetalle.TabStop = false;
            // 
            // pb_AgregarDetalle
            // 
            pb_AgregarDetalle.BackColor = Color.Transparent;
            pb_AgregarDetalle.BackgroundImage = (Image)resources.GetObject("pb_AgregarDetalle.BackgroundImage");
            pb_AgregarDetalle.BackgroundImageLayout = ImageLayout.Zoom;
            pb_AgregarDetalle.Cursor = Cursors.Hand;
            pb_AgregarDetalle.Image = (Image)resources.GetObject("pb_AgregarDetalle.Image");
            pb_AgregarDetalle.Location = new Point(678, 225);
            pb_AgregarDetalle.Name = "pb_AgregarDetalle";
            pb_AgregarDetalle.Size = new Size(49, 36);
            pb_AgregarDetalle.TabIndex = 30;
            pb_AgregarDetalle.TabStop = false;
            pb_AgregarDetalle.Click += pb_AgregarDetalle_Click;
            // 
            // pb_EliminarFactura
            // 
            pb_EliminarFactura.BackColor = Color.Transparent;
            pb_EliminarFactura.BackgroundImage = (Image)resources.GetObject("pb_EliminarFactura.BackgroundImage");
            pb_EliminarFactura.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EliminarFactura.Cursor = Cursors.Hand;
            pb_EliminarFactura.Location = new Point(678, 128);
            pb_EliminarFactura.Name = "pb_EliminarFactura";
            pb_EliminarFactura.Size = new Size(49, 36);
            pb_EliminarFactura.TabIndex = 29;
            pb_EliminarFactura.TabStop = false;
            pb_EliminarFactura.Click += pb_EliminarFactura_Click;
            // 
            // pb_EditarFactura
            // 
            pb_EditarFactura.BackColor = Color.Transparent;
            pb_EditarFactura.BackgroundImage = (Image)resources.GetObject("pb_EditarFactura.BackgroundImage");
            pb_EditarFactura.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EditarFactura.Cursor = Cursors.Hand;
            pb_EditarFactura.Location = new Point(678, 77);
            pb_EditarFactura.Name = "pb_EditarFactura";
            pb_EditarFactura.Size = new Size(49, 45);
            pb_EditarFactura.TabIndex = 28;
            pb_EditarFactura.TabStop = false;
            pb_EditarFactura.Click += pb_EditarFactura_Click;
            // 
            // pb_AgregarFactura
            // 
            pb_AgregarFactura.BackColor = Color.Transparent;
            pb_AgregarFactura.BackgroundImage = (Image)resources.GetObject("pb_AgregarFactura.BackgroundImage");
            pb_AgregarFactura.BackgroundImageLayout = ImageLayout.Zoom;
            pb_AgregarFactura.Cursor = Cursors.Hand;
            pb_AgregarFactura.Image = (Image)resources.GetObject("pb_AgregarFactura.Image");
            pb_AgregarFactura.Location = new Point(678, 33);
            pb_AgregarFactura.Name = "pb_AgregarFactura";
            pb_AgregarFactura.Size = new Size(49, 36);
            pb_AgregarFactura.TabIndex = 27;
            pb_AgregarFactura.TabStop = false;
            pb_AgregarFactura.Click += pb_AgregarFactura_Click;
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new Point(12, 250);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new Size(55, 15);
            lbl_Cantidad.TabIndex = 21;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new Point(13, 259);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(122, 23);
            txt_Cantidad.TabIndex = 20;
            // 
            // lbl_Productos
            // 
            lbl_Productos.AutoSize = true;
            lbl_Productos.Location = new Point(13, 204);
            lbl_Productos.Name = "lbl_Productos";
            lbl_Productos.Size = new Size(61, 15);
            lbl_Productos.TabIndex = 18;
            lbl_Productos.Text = "Productos";
            // 
            // lbl_ClienteMayorista
            // 
            lbl_ClienteMayorista.AutoSize = true;
            lbl_ClienteMayorista.Location = new Point(12, 136);
            lbl_ClienteMayorista.Name = "lbl_ClienteMayorista";
            lbl_ClienteMayorista.Size = new Size(99, 15);
            lbl_ClienteMayorista.TabIndex = 17;
            lbl_ClienteMayorista.Text = "Cliente Mayorista";
            // 
            // lbl_ClienteMinorista
            // 
            lbl_ClienteMinorista.AutoSize = true;
            lbl_ClienteMinorista.Location = new Point(12, 96);
            lbl_ClienteMinorista.Name = "lbl_ClienteMinorista";
            lbl_ClienteMinorista.Size = new Size(97, 15);
            lbl_ClienteMinorista.TabIndex = 16;
            lbl_ClienteMinorista.Text = "Cliente Minorista";
            // 
            // lbl_FechaFactura
            // 
            lbl_FechaFactura.AutoSize = true;
            lbl_FechaFactura.Location = new Point(13, 55);
            lbl_FechaFactura.Name = "lbl_FechaFactura";
            lbl_FechaFactura.Size = new Size(38, 15);
            lbl_FechaFactura.TabIndex = 15;
            lbl_FechaFactura.Text = "Fecha";
            // 
            // lbl_CodigoFactura
            // 
            lbl_CodigoFactura.AutoSize = true;
            lbl_CodigoFactura.Location = new Point(13, 18);
            lbl_CodigoFactura.Name = "lbl_CodigoFactura";
            lbl_CodigoFactura.Size = new Size(88, 15);
            lbl_CodigoFactura.TabIndex = 14;
            lbl_CodigoFactura.Text = "Codigo Factura";
            // 
            // txt_CodigoFactura
            // 
            txt_CodigoFactura.Location = new Point(14, 31);
            txt_CodigoFactura.Name = "txt_CodigoFactura";
            txt_CodigoFactura.Size = new Size(166, 23);
            txt_CodigoFactura.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(13, 69);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(165, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // dgv_DetalleFactura
            // 
            dgv_DetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DetalleFactura.Location = new Point(237, 214);
            dgv_DetalleFactura.Name = "dgv_DetalleFactura";
            dgv_DetalleFactura.Size = new Size(407, 150);
            dgv_DetalleFactura.TabIndex = 11;
            // 
            // dgv_Facturas
            // 
            dgv_Facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Facturas.Location = new Point(237, 22);
            dgv_Facturas.Name = "dgv_Facturas";
            dgv_Facturas.Size = new Size(407, 150);
            dgv_Facturas.TabIndex = 10;
            dgv_Facturas.CellClick += dgv_Facturas_CellClick;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(14, 214);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 9;
            // 
            // cb_ClienteMayorista
            // 
            cb_ClienteMayorista.FormattingEnabled = true;
            cb_ClienteMayorista.Location = new Point(12, 149);
            cb_ClienteMayorista.Name = "cb_ClienteMayorista";
            cb_ClienteMayorista.Size = new Size(165, 23);
            cb_ClienteMayorista.TabIndex = 8;
            // 
            // cb_ClienteMinorista
            // 
            cb_ClienteMinorista.FormattingEnabled = true;
            cb_ClienteMinorista.Location = new Point(13, 110);
            cb_ClienteMinorista.Name = "cb_ClienteMinorista";
            cb_ClienteMinorista.Size = new Size(165, 23);
            cb_ClienteMinorista.TabIndex = 7;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 547);
            Controls.Add(gb_Facturacion);
            Name = "Facturas";
            Text = "Facturas";
            Load += Facturas_Load;
            gb_Facturacion.ResumeLayout(false);
            gb_Facturacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_ActualizarDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EditarFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DetalleFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Facturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Facturacion;
        private TextBox txt_CodigoFactura;
        private DateTimePicker dateTimePicker1;
        private DataGridView dgv_DetalleFactura;
        private DataGridView dgv_Facturas;
        private ComboBox comboBox3;
        private ComboBox cb_ClienteMayorista;
        private ComboBox cb_ClienteMinorista;
        private TextBox txt_Cantidad;
        private Label lbl_Productos;
        private Label lbl_ClienteMayorista;
        private Label lbl_ClienteMinorista;
        private Label lbl_FechaFactura;
        private Label lbl_CodigoFactura;
        private Label lbl_Cantidad;
        private PictureBox pb_EliminarDetalle;
        private PictureBox pb_ActualizarDetalle;
        private PictureBox pb_AgregarDetalle;
        private PictureBox pb_EliminarFactura;
        private PictureBox pb_EditarFactura;
        private PictureBox pb_AgregarFactura;
    }
}