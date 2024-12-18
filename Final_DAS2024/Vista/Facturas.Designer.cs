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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturas));
            gb_Facturacion = new GroupBox();
            pb_ProductoSeleccionado = new PictureBox();
            pb_EliminarDetalle = new PictureBox();
            pb_ActualizarDetalle = new PictureBox();
            pb_AgregarDetalle = new PictureBox();
            pb_EliminarFactura = new PictureBox();
            pb_AgregarFactura = new PictureBox();
            lbl_Cantidad = new Label();
            txt_Cantidad = new TextBox();
            lbl_Productos = new Label();
            lbl_ClienteMayorista = new Label();
            lbl_ClienteMinorista = new Label();
            lbl_CodigoFactura = new Label();
            txt_CodigoFactura = new TextBox();
            dgv_DetalleFactura = new DataGridView();
            dgv_Facturas = new DataGridView();
            cb_Productos = new ComboBox();
            cb_ClienteMayorista = new ComboBox();
            cb_ClienteMinorista = new ComboBox();
            notificacionesFacturas = new NotifyIcon(components);
            gb_Facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ProductoSeleccionado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_ActualizarDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DetalleFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Facturas).BeginInit();
            SuspendLayout();
            // 
            // gb_Facturacion
            // 
            gb_Facturacion.Controls.Add(pb_ProductoSeleccionado);
            gb_Facturacion.Controls.Add(pb_EliminarDetalle);
            gb_Facturacion.Controls.Add(pb_ActualizarDetalle);
            gb_Facturacion.Controls.Add(pb_AgregarDetalle);
            gb_Facturacion.Controls.Add(pb_EliminarFactura);
            gb_Facturacion.Controls.Add(pb_AgregarFactura);
            gb_Facturacion.Controls.Add(lbl_Cantidad);
            gb_Facturacion.Controls.Add(txt_Cantidad);
            gb_Facturacion.Controls.Add(lbl_Productos);
            gb_Facturacion.Controls.Add(lbl_ClienteMayorista);
            gb_Facturacion.Controls.Add(lbl_ClienteMinorista);
            gb_Facturacion.Controls.Add(lbl_CodigoFactura);
            gb_Facturacion.Controls.Add(txt_CodigoFactura);
            gb_Facturacion.Controls.Add(dgv_DetalleFactura);
            gb_Facturacion.Controls.Add(dgv_Facturas);
            gb_Facturacion.Controls.Add(cb_Productos);
            gb_Facturacion.Controls.Add(cb_ClienteMayorista);
            gb_Facturacion.Controls.Add(cb_ClienteMinorista);
            gb_Facturacion.Location = new Point(0, 12);
            gb_Facturacion.Name = "gb_Facturacion";
            gb_Facturacion.Size = new Size(995, 585);
            gb_Facturacion.TabIndex = 0;
            gb_Facturacion.TabStop = false;
            gb_Facturacion.Text = "Generador de Facturas";
            // 
            // pb_ProductoSeleccionado
            // 
            pb_ProductoSeleccionado.Image = Properties.Resources.logo_fig_kart_01__1_;
            pb_ProductoSeleccionado.Location = new Point(10, 365);
            pb_ProductoSeleccionado.Name = "pb_ProductoSeleccionado";
            pb_ProductoSeleccionado.Size = new Size(259, 197);
            pb_ProductoSeleccionado.SizeMode = PictureBoxSizeMode.Zoom;
            pb_ProductoSeleccionado.TabIndex = 33;
            pb_ProductoSeleccionado.TabStop = false;
            // 
            // pb_EliminarDetalle
            // 
            pb_EliminarDetalle.BackColor = Color.Transparent;
            pb_EliminarDetalle.BackgroundImage = (Image)resources.GetObject("pb_EliminarDetalle.BackgroundImage");
            pb_EliminarDetalle.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EliminarDetalle.Cursor = Cursors.Hand;
            pb_EliminarDetalle.Location = new Point(841, 414);
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
            pb_ActualizarDetalle.Location = new Point(841, 363);
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
            pb_AgregarDetalle.Location = new Point(841, 319);
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
            pb_EliminarFactura.Location = new Point(841, 98);
            pb_EliminarFactura.Name = "pb_EliminarFactura";
            pb_EliminarFactura.Size = new Size(49, 36);
            pb_EliminarFactura.TabIndex = 29;
            pb_EliminarFactura.TabStop = false;
            pb_EliminarFactura.Click += pb_EliminarFactura_Click;
            // 
            // pb_AgregarFactura
            // 
            pb_AgregarFactura.BackColor = Color.Transparent;
            pb_AgregarFactura.BackgroundImage = (Image)resources.GetObject("pb_AgregarFactura.BackgroundImage");
            pb_AgregarFactura.BackgroundImageLayout = ImageLayout.Zoom;
            pb_AgregarFactura.Cursor = Cursors.Hand;
            pb_AgregarFactura.Image = (Image)resources.GetObject("pb_AgregarFactura.Image");
            pb_AgregarFactura.Location = new Point(841, 56);
            pb_AgregarFactura.Name = "pb_AgregarFactura";
            pb_AgregarFactura.Size = new Size(49, 36);
            pb_AgregarFactura.TabIndex = 27;
            pb_AgregarFactura.TabStop = false;
            pb_AgregarFactura.Click += pb_AgregarFactura_Click;
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new Point(11, 312);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new Size(55, 15);
            lbl_Cantidad.TabIndex = 21;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new Point(12, 321);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(122, 23);
            txt_Cantidad.TabIndex = 20;
            // 
            // lbl_Productos
            // 
            lbl_Productos.AutoSize = true;
            lbl_Productos.Location = new Point(12, 266);
            lbl_Productos.Name = "lbl_Productos";
            lbl_Productos.Size = new Size(61, 15);
            lbl_Productos.TabIndex = 18;
            lbl_Productos.Text = "Productos";
            // 
            // lbl_ClienteMayorista
            // 
            lbl_ClienteMayorista.AutoSize = true;
            lbl_ClienteMayorista.Location = new Point(12, 100);
            lbl_ClienteMayorista.Name = "lbl_ClienteMayorista";
            lbl_ClienteMayorista.Size = new Size(99, 15);
            lbl_ClienteMayorista.TabIndex = 17;
            lbl_ClienteMayorista.Text = "Cliente Mayorista";
            // 
            // lbl_ClienteMinorista
            // 
            lbl_ClienteMinorista.AutoSize = true;
            lbl_ClienteMinorista.Location = new Point(12, 60);
            lbl_ClienteMinorista.Name = "lbl_ClienteMinorista";
            lbl_ClienteMinorista.Size = new Size(97, 15);
            lbl_ClienteMinorista.TabIndex = 16;
            lbl_ClienteMinorista.Text = "Cliente Minorista";
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
            // dgv_DetalleFactura
            // 
            dgv_DetalleFactura.BackgroundColor = SystemColors.Info;
            dgv_DetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DetalleFactura.Location = new Point(346, 276);
            dgv_DetalleFactura.Name = "dgv_DetalleFactura";
            dgv_DetalleFactura.Size = new Size(470, 234);
            dgv_DetalleFactura.TabIndex = 11;
            dgv_DetalleFactura.CellClick += dgv_DetalleFactura_CellClick;
            // 
            // dgv_Facturas
            // 
            dgv_Facturas.BackgroundColor = SystemColors.Info;
            dgv_Facturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Facturas.Location = new Point(346, 20);
            dgv_Facturas.Name = "dgv_Facturas";
            dgv_Facturas.Size = new Size(470, 221);
            dgv_Facturas.TabIndex = 10;
            dgv_Facturas.CellClick += dgv_Facturas_CellClick;
            // 
            // cb_Productos
            // 
            cb_Productos.FormattingEnabled = true;
            cb_Productos.Location = new Point(13, 276);
            cb_Productos.Name = "cb_Productos";
            cb_Productos.Size = new Size(121, 23);
            cb_Productos.TabIndex = 9;
            // 
            // cb_ClienteMayorista
            // 
            cb_ClienteMayorista.FormattingEnabled = true;
            cb_ClienteMayorista.Location = new Point(12, 113);
            cb_ClienteMayorista.Name = "cb_ClienteMayorista";
            cb_ClienteMayorista.Size = new Size(165, 23);
            cb_ClienteMayorista.TabIndex = 8;
            // 
            // cb_ClienteMinorista
            // 
            cb_ClienteMinorista.FormattingEnabled = true;
            cb_ClienteMinorista.Location = new Point(13, 74);
            cb_ClienteMinorista.Name = "cb_ClienteMinorista";
            cb_ClienteMinorista.Size = new Size(165, 23);
            cb_ClienteMinorista.TabIndex = 7;
            // 
            // notificacionesFacturas
            // 
            notificacionesFacturas.Icon = (Icon)resources.GetObject("notificacionesFacturas.Icon");
            notificacionesFacturas.Text = "notifyIcon1";
            notificacionesFacturas.Visible = true;
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(991, 620);
            Controls.Add(gb_Facturacion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Facturas";
            Text = "Facturas";
            Load += Facturas_Load;
            gb_Facturacion.ResumeLayout(false);
            gb_Facturacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ProductoSeleccionado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_ActualizarDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_DetalleFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Facturas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Facturacion;
        private TextBox txt_CodigoFactura;
        private DataGridView dgv_DetalleFactura;
        private DataGridView dgv_Facturas;
        private ComboBox cb_Productos;
        private ComboBox cb_ClienteMayorista;
        private ComboBox cb_ClienteMinorista;
        private TextBox txt_Cantidad;
        private Label lbl_Productos;
        private Label lbl_ClienteMayorista;
        private Label lbl_ClienteMinorista;
        private Label lbl_CodigoFactura;
        private Label lbl_Cantidad;
        private PictureBox pb_EliminarDetalle;
        private PictureBox pb_ActualizarDetalle;
        private PictureBox pb_AgregarDetalle;
        private PictureBox pb_EliminarFactura;
        private PictureBox pb_AgregarFactura;
        private PictureBox pb_ProductoSeleccionado;
        private NotifyIcon notificacionesFacturas;
    }
}