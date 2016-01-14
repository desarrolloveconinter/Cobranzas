<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rptGruposEmpresas.aspx.cs" Inherits="Cobranzas.Emergentes.rptGruposEmpresas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="grdGrupos" runat="server" DataKeyNames="CodigoGrupo" ShowFooter="True"
                Width="90%" AllowPaging="True" BackColor="White" BorderColor="#E7E7FF"
                BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal"
                AutoGenerateColumns="False">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:BoundField DataField="NombreGrupo" HeaderStyle-HorizontalAlign="Left" HeaderText="Nombre del Grupo de Empresa"></asp:BoundField>
                    <asp:BoundField DataField="NombreCliente" HeaderStyle-HorizontalAlign="Left" HeaderText="Cliente"></asp:BoundField>
                </Columns>
                <FooterStyle BackColor="#B5C7DE" Font-Names="Verdana" Font-Size="Small" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <HeaderStyle BackColor="#002955" Font-Bold="True" Font-Names="Verdana" Font-Size="Small" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" Font-Names="Verdana" Font-Size="Small" />
                <RowStyle BackColor="#E7E7FF" Font-Names="Verdana" Height="10px" Font-Size="Small" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
