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
    public partial class Facturas : Form
    {
        private ControladoraFacturas controladoraFacturas;
        public Facturas()
        {
            controladoraFacturas = new ControladoraFacturas();
            InitializeComponent();
            ActualizarVistaFacturas();
           ActualizarVistaDetalleFacturas();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            ActualizarVistaFacturas();
        }

        private void pb_AgregarFactura_Click(object sender, EventArgs e)
        {
            if (ValidarCamposFactura())
            {
                Factura factura = new Factura();
                factura.NumeroFactura = Convert.ToInt32(txt_CodigoFactura.Text);
                factura.Fecha =Convert.ToDateTime(dtp_FechaFactura.Text);
                factura.Cliente = cb_ClienteMinorista.SelectedItem as Cliente;
                if (controladoraFacturas.AgregarFactura(factura))
                {
                    MessageBox.Show("La factura generó exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La factura ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            ActualizarVistaFacturas();
        }

        private void pb_EditarFactura_Click(object sender, EventArgs e)
        {

        }

        private void pb_EliminarFactura_Click(object sender, EventArgs e)
        {

        }

        private void pb_AgregarDetalle_Click(object sender, EventArgs e)
        {
            if(dgv_Facturas.SelectedRows.Count > 0)
            {
                Factura facturaSeleccionada = dgv_Facturas.SelectedRows[0].DataBoundItem as Factura;

                if (ValidarCamposDetallesFactura())
                {
                    Producto productoSeleccionado = cb_Productos.SelectedItem as Producto;
                    if (ControlarStock(productoSeleccionado))
                    {
                        DetalleFactura detalleFactura = new DetalleFactura();
                        detalleFactura.Producto = productoSeleccionado;
                        detalleFactura.Cantidad = Convert.ToInt32(txt_Cantidad.Text);
                        detalleFactura.PrecioUnitario = productoSeleccionado.Precio;
                        if (controladoraFacturas.RegistrarDetalle(facturaSeleccionada, detalleFactura))
                        {
                            MessageBox.Show("El detalle se generó exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El detalle no se generó", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            
          
        }

        private void pb_EliminarDetalle_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Facturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Seleccion = dgv_Facturas.Rows[e.RowIndex];
                if (Seleccion != null)
                {
                    txt_CodigoFactura.Enabled = false;
                    

                    var factura = controladoraFacturas.ConsultarFacturas().FirstOrDefault(x => x.NumeroFactura == Convert.ToInt32(dgv_Facturas.Rows[e.RowIndex].Cells[0].Value));
                    
                    txt_CodigoFactura.Text = factura.NumeroFactura.ToString();
                    dtp_FechaFactura.Value = factura.Fecha;

                    switch (controladoraFacturas.ControlarTipoCliente(factura))
                    {
                        case true:
                            cb_ClienteMayorista.Enabled = false;
                            cb_ClienteMinorista.SelectedItem=factura.Cliente;
                            break;
                       
                        case false:
                            cb_ClienteMinorista.Enabled = false;
                            cb_ClienteMayorista.SelectedItem = factura.Cliente;
                            break;
                    }
                    

                }
            }
        }

        private bool ValidarCamposFactura() 
        {
            if (string.IsNullOrWhiteSpace(txt_CodigoFactura.Text))
            {
                MessageBox.Show("El campo Numero de Factura no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cb_ClienteMayorista.SelectedItem==null && cb_ClienteMinorista.SelectedItem==null)
            {
                MessageBox.Show("Debe seleccionar un cliente para facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool ValidarCamposDetallesFactura()
        {
            if (!int.TryParse(txt_Cantidad.Text, out int Cantidad) || Convert.ToInt32(txt_Cantidad.Text) <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cb_Productos.SelectedItem == null )
            {
                MessageBox.Show("Debe seleccionar un producto a facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true ;
        }
        private bool ControlarStock(Producto producto)
        {
            if (Convert.ToInt32(txt_Cantidad.Text) > producto.Stock)
            {
                MessageBox.Show("El stock del producto seleccionado no satisface la cantidad solicitada.\n El stock disponible es de " + producto.Stock + " unidades.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;   
            }
            else return true;
        }
        
        private void ActualizarVistaFacturas()
        {
            dgv_Facturas.AutoGenerateColumns = false;
            dgv_Facturas.DataSource = controladoraFacturas.ConsultarFacturas();
            dgv_Facturas.Columns.Clear();

            dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Numero Factura", DataPropertyName = "NumeroFactura" });
            dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha", DataPropertyName = "Fecha" });
            dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cliente", DataPropertyName = "NombreCliente" });
            dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Dni", DataPropertyName = "DniCliente" });
            dgv_Facturas.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Contacto", DataPropertyName = "ContactoCliente" });
            

            cb_ClienteMayorista.DataSource = null;
            cb_ClienteMayorista.DataSource = controladoraFacturas.ConsultarClienteMayorista();
            cb_ClienteMayorista.DisplayMember = "Nombre";

            cb_ClienteMinorista.DataSource = null;
            cb_ClienteMinorista.DataSource = controladoraFacturas.ConsultarClienteMinorista();
            cb_ClienteMinorista.DisplayMember = "Nombre";

        }
        private void ActualizarVistaDetalleFacturas()
        {
            dgv_DetalleFactura.AutoGenerateColumns = false;
            dgv_DetalleFactura.DataSource = controladoraFacturas.ConsultarDetalles();
            dgv_DetalleFactura.Columns.Clear();

            dgv_DetalleFactura.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Producto", DataPropertyName = "NombreProducto" });
            dgv_DetalleFactura.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "PrecioProducto" });
            dgv_DetalleFactura.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Unidades", DataPropertyName = "Cantidad" });
            dgv_DetalleFactura.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Subtotal", DataPropertyName = "Subtotal" });
            
            cb_Productos.DataSource = null;
            cb_Productos.DataSource = controladoraFacturas.ConsultarProductos();
            cb_Productos.DisplayMember = "Nombre";
            txt_Cantidad.Text= string.Empty;
        }
    }
}
