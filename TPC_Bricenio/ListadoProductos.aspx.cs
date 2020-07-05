using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPC_Bricenio
{
    public partial class ListadoProductos : System.Web.UI.Page
    {
        public List<Producto> ListaProductos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ProductosNegocio negocio = new ProductosNegocio();
                ListaProductos = negocio.ListarConView();

                Session[Session.SessionID + "ListaProductos"] = ListaProductos;
                
                    //cboProductos.DataSource = ListaProductos;
                    //cboProductos.DataBind();
                if(!IsPostBack)
                {//Pregunto si es la primera carga de la page
                    //txtNumeroProducto.Text = "150";

                    //cboProductos.Items.Add("Rojo");
                    //cboProductos.Items.Add("Azul");
                    //cboProductos.Items.Add("Verde");
                }
            }
            catch (Exception Ex)
            {
                //Error de Exepcion, SOLUCIONAR!
                throw Ex;
            }
        }
    }
}