using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        public int IdProveedor {  get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public long Contacto { get; set; }
        public List <Producto> CatalogoProductos { get; set; } = new List<Producto>();

                      //--------- Metodos alta/baja productos del catalogo ----------//

        public bool AsociarProducto(Producto producto)
        {
            try
            {
                var buscarProducto = CatalogoProductos.FirstOrDefault(p=>p.CodigoProducto == producto.CodigoProducto);
                if (buscarProducto == null) 
                {
                    CatalogoProductos.Add(producto);
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DesasociarProducto(Producto producto)
        {
            try
            {
                var buscarProducto = CatalogoProductos.FirstOrDefault(p => p.CodigoProducto == producto.CodigoProducto);
                if (buscarProducto != null)
                {
                    CatalogoProductos.Remove(producto);
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
