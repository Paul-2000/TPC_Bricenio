using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public long ID { get; set; }
        public string Nombre { get; set; }
        public Marca IDMarca { get; set; }
        public Modelo IDModelo { get; set; }
        //public Carrito carrito { get; set; }
        public Condicion IDCondicion { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public decimal Precio { get; set; }
        public string ImagenURL { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
