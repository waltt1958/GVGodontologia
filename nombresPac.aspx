<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="nombresPac.aspx.vb" Inherits="nombresPac" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Pacientes encontrados - Seleccione el que necesite actualizar</h3>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="AccessDataSource1" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" HorizontalAlign="Center" AutoGenerateColumns="False" DataKeyNames="dni">
        <Columns>
            <asp:CommandField HeaderText="MODIFICAR" ShowSelectButton="True" CancelText="cancelar" DeleteText="eliminar" InsertText="insertar" NewText="nuevo" >
            <ControlStyle Font-Bold="True" />
            </asp:CommandField>
            <asp:BoundField DataField="aYnombre" HeaderText="APELLIDO" SortExpression="aYnombre" />
            <asp:BoundField DataField="direccion" HeaderText="DIRECCION" SortExpression="direccion" />
            <asp:BoundField DataField="cp" HeaderText="CP" />
            <asp:BoundField DataField="localidad" HeaderText="LOCALIDAD" />
            <asp:BoundField DataField="telediscado" HeaderText="TELEDISCADO" />
            <asp:BoundField DataField="celular" HeaderText="CELULAR" />
            <asp:BoundField DataField="fijo" HeaderText="TEL. FIJO" />
            <asp:BoundField DataField="sexo" HeaderText="SEXO" />
            <asp:BoundField DataField="fechaNacimiento" HeaderText="FEC. NACIM." />
            <asp:BoundField DataField="dni" HeaderText="DNI" ReadOnly="True" SortExpression="dni" />
            <asp:BoundField DataField="mail" HeaderText="MAIL" />
            <asp:BoundField DataField="categoria" HeaderText="CATEGORIA" />
            <asp:BoundField DataField="obraSocial" HeaderText="OBRA SOCIAL" />
            <asp:BoundField DataField="historiaClinica" HeaderText="HIST. CLINICA" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
    <asp:AccessDataSource runat="server" ID="AccessDataSource1" DataFile="~/bbdd/gvg.accdb" SelectCommand="SELECT * FROM [pacientes] WHERE ([aYnombre] LIKE '%' + ? + '%') ORDER BY [aYnombre]">
        <SelectParameters>
            <asp:SessionParameter Name="aYnombre2" SessionField="apellido" Type="String" />
        </SelectParameters>
    </asp:AccessDataSource>
    <br />
    <table style="width: 30%;" align="center" border="2" cellspacing="0" bordercolor="black">
            <tr>
           <td align="center">
           <asp:Button ID="btVolver" PostBackUrl="~/index.aspx" CausesValidation="false" CssClass="button" runat="server" Text="VOLVER AL INICIO"></asp:Button>
           </td>
           </tr>
       </table>
    </asp:Content>

