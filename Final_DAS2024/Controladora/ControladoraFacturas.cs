using iText.Commons.Actions.Contexts;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraFacturas
    {
        Context _context;
        public ControladoraFacturas()

        {
            _context = new Context();
        }

        public ReadOnlyCollection<Factura> ConsultarFacturas()
        {
            return _context.Facturas.Include(d=>d.Detalle).ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Producto> ConsultarProductos()
        {
            return _context.Productos.ToList().AsReadOnly();
        }
        public ReadOnlyCollection<Cliente> ConsultarClienteMinorista()
        {
            return _context.Clientes.OfType<Cliente>().Where(c => !(c is ClienteMayorista)).ToList().AsReadOnly();
        }
        public ReadOnlyCollection<ClienteMayorista> ConsultarClienteMayorista()
        {
            return _context.ClientesMayoristas.ToList().AsReadOnly();
        }


        public bool AgregarFactura(Factura factura)
        {
            try
            {
                var buscarFactura = _context.Facturas.FirstOrDefault(f => f.NumeroFactura == factura.NumeroFactura);
                if (buscarFactura == null)
                {
                    _context.Facturas.Add(factura);
                    return _context.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarFactura(Factura factura)
        {
            try
            {
                var buscarFactura = _context.Facturas.FirstOrDefault(f => f.NumeroFactura == factura.NumeroFactura);
                if (buscarFactura != null)
                {
                    _context.Facturas.Update(factura);
                    return _context.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarFactura(Factura factura)
        {
            try
            {
                var buscarFactura = _context.Facturas.FirstOrDefault(f => f.NumeroFactura == factura.NumeroFactura);
                if (buscarFactura != null)
                {
                    _context.Facturas.Remove(factura);
                    return _context.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void RegistrarDetalle(Factura factura, DetalleFactura detalle)
        {
            factura.AgregarDetalleDeFactura(detalle);
            _context.Facturas.Update(factura);
            _context.SaveChanges();
        }

        public void ElimarDetalle(Factura factura, DetalleFactura detalle)
        {
            factura.EliminarDetalleDeFactura(detalle);
            _context.Facturas.Update(factura);
            _context.SaveChanges();
        }
    }
}
