namespace Vista
{
    partial class Categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorias));
            gb_Categorias = new GroupBox();
            Logo_Empresa = new PictureBox();
            pb_EliminarCategoria = new PictureBox();
            dgv_Categorias = new DataGridView();
            pb_EditarCategoria = new PictureBox();
            pb_AgregarCategoria = new PictureBox();
            txt_DescripcionCategoria = new TextBox();
            txt_NombreCategoria = new TextBox();
            txt_CodigoCategoria = new TextBox();
            lbl_DescripcionCategoria = new Label();
            lbl_NombreCategoria = new Label();
            lbl_CodigoCategoria = new Label();
            gb_Categorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo_Empresa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Categorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_EditarCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarCategoria).BeginInit();
            SuspendLayout();
            // 
            // gb_Categorias
            // 
            gb_Categorias.BackColor = Color.Transparent;
            gb_Categorias.Controls.Add(Logo_Empresa);
            gb_Categorias.Controls.Add(pb_EliminarCategoria);
            gb_Categorias.Controls.Add(dgv_Categorias);
            gb_Categorias.Controls.Add(pb_EditarCategoria);
            gb_Categorias.Controls.Add(pb_AgregarCategoria);
            gb_Categorias.Controls.Add(txt_DescripcionCategoria);
            gb_Categorias.Controls.Add(txt_NombreCategoria);
            gb_Categorias.Controls.Add(txt_CodigoCategoria);
            gb_Categorias.Controls.Add(lbl_DescripcionCategoria);
            gb_Categorias.Controls.Add(lbl_NombreCategoria);
            gb_Categorias.Controls.Add(lbl_CodigoCategoria);
            gb_Categorias.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gb_Categorias.ForeColor = SystemColors.ControlText;
            gb_Categorias.Location = new Point(1, 12);
            gb_Categorias.Name = "gb_Categorias";
            gb_Categorias.Size = new Size(751, 318);
            gb_Categorias.TabIndex = 5;
            gb_Categorias.TabStop = false;
            gb_Categorias.Text = "Administración Categorias";
            
            // 
            // Logo_Empresa
            // 
            Logo_Empresa.BackColor = Color.Transparent;
            Logo_Empresa.BackgroundImage = (Image)resources.GetObject("Logo_Empresa.BackgroundImage");
            Logo_Empresa.BackgroundImageLayout = ImageLayout.Zoom;
            Logo_Empresa.Image = (Image)resources.GetObject("Logo_Empresa.Image");
            Logo_Empresa.Location = new Point(573, 244);
            Logo_Empresa.Name = "Logo_Empresa";
            Logo_Empresa.Size = new Size(135, 68);
            Logo_Empresa.TabIndex = 22;
            Logo_Empresa.TabStop = false;
            // 
            // pb_EliminarCategoria
            // 
            pb_EliminarCategoria.BackColor = Color.Transparent;
            pb_EliminarCategoria.BackgroundImage = (Image)resources.GetObject("pb_EliminarCategoria.BackgroundImage");
            pb_EliminarCategoria.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EliminarCategoria.Cursor = Cursors.Hand;
            pb_EliminarCategoria.Location = new Point(187, 173);
            pb_EliminarCategoria.Name = "pb_EliminarCategoria";
            pb_EliminarCategoria.Size = new Size(49, 52);
            pb_EliminarCategoria.TabIndex = 21;
            pb_EliminarCategoria.TabStop = false;
            pb_EliminarCategoria.Click += pb_EliminarCategoria_Click;
            // 
            // dgv_Categorias
            // 
            dgv_Categorias.BackgroundColor = SystemColors.Info;
            dgv_Categorias.BorderStyle = BorderStyle.Fixed3D;
            dgv_Categorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categorias.GridColor = SystemColors.Desktop;
            dgv_Categorias.Location = new Point(309, 28);
            dgv_Categorias.Name = "dgv_Categorias";
            dgv_Categorias.Size = new Size(399, 196);
            dgv_Categorias.TabIndex = 3;
            dgv_Categorias.CellClick += dgv_Categorias_CellClick;
            // 
            // pb_EditarCategoria
            // 
            pb_EditarCategoria.BackColor = Color.Transparent;
            pb_EditarCategoria.BackgroundImage = (Image)resources.GetObject("pb_EditarCategoria.BackgroundImage");
            pb_EditarCategoria.BackgroundImageLayout = ImageLayout.Zoom;
            pb_EditarCategoria.Cursor = Cursors.Hand;
            pb_EditarCategoria.Location = new Point(107, 172);
            pb_EditarCategoria.Name = "pb_EditarCategoria";
            pb_EditarCategoria.Size = new Size(60, 53);
            pb_EditarCategoria.TabIndex = 20;
            pb_EditarCategoria.TabStop = false;
            pb_EditarCategoria.Click += pb_EditarCategoria_Click;
            // 
            // pb_AgregarCategoria
            // 
            pb_AgregarCategoria.BackColor = Color.Transparent;
            pb_AgregarCategoria.BackgroundImage = (Image)resources.GetObject("pb_AgregarCategoria.BackgroundImage");
            pb_AgregarCategoria.BackgroundImageLayout = ImageLayout.Zoom;
            pb_AgregarCategoria.Cursor = Cursors.Hand;
            pb_AgregarCategoria.Image = (Image)resources.GetObject("pb_AgregarCategoria.Image");
            pb_AgregarCategoria.Location = new Point(38, 172);
            pb_AgregarCategoria.Name = "pb_AgregarCategoria";
            pb_AgregarCategoria.Size = new Size(49, 52);
            pb_AgregarCategoria.TabIndex = 19;
            pb_AgregarCategoria.TabStop = false;
            pb_AgregarCategoria.Click += pb_AgregarCategoria_Click;
            // 
            // txt_DescripcionCategoria
            // 
            txt_DescripcionCategoria.BackColor = SystemColors.ActiveCaption;
            txt_DescripcionCategoria.ForeColor = Color.WhiteSmoke;
            txt_DescripcionCategoria.Location = new Point(118, 122);
            txt_DescripcionCategoria.Name = "txt_DescripcionCategoria";
            txt_DescripcionCategoria.Size = new Size(136, 29);
            txt_DescripcionCategoria.TabIndex = 18;
            // 
            // txt_NombreCategoria
            // 
            txt_NombreCategoria.BackColor = SystemColors.ActiveCaption;
            txt_NombreCategoria.ForeColor = Color.WhiteSmoke;
            txt_NombreCategoria.Location = new Point(118, 87);
            txt_NombreCategoria.Name = "txt_NombreCategoria";
            txt_NombreCategoria.Size = new Size(136, 29);
            txt_NombreCategoria.TabIndex = 17;
            // 
            // txt_CodigoCategoria
            // 
            txt_CodigoCategoria.BackColor = SystemColors.ActiveCaption;
            txt_CodigoCategoria.ForeColor = Color.WhiteSmoke;
            txt_CodigoCategoria.Location = new Point(118, 52);
            txt_CodigoCategoria.Name = "txt_CodigoCategoria";
            txt_CodigoCategoria.Size = new Size(136, 29);
            txt_CodigoCategoria.TabIndex = 16;
            // 
            // lbl_DescripcionCategoria
            // 
            lbl_DescripcionCategoria.AutoSize = true;
            lbl_DescripcionCategoria.BackColor = Color.Transparent;
            lbl_DescripcionCategoria.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold);
            lbl_DescripcionCategoria.ForeColor = Color.Black;
            lbl_DescripcionCategoria.Location = new Point(15, 122);
            lbl_DescripcionCategoria.Name = "lbl_DescripcionCategoria";
            lbl_DescripcionCategoria.Size = new Size(97, 19);
            lbl_DescripcionCategoria.TabIndex = 15;
            lbl_DescripcionCategoria.Text = "Descripción";
            // 
            // lbl_NombreCategoria
            // 
            lbl_NombreCategoria.AutoSize = true;
            lbl_NombreCategoria.BackColor = Color.Transparent;
            lbl_NombreCategoria.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold);
            lbl_NombreCategoria.ForeColor = Color.Black;
            lbl_NombreCategoria.Location = new Point(15, 87);
            lbl_NombreCategoria.Name = "lbl_NombreCategoria";
            lbl_NombreCategoria.Size = new Size(72, 19);
            lbl_NombreCategoria.TabIndex = 14;
            lbl_NombreCategoria.Text = "Nombre";
            // 
            // lbl_CodigoCategoria
            // 
            lbl_CodigoCategoria.AutoSize = true;
            lbl_CodigoCategoria.BackColor = Color.Transparent;
            lbl_CodigoCategoria.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold);
            lbl_CodigoCategoria.ForeColor = Color.Black;
            lbl_CodigoCategoria.Location = new Point(15, 52);
            lbl_CodigoCategoria.Name = "lbl_CodigoCategoria";
            lbl_CodigoCategoria.Size = new Size(63, 19);
            lbl_CodigoCategoria.TabIndex = 13;
            lbl_CodigoCategoria.Text = "Codigo";
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(752, 342);
            Controls.Add(gb_Categorias);
            ForeColor = SystemColors.ControlLight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Categorias";
            Text = "Categorias";
            Load += Categorias_Load;
            gb_Categorias.ResumeLayout(false);
            gb_Categorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo_Empresa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EliminarCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Categorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_EditarCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_AgregarCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Categorias;
        private PictureBox pb_EliminarCategoria;
        private DataGridView dgv_Categorias;
        private PictureBox pb_EditarCategoria;
        private PictureBox pb_AgregarCategoria;
        private TextBox txt_DescripcionCategoria;
        private TextBox txt_NombreCategoria;
        private TextBox txt_CodigoCategoria;
        private Label lbl_DescripcionCategoria;
        private Label lbl_NombreCategoria;
        private Label lbl_CodigoCategoria;
        private PictureBox Logo_Empresa;
    }
}
