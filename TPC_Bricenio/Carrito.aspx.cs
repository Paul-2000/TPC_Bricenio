using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Bricenio
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<Producto> ListaCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ListaCarrito = (List<Producto>)Session[Session.SessionID + "ListaCarrito"];
                if (Request.QueryString["idQui"] != null)
                {
                    Producto ProductoQ = ListaCarrito.Find(J => J.ID == int.Parse(Request.QueryString["idQui"]));
                    ListaCarrito.Remove(ProductoQ);
                    Session[Session.SessionID + "ListaCarrito"] = ListaCarrito;
                }
                else if (Request.QueryString["idPro"] != null)
                {
                    //obtengo la lista original (El listado completo)
                    List<Producto> ListaOriginal = (List<Producto>)Session[Session.SessionID + "ListaProductos"];
                    var ProductoSeleccionado = Convert.ToInt32(Request.QueryString["idPro"]);
                    Producto producto = ListaOriginal.Find(J => J.ID == ProductoSeleccionado);
                    // obtengo la lista de favoritos de la session
                    if (ListaCarrito == null)
                        ListaCarrito = new List<Producto>();
                    ListaCarrito.Add(producto);
                    Session[Session.SessionID + "ListaCarrito"] = ListaCarrito;
                }
            }
            catch (Exception)
            {
                Session["Error" + Session.SessionID] = "Aun no tenes Favoritos";
                Response.Redirect("Error");
            }

        }
    }
}