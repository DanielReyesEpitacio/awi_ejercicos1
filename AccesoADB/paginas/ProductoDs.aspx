<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductoDs.aspx.cs" Inherits="AccesoADB.paginas.ProductoDs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
      <br />
        <br />
        <center>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <br />
            <a href="../Index.aspx">Regresar</a>
        </center>
    </form>
    <script src="Pops/popper.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
