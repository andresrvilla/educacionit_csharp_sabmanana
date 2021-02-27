<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PaginaWeb.Default" %>
<%-- Markup --%>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Saludador</h1>
            Ingrese su nombre:
            <asp:TextBox runat="server" ID="txtNombre"></asp:TextBox><br />
            <asp:Button runat="server" ID="btnSaludar" Text="Saludar" OnClick="btnSaludar_Click" /><br />
            <asp:Label runat="server" ID="lblSaludo"></asp:Label>
        </div>
    </form>
</body>
</html>
