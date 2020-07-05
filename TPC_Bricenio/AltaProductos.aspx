<%@ Page Title="" Language="C#" MasterPageFile="~/MySiteMaster.Master" AutoEventWireup="true" CodeBehind="AltaProductos.aspx.cs" Inherits="TPC_Bricenio.AltaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<asp:DropDownList ID="cboProductos" runat="server"/>--%>

    <div class="container">
        <div class="row">
            <div class="col">
                <h1>Alta de nuevos Productos</h1>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <div class="form-group">
                    <div class="form-group">
                        <asp:Label CssClass="col-form-label" Text="Nombre" runat="server" />
                        <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="col-form-label" Text="Marca" runat="server" />
                        <asp:DropDownList CssClass="form-control" ID="dropDownMarca" runat="server" OnSelectedIndexChanged="dropDownMarca_SelectedIndexChanged" AutoPostBack="true" Width="300"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="col-form-label" Text="Modelo" runat="server" />
                        <asp:DropDownList CssClass="form-control" ID="dropDownModelo" runat="server" OnSelectedIndexChanged="dropDownModelo_SelectedIndexChanged" AutoPostBack="true" Width="300"></asp:DropDownList>
                    </div>
                    <div class="form-gruop">
                    <asp:Label CssClass="col-form-label" Text="Condicion" runat="server" />
                        <asp:DropDownList CssClass="form-control" ID="dropDownCondicion" runat="server" OnSelectedIndexChanged="dropDownCondicion_SelectedIndexChanged" AutoPostBack="true" Width="300"></asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="col-form-label" Text="Descripción" runat="server" />
                        <%--<textarea class="form-control" id="txtDescripcion" rows="8" placeholder="Escriba una Descripción."></textarea>--%>
                        <asp:TextBox CssClass="form-control" ID="txtDescripcion" rows="8" placeholder="Escriba una Descripción." runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="col-form-label" Text="Precio" runat="server" />
                        <div class="controls">
                            <div class="input-prepend input-group">
                                <div class="input-group-prepend"><span class="input-group-text">$</span></div>
                                <asp:TextBox CssClass="form-control" ID="txtPrecio" size="16" runat="server" />
                                <div class="input-group-append"><span class="input-group-text">.00</span></div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="col-form-label" Text="Imagen URL" runat="server" />
                        <asp:TextBox CssClass="form-control" ID="imgURL" runat="server" />
                    </div>
                    <asp:Button CssClass="btn btn-dark" ID="btnAgregar" Text="Agregar" runat="server" OnClick="btnAgregar_Click"/>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
