using Controladora;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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


        private void pb_AgregarProveedor_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Codigo = txt_CodigoProveedor.Text;
                proveedor.Nombre = txt_NombreProveedor.Text;
                proveedor.Contacto = Convert.ToInt64(txt_ContactoProveedor.Text);
                proveedor.Descripcion = rtxt_Descripcion.Text;

                if (clb_Productos.CheckedItems.Count > 0)
                {
                    foreach (var productos in clb_Productos.CheckedItems)
                    {
                        Producto producto = productos as Producto;
                        if (proveedor.AsociarProducto(producto))

                        {
                            MostrarNotificacion("Se agrego " + producto.Nombre + " al catalogo.", "Noticias Catalogo");
                        }
                        else
                        {
                            MostrarNotificacion(producto.Nombre + " ya existe en el  catalogo.", "Noticias Catalogo");
                        }
                    }
                }

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



        private void pb_EditarProveedor_Click(object sender, EventArgs e)
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
                proveedor.Descripcion = rtxt_Descripcion.Text;

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

        private void pb_EliminarProveedor_Click(object sender, EventArgs e)
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
                for (int i = 0; i < clb_Productos.Items.Count; i++)
                {
                    clb_Productos.SetItemChecked(i, false); // Desmarcar todos los elementos
                }

                DataGridViewRow Seleccion = dgv_Proveedores.Rows[e.RowIndex];
                
                if (Seleccion != null)
                {
                    txt_CodigoProveedor.Enabled = false;
                    var proveedor = Seleccion.DataBoundItem as Proveedor;

                    txt_CodigoProveedor.Text = proveedor.Codigo.ToString();
                    txt_NombreProveedor.Text = proveedor.Nombre.ToString();
                    rtxt_Descripcion.Text = proveedor.Descripcion.ToString();
                    txt_ContactoProveedor.Text = proveedor.Contacto.ToString();
                    proveedor.CatalogoProductos = controladoraProveedores.RecuperarProductosProveedor(proveedor);


                    foreach (Producto prod in proveedor.CatalogoProductos)
                    {
                        for (int i = 0; i < clb_Productos.Items.Count; i++)
                        {
                            var item = clb_Productos.Items[i] as Producto;
                            if (item != null && item.CodigoProducto  == prod.CodigoProducto)
                            {
                                clb_Productos.SetItemChecked(i, true);
                            }
                        }
                    }

                    RefrescarVistaCatalogo(proveedor);
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
            if (string.IsNullOrWhiteSpace(rtxt_Descripcion.Text))
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

            cb_Categorias.DataSource = null;
            cb_Categorias.DataSource = controladoraProveedores.CargarCategorias();
            cb_Categorias.DisplayMember = "Nombre";

            clb_Productos.DataSource = null;
            clb_Productos.DataSource = controladoraProveedores.ConsultaPorCategoria(cb_Categorias.SelectedItem as Categoria);
            clb_Productos.DisplayMember = "Nombre";

            txt_CodigoProveedor.Text = string.Empty;
            txt_NombreProveedor.Text = string.Empty;
            txt_ContactoProveedor.Text = string.Empty;
            rtxt_Descripcion.Text = string.Empty;
            txt_CodigoProveedor.Enabled = true;
        }
        private void RefrescarVistaCatalogo(Proveedor proveedor)
        {
            dgv_Productos.AutoGenerateColumns = false;
            dgv_Productos.DataSource = controladoraProveedores.RecuperarProductosProveedor(proveedor);
            dgv_Productos.Columns.Clear();

            dgv_Productos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Codigo", DataPropertyName = "CodigoProducto" });
            dgv_Productos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgv_Productos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "Precio" });
            dgv_Productos.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripción", DataPropertyName = "Descripcion" });

        }

        private void cb_Categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Categorias.SelectedItem != null)
            {
                // Obtener la categoría seleccionada
                var categoriaSeleccionada = cb_Categorias.SelectedItem as Categoria;

                // Actualizar el DataSource del CheckedListBox
                clb_Productos.DataSource = null;  // Limpiar el DataSource anterior
                clb_Productos.DataSource = controladoraProveedores.ConsultaPorCategoria(categoriaSeleccionada);
                clb_Productos.DisplayMember = "Nombre"; // Mostrar el nombre en el CheckedListBox
            }
        }

       

        private void MostrarNotificacion(string mensaje, string titulo)
        {
            notificacion_Catalogo.BalloonTipTitle = titulo;
            notificacion_Catalogo.BalloonTipText = mensaje;
            notificacion_Catalogo.BalloonTipIcon = ToolTipIcon.Info;
            notificacion_Catalogo.ShowBalloonTip(4000); // Muestra la notificación durante 3 segundos
        }


       

        private void pb_AgregarProducto_Click(object sender, EventArgs e)
        {
           

            Proveedor? proveedor = dgv_Proveedores.SelectedRows[0].DataBoundItem as Proveedor;
            Producto? productoSeleccionado = dgv_Productos.SelectedRows[0].DataBoundItem as Producto;

            if (clb_Productos.CheckedItems.Count > 0)
            {
                foreach (var productos in clb_Productos.CheckedItems)
                {
                    Producto producto = productos as Producto;
                    if (proveedor.AsociarProducto(productoSeleccionado))

                    {
                        MostrarNotificacion("Se agrego " + productoSeleccionado.Nombre + " al catalogo.", "Noticias Catalogo");
                    }
                    else
                    {
                        MostrarNotificacion(productoSeleccionado.Nombre + " ya existe en el  catalogo.", "Noticias Catalogo");
                    }
                }
            }


            RefrescarVistaCatalogo(proveedor);
        }

        private void pb_EliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgv_Productos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Proveedor? proveedor = dgv_Proveedores.SelectedRows[0].DataBoundItem as Proveedor;
            Producto? producto = dgv_Productos.SelectedRows[0].DataBoundItem as Producto;

            if (proveedor.DesasociarProducto(producto)) 
            {
              MostrarNotificacion("Se eliminó " + producto.Nombre + " del catalogo.", "Noticias Catalogo");
            }
            else 
            {
                MostrarNotificacion(producto.Nombre + " no existe en el  catalogo.", "Noticias Catalogo");
            }

                
            //RefrescarVistaCatalogo(proveedor);
        }
    }
}
