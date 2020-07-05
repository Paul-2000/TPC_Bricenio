using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public Cliente IdCliente { get; set; }
        public Administrador IdAdministrador { get; set; }
    }
}
