using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClienteMayorista:Cliente
    {
        public decimal DescuentoMayorista { get; set; } = 30;
    }
}
