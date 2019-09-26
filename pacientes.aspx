<%@ Page Title="" Language="VB" MasterPageFile="~/M.master" AutoEventWireup="false" CodeFile="pacientes.aspx.vb" Inherits="pacientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h3>PACIENTES</h3>
    <br />
      <div align="center">
        <asp:Button ID="BTNconsulta" runat="server" Text="CONSULTA" CssClass="button" PostBackUrl="~/consultaPac1.aspx" />
        <asp:Button ID="BTNalta" runat="server" Text="ALTA PACIENTE" CssClass="button" PostBackUrl="~/altaPaciente1.aspx" />
        <br />
    </div>
       <div align="center">
        <asp:Button ID="BTNbaja" runat="server" Text="BAJA PACIENTE" CssClass="button" PostBackUrl="~/bajaPaciente1.aspx" />
        <asp:Button ID="BTNmodif" runat="server" Text="MODIF. PACIENTE" CssClass="button" PostBackUrl="~/modifPaciente1.aspx" />
    </div>
        <br />
       <div align="center">
    <asp:Button ID="BTNvolver" runat="server" Text="VOLVER" CssClass="button" PostBackUrl="~/index.aspx" />
    </div>
        <br />


</asp:Content>
