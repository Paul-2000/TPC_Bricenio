<%@ Page Title="" Language="C#" MasterPageFile="~/MySiteMaster.Master" AutoEventWireup="true" CodeBehind="ProductosDetail.aspx.cs" Inherits="TPC_Bricenio.ProductosDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <figure class="figure">
        <img src="<% = producto.ImagenURL %>" class="figure-img img-fluid rounded" alt="Imagen">
    </figure>
    <div class="card mb-3" style="max-width: 540px;">
        <div class="row no-gutters">
            <div class="col-md-8">
                <div class="card-body">
                    <h4 class="card-title"><% = producto.IDMarca.Nombre %> <% = producto.Nombre %> <% = producto.IDModelo.Nombre %> </h4>
                    <p class="card-text"><% = producto.Descripcion %></p>
                    <p class="card-text"><% = producto.IDCondicion.Nombre %></p>
                    <p class="card-text"><% = producto.Precio %></p>
                    <p class="card-text"><% = producto.IDModelo.Anio %></p>
                    <p class="card-text"><small class="text-muted">Last updated 3 mins ago</small></p>
                    <asp:Label CssClass="col-form-label" Text="Cantidad" runat="server" />
      <%--              <asp:DropDownList ID="dropList" OnSelectedIndexChanged="dropList_SelectedIndexChanged" AutoPostBack="true" CssClass="form-control" runat="server">
                        <asp:ListItem Value="0" Text="1" />
                        <asp:ListItem Value="1" Text="2" />
                        <asp:ListItem Value="2" Text="3" />
                        <asp:ListItem Value="3" Text="4" />
                        <asp:ListItem Value="4" Text="5" />
                    </asp:DropDownList>--%>
                </div>
                <div class="card-body">
                    <a href="Carrito.aspx?idPro=<% = producto.ID.ToString() %>&&idCant=" class="btn btn-primary">
                        <img src="Imgs/Cart.png" alt="Carrito" />
                    </a>
                    <a href="Favoritos.aspx?idPro=<% = producto.ID.ToString() %>" class="btn btn-primary">
                        <img src="Imgs/WhiteHeart.jpg" alt="Fav" />
                    </a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<%--                    <asp:Button Text="-" ID="btnMenos" CssClass="btn btn-primary" runat="server" OnSelectedIndexChanged="Menos_SelectedIndexChanged" AutoPostBack="true" />
                    <p><% = producto.carrito.Cant %></p>
                    <asp:Button Text="+" ID="btnMas" CssClass="btn btn-primary" runat="server" OnSelectedIndexChanged="Mas_SelectedIndexChanged" AutoPostBack="true" />--%>