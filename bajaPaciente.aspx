<%@ Page Title="" Language="VB" MasterPageFile="~/M.master" AutoEventWireup="false" CodeFile="bajaPaciente.aspx.vb" Inherits="bajaPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <table style="width: 45%;" align="center" border="2" cellspacing="0" bordercolor="black">
        <tr>
            <td width="50%"><asp:Label ID="LblDNI" Font-Size="14" runat="server" Font-Bold="True" Text="DNI"></asp:Label></td>
            <td width="30%" align="center">
                <asp:TextBox ID="dni" MaxLength="10" onkeypress="return validaNumericos(event)" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Complete el número de DNI" ControlToValidate="dni" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td width="50%"><asp:Label ID="lblaYn" Font-Size="14" runat="server" Font-Bold="True" Text="Apellido y nombre"></asp:Label></td>
            <td width="30%" align="center">
                <asp:TextBox ID="aYnombre" MaxLength="60" onkeypress="return soloLetras(event)" runat="server" ReadOnly="True"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Complete el apellido y nombre"  ControlToValidate="aYnombre" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
                    <tr>
           <td align="center"> <asp:Button ID="btbaja" CssClass="button" runat="server" Text="BAJA"></asp:Button></td>
           <td align="center"><asp:Button ID="btcancelar" CausesValidation="false" CssClass="button" runat="server" Text="CANCELAR"></asp:Button></td>
        </tr>
        <tr>
           <td colspan="2" align="center">
           <asp:Button ID="btVolver" PostBackUrl="~/index.aspx" CausesValidation="false" CssClass="button" runat="server" Text="VOLVER AL INICIO"></asp:Button>
        </td>
        </tr>
       </table>
</asp:Content>

