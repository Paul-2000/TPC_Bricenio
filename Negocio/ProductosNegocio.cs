using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Negocio
{
    public class ProductosNegocio
    {
        public List<Producto> Listar()
        {
            List<Producto> Lista = new List<Producto>();
            Producto aux;
            SqlCommand Comando = new SqlCommand();
            SqlConnection Conexion = new SqlConnection();
            SqlDataReader Lector;
            try
            {
                Conexion.ConnectionString = "data source=DESKTOP-VMO2M2L\\SQLEXPRESS01; initial catalog=Bricenio_DB; integrated security=sspi;";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "select p.ID, p.IDMarca, p.Nombre, p.IDModelo, mod.Año ModAnio, con.Nombre ConNom, mar.Nombre MarNom, mod.Nombre ModNom, p.Descripcion, p.Precio, p.IDCondicion, p.Status, p.ImagenURL from Productos AS p inner join Marcas AS mar on mar.ID = p.IDMarca left join Modelos AS mod on mod.ID = p.IDModelo left join Condicion AS con on con.ID = p.IDCondicion";
                Comando.Connection = Conexion;
                Conexion.Open();
                Lector = Comando.ExecuteReader();
                while (Lector.Read())
                {
                    aux = new Producto();
                    aux.ID = (long)Lector["ID"];
                    aux.Nombre = (string)Lector["Nombre"];
                    aux.Descripcion = (string)Lector["Descripcion"];
                    aux.Precio = (decimal)Lector["Precio"];
                    aux.Estado = (bool)Lector["Status"];
                    aux.ImagenURL = (string)Lector["ImagenURL"];
                    aux.IDMarca = new Marca();
                    aux.IDMarca.ID = (long)Lector["IDMarca"];
                    aux.IDMarca.Nombre = (string)Lector["MarNom"];
                    aux.IDModelo = new Modelo();
                    aux.IDModelo.ID = (long)Lector["IDModelo"];
                    aux.IDModelo.Nombre = (string)Lector["ModNom"];
                    aux.IDModelo.Anio = (short)Lector["ModAnio"];
                    aux.IDCondicion = new Condicion();
                    aux.IDCondicion.ID = (byte)Lector["IDCondicion"];
                    aux.IDCondicion.Nombre = (string)Lector["ConNom"];
                    //if(!Convert.IsDBNull(Lector["IDMarca"]))
                    //{
                    //    aux.IDMarca = new Marca();
                    //    aux.IDMarca.ID = (int)Lector["IDMarca"];
                    //    aux.IDMarca.Nombre = Lector["Nombre"].ToString();
                    //}
                    Lista.Add(aux);

                }
                return Lista;
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
        public void EliminarLogico(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearSP("spEliminarLogico");
                datos.AgregarParametro("@ID", ID);
                datos.EjecutarAccion();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
        public void Agregar(Producto producto)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-VMO2M2L\\SQLEXPRESS01; initial catalog=Bricenio_DB; integrated security=sspi;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "Insert into Bricenio_DB values ('" + producto.Nombre + "', @IDMarca, @IDModelo, @Descripcion, @IDCondicion, @Estado, @Precio, @Imagen";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@IDMarca", producto.IDMarca);
                comando.Parameters.AddWithValue("@IDModelo", producto.IDModelo);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@IDCondicion", producto.IDCondicion);
                comando.Parameters.AddWithValue("@Estado", producto.Estado);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@Imagen", producto.ImagenURL);

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        public void AgregarConSP(Producto producto)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "data source=DESKTOP-VMO2M2L\\SQLEXPRESS01; initial catalog=Bricenio_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.CommandText = "spAltaProducto";
                //esto vale, funciona, pero no tiene gracia... 
                //comando.CommandText = "exec spAltaPokemon " + pokemon.Nombre + ", 1, 1, 'no soy un pokemon... o si?'"
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@IDMarca", producto.IDMarca.ID);
                comando.Parameters.AddWithValue("@IDModelo", producto.IDModelo.ID);
                comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                comando.Parameters.AddWithValue("@Precio", producto.Precio);
                comando.Parameters.AddWithValue("@IDCondicion", producto.IDCondicion.ID);
                comando.Parameters.AddWithValue("@Status", producto.Estado);
                comando.Parameters.AddWithValue("@ImagenURL", producto.ImagenURL);

                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Modificar(Producto producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.setearQuery("Update POKEMONS set Nombre=@Nombre Where Id=@Id");
                datos.SetearSP("spModificarProducto");
                datos.AgregarParametro("@Nombre", producto.Nombre);
                //datos.AgregarParametro("@id", producto.ID);
                datos.AgregarParametro("@IDMarca", producto.IDMarca);
                datos.AgregarParametro("@IDModelo", producto.IDModelo);
                datos.AgregarParametro("@Descripcion", producto.Descripcion);
                datos.AgregarParametro("@IDCondicion", producto.IDCondicion);
                datos.AgregarParametro("@Estado", producto.Estado);
                datos.AgregarParametro("@Precio", producto.Precio);
                datos.AgregarParametro("@Imagen", producto.ImagenURL);

                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Producto> ListarConView()
        {
            List<Producto> lista = new List<Producto>();
            Producto aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearSP("spListar");
                datos.EjecutarLector();
                while (datos.Lector.Read())
                {
                    aux = new Producto();
                    aux.ID = (long)datos.Lector["ID"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Estado = (bool)datos.Lector["Status"];
                    aux.ImagenURL = (string)datos.Lector["ImagenURL"];
                    aux.IDMarca = new Marca();
                    aux.IDMarca.ID = (long)datos.Lector["IDMarca"];
                    aux.IDMarca.Nombre = (string)datos.Lector["MarNom"];
                    aux.IDModelo = new Modelo();
                    aux.IDModelo.ID = (long)datos.Lector["IDModelo"];
                    aux.IDModelo.Nombre = (string)datos.Lector["ModNom"];
                    aux.IDModelo.Anio = (short)datos.Lector["ModAnio"];
                    aux.IDCondicion = new Condicion();
                    aux.IDCondicion.ID = (byte)datos.Lector["IDCondicion"];
                    aux.IDCondicion.Nombre = (string)datos.Lector["ConNom"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
                datos = null;
            }
        }

    }
}
