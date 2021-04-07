<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Blog.Administracion.Comentarios.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h1>Confirmación de eliminación de comentario</h1>
    <p>
        <b>Autor: </b><asp:Label runat="server" ID="lblAutor"></asp:Label>
    </p>
    <p>
        <b>Comentario:</b> <asp:Label runat="server" id="lblComentario"></asp:Label>
    </p>
    <div class="alert alert-warning" role="alert">
      ¿Desea borrar el comentario?<br />
      <a href="Default.aspx" class="btn btn-primary">No</a>
      <asp:Button runat="server" ID="btnBorrar" CssClass="btn btn-danger" Text="Si" OnClick="btnBorrar_Click" />
    </div>
</asp:Content>
