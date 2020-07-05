using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public string Calle { get; set; }
        public int Altura { get; set; }
        public string Entrecalle1 { get; set; }
        public string Entrecalle2 { get; set; }
    }
}
