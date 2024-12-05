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
        public DateTime Fecha { get; set; }
        public decimal Total {  get; set; }
        public Cliente Cliente {  get; set; }
        public List<DetalleFactura> Detalle { get; set; }

        public void AgregarDetalleDeFactura(DetalleFactura detalle)
        {
            var buscarDetalle = Detalle.FirstOrDefault(d=>d.Producto.CodigoProducto == detalle.Producto.CodigoProducto);

            if (buscarDetalle == null)
            {
                detalle.CalcularSubtotal();
                Detalle.Add(detalle);
            }
            else
            {
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
                buscarDetalle.Cantidad-=detalle.Cantidad;
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


    }
}
