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
    public partial class Productos : Form
    {
        ControladoraProductos controladoraProductos;
        public Productos()
        {
            InitializeComponent();
            controladoraProductos = new ControladoraProductos();
            ActualizarVista();
            txt_Stock.KeyPress += SoloNumeros_KeyPress;
            txt_StockMinimo.KeyPress += SoloNumeros_KeyPress;
            chk_Importado.CheckedChanged += new EventHandler(ControlarEstadoCbNacionalidad);
            pb_CargarImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }

        
        private void Productos_Load(object sender, EventArgs e)
        {
            ActualizarVista();
        }

        private void pb_AgregarProducto_Click(object sender, EventArgs e)
        {
            switch (chk_Importado.Checked)
            {
                case true:
                    cb_Nacionalidad.Enabled = true;
                    if (ValidarCampos())
                    {
                        ProductoImportado productoImportado = new ProductoImportado();
                        productoImportado.Nombre = txt_Nombre.Text;
                        productoImportado.CodigoProducto = txt_Codigo.Text;
                        productoImportado.Precio = Convert.ToDecimal(txt_Precio.Text);
                        productoImportado.Stock = Convert.ToInt32(txt_Stock.Text);
                        productoImportado.StockMinimo = Convert.ToInt32(txt_StockMinimo.Text);
                        productoImportado.Descripcion = rtxt_Descripcion.Text;
                        productoImportado.Nacionalidad = cb_Nacionalidad.SelectedText;
                        productoImportado.CategoriaAsociada = cb_Categorias.SelectedItem as Categoria;
                        productoImportado.ImagenProducto = txt_RutaImagen.Text;

                        if (controladoraProductos.CrearProductoImportado(productoImportado))
                        {
                            MessageBox.Show("El Producto  " + productoImportado.Nombre + " se creó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El Producto  " + productoImportado.Nombre + " ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ActualizarVista();
                    break;

                case false:
                    cb_Nacionalidad.Enabled = false;
                    if (ValidarCampos())
                    {
                        Producto productoNacional = new Producto();
                        productoNacional.Nombre = txt_Nombre.Text;
                        productoNacional.CodigoProducto = txt_Codigo.Text;
                        productoNacional.Precio = Convert.ToDecimal(txt_Precio.Text);
                        productoNacional.Stock = Convert.ToInt32(txt_Stock.Text);
                        productoNacional.StockMinimo = Convert.ToInt32(txt_StockMinimo.Text);
                        productoNacional.Descripcion = rtxt_Descripcion.Text;
                        productoNacional.CategoriaAsociada = cb_Categorias.SelectedItem as Categoria;
                        productoNacional.ImagenProducto = txt_RutaImagen.Text;

                        if (controladoraProductos.CrearProducto(productoNacional))
                        {
                            MessageBox.Show("El Producto  " + productoNacional.Nombre + " se creó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El Producto  " + productoNacional.Nombre + " ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ActualizarVista();
                    break;
            }
        }

        private void pb_EditarProducto_Click(object sender, EventArgs e)
        {
            switch (chk_Importado.Checked)
            {
                case true:
                    cb_Nacionalidad.Enabled = true;
                    if (dgv_ProductosImportados.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un producto.", "Error Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ProductoImportado? productoImportado = dgv_ProductosImportados.SelectedRows[0].DataBoundItem as ProductoImportado;

                    if (ValidarCampos())
                    {
                        productoImportado.Nombre = txt_Nombre.Text;
                        productoImportado.CodigoProducto = txt_Codigo.Text;
                        productoImportado.Precio = Convert.ToDecimal(txt_Precio.Text);
                        productoImportado.Stock = Convert.ToInt32(txt_Stock.Text);
                        productoImportado.StockMinimo = Convert.ToInt32(txt_StockMinimo.Text);
                        productoImportado.Descripcion = rtxt_Descripcion.Text;
                        productoImportado.Nacionalidad = cb_Nacionalidad.SelectedItem.ToString();
                        productoImportado.CategoriaAsociada = cb_Categorias.SelectedItem as Categoria;
                        productoImportado.ImagenProducto = txt_RutaImagen.Text;


                        if (controladoraProductos.ModificarProductoImportado(productoImportado))
                        {
                            MessageBox.Show("El producto   " + productoImportado.Nombre + " se modificó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El producto   " + productoImportado.Nombre + " se modificó exitosamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    ActualizarVista();
                    break;

                case false:
                    cb_Nacionalidad.Enabled = false;
                    if (dgv_ProductosNacionales.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un producto.", "Error Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Producto? productoNacional = dgv_ProductosNacionales.SelectedRows[0].DataBoundItem as Producto;

                    if (ValidarCampos())
                    {
                        productoNacional.Nombre = txt_Nombre.Text;
                        productoNacional.CodigoProducto = txt_Codigo.Text;
                        productoNacional.Precio = Convert.ToDecimal(txt_Precio.Text);
                        productoNacional.Stock = Convert.ToInt32(txt_Stock.Text);
                        productoNacional.StockMinimo = Convert.ToInt32(txt_StockMinimo.Text);
                        productoNacional.Descripcion = rtxt_Descripcion.Text;
                        productoNacional.CategoriaAsociada = cb_Categorias.SelectedItem as Categoria;
                        productoNacional.ImagenProducto = txt_RutaImagen.Text;

                        if (controladoraProductos.ModificarProducto(productoNacional))
                        {
                            MessageBox.Show("El producto   " + productoNacional.Nombre + " se modificó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El producto   " + productoNacional.Nombre + " se modificó exitosamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    ActualizarVista();
                    break;
            }
        }

        private void pb_EliminarProducto_Click(object sender, EventArgs e)
        {
            switch (chk_Importado.Checked)
            {

                case true:
                    cb_Nacionalidad.Enabled = true;
                    if (dgv_ProductosImportados.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un producto.", "Error Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ProductoImportado? productoImportado = dgv_ProductosImportados.SelectedRows[0].DataBoundItem as ProductoImportado;

                    if (controladoraProductos.EliminarProductoImportado(productoImportado))
                    {
                        MessageBox.Show("El producto   " + productoImportado.Nombre + " se eliminó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El producto   " + productoImportado.Nombre + " se eliminó exitosamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ActualizarVista();
                    break;

                case false:
                    cb_Nacionalidad.Enabled = false;
                    if (dgv_ProductosNacionales.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Debe seleccionar un producto.", "Error Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Producto? productoNacional = dgv_ProductosNacionales.SelectedRows[0].DataBoundItem as Producto;


                    if (controladoraProductos.EliminarProducto(productoNacional))
                    {
                        MessageBox.Show("El producto   " + productoNacional.Nombre + " se eliminó exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El producto   " + productoNacional.Nombre + " se eliminó exitosamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ActualizarVista();
                    break;
            }
        }




        private void ActualizarVista()
        {
            dgv_ProductosNacionales.AutoGenerateColumns = false;
            dgv_ProductosImportados.AutoGenerateColumns = false;

            dgv_ProductosNacionales.DataSource = controladoraProductos.ConsultarProductos();
            dgv_ProductosImportados.DataSource = controladoraProductos.ConsultarProductosImportados();

            dgv_ProductosNacionales.Columns.Clear();
            dgv_ProductosImportados.Columns.Clear();

            dgv_ProductosNacionales.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Codigo Producto", DataPropertyName = "CodigoProducto" });
            dgv_ProductosNacionales.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgv_ProductosNacionales.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoria", DataPropertyName = "NombreCategoria" });
            dgv_ProductosNacionales.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripcion", DataPropertyName = "Descripcion" });
            dgv_ProductosNacionales.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "Precio" });
            dgv_ProductosNacionales.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock", DataPropertyName = "Stock" });
            dgv_ProductosNacionales.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock Min", DataPropertyName = "StockMinimo" });


            dgv_ProductosImportados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Codigo Producto", DataPropertyName = "CodigoProducto" });
            dgv_ProductosImportados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "Nombre" });
            dgv_ProductosImportados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoria", DataPropertyName = "NombreCategoria" });
            dgv_ProductosImportados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Descripcion", DataPropertyName = "Descripcion" });
            dgv_ProductosImportados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Origen", DataPropertyName = "Nacionalidad" });
            dgv_ProductosImportados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "Precio" });
            dgv_ProductosImportados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock", DataPropertyName = "Stock" });
            dgv_ProductosImportados.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock Min", DataPropertyName = "StockMinimo" });

            cb_Categorias.DataSource = null;
            cb_Categorias.DataSource = controladoraProductos.ConsultarCategorias();
            cb_Categorias.DisplayMember = "Nombre";

            txt_Codigo.Enabled = true;
            txt_Codigo.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_Precio.Text = string.Empty;
            txt_Stock.Text = string.Empty;
            txt_StockMinimo.Text = string.Empty;
            rtxt_Descripcion.Text = string.Empty; ;
            txt_RutaImagen.Text = string.Empty;
            chk_Importado.Enabled = true;
            chk_Importado.Checked = false;
            cb_Nacionalidad.Enabled = false;

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_Codigo.Text))
            {
                MessageBox.Show("El campo Codigo no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Nombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_Precio.Text))
            {
                MessageBox.Show("El campo Precio no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!decimal.TryParse(txt_Precio.Text, out decimal Precio) || Convert.ToDecimal(txt_Precio.Text) < 0)
            {
                MessageBox.Show("El Precio no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Stock.Text))
            {
                MessageBox.Show("El campo Stock no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(Convert.ToInt32(txt_Stock.Text)< Convert.ToInt32(txt_StockMinimo.Text))
            {
                MessageBox.Show("El Stock no puede ser menor que el minimo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txt_Stock.Text, out int Stock) || Convert.ToInt32(txt_Stock.Text) < 0)
            {
                MessageBox.Show("El Stock no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_StockMinimo.Text))
            {
                MessageBox.Show("El campo Stock Min no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txt_Stock.Text, out int StockMin) || Convert.ToInt32(txt_StockMinimo.Text) < 0)
            {
                MessageBox.Show("El Stock Minimo no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgv_ProductosNacionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Seleccion = dgv_ProductosNacionales.Rows[e.RowIndex];

                if (Seleccion != null)
                {
                    txt_Codigo.Enabled = false;
                    var nacional = Seleccion.DataBoundItem as Producto;

                    txt_Nombre.Text = nacional.Nombre.ToString();
                    txt_Codigo.Text = nacional.CodigoProducto.ToString();
                    txt_Precio.Text = nacional.Precio.ToString();
                    txt_Stock.Text = nacional.Stock.ToString();
                    txt_StockMinimo.Text = nacional.StockMinimo.ToString();
                    txt_RutaImagen.Text = nacional.ImagenProducto.ToString();
                    rtxt_Descripcion.Text = nacional.Descripcion.ToString();
                    pb_CargarImagen.Load(nacional.ImagenProducto.ToString());
                    chk_Importado.Checked = false;
                    chk_Importado.Enabled = false;
                }
            }
            chk_Importado.Enabled = true;
        }

        private void dgv_ProductosImportados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Seleccion = dgv_ProductosImportados.Rows[e.RowIndex];

                if (Seleccion != null)
                {
                    txt_Codigo.Enabled = false;
                    var importado = Seleccion.DataBoundItem as ProductoImportado;

                    txt_Nombre.Text = importado.Nombre.ToString();
                    txt_Codigo.Text = importado.CodigoProducto.ToString();
                    txt_Precio.Text = importado.Precio.ToString();
                    txt_Stock.Text = importado.Stock.ToString();
                    txt_StockMinimo.Text = importado.StockMinimo.ToString();
                    txt_RutaImagen.Text = importado.ImagenProducto.ToString();
                    rtxt_Descripcion.Text = importado.Descripcion.ToString();
                    cb_Categorias.SelectedIndex = cb_Categorias.FindStringExact(importado.CategoriaAsociada.Nombre);
                    cb_Nacionalidad.SelectedIndex = cb_Nacionalidad.FindStringExact(importado.Nacionalidad.ToString());
                    pb_CargarImagen.Load(importado.ImagenProducto.ToString());
                    chk_Importado.Checked = true;
                    chk_Importado.Enabled = false;
                    cb_Nacionalidad.Enabled = true;
                }
            }

        }

        private void ControlarEstadoCbNacionalidad(object sender, EventArgs e)
        {
            // Cambiar el estado de habilitación del ComboBox dependiendo del estado del CheckBox
            cb_Nacionalidad.Enabled = chk_Importado.Checked;
        }

        private void pb_ImagenProducto_Click(object sender, EventArgs e)
        {
            // Crear una instancia del cuadro de diálogo
            OpenFileDialog cargarImagen = new OpenFileDialog();

            // Establecer los filtros de archivo (opcional)
            cargarImagen.Filter = "Archivos de imagen (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            // Mostrar el cuadro de diálogo y comprobar si el usuario seleccionó un archivo
            if (cargarImagen.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = cargarImagen.FileName;

                // Mostrar la ruta en un TextBox, Label o usarla como lo necesites
                txt_RutaImagen.Text = rutaArchivo;
            }
        }
    }
}
