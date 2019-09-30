<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="cumpleanos.aspx.vb" Inherits="cumpleanosDefault" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>CUMPLEAÑOS DEL MES ACTUAL</h3>

    <div align="center">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BorderColor="Black" BorderStyle="Solid" CellPadding="4" DataKeyNames="dni" DataSourceID="conexCumpleanos" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="aYnombre" HeaderText="NOMBRE" SortExpression="aYnombre" />
                <asp:BoundField DataField="localidad" HeaderText="LOCALIDAD" SortExpression="localidad" Visible="False" />
                <asp:BoundField DataField="telediscado" HeaderText="TELEDISCADO" SortExpression="telediscado" />
                <asp:BoundField DataField="celular" HeaderText="CELULAR" SortExpression="celular" />
                <asp:BoundField DataField="sexo" HeaderText="SEXO" SortExpression="sexo" />
                <asp:BoundField DataField="fechaNacimiento" HeaderText="FEC. NACIMIENTO" SortExpression="fechaNacimiento" DataFormatString="{0:dd-MM-yyyy}" />
                <asp:BoundField DataField="dni" HeaderText="DNI" ReadOnly="True" SortExpression="dni" />
                <asp:BoundField DataField="mail" HeaderText="CORREO ELECTRON." SortExpression="mail" />
                <asp:CommandField HeaderText="ENVIAR MAIL" SelectText="enviar mail" ShowSelectButton="True" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:AccessDataSource ID="conexCumpleanos" runat="server" DataFile="~/bbdd/gvg.accdb" SelectCommand="SELECT [aYnombre], [telediscado], [celular], [sexo], [fechaNacimiento], [dni], [mail] FROM [pacientes] WHERE ( month([fechaNacimiento]) like  ?) ORDER BY [fechaNacimiento]">
            <SelectParameters>
                <asp:SessionParameter Name="?" SessionField="mesActual" Type="Decimal" />
            </SelectParameters>
        </asp:AccessDataSource>
        <br />
        <br />
    <asp:Button ID="btVolver" PostBackUrl="~/index.aspx" CausesValidation="false" CssClass="button" runat="server" Text="VOLVER AL INICIO"></asp:Button>
     </div>
</asp:Content>

