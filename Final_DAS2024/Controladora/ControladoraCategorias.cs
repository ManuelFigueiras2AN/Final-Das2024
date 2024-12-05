using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraCategorias
    {
        private Context _context;

        public ControladoraCategorias()
        {
            _context = new Context();
        }

        public ReadOnlyCollection<Categoria> ConsultarCategorias()
        {
            return _context.Categorias.ToList().AsReadOnly();
        }

        public ReadOnlyCollection<Producto> ConsultarProductos()
        {
            return _context.Productos.ToList().AsReadOnly();
        }

        public bool CrearCategoria(Categoria categoria)
        {
            try
            {
                var buscarCategoria = _context.Categorias.FirstOrDefault(c => c.Codigo == categoria.Codigo);

                if (buscarCategoria == null)
                {
                    _context.Categorias.Add(categoria);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarCategoria(Categoria categoria)
        {
            try
            {
                var buscarCategoria = _context.Categorias.FirstOrDefault(c => c.Codigo == categoria.Codigo);
                if (buscarCategoria != null)
                {
                    _context.Update(categoria);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarCategoria(Categoria categoria)
        {
            try 
            {
                var buscarCategoria= _context.Categorias.FirstOrDefault(c=>c.Codigo == categoria.Codigo);

                if (buscarCategoria != null)
                {
                    _context.Categorias.Remove(categoria);
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
