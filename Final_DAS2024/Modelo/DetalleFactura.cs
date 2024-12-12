using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DetalleFactura
    {
        public int IdDetalle { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; } 
        public decimal Subtotal { get; set; }
        public Producto Producto { get; set; }
        public Factura FacturaAsociada { get; set; }


        public void CalcularSubtotal()
        {
            Subtotal = Cantidad * PrecioUnitario;
        }
        public string NombreProducto { get { return Producto.Nombre; } }
        public string PrecioProducto { get { return Producto.Precio.ToString(); } }
    }
}   