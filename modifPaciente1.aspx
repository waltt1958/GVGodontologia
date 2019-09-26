<%@ Page Title="" Language="VB" MasterPageFile="~/M.master" AutoEventWireup="false" CodeFile="modifPaciente1.aspx.vb" Inherits="aaa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        #Radio1 {
            width: 58px;
        }
        #Radio2 {
            width: 88px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>MODIFICACION DATOS PACIENTE - Verificar existencia del Paciente</h3>

     <table style="width: 45%;" align="center" border="2" cellspacing="0" bordercolor="black">
        <tr>
            <td width="50%"><asp:Label ID="apellido" Font-Size="14" runat="server" Font-Bold="True" Text="APELLIDO / DNI"></asp:Label></td>
            <td width="30%" align="center">
                <asp:TextBox ID="buscaApe" MaxLength="60" onkeypress="return isNumberOrLetter(evt)" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Ingrese el apellido o DNI" ControlToValidate="buscaAPE" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td align="center" width="50%" colspan="2"><h4>Seleccione el dato a introducir para la búsqueda del paciente</h4></td>
         </tr>
        <tr>
            <td align="center" width="50%" colspan="2">
                
            <b><asp:RadioButtonList ID="radio2" runat="server" style="margin-left: 0px" Font-Size="XX-Large"><asp:ListItem Text="Documento"></asp:ListItem><asp:ListItem  Text="Apellido"></asp:ListItem> </asp:RadioButtonList> </b>  
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

<SCRIPT language=Javascript>

        function isNumberOrLetter(evt) {

        var charCode = (evt.which) ? evt.which : event.keyCode;

        if ((charCode > 65 && charCode < 91) || (charCode > 97 && charCode < 123) || (charCode > 47 && charCode < 58))

            return true;

        return false;
    }

  </SCRIPT>

</asp:Content>


