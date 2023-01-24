<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="AccesoADB.paginas.Producto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <center >
                <h3>
                    REGISTRO DE NUEVO PRODUCTO
                </h3>
            </center>
            <div class="mb-3">
                <label class="form-label">Nombre Producto</label>
                <input id="text1" type="text" runat="server" required pattern="[A-Za-z áéíóú]" title="Capture solo texto" class="form-control" />
            </div>

            <div class="mb-3">
                <label class="form-label">Descripcion</label>
                <input id="text2" type="text" runat="server" required pattern="[A-Za-z-áéíóú. 0-9]" title="Se permiten solo texto, digitos, espacios y puntos" class="form-control" />
            </div>

           <div class="mb-3">
                <label class="form-label">NombreImagen</label>
                <input id="text3" type="text" runat="server" required pattern="[A-Za-z áéíóú. 0-9_-]" title="No se permiten caracteres especiales" class="form-control" />
            </div>

            <div class="mb-3">
                <label class="form-label">Precio unitario</label>
                <input id="text4" type="text" runat="server" required pattern="[0-9.]+" title="Capture digitos y un punto decimal" class="form-control" />
            </div>

            <div class="mb-3">
                <label class="form-label">Id categoria</label>
                <input id="text" type="text" runat="server" required pattern="[0-9]" title="Capture solo números" class="form-control" />
            </div>
            <div class="mb-5">
                <asp:Button ID="agregar_producto" runat="server" Text="Agregar producto" CssClass="btn-outline-warning"/>
            </div>
        </div>
    </form>

    <script src="../Pops/popper.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
