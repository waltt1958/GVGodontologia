<%@ Page Title="" Language="VB" MasterPageFile="~/M.master" AutoEventWireup="false" CodeFile="altaPaciente.aspx.vb" Inherits="altaPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>ALTA DE PACIENTE A LA BASE DE DATOS</h3>

    <table style="width: 45%;" align="center" border="2" cellspacing="0" bordercolor="black">
        <tr>
            <td width="50%"><asp:Label ID="LblDNI" Font-Size="14" runat="server" Font-Bold="True" Text="DNI"></asp:Label></td>
            <td width="30%" align="center">
               <div class="tdCenter" ><asp:TextBox ID="dni" MaxLength="10"  onkeypress="return validaNumericos(event)" runat="server"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Complete el número de DNI" ControlToValidate="dni" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td width="50%"><asp:Label ID="lblaYn" Font-Size="14" runat="server" Font-Bold="True" Text="Apellido y nombre"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="aYnombre" MaxLength="60" onkeypress="return soloLetras(event)" runat="server"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Complete el apellido y nombre"  ControlToValidate="aYnombre" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
                  <tr>
            <td width="50%"><asp:Label ID="LblDireccion" Font-Size="14" runat="server" Font-Bold="True" Text="Dirección"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="direccion" MaxLength="60" runat="server"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Complete la dirección" ControlToValidate="direccion" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>  
         <tr>
            <td width="50%"><asp:Label ID="LabelCP" Font-Size="14" runat="server" Font-Bold="True" Text="Cod. Postal"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="CP" MaxLength="8" onkeypress="return validaNumericos(event)" runat="server"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Complete el CP" ControlToValidate="CP" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr> 
         <tr>
            <td width="50%"><asp:Label ID="Labelocalidad" Font-Size="14" runat="server" Font-Bold="True" Text="Localidad"></asp:Label></td>
             <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="localidad" MaxLength="40" onkeypress="return soloLetras(event)" runat="server"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Complete la localidad" ControlToValidate="localidad" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td width="50%"><asp:Label ID="LabelTeled" Font-Size="14" runat="server" Font-Bold="True" Text="Telediscado"></asp:Label></td>
            <td width="30%" align="center">
               <div class="tdCenter" ><asp:TextBox ID="telediscado" MaxLength="8" onkeypress="return validaNumericos(event)" runat="server"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Complete el telediscado" ControlToValidate="telediscado" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td width="50%"><asp:Label ID="LabelCelular" Font-Size="14" runat="server" Font-Bold="True" Text="Celular"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="celular" MaxLength="10" onkeypress="return validaNumericos(event)" runat="server"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Complete el numero de celular" ControlToValidate="celular" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td width="50%"><asp:Label ID="LabelFijo" Font-Size="14" runat="server" Font-Bold="True" Text="Telefono fijo"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="fijo" MaxLength="10" onkeypress="return validaNumericos(event)" runat="server"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Complete el teléfono fijo" ControlToValidate="fijo" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td width="50%"><asp:Label ID="Labelsexo" Font-Size="14" runat="server" Font-Bold="True" Text="Sexo"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:DropDownList ID="sexo" Width="57%" AutoPostBack="true" runat="server"> 
                <asp:ListItem Value="Femenino" Text="Femenino"></asp:ListItem> 
                <asp:ListItem Value="Masculino" Text="Masculino"></asp:ListItem> 
                <asp:ListItem Value="Otro" Text="Otro"></asp:ListItem> 
                </asp:DropDownList></div> 
            </td>
         </tr>
         <tr>
            <td width="50%"><asp:Label ID="LabelFecNac" Font-Size="14" runat="server" Font-Bold="True" Text="Fecha de nacimiento"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="FecNac" MaxLength="10" runat="server" Width="57%" TextMode="Date"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Complete la fecha de nacimiento" ControlToValidate="FecNac" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td width="50%"><asp:Label ID="LabelMail" Font-Size="14" runat="server" Font-Bold="True" Text="Correo electrónico"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="mail" MaxLength="40" runat="server" TextMode="Email"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Complete el correo electrónico" ControlToValidate="mail" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
     
         <tr>
            <td width="50%"><asp:Label ID="LabelObra" Font-Size="14" runat="server" Font-Bold="True" Text="Obra social"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="obra" MaxLength="50" runat="server"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="Complete la Obra Social" ControlToValidate="obra" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td width="50%"><asp:Label ID="LabelCateg" Font-Size="14" runat="server" Font-Bold="True" Text="Categoria"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="categoria" MaxLength="20" runat="server"></asp:TextBox></div>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ErrorMessage="Complete la categoria" ControlToValidate="categoria" Font-Bold="true" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td width="50%"><asp:Label ID="memo" Font-Size="14" runat="server" Font-Bold="True" Text="Historia Clínica"></asp:Label></td>
            <td width="30%" align="center">
                <div class="tdCenter" ><asp:TextBox ID="histClinica" Columns="40" Rows="10" runat="server" TextMode="MultiLine"></asp:TextBox></div>
            </td>
         </tr>
        <tr>
           <td align="center"> <asp:Button ID="btaceptar" CssClass="button" runat="server" Text="ACEPTAR"></asp:Button></td>
           <td align="center"><asp:Button ID="btcancelar" CausesValidation="false" CssClass="button" runat="server" Text="CANCELAR"></asp:Button></td>
        </tr>
        <tr>
        <td colspan="2" align="center">
           <asp:Button ID="btVolver" PostBackUrl="~/index.aspx" CausesValidation="false" CssClass="button" runat="server" Text="VOLVER AL INICIO"></asp:Button>
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

            function soloLetras(e) {
                key = e.keyCode || e.which;
                tecla = String.fromCharCode(key).toLowerCase();
                letras = " áéíóúabcdefghijklmnñopqrstuvwxyz";
                especiales = "8-37-39-46";

                tecla_especial = false
                for (var i in especiales) {
                    if (key == especiales[i]) {
                        tecla_especial = true;
                        break;
                    }
                }

                if (letras.indexOf(tecla) == -1 && !tecla_especial) {
                    return false;
                }
            }
    </script>

</asp:Content>

