using Controladora;
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
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void pb_AgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void pb_EditarProducto_Click(object sender, EventArgs e)
        {

        }

        private void pb_EliminarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
