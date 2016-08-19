<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="mostrarProductos.aspx.cs" Inherits="proyectoUniversidad.MostrarProductos.mostrarProductos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="tablaProductos"  runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="tablaProductos_SelectedIndexChanged">
            <Columns>
                <asp:BoundField HeaderText="Codigo" DataField="codigo" />
                <asp:BoundField HeaderText="Producto" DataField="nombre" />
                <asp:BoundField HeaderText="Cantidad" DataField="cantidad" />
                 <asp:TemplateField HeaderText="Detalle" ShowHeader="False">
                    <ItemTemplate>
                        <asp:ImageButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" ImageUrl="~/images/search.png" Width="25px" Height="25px"></asp:ImageButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
    </asp:GridView>
</asp:Content>
