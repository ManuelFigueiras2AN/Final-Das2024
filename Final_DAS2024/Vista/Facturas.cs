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
    public partial class Facturas : Form
    {
        private ControladoraFacturas controladoraFacturas;
        public Facturas()
        {
            controladoraFacturas = new ControladoraFacturas();
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {

        }

        private void pb_AgregarFactura_Click(object sender, EventArgs e)
        {

        }

        private void pb_EditarFactura_Click(object sender, EventArgs e)
        {

        }

        private void pb_EliminarFactura_Click(object sender, EventArgs e)
        {

        }

        private void pb_AgregarDetalle_Click(object sender, EventArgs e)
        {

        }

        private void pb_EliminarDetalle_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Facturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ValidarCampos() 
        {

        }
        private void LimpiarCampos() 
        {

        }
        private void ActualizarVista()
        {

        }
    }
}
