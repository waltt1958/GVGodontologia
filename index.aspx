<%@ Page Title="" Language="VB" MasterPageFile="~/M.master" AutoEventWireup="false" CodeFile="index.aspx.vb" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <br />
    <br />
    <div align="center">
    <asp:Button ID="BTNagenda" runat="server"  CssClass="button" Text="AGENDA" PostBackUrl="~/agenda.aspx" Width="250px" />
    <asp:Button ID="Button1" runat="server" CssClass="button" Text="ADMINIST. PACIENTES" Width="258px" PostBackUrl="~/pacientes.aspx" />
        <br />
        <br />
    <asp:Button ID="historiaClinica" runat="server"  CssClass="button" Text="HISTORIA CLINICA" PostBackUrl="~/buscaHistClinica.aspx" Width="250px" />
    <asp:Button ID="consGeneral" runat="server"  CssClass="button" Text="CONSULTAS GENERALES" PostBackUrl="~/consGeneral.aspx" Width="250px" />

    </div>
    
</asp:Content>

