using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Microsoft.Ajax.Utilities;
using Negocio;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TPC_Bricenio
{
    public partial class AltaProductos : System.Web.UI.Page
    {
        public List<Producto> ListaProductos { get; set; }
        Producto Producto;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargarMarcas();
                    CargarModelos();
                    CargarCondicion();
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CargarMarcas()
        {
            AccesoDatos acceso = new AccesoDatos();
            acceso.SetearQuery("select mar.Nombre, mar.ID from Productos AS p inner join Marcas AS mar on mar.ID = p.IDMarca");
            //acceso.EjecutarLector();
            acceso.Comando.Connection.Open();
            dropDownMarca.DataSource = acceso.Comando.ExecuteReader();
            dropDownMarca.DataTextField = "Nombre";
            dropDownMarca.DataValueField = "ID";
            dropDownMarca.DataBind();
            dropDownMarca.Items.Insert(0, new ListItem(" --Seleccionar --", "0"));
        }
        public void CargarModelos()
        {
            AccesoDatos acceso = new AccesoDatos();
            acceso.SetearQuery("select mod.Nombre, mod.ID from Productos AS p inner join Modelos AS mod on mod.ID = p.IDModelo");
            acceso.Comando.Connection.Open();
            dropDownModelo.DataSource = acceso.Comando.ExecuteReader();
            dropDownModelo.DataTextField = "Nombre";
            dropDownModelo.DataValueField = "ID";
            dropDownModelo.DataBind();
            dropDownModelo.Items.Insert(0, new ListItem(" --Seleccionar --", "0"));
        }

        public void CargarCondicion()
        {
            AccesoDatos acceso = new AccesoDatos();
            acceso.SetearQuery("select con.Nombre, con.ID from Productos AS p inner join Condicion AS con on con.ID = p.IDCondicion");
            acceso.Comando.Connection.Open();
            dropDownCondicion.DataSource = acceso.Comando.ExecuteReader();
            dropDownCondicion.DataTextField = "Nombre";
            dropDownCondicion.DataValueField = "ID";
            dropDownCondicion.DataBind();
            dropDownCondicion.Items.Insert(0, new ListItem(" --Seleccionar --", "0"));
        }

        protected void dropDownMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        protected void dropDownModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void dropDownCondicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductosNegocio productosNegocio = new ProductosNegocio();
            try
            {
                if (Producto == null)
                    Producto = new Producto();
                if (Producto.IDMarca == null)
                    Producto.IDMarca = new Marca();
                if (Producto.IDModelo == null)
                    Producto.IDModelo = new Modelo();
                if (Producto.IDCondicion == null)
                    Producto.IDCondicion = new Condicion();
                Producto.IDMarca.ID = Convert.ToInt64(dropDownMarca.SelectedValue);
                Producto.IDModelo.ID = Convert.ToInt64(dropDownModelo.SelectedValue);
                Producto.Nombre = txtNombre.Text;
                Producto.Descripcion = txtDescripcion.Text;
                Producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                Producto.IDCondicion.ID = Convert.ToByte(dropDownCondicion.SelectedValue);
                Producto.Estado = true;
                Producto.ImagenURL = imgURL.Text;
                if (Producto.ID != 0)
                    productosNegocio.Modificar(Producto);
                else
                    productosNegocio.AgregarConSP(Producto);

                Dispose();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}