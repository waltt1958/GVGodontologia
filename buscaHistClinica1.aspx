<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="buscaHistClinica1.aspx.vb" Inherits="nombresPac" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Pacientes encontrados con el Apellido ingresado</h3>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" DataKeyNames="dni" HorizontalAlign="Center" DataSourceID="histClinica">
        <Columns>
            <asp:CommandField HeaderText="ELEGIR" ShowSelectButton="True" />
            <asp:BoundField DataField="aYnombre" HeaderText="APELLIDO" SortExpression="aYnombre" />
            <asp:BoundField DataField="dni" HeaderText="DNI" ReadOnly="True" SortExpression="dni" />
            <asp:BoundField DataField="direccion" HeaderText="DIRECCION" SortExpression="direccion" />
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
    <asp:AccessDataSource ID="histClinica" runat="server" DataFile="~/bbdd/gvg.accdb" SelectCommand="SELECT [aYnombre], [direccion], [dni] FROM [pacientes] WHERE ([aYnombre] LIKE '%' + ? + '%') ORDER BY [aYnombre]">
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

