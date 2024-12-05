using Modelo;

namespace Controladora
{
    public class ControladoraClientes
    {
        private Context _context;

        public ControladoraClientes() 
        {
            _context = new Context();
        }

        public List<Cliente> ConsultarClientes()
        {
            return _context.Clientes.OfType<Cliente>().Where(c=>!(c is ClienteMayorista)).ToList();
        }
        //return _context.Pasajeros.OfType<Pasajero>().Where(p => !(p is PasajeroEstudiante)).ToList()

        public List<ClienteMayorista> ConsultarClientesMayoristas()
        {
            return _context.ClientesMayoristas.ToList();
        }


                    //-------------- ABM CLIENTES MINORISTAS O COMUNES -------------//

        public bool CrearCliente(Cliente cliente)
        {
            try
            {
                var buscarCliente = _context.Clientes.FirstOrDefault(c => c.Dni == cliente.Dni);
                if (buscarCliente == null)
                {
                    _context.Clientes.Add(cliente);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarCliente(Cliente cliente)
        {
            try
            {
                var buscarCliente = _context.Clientes.FirstOrDefault(c => c.Dni == cliente.Dni);
                if (buscarCliente != null)
                {
                    _context.Clientes.Update(cliente);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarCliente(Cliente cliente)
        {

            try
            {
                var buscarCliente = _context.Clientes.FirstOrDefault(c => c.Dni == cliente.Dni);
                if (buscarCliente != null)
                {
                    _context.Clientes.Remove(cliente);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }

            catch (Exception ex)
            {
                return false;
            }
        }


                        //----------- ABM CLIENTES MAYORISTAS ----------//

        public bool CrearClienteMayorista(ClienteMayorista clienteMayorista)
        {
            try
            {
                var buscarCliente = _context.Clientes.FirstOrDefault(c => c.Dni == clienteMayorista.Dni);
                if (buscarCliente == null)
                {
                    _context.Clientes.Add(clienteMayorista);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool ModificarClienteMayorista(ClienteMayorista clienteMayorista)
        {
            try
            {
                var buscarCliente = _context.Clientes.FirstOrDefault(c => c.Dni == clienteMayorista.Dni);
                if (buscarCliente != null)
                {
                    _context.Clientes.Update(clienteMayorista);
                    return _context.SaveChanges() > 0;
                }
                else return false;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EliminarClienteMayorista(ClienteMayorista clienteMayorista)
        {

            try
            {
                var buscarCliente = _context.ClientesMayoristas.FirstOrDefault(c => c.Dni == clienteMayorista.Dni);
                if (buscarCliente != null)
                {
                    _context.Clientes.Remove(clienteMayorista);
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
