<%@ Page Title="" Language="C#" MasterPageFile="~/Navbar-Carrito.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="TPC_Bricenio.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <% if (ListaCarrito != null)
        {%>
    <table class="table table-striped table-dark">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">Nombre</th>
                <th scope="col">Marca</th>
                <th scope="col">Modelo</th>
                <th scope="col">Accion</th>
            </tr>
        </thead>
        <tbody>
            <% int n = 0; %>
            <%foreach (var prod in ListaCarrito)
                {
                    n++;   %>
            <tr>

                <th scope="row"><% = n %></th>
                <td><% = prod.Nombre %> </td>
                <td><% = prod.IDMarca.Nombre %> </td>
                <td><% = prod.IDModelo.Nombre %> </td>
                <td><a href="Carrito.aspx?idQui=<% = prod.ID.ToString() %>" class="btn btn-primary">Quitar</a></td>
            </tr>
            <% } %>

            <% } %>
            <%else
                { %>
            <h4>No tenes productos en el Carrito por el momento.</h4>
            <% } %>
        </tbody>
    </table>

</asp:Content>
