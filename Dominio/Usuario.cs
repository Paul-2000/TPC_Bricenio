using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario : Persona
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public  string Id { get; set; }
    }
}
