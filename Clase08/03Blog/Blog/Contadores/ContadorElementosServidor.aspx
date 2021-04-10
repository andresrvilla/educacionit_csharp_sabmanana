<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="ContadorElementosServidor.aspx.cs" Inherits="Blog.Contadores.ContadorElementosServidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h3>Contador Elementos Servidor</h3>
    <asp:Label runat="server" ID="lblContador">0</asp:Label><br />
    <asp:Button runat="server" ID="btnContar" Text="Contar" OnClick="btnContar_Click" />
</asp:Content>
