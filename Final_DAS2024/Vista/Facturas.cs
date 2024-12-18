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
                //factura.Fecha =Convert.ToDateTime(dtp_FechaFactura.Text);
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


        private void pb_EliminarFactura_Click(object sender, EventArgs e)
        {
            if (dgv_Facturas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Factura? facturaSeleccionada = dgv_Facturas.SelectedRows[0].DataBoundItem as Factura;

            if (facturaSeleccionada != null && controladoraFacturas.EliminarFactura(facturaSeleccionada))
            {
                MessageBox.Show("La factura se eliminó exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede eliminar la factura seleccionada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            ActualizarVistaFacturas();
        }

        private void pb_AgregarDetalle_Click(object sender, EventArgs e)
        {
            if (dgv_Facturas.SelectedRows.Count > 0)
            {
                Factura? facturaSeleccionada = dgv_Facturas.SelectedRows[0].DataBoundItem as Factura;

                if (ValidarCamposDetallesFactura())
                {
                    Producto? productoSeleccionado = cb_Productos.SelectedItem as Producto;

                    if (productoSeleccionado != null && ControlarStock(productoSeleccionado))
                    {
                        DetalleFactura detalleFactura = new DetalleFactura();
                        detalleFactura.Producto = productoSeleccionado;
                        detalleFactura.Cantidad = Convert.ToInt32(txt_Cantidad.Text);
                        detalleFactura.PrecioUnitario = productoSeleccionado.Precio;

                        if (facturaSeleccionada != null && controladoraFacturas.RegistrarDetalle(facturaSeleccionada, detalleFactura))
                        {
                            MostrarNotificacion("Se agrego el detalle de la factura" + facturaSeleccionada.NumeroFactura + 
                                "\n Detalle: Producto "+detalleFactura.NombreProducto+" - "+detalleFactura.Cantidad+" Unidades - Subtotal= $"+ detalleFactura.Subtotal, "Noticias");
                        }
                        else
                        {
                            MessageBox.Show("El detalle no se generó", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        ActualizarVistaDetalleFacturas(facturaSeleccionada);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una factura.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pb_EliminarDetalle_Click(object sender, EventArgs e)
        {
            Factura? facturaSeleccionada = dgv_Facturas.SelectedRows[0].DataBoundItem as Factura;

            if (dgv_DetalleFactura.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un detalle de la factura " + facturaSeleccionada.NumeroFactura, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DetalleFactura? detalleFacturaSeleccionado = dgv_DetalleFactura.SelectedRows[0].DataBoundItem as DetalleFactura;

            if (detalleFacturaSeleccionado != null && facturaSeleccionada != null && controladoraFacturas.ElimarDetalle(facturaSeleccionada, detalleFacturaSeleccionado))
            {
                MostrarNotificacion("Se ha eliminado el detalle de la factura " + facturaSeleccionada.NumeroFactura, "Noticias");
                ActualizarVistaDetalleFacturas(facturaSeleccionada);
            }
            else
            {
                MessageBox.Show("El detalle no se puede borrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ActualizarVistaFacturas();
            ActualizarVistaDetalleFacturas(facturaSeleccionada);
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
                    //dtp_FechaFactura.Value = factura.Fecha;

                    switch (controladoraFacturas.ControlarTipoCliente(factura))
                    {
                        case true:
                            cb_ClienteMayorista.Enabled = false;
                            cb_ClienteMinorista.SelectedItem = factura.Cliente;
                            break;

                        case false:
                            cb_ClienteMinorista.Enabled = false;
                            cb_ClienteMayorista.SelectedItem = factura.Cliente;
                            break;
                    }
                    ActualizarVistaDetalleFacturas(factura);
                }
            }
        }

        private bool ValidarCamposFactura()
        {

            if (cb_ClienteMayorista.SelectedItem == null && cb_ClienteMinorista.SelectedItem == null)
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
            if (cb_Productos.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto a facturar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
        private void ActualizarVistaDetalleFacturas(Factura factura)
        {
            dgv_DetalleFactura.AutoGenerateColumns = false;
            dgv_DetalleFactura.DataSource = controladoraFacturas.ConsultarDetalles(factura);
            dgv_DetalleFactura.Columns.Clear();

            dgv_DetalleFactura.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Producto", DataPropertyName = "NombreProducto" });
            dgv_DetalleFactura.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "PrecioProducto" });
            dgv_DetalleFactura.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Unidades", DataPropertyName = "Cantidad" });
            dgv_DetalleFactura.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Subtotal", DataPropertyName = "Subtotal" });

            cb_Productos.DataSource = null;
            cb_Productos.DataSource = controladoraFacturas.ConsultarProductos();
            cb_Productos.DisplayMember = "Nombre";
            txt_Cantidad.Text = string.Empty;
        }

        private void dgv_DetalleFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se ha hecho clic en una fila válida (y no en los encabezados)
            if (e.RowIndex >= 0 )
            {
                DataGridViewRow seleccion = dgv_Facturas.Rows[e.RowIndex];

                if (seleccion != null)
                {
                    var detalleSeleccionado = dgv_DetalleFactura.SelectedRows[e.RowIndex].DataBoundItem as DetalleFactura;
                    if (detalleSeleccionado != null && detalleSeleccionado.Producto != null)
                    {
                        var productoDetalle = detalleSeleccionado.Producto.ImagenProducto?.ToString();

                        // Verifica si el path no está vacío o es solo espacio en blanco y si el archivo existe
                        if (!string.IsNullOrWhiteSpace(productoDetalle) && File.Exists(productoDetalle))
                        {
                            // Establece la ruta de la imagen
                            pb_ProductoSeleccionado.ImageLocation = productoDetalle;
                        }
                        else
                        {
                            // Imagen predeterminada en caso de que no haya una imagen válida
                            pb_ProductoSeleccionado.ImageLocation = "C:\\Users\\Ente\\source\\repos\\Final-Das2024\\Final_DAS2024\\Vista\\Properties\\Resources\\logo fig kart-01 (1).png";
                        }
                    }
                    else
                    {
                        // Si Producto o ImagenProducto son nulos, mostrar la imagen predeterminada
                        pb_ProductoSeleccionado.ImageLocation = "C:\\Users\\Ente\\source\\repos\\Final-Das2024\\Final_DAS2024\\Vista\\Properties\\Resources\\logo fig kart-01 (1).png";
                    }
                }
            }
            else
            {
                // Si el índice de la fila no es válido, puedes manejar esto de alguna manera
                MostrarNotificacion("indice de fila erroneo", "error");
            }
        }

        private void MostrarNotificacion(string mensaje, string titulo)
        {
            notificacionesFacturas.BalloonTipTitle = titulo;
            notificacionesFacturas.BalloonTipText = mensaje;
            notificacionesFacturas.BalloonTipIcon = ToolTipIcon.Info;
            notificacionesFacturas.ShowBalloonTip(4000); // Muestra la notificación durante 3 segundos
        }
    }
}
