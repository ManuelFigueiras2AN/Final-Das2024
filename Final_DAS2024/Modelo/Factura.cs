using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }= DateTime.Now;
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleFactura> Detalle { get; set; }

        public void AgregarDetalleDeFactura(DetalleFactura detalle)
        {
            var buscarDetalle = Detalle.FirstOrDefault(d => d.Producto.CodigoProducto == detalle.Producto.CodigoProducto);

            if (buscarDetalle == null)
            {
                detalle.Producto.AjustarStock(detalle.Cantidad);
                detalle.CalcularSubtotal();
                Detalle.Add(detalle);
            }
            else
            {
                detalle.Producto.AjustarStock(detalle.Cantidad);
                buscarDetalle.Cantidad += detalle.Cantidad;
                buscarDetalle.CalcularSubtotal();  
            }
            CalcularTotal();
        }

        public void EliminarDetalleDeFactura(DetalleFactura detalle)
        {
            var buscarDetalle = Detalle.FirstOrDefault(d => d.Producto.CodigoProducto == detalle.Producto.CodigoProducto);

            if (buscarDetalle != null)
            {
                detalle.Producto.RecuperarStock(detalle.Cantidad);
                buscarDetalle.Cantidad -= detalle.Cantidad;
                buscarDetalle.CalcularSubtotal();
                Detalle.Remove(detalle);
            }
            CalcularTotal();
        }

        public void EliminarDetalles()
        {
            Detalle.Clear();
            CalcularTotal();
        }


        public decimal CalcularTotal()
        {
            Total = 0;
            if (Detalle.Count > 0)
            {
                foreach (DetalleFactura controlarDetalles in Detalle)
                {
                    Total += controlarDetalles.Subtotal;
                }
                return Total;
            }
            else
            {
                return 0;
            }
        }

        public string NombreCliente {get { return Cliente.Nombre.ToString();}}
        public string DniCliente { get { return Cliente.Dni.ToString();}}
        public string ContactoCliente { get{ return Cliente.Contacto.ToString(); } }


    }
}
