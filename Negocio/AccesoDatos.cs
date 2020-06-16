using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Win32.SafeHandles;

namespace Negocio
{
    public class AccesoDatos
    {
        public SqlDataReader lector { get; set; }
        public SqlConnection conexion { get; set; }
        public SqlCommand comando { get; set; }
        public AccesoDatos()
        {
            conexion = new SqlConnection("data source=DESKTOP-VMO2M2L\\SQLEXPRESS01; initial catalog=Bricenio_DB; integrated security=sspi;");
            comando = new SqlCommand();
            comando.Connection = conexion;
        }
        public void setearQuery(string consulta)
        {

        }
        public void setearSP(string sp)
        {

        }
        public void agregarParametro(string nombre, string valor)
        {

        }
    }
}
