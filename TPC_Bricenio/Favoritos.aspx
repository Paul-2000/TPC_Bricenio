<%@ Page Title="" Language="C#" MasterPageFile="~/MySiteMaster.Master" AutoEventWireup="true" CodeBehind="Favoritos.aspx.cs" Inherits="TPC_Bricenio.Favoritos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <% if (ListaFavoritos != null)
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
            <%foreach (var prod in ListaFavoritos)
                { n++;   %>
            <tr>

                <th scope="row"><% = n %></th>
                <td><% = prod.Nombre %> </td>
                <td><% = prod.IDMarca.Nombre %> </td>
                <td><% = prod.IDModelo.Nombre %> </td>
                <td><a href="Favoritos.aspx?idQui=<% = prod.ID.ToString() %>" class="btn btn-primary">Quitar</a></td>
            </tr>
            <% } %>

            <% } %>
            <%else
                { %>
            <h4>No tenes productos Favoritos por el momento.</h4>
            <% } %>
        </tbody>
    </table>
</asp:Content>
