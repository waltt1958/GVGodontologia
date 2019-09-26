<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="consultaPac.aspx.vb" Inherits="nombresPac" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Pacientes encontrados con el DNI o Apellido ingresado</h3>
    <asp:GridView ID="GridView1" runat="server" DataSourceID="AccessDataSource1" DataKeys="telediscado, celular, fijo, sexo, fechaNacimiento, mail, categoria, obraSocial, historiaClinica" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" HorizontalAlign="Center" AutoGenerateColumns="False" DataKeyNames="dni" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:BoundField DataField="aYnombre" HeaderText="NOMBRE" SortExpression="aYnombre" />
            <asp:BoundField DataField="dni" HeaderText="DNI" ReadOnly="True" SortExpression="dni" />
            <asp:BoundField DataField="direccion" HeaderText="DIRECCION" SortExpression="direccion" />
            <asp:BoundField DataField="cp" HeaderText="CP" SortExpression="cp" />
            <asp:BoundField DataField="localidad" HeaderText="LOCALIDAD" SortExpression="localidad" />
            <asp:BoundField DataField="telediscado" HeaderText="TELEDISCADO" SortExpression="telediscado" />
            <asp:BoundField DataField="celular" HeaderText="CELULAR" SortExpression="celular" />
            <asp:BoundField DataField="fijo" HeaderText="FIJO" SortExpression="fijo" />
            <asp:BoundField DataField="sexo" HeaderText="SEXO" SortExpression="sexo" Visible="False" />
            <asp:BoundField DataField="fechaNacimiento" HeaderText="FEC. NACIM." SortExpression="fechaNacimiento" Visible="False" />
            <asp:BoundField DataField="mail" HeaderText="MAIL" SortExpression="mail" />
            <asp:BoundField DataField="categoria" HeaderText="CATEGORIA" SortExpression="categoria" Visible="False" />
            <asp:BoundField DataField="obraSocial" HeaderText="OBRA SOCIAL" SortExpression="obraSocial" />
            <asp:BoundField DataField="historiaClinica" HeaderText="HIST. CLINICA" SortExpression="historiaClinica" Visible="False" />
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
            <asp:SessionParameter Name="aYnombre" SessionField="apellido" Type="String" />
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

