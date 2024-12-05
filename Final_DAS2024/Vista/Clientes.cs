using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Modelo;

namespace Vista
{
    public partial class Clientes : Form
    {
        ControladoraClientes controladoraClientes;
        public Clientes()
        {
            InitializeComponent();
            controladoraClientes = new ControladoraClientes();
            ActualizarVista();
            txt_Documento.KeyPress += SoloNumeros_KeyPress;
            txt_Contacto.KeyPress += SoloNumeros_KeyPress;
        }

        private void pb_AgregarCLiente_Click(object sender, EventArgs e)
        {
            switch (chkb_ClienteMayorista.Checked)
            {
                case true:

                    if (ValidarCampos())
                    {
                        ClienteMayorista clienteMayorista = new ClienteMayorista();
                        clienteMayorista.Nombre = txt_NombreCliente.Text;
                        clienteMayorista.Codigo = txt_Codigo.Text;
                        clienteMayorista.Dni = Convert.ToInt32(txt_Documento.Text);
                        clienteMayorista.Contacto = Convert.ToInt64(txt_Contacto.Text);
                        clienteMayorista.Descripcion = rtxt_Descripcion.Text;

                        if (controladoraClientes.CrearClienteMayorista(clienteMayorista))
                        {
                            MessageBox.Show("El cliente  " + clienteMayorista.Nombre + " se creó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El cliente  " + clienteMayorista.Nombre + " ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ActualizarVista();
                    break;

                case false:
                    if (ValidarCampos())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Nombre = txt_NombreCliente.Text;
                        cliente.Codigo = txt_Codigo.Text;
                        cliente.Dni = Convert.ToInt32(txt_Documento.Text);
                        cliente.Contacto = Convert.ToInt64(txt_Contacto.Text);
                        cliente.Descripcion = rtxt_Descripcion.Text;

                        if (controladoraClientes.CrearCliente(cliente))
                        {
                            MessageBox.Show("El cliente  " + cliente.Nombre + " se creó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El cliente  " + cliente.Nombre + " ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ActualizarVista();
                    break;
            }
        }

        private void pb_EditarCliente_Click(object sender, EventArgs e)
        {
            switch (chkb_ClienteMayorista.Checked)
            {
                case true:
                    if (dgv_ClientesMayoristas.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un cliente mayorista.", "Error Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClienteMayorista? clienteMayorista = dgv_ClientesMayoristas.SelectedRows[0].DataBoundItem as ClienteMayorista;

                    if (ValidarCampos())
                    {
                        clienteMayorista.Nombre = txt_NombreCliente.Text;
                        clienteMayorista.Codigo = txt_Codigo.Text;
                        clienteMayorista.Dni = Convert.ToInt32(txt_Documento.Text);
                        clienteMayorista.Contacto = Convert.ToInt64(txt_Contacto.Text);
                        clienteMayorista.Descripcion = rtxt_Descripcion.Text;

                        if (controladoraClientes.ModificarClienteMayorista(clienteMayorista))
                        {
                            MessageBox.Show("El cliente  " + clienteMayorista.Nombre + " se modificó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El cliente  " + clienteMayorista.Nombre + " no se puede modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    ActualizarVista();
                    break;

                case false:
                    if (dgv_Clientes.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un cliente.", "Error Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Cliente? cliente = dgv_Clientes.SelectedRows[0].DataBoundItem as Cliente;

                    if (ValidarCampos())
                    {
                        cliente.Nombre = txt_NombreCliente.Text;
                        cliente.Codigo = txt_Codigo.Text;
                        cliente.Dni = Convert.ToInt32(txt_Documento.Text);
                        cliente.Contacto = Convert.ToInt64(txt_Contacto.Text);
                        cliente.Descripcion = rtxt_Descripcion.Text;

                        if (controladoraClientes.ModificarCliente(cliente))
                        {
                            MessageBox.Show("El cliente  " + cliente.Nombre + " se modificó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El cliente  " + cliente.Nombre + " no se puede modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ActualizarVista();
                    break;
            }
        }

        private void pb_EliminarCliente_Click(object sender, EventArgs e)
        {
            switch (chkb_ClienteMayorista.Checked)
            {
                case true:
                    if (dgv_ClientesMayoristas.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un cliente mayorista.", "Error Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClienteMayorista? clienteMayorista = dgv_ClientesMayoristas.SelectedRows[0].DataBoundItem as ClienteMayorista;

                    if (controladoraClientes.EliminarClienteMayorista(clienteMayorista))
                    {
                        MessageBox.Show("El cliente  " + clienteMayorista.Nombre + " se eliminó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El cliente  " + clienteMayorista.Nombre + " no se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ActualizarVista();
                    break;

                case false:
                    if (dgv_Clientes.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un cliente.", "Error Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Cliente? cliente = dgv_Clientes.SelectedRows[0].DataBoundItem as Cliente;

                    if (ValidarCampos())
                    {
                        cliente.Nombre = txt_NombreCliente.Text;
                        cliente.Codigo = txt_Codigo.Text;
                        cliente.Dni = Convert.ToInt32(txt_Documento.Text);
                        cliente.Contacto = Convert.ToInt64(txt_Contacto.Text);
                        cliente.Descripcion = rtxt_Descripcion.Text;

                        if (controladoraClientes.EliminarCliente(cliente))
                        {
                            MessageBox.Show("El cliente  " + cliente.Nombre + " se eliminó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El cliente  " + cliente.Nombre + " no se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ActualizarVista();
                    break;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            ActualizarVista();
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_NombreCliente.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Codigo.Text))
            {
                MessageBox.Show("El campo codigo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Documento.Text))
            {
                MessageBox.Show("El campo DNI no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txt_Documento.Text, out int Documento) || txt_Documento.TextLength < 8)
            {
                MessageBox.Show("El campo DNI debe tener 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Contacto.Text))
            {
                MessageBox.Show("El campo Contacto no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!long.TryParse(txt_Contacto.Text, out long Contacto) || txt_Contacto.TextLength < 11)
            {
                MessageBox.Show("El número de contacto tiene un formato erroneo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ActualizarVista()
        {
            dgv_Clientes.AutoGenerateColumns = false;
            dgv_ClientesMayoristas.AutoGenerateColumns = false;

            dgv_Clientes.DataSource = controladoraClientes.ConsultarClientes();
            dgv_ClientesMayoristas.DataSource = controladoraClientes.ConsultarClientesMayoristas();

            dgv_Clientes.Columns.Clear();
            dgv_ClientesMayoristas.Columns.Clear();

            dgv_Clientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Codigo Cliente", DataPropertyName = "Codigo" });
            dgv_Clientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgv_Clientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Documento", DataPropertyName = "Dni" });
            dgv_Clientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Contacto", DataPropertyName = "Contacto" });
            dgv_Clientes.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripción", DataPropertyName = "Descripcion" });

            dgv_ClientesMayoristas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Codigo Cliente", DataPropertyName = "Codigo" });
            dgv_ClientesMayoristas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgv_ClientesMayoristas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Documento", DataPropertyName = "Dni" });
            dgv_ClientesMayoristas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Contacto", DataPropertyName = "Contacto" });
            dgv_ClientesMayoristas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "% Descuento ", DataPropertyName = "DescuentoMayorista" });
            dgv_ClientesMayoristas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripción", DataPropertyName = "Descripcion" });


            txt_NombreCliente.Text = string.Empty;
            txt_Codigo.Text = string.Empty;
            txt_Contacto.Text = string.Empty;
            rtxt_Descripcion.Text = string.Empty;
            txt_Documento.Text = string.Empty;
            chkb_ClienteMayorista.Checked = false;
            chkb_ClienteMayorista.Enabled = true;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter presionado no es un número y no es la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgv_ClientesMayoristas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Seleccion = dgv_ClientesMayoristas.Rows[e.RowIndex];

                if (Seleccion != null)
                {
                    txt_Codigo.Enabled = false;
                    var mayorista = Seleccion.DataBoundItem as ClienteMayorista;

                    txt_NombreCliente.Text = mayorista.Nombre.ToString();
                    txt_Codigo.Text = mayorista.Codigo.ToString();
                    txt_Documento.Text = mayorista.Dni.ToString();
                    txt_Contacto.Text = mayorista.Contacto.ToString();
                    rtxt_Descripcion.Text = mayorista.Descripcion.ToString();
                    chkb_ClienteMayorista.Checked = true;
                    chkb_ClienteMayorista.Enabled = false;
                }
            }
            chkb_ClienteMayorista.Enabled = true;
        }

        private void dgv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Seleccion = dgv_Clientes.Rows[e.RowIndex];

                if (Seleccion != null)
                {
                    txt_Codigo.Enabled = false;
                    var cliente = Seleccion.DataBoundItem as Cliente;

                    txt_NombreCliente.Text = cliente.Nombre.ToString();
                    txt_Codigo.Text = cliente.Codigo.ToString();
                    txt_Documento.Text = cliente.Dni.ToString();
                    txt_Contacto.Text = cliente.Contacto.ToString();
                    rtxt_Descripcion.Text = cliente.Descripcion.ToString();
                    chkb_ClienteMayorista.Checked = false;
                }
            }
            chkb_ClienteMayorista.Enabled = true;
        }
    }
}
