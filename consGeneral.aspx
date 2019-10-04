<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="consGeneral.aspx.vb" Inherits="consGeneral" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div align="center">
    <asp:Button ID="OsocialSexo" PostBackUrl="~/OsocialSexo.aspx" CausesValidation="false" CssClass="button" runat="server" Text="OBRA SOCIAL / SEXO"></asp:Button>
    <asp:Button ID="cumpleanos" runat="server"  CssClass="button" Text="CUMPLEAÑOS" PostBackUrl="~/cumpleanos.aspx" Width="250px" />
        <br />
        <br />
    <asp:Button ID="btVolver" PostBackUrl="~/index.aspx" CausesValidation="false" CssClass="button" runat="server" Text="VOLVER AL INICIO"></asp:Button>
     </div>
</asp:Content>

