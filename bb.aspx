<%@ Page Title="" Language="VB" MasterPageFile="~/M.Master" AutoEventWireup="false" CodeFile="bb.aspx.vb" Inherits="bb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <asp:Table ID="Table1" runat="server" BorderStyle="Solid" BackColor="#99FF33" BorderColor="#003300" BorderWidth="1px">
    <asp:TableRow>
        <asp:TableCell BorderStyle="Solid">
            <asp:Image ID="Image1"  runat="server" Width="33" Height="24" BorderStyle="Ridge" />
        </asp:TableCell>
        <asp:TableCell BorderStyle="Solid">
            <asp:Image ID="Image2" runat="server" Width="33" Height="24" BorderStyle="Double" />
        </asp:TableCell>
        <asp:TableCell BorderStyle="Solid">
            <asp:Image ID="Image3" runat="server" Width="33" Height="24" BorderStyle="Solid" />
        </asp:TableCell>
    </asp:TableRow>

    </asp:Table>
      

</asp:Content>

