<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="VerPost.aspx.cs" Inherits="Blog.VerPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h1><asp:Label runat="server" ID="lblTitulo"></asp:Label></h1>
    <hr />
    <asp:Label runat="server" ID="lblContenido"></asp:Label>
    <hr />
    <h3>Comentarios del post</h3>
    <asp:ListView runat="server" ID="lstComentarios">
        <LayoutTemplate>
            <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
        </LayoutTemplate>
        <ItemTemplate>
            <b>Autor:</b> <%#Eval("Autor") %> <br />
            <b>Comentario:</b><br /><%#Eval("Comentario1") %><br />
            <hr />
        </ItemTemplate>
        <EmptyDataTemplate>
            <i>No se encontraron comentarios</i>
        </EmptyDataTemplate>
    </asp:ListView>
    <hr />
    <h5>Agregar nuevo comentario</h5>
    Autor:<br />
    <asp:TextBox runat="server" ID="txtAutor" CssClass="form-control"></asp:TextBox><br />
    Comentario:<br />
    <asp:TextBox runat="server" ID="txtComentario" CssClass="form-control mb-2" Rows="10" TextMode="MultiLine"></asp:TextBox>
    <asp:Button runat="server" ID="btnGuardar" CssClass="btn btn-block btn-primary" Text="Guardar" OnClick="btnGuardar_Click" />
</asp:Content>
