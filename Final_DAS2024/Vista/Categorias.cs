using Controladora;
using Modelo;

namespace Vista
{
    public partial class Categorias : Form
    {
        ControladoraCategorias controladoraCategorias;
        public Categorias()
        {
            InitializeComponent();
            controladoraCategorias = new ControladoraCategorias();
            RefrescarVista();
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            RefrescarVista();
        }

        private void pb_AgregarCategoria_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Categoria categoria = new Categoria();

                categoria.Codigo = txt_CodigoCategoria.Text;
                categoria.Nombre = txt_NombreCategoria.Text;
                categoria.Descripcion = txt_DescripcionCategoria.Text;

                if (controladoraCategorias.CrearCategoria(categoria))
                {
                    MessageBox.Show("La categoria  " + categoria.Nombre + " se creó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La categoria  " + categoria.Nombre + " ya existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            RefrescarVista();
        }
        private void pb_EditarCategoria_Click(object sender, EventArgs e)
        {

            if (dgv_Categorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Categoria? categoria = dgv_Categorias.SelectedRows[0].DataBoundItem as Categoria;

            txt_CodigoCategoria.Enabled = false;

            if (ValidarCampos())
            {
                categoria.Codigo = txt_CodigoCategoria.Text;
                categoria.Nombre = txt_NombreCategoria.Text;
                categoria.Descripcion = txt_DescripcionCategoria.Text;

                if (controladoraCategorias.ModificarCategoria(categoria))
                {
                    MessageBox.Show("La categoria  " + categoria.Nombre + " se editó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La categoria  " + categoria.Nombre + " no se editó.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            txt_CodigoCategoria.Enabled = true;

            RefrescarVista();
        }

        private void pb_EliminarCategoria_Click(object sender, EventArgs e)
        {

            if (dgv_Categorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una categoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Categoria? categoria = dgv_Categorias.SelectedRows[0].DataBoundItem as Categoria;


            if (controladoraCategorias.EliminarCategoria(categoria))
            {
                MessageBox.Show("La categoria  " + categoria.Nombre + " se eliminó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La categoria  " + categoria.Nombre + " no se eliminó.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefrescarVista();
        }


        private void dgv_Categorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Seleccion = dgv_Categorias.Rows[e.RowIndex];

                if (Seleccion != null)
                {
                    txt_CodigoCategoria.Enabled = false;
                    var categoria = Seleccion.DataBoundItem as Categoria;

                    txt_CodigoCategoria.Text = categoria.Codigo.ToString();
                    txt_NombreCategoria.Text = categoria.Nombre.ToString();
                    txt_DescripcionCategoria.Text = categoria.Descripcion.ToString();
                }
            }
            txt_CodigoCategoria.Enabled = true;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_CodigoCategoria.Text))
            {
                MessageBox.Show("El campo codigo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_NombreCategoria.Text))
            {
                MessageBox.Show("El campo codigo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_DescripcionCategoria.Text))
            {
                MessageBox.Show("El campo codigo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter presionado no es un número y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Verifica si el carácter presionado no es un número y no es la tecla de retroceso
        private void SoloDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        // Verifica si el carácter presionado no es un número, letra y no es la tecla de retroceso
        private void NoCaracterEspecial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void RefrescarVista()
        {
            dgv_Categorias.AutoGenerateColumns = false;
            dgv_Categorias.DataSource = controladoraCategorias.ConsultarCategorias();
            dgv_Categorias.Columns.Clear();

            dgv_Categorias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Codigo", DataPropertyName = "Codigo" });
            dgv_Categorias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgv_Categorias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripción", DataPropertyName = "Descripcion" });


            txt_CodigoCategoria.Text = string.Empty;
            txt_NombreCategoria.Text = string.Empty;
            txt_DescripcionCategoria.Text = string.Empty;
        }    
    }
}
