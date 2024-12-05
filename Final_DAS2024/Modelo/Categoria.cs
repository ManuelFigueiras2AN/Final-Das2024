using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public List<Producto>? ProductosCategorizados { get; set; }


                                                //----------- METODOS ALTA/BAJA DE PRODUCTOS CATEGORIZADOS ----------//

        public bool AsociarProducto(Producto producto)
        {
            try
            {
                var buscarProducto = ProductosCategorizados.FirstOrDefault(p => p.CodigoProducto == producto.CodigoProducto);

                if (buscarProducto == null)
                {
                    ProductosCategorizados.Add(producto);
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
                var buscarProducto = ProductosCategorizados.FirstOrDefault(p => p.CodigoProducto == producto.CodigoProducto);

                if (buscarProducto != null)
                {
                    ProductosCategorizados.Remove(producto);
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
