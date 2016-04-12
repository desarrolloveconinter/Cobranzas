<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocumentosInteres.aspx.cs" Inherits="Cobranzas.Emergentes.DocumentosInteres" %>

<head>
    <style type="text/css">
        .auto-style1 {
            width: 48px;
            height: 48px;
        }
    </style>
</head>

<script src="DocumentosInteres.aspx.js"></script>


<img src="../Img/Logo.jpg" /> <form id="form1" runat="server">
      
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      
    <h2 style="width: 466px">&nbsp;&nbsp;&nbsp;&nbsp;

    <asp:FileUpload ID="FileUpload1" runat="server" style="margin-left: 0px" Width="207px" />
    &nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Documento" Height="23px" Width="130px" />


    &nbsp;&nbsp;
        <img alt="" class="auto-style1" src="../Img/Reporte.png" /></h2>
    <h2 style="width: 265px">Documentos de Interes&nbsp;&nbsp;&nbsp;&nbsp; </h2>
    
    
    

    <asp:panel runat="server" id="pnlContenttxt" Width="190px"></asp:panel>
    <asp:panel runat="server" id="pnlContentPDF" Width="190px"></asp:panel>
    <asp:panel runat="server" id="pnlContentDOC" Width="190px"></asp:panel>
    <asp:panel runat="server" id="pnlContentXLS" Width="190px"></asp:panel>
  
  </form>
<%--
<asp:panel runat="server" id="pnlContenedor"></asp:panel>
    <asp:fileupload id="FileUpload1" runat="server" style="margin-bottom: 0px"></asp:fileupload>
    <asp:Button ID="InsDocumentoInteres" runat="server" OnClick="Button1_Click" Text="Agregar Documento" />
    <asp:GridView ID="DocumentosInt" runat="server" AutoGenerateColumns="False" DataKeyNames="idDocumento">
        <Columns>
            <asp:TemplateField HeaderText="Documentos">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" onClick ="AbrirDocumento" runat="server" Text='<%# Eval("NombreDoc") %>' ></asp:LinkButton>
                </ItemTemplate>

            </asp:TemplateField>

        </Columns>

         <Columns>
            <asp:TemplateField HeaderText="Fecha">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" Text='<%# Eval("Fecha") %>'></asp:LinkButton>
                </ItemTemplate>

            </asp:TemplateField>

        </Columns>

    </asp:GridView>
    <p>
        &nbsp;</p>--%>

    





 
  