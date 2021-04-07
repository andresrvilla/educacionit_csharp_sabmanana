<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="ContadorViewState.aspx.cs" Inherits="Blog.Contadores.ContadorViewState" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h3>Contador</h3>
    <asp:Label runat="server" ID="lblContador">0</asp:Label><br />
    <asp:Button runat="server" ID="btnContar" Text="Contar" OnClick="btnContar_Click" />
</asp:Content>
