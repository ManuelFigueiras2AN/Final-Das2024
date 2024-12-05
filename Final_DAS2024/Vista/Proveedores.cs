using Controladora;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Proveedores : Form
    {
        ControladoraProveedores controladoraProveedores;
        public Proveedores()
        {
            InitializeComponent();
            controladoraProveedores = new ControladoraProveedores();
            RefrescarVista();
            txt_ContactoProveedor.KeyPress += SoloNumeros_KeyPress;
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            RefrescarVista();
        }
        private void btn_CrearProveedor_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Codigo=txt_CodigoProveedor.Text;
                proveedor.Nombre = txt_NombreProveedor.Text;
                proveedor.Contacto = Convert.ToInt64(txt_ContactoProveedor.Text);
                proveedor.Descripcion = txt_DescripcionProveedor.Text;
               
                if (controladoraProveedores.CrearProveedor(proveedor))
                {
                    MessageBox.Show("El proveedor  " + proveedor.Nombre + " se creó exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El proveedor  " + proveedor.Nombre + " ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefrescarVista();
            }
        }

        private void btn_EditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgv_Proveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Proveedor? proveedor = dgv_Proveedores.SelectedRows[0].DataBoundItem as Proveedor;
            
            if (ValidarCampos())
            {
                proveedor.Codigo = txt_CodigoProveedor.Text;
                proveedor.Nombre = txt_NombreProveedor.Text;
                proveedor.Contacto = Convert.ToInt64(txt_ContactoProveedor.Text);
                proveedor.Descripcion = txt_DescripcionProveedor.Text;

                if (controladoraProveedores.ModificarProveedor(proveedor))
                {
                    MessageBox.Show("El proveedor  " + proveedor.Nombre + " se editó exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El proveedor  " + proveedor.Nombre + " no se pudo editar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefrescarVista();
            }

        }

        private void btn_EliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgv_Proveedores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Proveedor? proveedor = dgv_Proveedores.SelectedRows[0].DataBoundItem as Proveedor;

            if (controladoraProveedores.EliminarProveedor(proveedor))
            {
                MessageBox.Show("El proveedor  " + proveedor.Nombre + " se eliminó exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El proveedor  " + proveedor.Nombre + " no se pudo eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefrescarVista();
        }

        private void dgv_Proveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Seleccion = dgv_Proveedores.Rows[e.RowIndex];

                if (Seleccion != null)
                {
                    txt_CodigoProveedor.Enabled = false;
                    var proveedor = Seleccion.DataBoundItem as Proveedor;

                    txt_CodigoProveedor.Text = proveedor.Codigo.ToString();
                    txt_NombreProveedor.Text = proveedor.Nombre.ToString();
                    txt_DescripcionProveedor.Text = proveedor.Descripcion.ToString();
                    txt_ContactoProveedor.Text = proveedor.Contacto.ToString();
                }
            }
            
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_CodigoProveedor.Text))
            {
                MessageBox.Show("El campo codigo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_NombreProveedor.Text))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_ContactoProveedor.Text))
            {
                MessageBox.Show("El campo contacto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_DescripcionProveedor.Text))
            {
                MessageBox.Show("El campo descripción no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgv_Proveedores.AutoGenerateColumns = false;
            dgv_Proveedores.DataSource = controladoraProveedores.ConsultarProveedores();
            dgv_Proveedores.Columns.Clear();

            dgv_Proveedores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Codigo", DataPropertyName = "Codigo" });
            dgv_Proveedores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgv_Proveedores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Contacto", DataPropertyName = "Contacto" });
            dgv_Proveedores.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripción", DataPropertyName = "Descripcion" });


            txt_CodigoProveedor.Text = string.Empty;
            txt_NombreProveedor.Text = string.Empty;
            txt_ContactoProveedor.Text = string.Empty;
            txt_DescripcionProveedor.Text= string.Empty;
            txt_CodigoProveedor.Enabled = true;
        }

    }
}
