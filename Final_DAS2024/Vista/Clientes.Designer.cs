namespace Vista
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            gb_Clientes = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            dgv_ClientesMayoristas = new DataGridView();
            Logo_Empresa = new PictureBox();
            pb_EliminarCliente = new PictureBox();
            pb_EditarCliente = new PictureBox();
            pb_AgregarCLiente = new PictureBox();
            dgv_Clientes = new DataGridView();
            rtxt_Descripcion = new RichTextBox();
            txt_Contacto = new TextBox();
            txt_Documento = new TextBox();
            txt_Codigo = new TextBox();
            txt_NombreCliente = new TextBox();
            lbl_Descripcion = new Label();
            lbl_Contacto = new Label();
            lbl_Documento = new Label();
            lbl_Codigo = new Label();
            lbl_NombreCLiente = new Label();
            chkb_ClienteMayorista = new CheckBox();
            gb_Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ClientesMayoristas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo_Empresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EditarCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarCLiente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Clientes).BeginInit();
            SuspendLayout();
            // 
            // gb_Clientes
            // 
            gb_Clientes.Controls.Add(label2);
            gb_Clientes.Controls.Add(label1);
            gb_Clientes.Controls.Add(dgv_ClientesMayoristas);
            gb_Clientes.Controls.Add(Logo_Empresa);
            gb_Clientes.Controls.Add(pb_EliminarCliente);
            gb_Clientes.Controls.Add(pb_EditarCliente);
            gb_Clientes.Controls.Add(pb_AgregarCLiente);
            gb_Clientes.Controls.Add(dgv_Clientes);
            gb_Clientes.Controls.Add(rtxt_Descripcion);
            gb_Clientes.Controls.Add(txt_Contacto);
            gb_Clientes.Controls.Add(txt_Documento);
            gb_Clientes.Controls.Add(txt_Codigo);
            gb_Clientes.Controls.Add(txt_NombreCliente);
            gb_Clientes.Controls.Add(lbl_Descripcion);
            gb_Clientes.Controls.Add(lbl_Contacto);
            gb_Clientes.Controls.Add(lbl_Documento);
            gb_Clientes.Controls.Add(lbl_Codigo);
            gb_Clientes.Controls.Add(lbl_NombreCLiente);
            gb_Clientes.Controls.Add(chkb_ClienteMayorista);
            gb_Clientes.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_Clientes.ImeMode = ImeMode.NoControl;
            gb_Clientes.Location = new Point(1, 22);
            gb_Clientes.Name = "gb_Clientes";
            gb_Clientes.Size = new Size(1343, 457);
            gb_Clientes.TabIndex = 0;
            gb_Clientes.TabStop = false;
            gb_Clientes.Text = "Administración Clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MediumBlue;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(235, 426);
            label2.Name = "label2";
            label2.Size = new Size(148, 17);
            label2.TabIndex = 29;
            label2.Text = "CLIENTES MINORISTAS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MediumBlue;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(934, 426);
            label1.Name = "label1";
            label1.Size = new Size(150, 17);
            label1.TabIndex = 28;
            label1.Text = "CLIENTES MAYORISTAS";
            // 
            // dgv_ClientesMayoristas
            // 
            dgv_ClientesMayoristas.BackgroundColor = SystemColors.Info;
            dgv_ClientesMayoristas.BorderStyle = BorderStyle.Fixed3D;
            dgv_ClientesMayoristas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ClientesMayoristas.Location = new Point(648, 212);
            dgv_ClientesMayoristas.Name = "dgv_ClientesMayoristas";
            dgv_ClientesMayoristas.Size = new Size(661, 211);
            dgv_ClientesMayoristas.TabIndex = 27;
            dgv_ClientesMayoristas.CellClick += dgv_ClientesMayoristas_CellClick;
            // 
            // Logo_Empresa
            // 
            Logo_Empresa.BackColor = Color.Transparent;
            Logo_Empresa.BackgroundImage = (Image)resources.GetObject("Logo_Empresa.BackgroundImage");
            Logo_Empresa.BackgroundImageLayout = ImageLayout.Zoom;
            Logo_Empresa.Image = (Image)resources.GetObject("Logo_Empresa.Image");
            Logo_Empresa.Location = new Point(1160, 24);
            Logo_Empresa.Name = "Logo_Empresa";
            Logo_Empresa.Size = new Size(149, 80);
            Logo_Empresa.TabIndex = 26;
            Logo_Empresa.TabStop = false;
            // 
            // pb_EliminarCliente
            // 
            pb_EliminarCliente.BackColor = Color.Transparent;
            pb_EliminarCliente.BackgroundImage = (Image)resources.GetObject("pb_EliminarCliente.BackgroundImage");
            pb_EliminarCliente.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EliminarCliente.Cursor = Cursors.Hand;
            pb_EliminarCliente.Location = new Point(1007, 56);
            pb_EliminarCliente.Name = "pb_EliminarCliente";
            pb_EliminarCliente.Size = new Size(49, 52);
            pb_EliminarCliente.TabIndex = 25;
            pb_EliminarCliente.TabStop = false;
            pb_EliminarCliente.Click += pb_EliminarCliente_Click;
            // 
            // pb_EditarCliente
            // 
            pb_EditarCliente.BackColor = Color.Transparent;
            pb_EditarCliente.BackgroundImage = (Image)resources.GetObject("pb_EditarCliente.BackgroundImage");
            pb_EditarCliente.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EditarCliente.Cursor = Cursors.Hand;
            pb_EditarCliente.Location = new Point(952, 114);
            pb_EditarCliente.Name = "pb_EditarCliente";
            pb_EditarCliente.Size = new Size(49, 53);
            pb_EditarCliente.TabIndex = 24;
            pb_EditarCliente.TabStop = false;
            pb_EditarCliente.Click += pb_EditarCliente_Click;
            // 
            // pb_AgregarCLiente
            // 
            pb_AgregarCLiente.BackColor = Color.Transparent;
            pb_AgregarCLiente.BackgroundImage = (Image)resources.GetObject("pb_AgregarCLiente.BackgroundImage");
            pb_AgregarCLiente.BackgroundImageLayout = ImageLayout.Zoom;
            pb_AgregarCLiente.Cursor = Cursors.Hand;
            pb_AgregarCLiente.Image = (Image)resources.GetObject("pb_AgregarCLiente.Image");
            pb_AgregarCLiente.Location = new Point(952, 56);
            pb_AgregarCLiente.Name = "pb_AgregarCLiente";
            pb_AgregarCLiente.Size = new Size(49, 52);
            pb_AgregarCLiente.TabIndex = 23;
            pb_AgregarCLiente.TabStop = false;
            pb_AgregarCLiente.Click += pb_AgregarCLiente_Click;
            // 
            // dgv_Clientes
            // 
            dgv_Clientes.BackgroundColor = SystemColors.Info;
            dgv_Clientes.BorderStyle = BorderStyle.Fixed3D;
            dgv_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Clientes.Location = new Point(24, 212);
            dgv_Clientes.Name = "dgv_Clientes";
            dgv_Clientes.Size = new Size(594, 211);
            dgv_Clientes.TabIndex = 12;
            dgv_Clientes.CellClick += dgv_Clientes_CellClick;
            // 
            // rtxt_Descripcion
            // 
            rtxt_Descripcion.BackColor = SystemColors.ActiveBorder;
            rtxt_Descripcion.Location = new Point(480, 123);
            rtxt_Descripcion.Name = "rtxt_Descripcion";
            rtxt_Descripcion.Size = new Size(328, 47);
            rtxt_Descripcion.TabIndex = 11;
            rtxt_Descripcion.Text = "";
            // 
            // txt_Contacto
            // 
            txt_Contacto.BackColor = SystemColors.ActiveBorder;
            txt_Contacto.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            txt_Contacto.Location = new Point(700, 89);
            txt_Contacto.MaxLength = 13;
            txt_Contacto.Name = "txt_Contacto";
            txt_Contacto.Size = new Size(108, 25);
            txt_Contacto.TabIndex = 9;
            // 
            // txt_Documento
            // 
            txt_Documento.BackColor = SystemColors.ActiveBorder;
            txt_Documento.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            txt_Documento.Location = new Point(673, 55);
            txt_Documento.MaxLength = 8;
            txt_Documento.Name = "txt_Documento";
            txt_Documento.Size = new Size(135, 25);
            txt_Documento.TabIndex = 8;
            // 
            // txt_Codigo
            // 
            txt_Codigo.BackColor = SystemColors.ActiveBorder;
            txt_Codigo.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            txt_Codigo.Location = new Point(480, 89);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(108, 25);
            txt_Codigo.TabIndex = 7;
            // 
            // txt_NombreCliente
            // 
            txt_NombreCliente.BackColor = SystemColors.ActiveBorder;
            txt_NombreCliente.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            txt_NombreCliente.Location = new Point(480, 55);
            txt_NombreCliente.Name = "txt_NombreCliente";
            txt_NombreCliente.Size = new Size(135, 25);
            txt_NombreCliente.TabIndex = 6;
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Descripcion.Location = new Point(339, 123);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(87, 19);
            lbl_Descripcion.TabIndex = 5;
            lbl_Descripcion.Text = "Descripción";
            // 
            // lbl_Contacto
            // 
            lbl_Contacto.AutoSize = true;
            lbl_Contacto.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Contacto.Location = new Point(814, 89);
            lbl_Contacto.Name = "lbl_Contacto";
            lbl_Contacto.Size = new Size(69, 19);
            lbl_Contacto.TabIndex = 4;
            lbl_Contacto.Text = "Contacto";
            // 
            // lbl_Documento
            // 
            lbl_Documento.AutoSize = true;
            lbl_Documento.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Documento.Location = new Point(822, 55);
            lbl_Documento.Name = "lbl_Documento";
            lbl_Documento.Size = new Size(34, 19);
            lbl_Documento.TabIndex = 3;
            lbl_Documento.Text = "DNI";
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_Codigo.Location = new Point(339, 89);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(108, 19);
            lbl_Codigo.TabIndex = 2;
            lbl_Codigo.Text = "Codigo Cliente";
            // 
            // lbl_NombreCLiente
            // 
            lbl_NombreCLiente.AutoSize = true;
            lbl_NombreCLiente.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            lbl_NombreCLiente.Location = new Point(339, 55);
            lbl_NombreCLiente.Name = "lbl_NombreCLiente";
            lbl_NombreCLiente.Size = new Size(135, 19);
            lbl_NombreCLiente.TabIndex = 1;
            lbl_NombreCLiente.Text = "Nombre Completo";
            // 
            // chkb_ClienteMayorista
            // 
            chkb_ClienteMayorista.AutoSize = true;
            chkb_ClienteMayorista.BackColor = Color.Transparent;
            chkb_ClienteMayorista.Font = new Font("Microsoft YaHei", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkb_ClienteMayorista.ForeColor = SystemColors.HotTrack;
            chkb_ClienteMayorista.Location = new Point(24, 54);
            chkb_ClienteMayorista.Name = "chkb_ClienteMayorista";
            chkb_ClienteMayorista.Size = new Size(109, 23);
            chkb_ClienteMayorista.TabIndex = 0;
            chkb_ClienteMayorista.Text = "MAYORISTA";
            chkb_ClienteMayorista.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LawnGreen;
            ClientSize = new Size(1339, 506);
            Controls.Add(gb_Clientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            gb_Clientes.ResumeLayout(false);
            gb_Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ClientesMayoristas).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo_Empresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EditarCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarCLiente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Clientes;
        private TextBox txt_Contacto;
        private TextBox txt_Documento;
        private TextBox txt_Codigo;
        private TextBox txt_NombreCliente;
        private Label lbl_Descripcion;
        private Label lbl_Contacto;
        private Label lbl_Documento;
        private Label lbl_Codigo;
        private Label lbl_NombreCLiente;
        private CheckBox chkb_ClienteMayorista;
        private DataGridView dgv_Clientes;
        private RichTextBox rtxt_Descripcion;
        private PictureBox Logo_Empresa;
        private PictureBox pb_EliminarCliente;
        private PictureBox pb_EditarCliente;
        private PictureBox pb_AgregarCLiente;
        private DataGridView dgv_ClientesMayoristas;
        private Label label2;
        private Label label1;
    }
}