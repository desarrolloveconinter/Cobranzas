<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rptCMC.aspx.cs" Inherits="Cobranzas.Emergentes.rptCMC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Estilos/Site.css" rel="stylesheet" />
    <link href="../Estilos/Estilos.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div>
                <div id="tituloDatos">
                    <table class="auto-style1">
                        <tr>
                            <td>Indique Codigo Persona:</td>
                            <td>&nbsp;</td>
                            <td>
                                <asp:TextBox ID="txtCodigoPersona" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                       
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>
                                <asp:Button ID="btnReporteCMC" runat="server" Text="Generar Reporte" OnClick="btnReporteCMC_Click" />
                            </td>
                        </tr>
                    </table>
                    <br />
                    <br />
                </div>
            </div>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
