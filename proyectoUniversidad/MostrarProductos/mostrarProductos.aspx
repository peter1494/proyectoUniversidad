<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="mostrarProductos.aspx.cs" Inherits="proyectoUniversidad.MostrarProductos.mostrarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="tabla1"  runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField HeaderText="Codigo:" DataField="codigo" />
                <asp:BoundField HeaderText="Producto:" DataField="nombre" />
                <asp:BoundField HeaderText="Cantidad:" DataField="cantidad" />
            </Columns>
    </asp:GridView>
</asp:Content>
