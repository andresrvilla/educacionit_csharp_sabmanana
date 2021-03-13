<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="VerPost.aspx.cs" Inherits="Blog.VerPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h1><asp:Label runat="server" ID="lblTitulo"></asp:Label></h1>
    <hr />
    <asp:Label runat="server" ID="lblContenido"></asp:Label>    
</asp:Content>
