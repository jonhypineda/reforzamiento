<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="RegistroClientes.aspx.vb" Inherits="RegistroClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="nav-justified">
        <tr>
            <td colspan="2"><H1>REGISTRO DE CLIENTES</H1></td>
        </tr>
        <tr>
            <td style="width: 176px">
                <asp:Label ID="Label1" runat="server" Text="ID CLIENTE"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TXT_IC" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 8px; width: 176px">
                <asp:Label ID="Label2" runat="server" Text="NOMBRE COMPLETO"></asp:Label>
            </td>
            <td style="height: 8px">
                <asp:TextBox ID="TXT_NC" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 22px; width: 176px">
                <asp:Label ID="Label3" runat="server" Text="SEXO"></asp:Label>
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="TXT_SEX" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 176px">
                <asp:Label ID="Label4" runat="server" Text="EDAD"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TXT_EDAD" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 176px">
                <asp:Label ID="Label5" runat="server" Text="OBSERVACIONES"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TXT_OBS" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="BTN_GUA" runat="server" Text="GUARDAR" />
                <asp:Button ID="BTN_MOD" runat="server" Text="MODIFICAR" />
                <asp:Button ID="BTN_ELI" runat="server" Text="ELIMINAR" />
                <asp:Button ID="BTN_BUS" runat="server" Text="BUSCAR" />
                <asp:Button ID="BTN_LIMP" runat="server" Text="LIMPIAR" />
                <asp:Label ID="LBL_RESPUESTA" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

