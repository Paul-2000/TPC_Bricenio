using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Modelo
    {
        public long ID { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
        public short Anio { get; set; }
    }
}
