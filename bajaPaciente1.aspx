<%@ Page Title="" Language="VB" MasterPageFile="~/M.master" AutoEventWireup="false" CodeFile="bajaPaciente1.aspx.vb" Inherits="bajaPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h3>BAJA DE PACIENTE DE LA BASE DE DATOS - Verificar existencia de Paciente</h3>

     <table style="width: 45%;" align="center" border="2" cellspacing="0" bordercolor="black">
        <tr>
            <td width="50%"><asp:Label ID="LblDNI" Font-Size="14" runat="server" Font-Bold="True" Text="DNI"></asp:Label></td>
            <td width="30%" align="center">
                <asp:TextBox ID="VERIFdni" MaxLength="10" onkeypress="return validaNumericos(event)" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Complete el número de DNI" ControlToValidate="VERIFdni" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
           <td align="center">
           <asp:Button ID="btVolver" PostBackUrl="~/index.aspx" CausesValidation="false" CssClass="button" runat="server" Text="VOLVER AL INICIO"></asp:Button>
           </td>
            <td align="center">
           <asp:Button ID="btVERIFICA" CssClass="button" runat="server" Text="VERIFICA PACIENTE"></asp:Button>
        </td>
        </tr>
       </table>

    <script>

        function validaNumericos(event) {
            if (event.charCode >= 48 && event.charCode <= 57) {
                return true;
            }
            return false;
        }
    </script>
</asp:Content>


