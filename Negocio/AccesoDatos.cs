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
        public SqlDataReader Lector { get; set; }
        public SqlConnection Conexion { get; set; }
        public SqlCommand Comando { get; set; }
        public AccesoDatos()
        {
            Conexion = new SqlConnection("data source=DESKTOP-VMO2M2L\\SQLEXPRESS01; initial catalog=Bricenio_DB; integrated security=sspi;");
            Comando = new SqlCommand();
            Comando.Connection = Conexion;
        }
        public void SetearQuery(string Consulta)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = Consulta;
        }
        public void SetearSP(string Sp)
        {
            Comando.CommandType = System.Data.CommandType.StoredProcedure;
            Comando.CommandText = Sp;
        }
        public void AgregarParametro(string Nombre, object Valor)
        {
            Comando.Parameters.AddWithValue(Nombre, Valor);
        }
        public void EjecutarLector()
        {
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                //Conexion.Close();
            }
        }
        public void CerrarConexion()
        {
            Conexion.Close();
        }
        public void EjecutarAccion()
        {
            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                Conexion.Close();
            }
        }
    }
}
