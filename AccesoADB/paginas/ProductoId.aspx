<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductoId.aspx.cs" Inherits="AccesoADB.paginas.ProductoId" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Busqueda de articulos por ID</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                Seleccione ID<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                <div class="container mt-5">
                    <div class="row row-cols-2 border">
                        <div class="col border-end border-bottom text-end">ID producto</div>
                        <div class="col border-bottom text-start">
                            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        </div>
                        <div class="col border-end border-bottom text-end">Nombre</div>
                        <div class="col border-end border-bottom text-start">
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        </div>
                        <div class="col border-end border-bottom text-end">Descripcion</div>
                        <div class="col border-end border-bottom text-start">
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                        </div>
                        <div class="col border-end text-end">Precio Unitario:</div>
                        <div class="col text-start">
                            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                        </div>
                    </div>
                </div>
                <a href="../Index.aspx">Regresar...</a>
            </center>
        </div>
    </form>
    <script src="../Pops/popper.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</body>
</html>
