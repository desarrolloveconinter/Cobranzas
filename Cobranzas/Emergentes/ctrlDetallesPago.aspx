<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ctrlDetallesPago.aspx.cs" Inherits="Cobranzas.Emergentes.ctrlDetallesPago" %>



<head>
    <style type="text/css">
        .auto-style1 {
            width: 48px;
            height: 48px;
        }
    </style>
    <link href="../Estilos/Estilos.css" rel="stylesheet" />
</head>
<p>
    <br />


    <img src="../Img/Logo.jpg" />
</p>



<h1>Detalles Pago</h1>

<asp:panel id="pnDetallesPago" runat="server" width="290px"></asp:panel>

<h1>Adjunto del Pago&nbsp;
        <img alt="" class="auto-style1" src="../Img/Reporte.png" /></h1>
<asp:label id="lbderror" runat="server" text="No se encuentran los soporte de la factura para el pago correspondiente"></asp:label>
<asp:panel runat="server" id="pnDocumentoPagotxt" width="190px"></asp:panel>
<asp:panel runat="server" id="pnDocumentoPagoPDF" width="190px"></asp:panel>
<asp:panel runat="server" id="pnDocumentoPagoDOC" width="190px"></asp:panel>
<asp:panel runat="server" id="pnDocumentoPagoXLS" width="190px"></asp:panel>
<asp:panel runat="server" id="pnDocumentoPagoMSG" width="190px"></asp:panel>
<asp:panel runat="server" id="pnDocumentoPagoBMP" width="190px"></asp:panel>
<asp:panel runat="server" id="pnDocumentoPagoJPG" width="190px"></asp:panel>
