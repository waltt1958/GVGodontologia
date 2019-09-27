<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="historiaClinica.aspx.vb" Inherits="historiaClinica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Historia clínica del paciente</h3>
    <div style="text-align:center">   
        <asp:TextBox ID="nombre"  runat="server" BackColor="#FFFFCC" BorderStyle="Solid" Columns="60" ReadOnly="true" Font-Size="Medium"  Font-Bold="true"></asp:TextBox>
        <br />
        <asp:TextBox ID="historia" runat="server" BackColor="#FFFFCC" BorderStyle="Solid" Columns="90" MaxLength="10000" ReadOnly="True" Rows="5" style="margin-left: 8px; margin-top: 0px" TextMode="MultiLine" Width="1007px" Font-Bold="True" Font-Size="Larger"></asp:TextBox>
        <br />
        <asp:Button ID="btnGrabar" runat="server" CssClass="button" Text="GRABAR" Visible="False" />
        <asp:Button ID="btnModificar" runat="server" CssClass="button" Text="MODIFICAR" />
        </div>

    <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataSourceID="mostrarHistoria" AllowSorting="True" CellPadding="4" ForeColor="#333333" AllowPaging="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="link" HeaderText="FOTO" SortExpression="link" />
            <asp:BoundField DataField="dni" HeaderText="dni" SortExpression="dni" Visible="False" />
            <asp:BoundField DataField="aYnombre" HeaderText="NOMBRE" SortExpression="aYnombre" Visible="False" />
            <asp:HyperLinkField DataNavigateUrlFields="link" DataNavigateUrlFormatString="{0}" HeaderText="MOSTRAR FOTO" SortExpression="link" Target="_blank" Text="mostrar foto" />
            <asp:BoundField DataField="fecha" HeaderText="FECHA" SortExpression="fecha" />
            <asp:BoundField DataField="historiaClinica" HeaderText="historiaClinica" SortExpression="historiaClinica" Visible="False" />
            <asp:CommandField ButtonType="Button" HeaderText="ELIMINAR" SelectText="eliminar foto" ShowSelectButton="True" />
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
    <br />
    <asp:FileUpload ID="cargArchivo"   runat="server" BackColor="Lime" BorderStyle="Solid" Height="28px" Width="306px" style="margin-left: 580px" />
    <asp:RegularExpressionValidator ID="control" runat="server"
     ControlToValidate="cargArchivo"
     ErrorMessage="Solo imágenes jpg | jpeg | png | JPG | JPEG | PNG" 
     ValidationExpression= "(.*).(.jpg|.JPG|.gif|.GIF|.jpeg|.JPEG|.bmp|.BMP|.png|.PNG)$" >
</asp:RegularExpressionValidator>
    <br />
    <br />
    <asp:Button ID="Subir" runat="server" Text="Subir foto"  style="margin-left: 610px" Width="108px" />
    <asp:AccessDataSource ID="mostrarHistoria" runat="server" DataFile="~/bbdd/gvg.accdb" SelectCommand="SELECT [dni], [aYnombre], [link], [historiaClinica], [fecha] FROM [verHistFot] WHERE ([dni] = ?)">
        <SelectParameters>
            <asp:SessionParameter Name="dni" SessionField="apellido" Type="String" />
        </SelectParameters>
    </asp:AccessDataSource>
    

    <br />
    <br />
   
    <div align="center">
        <asp:Button ID="btVolver" PostBackUrl="~/index.aspx" CausesValidation="false" CssClass="button" runat="server" Text="VOLVER AL INICIO"></asp:Button>
    </div>
    
</asp:Content>

