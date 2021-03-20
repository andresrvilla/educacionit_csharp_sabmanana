<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.Administracion.Comentarios.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <asp:ListView runat="server" ID="lstComentarios">
        <LayoutTemplate>
            <table class="table">
              <thead>
                <tr>
                  <th scope="col">#</th>
                  <th scope="col">Autor</th>
                  <th scope="col">Acciones</th>
                </tr>
              </thead>
              <tbody>
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
              </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <th scope="row"><%#Eval("Id") %></th>
                <td><%#Eval("Autor") %></td>
                <td>
                    <a href="Eliminar.aspx?id=<%#Eval("Id") %>" class="btn btn-danger">Borrar</a>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
