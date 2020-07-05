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
    public partial class Favoritos : System.Web.UI.Page
    {
        public List<Producto> ListaFavoritos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ListaFavoritos = (List<Producto>)Session[Session.SessionID + "ListaFavoritos"];
                if (Request.QueryString["idQui"] != null)
                {
                    Producto ProductoQ = ListaFavoritos.Find(J => J.ID == int.Parse(Request.QueryString["idQui"]));
                    ListaFavoritos.Remove(ProductoQ);
                    Session[Session.SessionID + "ListaFavoritos"] = ListaFavoritos;
                }
                else if (Request.QueryString["idPro"] != null)
                {
                    //obtengo la lista original (El listado completo)
                    List<Producto> ListaOriginal = (List<Producto>)Session[Session.SessionID + "ListaProductos"];
                    var ProductoSeleccionado = Convert.ToInt32(Request.QueryString["idPro"]);
                    Producto producto = ListaOriginal.Find(J => J.ID == ProductoSeleccionado);
                    // obtengo la lista de favoritos de la session
                    if (ListaFavoritos == null)
                        ListaFavoritos = new List<Producto>();
                    ListaFavoritos.Add(producto);
                    Session[Session.SessionID + "ListaFavoritos"] = ListaFavoritos;
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