<%@ Page Title="Pavenbri" Language="C#" MasterPageFile="~/MySiteMaster.Master" AutoEventWireup="true" CodeBehind="InicioWeb.aspx.cs" Inherits="TPC_Bricenio.Inicio_web" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:DropDownList runat="server" ID="cboProductos" />--%>
    <asp:Label Text="Te damos la Bienvenida..." ID="lblBienvenida" runat="server" />
    
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
