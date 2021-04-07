<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Sitio.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h3>Posts recientes</h3>
    <div class="col">
        <asp:DropDownList runat="server" ID="cmbCategorias" DataTextField="Nombre" DataValueField="Id" OnSelectedIndexChanged="cmbCategorias_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList><br />
        <asp:DropDownList runat="server" ID="cmbSubCategorias" DataTextField="Nombre" DataValueField="Id"></asp:DropDownList>
    </div>
    <asp:Panel runat="server" ID="pnlErrorPosts" CssClass="alert alert-danger" Visible="false">
        <asp:Label runat="server" ID="lblError"></asp:Label>
    </asp:Panel>
    <asp:ListView runat="server" ID="lstPosteos">
        <LayoutTemplate> <%-- Equivalente a la "MasterPage" --%>
            <div class="card-columns">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
            </div>
        </LayoutTemplate>
        <ItemTemplate> <%-- Equivalente a el WebForm con MasterPage. Este se repite por cada elemento --%>
            <div class="card">
                <div class="card-body">
                    <h5 class="card-title">
                        <a href="VerPost.aspx?id=<%#Eval("Id") %>">
                            <%#Eval("Titulo") %>
                        </a>
                    </h5>
                    <p class="card-text"><%#Eval("Resumen") %></p>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
