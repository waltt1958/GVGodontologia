<%@ Page Title="" Language="VB" MasterPageFile="~/M.master" AutoEventWireup="false" CodeFile="agenda.aspx.vb" Inherits="agenda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <h3>AGENDA DE TURNOS</h3>
        <br />
    <p>
        <div align="center">
        <asp:Button ID="BTNverAgenda" runat="server" CssClass="button" Text="VER AGENDA" PostBackUrl="~/verAgenda.aspx" />
        <asp:Button ID="BTNaltaTurno" runat="server" CssClass="button" Text="ALTA TURNO" PostBackUrl="~/altaTurno.aspx" />
        <asp:Button ID="BTNbajaTurno" runat="server" CssClass="button" Text="BAJA TURNO" PostBackUrl="~/bajaTurno.aspx" />
        <asp:Button ID="BTNmodifTurno" runat="server" CssClass="button" Text="MODIF. TURNO" PostBackUrl="~/modifTurno.aspx" />
        </div>
        <br />

    </p>
    <p>
    </p>
    <p>
        <div align="center">
        <asp:Button ID="BTNvolver" runat="server" CssClass="button" PostBackUrl="~/index.aspx" Text="VOLVER" />
        </div>
    </p>
    <p>
    </p>
</asp:Content>

