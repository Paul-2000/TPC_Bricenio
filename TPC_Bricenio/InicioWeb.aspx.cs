using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPC_Bricenio
{
    public partial class Inicio_web : System.Web.UI.Page
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
                if (!IsPostBack)
                {//Pregunto si es la primera carga de la page
                    
                }
            }
            catch (Exception Ex)
            {
                Session["Error" + Session.SessionID] = Ex;
                Response.Redirect("Error.aspx");
            }
        }
    }
}

