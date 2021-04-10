<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="Blog.Administracion.Categorias.Editar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <div class="row">
        <div class="col-12">
            <asp:Panel runat="server" ID="pnlError" CssClass="alert alert-danger" Visible="false">
                <asp:Label runat="server" ID="lblError"></asp:Label>
            </asp:Panel>
        </div>
        <div class="col-12">
            Nombre:
        <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-12">
            <div class="col-md-6">
                <asp:Button runat="server" ID="btnGuardar" CssClass="btn btn-primary btn-block" Text="Guardar" OnClick="btnGuardar_Click" />
            </div>
            <div class="col-md-6">
                <a href="Default.aspx" class="btn btn-danger btn-block">Cancelar</a>
            </div>
        </div>

    </div>

</asp:Content>
