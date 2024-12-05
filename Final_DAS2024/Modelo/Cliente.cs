using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Codigo { get; set; }
        public long Dni {  get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public long Contacto { get; set; }
        public List<Factura> Facturaciones { get; set; }=new List<Factura>();


                                                      //------------ Altas/bajas de facturas ----------//

        public bool GenerarFacturacion(Factura factura)
        {
            var buscarFactura = Facturaciones.FirstOrDefault(f => f.NumeroFactura == factura.NumeroFactura);
            try
            {
                if (buscarFactura == null)
                {
                    Facturaciones.Add(factura);
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ReversoFacturacion(Factura factura)
        {
            var buscarFactura = Facturaciones.FirstOrDefault(f => f.NumeroFactura == factura.NumeroFactura);
            try
            {
                if (buscarFactura != null)
                {
                    Facturaciones.Remove(factura);
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
