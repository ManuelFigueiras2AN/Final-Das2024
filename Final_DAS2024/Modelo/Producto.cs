using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string Nombre {  get; set; }
        public string Descripcion {  get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int StockMinimo {  get; set; }
        public string? ImagenProducto {  get; set; }
        public int CategoriaId {  get; set; }

        public Categoria CategoriaAsociada {  get; set; }

        public bool AjustarStock(int cantidad)
        {
            Stock -= cantidad;

            if (Stock <= StockMinimo)
            {
                return false;
            }
            else return true;
        }
        public string NombreCategoria
        {
            get { return CategoriaAsociada != null ? CategoriaAsociada.Nombre : string.Empty; }
        }
    }
}
