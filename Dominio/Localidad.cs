using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Localidad
    {
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public Direccion IdDireccion { get; set; }
    }
}
