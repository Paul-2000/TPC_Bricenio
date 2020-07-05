using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Carrito
    {
        public int Cant { get; set; }
        public Carrito()
        {
            Cant = 1;
        }
        public long IDProducto { get; set; } 
    }
}
