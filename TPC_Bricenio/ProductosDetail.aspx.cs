using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Reflection;

namespace TPC_Bricenio
{
    public partial class ProductosDetail : System.Web.UI.Page
    {
        public Dominio.Carrito carrito { get; set; }
        public Producto producto { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductosNegocio negocio = new ProductosNegocio();
            List<Producto> ListaProducto;
            try
            {
                ListaProducto = negocio.Listar();
                var ProductoSeleccionado = Convert.ToInt32(Request.QueryString["idPro"]);
                producto = ListaProducto.Find(J => J.ID == ProductoSeleccionado);
                
            }
            catch (Exception Ex)
            {
                Session["Error" + Session.SessionID] = Ex;
                Response.Redirect("Error.aspx");
            }
        }
    }
}