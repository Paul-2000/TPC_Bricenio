<%@ Page Title="" Language="C#" MasterPageFile="~/MySiteMaster.Master" AutoEventWireup="true" CodeBehind="ListadoProductos.aspx.cs" Inherits="TPC_Bricenio.ListadoProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="ListaProducto" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>LISTADO DE PRODUCTOS</h1>

    <%--<asp:TextBox runat="server" AutoPostBack="true" ID="txtNumeroProducto" OnTextChanged="txtNumeroProducto_TextChanged" />--%>
    <%--    <asp:DropDownList runat="server" ID="cboProductos" />--%>


    <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">
        <%foreach (var item in ListaProductos)
            {%>
        <a href="ProductosDetail.aspx?idPro=<% = item.ID.ToString() %>">
            <div class="card" style="width: 18rem;">
                <img src="<% = item.ImagenURL %>" class="card-img-top" alt="Imagen del producto">
                <div class="card-body">
                    <h5 class="card-title"><%= item.Nombre %></h5>
                    <p class="card-text"><%= item.Descripcion %></p>

                </div>
                <div class="card-body">
                    <a href="Favoritos.aspx?idPro=<% = item.ID.ToString() %>" style="display: flex; justify-content: center;" class="btn btn-primary">
                        <img src="Imgs/WhiteHeart.jpg" alt="Fav"/>
                    </a>
                </div>
            </div>
        </a>
        <%} %>
    </div>

</asp:Content>
