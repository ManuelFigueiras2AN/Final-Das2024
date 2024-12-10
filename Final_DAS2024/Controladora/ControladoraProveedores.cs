using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraProveedores
    {
        private Context _context;

        public ControladoraProveedores()
        {
            _context = new Context();
        }

        public ReadOnlyCollection<Proveedor> ConsultarProveedores()
        {
            return _context.Proveedores.ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Producto> ConsultarProductos()
        {
            return _context.Productos.ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Categoria> CargarCategorias()
        {
            return _context.Categorias.ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Producto> ConsultaPorCategoria(Categoria Categoria)
        {
            return _context.Productos.Where(p =>( p.CategoriaAsociada.Nombre == Categoria.Nombre)).ToList().AsReadOnly();
        }
        public List<Producto>RecuperarProductosProveedor(Proveedor proveedor) 
        {
            return _context.Proveedores.Where(p => p.Codigo == proveedor.Codigo).SelectMany(p => p.CatalogoProductos).ToList();
        }
       

        public ReadOnlyCollection<Producto> ConsultaPorProveedor(Proveedor proveedor)
        {
            return proveedor.CatalogoProductos.ToList().AsReadOnly();
        }

       

        public bool CrearProveedor(Proveedor proveedor)
        {
            try
            {
                var buscarProveedor = _context.Proveedores.FirstOrDefault(p=>p.Codigo == proveedor.Codigo);
                if (buscarProveedor == null)
                {
                    _context.Proveedores.Add(proveedor);
                    return _context.SaveChanges()>0;
                }
                else return false;
            }
            catch (Exception ex) 

            {
                return false;
                
            }
        }

        public bool ModificarProveedor (Proveedor proveedor)
        {
            try
            {
                var buscarProveedor = _context.Proveedores.FirstOrDefault(p => p.Codigo == proveedor.Codigo);
                if (buscarProveedor != null)
                {
                    _context.Proveedores.Update(proveedor);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarProveedor(Proveedor proveedor)
        {
            try
            {
                var buscarProveedor = _context.Proveedores.FirstOrDefault(p => p.Codigo == proveedor.Codigo);
                if (buscarProveedor != null)
                {
                    _context.Proveedores.Remove(proveedor);
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
