<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="modificarProducto.aspx.cs" Inherits="proyectoUniversidad.Productos.modificarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>Nombre:</td>
            <td> <asp:TextBox ID="txtNombre" runat="server" Width="386px"></asp:TextBox>  </td>
        </tr>
        <tr>
            <td>Codigo:</td>
            <td>  <asp:TextBox ID="txtCodigo" Enabled="false" runat="server" Width="387px"></asp:TextBox> </td>
        </tr>
        <tr>
            <td>Cantidad</td>
            <td> <asp:TextBox ID="txtCantidad" Enabled="true" runat="server" Width="387px"></asp:TextBox> </td>
        </tr>
        <tr>
            <td>Activo:</td>
            <td> <asp:CheckBox ID="chkboxActivo" runat="server" />  </td>
        </tr>
        <tr>
            <td></td>
            <td> <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />  </td>
        </tr>
    </table>
</asp:Content>
