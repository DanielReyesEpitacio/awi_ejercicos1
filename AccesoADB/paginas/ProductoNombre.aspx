<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductoNombre.aspx.cs" Inherits="AccesoADB.paginas.ProductoNombre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                Seleccione nombre: <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                <br />
                <br />
                <a href="../Index.aspx">Regresar</a>
            </center>
        </div>
    </form>
</body>
</html>
