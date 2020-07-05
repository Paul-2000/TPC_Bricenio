<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sesion.aspx.cs" Inherits="TPC_Bricenio.Sesion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Iniciar Sesión</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <!-- Image and text -->
        <nav class="navbar navbar-dark bg-dark navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="#">
                <img src="/docs/4.5/assets/brand/bootstrap-solid.svg" width="30" height="30" class="d-inline-block align-top" alt="" loading="lazy">
                Briceño
            </a>
            <form class="form-inline my-2 my-lg-0">
                <%--                    <input class="form-control mr-sm-2" type="search" placeholder="Search" aria-label="Search">--%>
                <asp:TextBox ID="txtBuscar" CssClass="form-control mr-sm-2" placeholder="Buscar" runat="server" />

                <%--<button class="" type="submit"></button>--%>
                <asp:Button CssClass="btn btn-outline-success my-2 my-sm-0" ID="btnBuscar" Text="Buscar" runat="server" />
            </form>
        </nav>
        <nav class="navbar navbar-dark bg-dark navbar-expand-lg navbar-light bg-light">
            <a class="navbar-brand" href="#">Pavenbri</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav mr-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Home <span class="sr-only">(current)</span></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Link</a>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">Opciones
                        </a>
                        <div class="dropdown-menu" aria-labelledby="navbarDropdown">
                            <a class="dropdown-item" href="#">Action</a>
                            <a class="dropdown-item" href="#">Another action</a>
                            <div class="dropdown-divider"></div>
                            <a class="dropdown-item" href="#">Something else here</a>
                        </div>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link disabled" href="#" tabindex="-1" aria-disabled="true">Disabled</a>
                    </li>
                </ul>

            </div>
        </nav>

        <div class="container">
            <div class="row">
                <div class="col">
                    <h1>Bienvenido a su inicio de Sesión</h1>
                    <div class="alert alert-success" role="alert">
                        ¡Iniciaste sesión correctamente!
                    </div>
                    <div class="alert alert-danger" role="alert">
                        ¡Usuario o contraseña es incorrecto!
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <label>Email address</label>
                        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" />

                        <small id="emailHelp" class="form-text text-muted">Tu Email tiene que ser Ejemplo@gmail.com</small>
                    </div>
                    <div class="form-group">
                        <label>Password</label>
                        <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" />
                    </div>

                    <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" runat="server" />

                </div>
            </div>
        </div>

    </form>
</body>
</html>
