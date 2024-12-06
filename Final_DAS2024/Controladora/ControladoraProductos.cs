using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProductos
    {
        private Context _context;

        public ControladoraProductos() 
        {
            _context = new Context();
        }


        public ReadOnlyCollection<Producto> ConsultarProductos()
        {
            return _context.Productos.OfType<Producto>().Where(p=>!(p is ProductoImportado)).ToList().AsReadOnly();
        }
        public ReadOnlyCollection<ProductoImportado> ConsultarProductosImportados()
        {
            return _context.ProductosImportados.ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Categoria> ConsultarCategorias()
        {
            return _context.Categorias.ToList().AsReadOnly();
        }


                // ------------- ABM Productos Nacionales ----------- //
        public bool CrearProducto(Producto producto)
        {
            try
            {
                var buscarProducto = _context.Productos.FirstOrDefault(c => c.CodigoProducto == producto.CodigoProducto);

                if (buscarProducto == null)
                {
                    _context.Productos.Add(producto);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarProducto(Producto producto)
        {
            try
            {
                var buscarProducto = _context.Productos.FirstOrDefault(c => c.CodigoProducto == producto.CodigoProducto);

                if (buscarProducto != null)
                {
                    _context.Productos.Update(producto);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EliminarProducto(Producto producto)
        {
            try
            {
                var buscarProducto = _context.Productos.FirstOrDefault(c => c.CodigoProducto == producto.CodigoProducto);

                if (buscarProducto != null)
                {
                    _context.Productos.Remove(producto);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

                     // -------------- ABM Productos Importados --------------- //

        public bool CrearProductoImportado(ProductoImportado productoImportado)
        {
            try
            {
                var buscarProducto = _context.Productos.FirstOrDefault(c => c.CodigoProducto == productoImportado.CodigoProducto);

                if (buscarProducto == null)
                {
                    _context.ProductosImportados.Add(productoImportado);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarProductoImportado(ProductoImportado productoImportado)
        {
            try
            {
                var buscarProducto = _context.Productos.FirstOrDefault(c => c.CodigoProducto == productoImportado.CodigoProducto);

                if (buscarProducto != null)
                {
                    _context.ProductosImportados.Update(productoImportado);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EliminarProductoImportado(ProductoImportado productoImportado)
        {
            try
            {
                var buscarProducto = _context.Productos.FirstOrDefault(c => c.CodigoProducto == productoImportado.CodigoProducto);

                if (buscarProducto != null)
                {
                    _context.ProductosImportados.Remove(productoImportado);
                    return _context.SaveChanges() > 0;
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
