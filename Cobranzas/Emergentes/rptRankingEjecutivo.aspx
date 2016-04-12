<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="rptRankingEjecutivo.aspx.cs" Inherits="Cobranzas.Emergentes.rptRankingEjecutivo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    
    <script>

        function EjecutarRank() {
            
            
            
            LlamarServicio(_Rank, "Rank", { FechaDesde: "2015/1/06", FechaHasta: "2015/3/06" });
        }

    </script>
    
    <td style="vertical-align: top;">

        <h3>Ranking Ejectutivo</h3>
        <table class="Tabla">
           <tr>
               
               <td>Desde:
                   
                   <select id="cboMesRank">
                       <option value="1">Enero</option>
                       <option value="2">Febreo</option>
                       <option value="3">Marzo</option>
                       <option value="4">Abril</option>
                       <option value="5">Mayo</option>
                       <option value="6">Junio</option>
                       <option value="7">Julio</option>
                       <option value="8">Agosto</option>
                       <option value="9">Septiembre</option>
                       <option value="10">Octubre</option>
                       <option value="11">Noviembre</option>
                       <option value="12">Diciembre</option>
                   </select>/
                   <select id="cboAnoRank">
                       <option value="2016">2016</option>
                       <option value="2015">2015</option>
                   </select>
               </td>
           </tr>
            <tr>
               <td>Hasta:
                   <select id="cboMesRank2">
                       <option value="1">Enero</option>
                       <option value="2">Febreo</option>
                       <option value="3">Marzo</option>
                       <option value="4">Abril</option>
                       <option value="5">Mayo</option>
                       <option value="6">Junio</option>
                       <option value="7">Julio</option>
                       <option value="8">Agosto</option>
                       <option value="9">Septiembre</option>
                       <option value="10">Octubre</option>
                       <option value="11">Noviembre</option>
                       <option value="12">Diciembre</option>
                   </select>/
                   <select id="cboAnoRank2">
                       <option value="2016">2016</option>
                       <option value="2015">2015</option>
                   </select>
               </td>
           </tr>
           
               <tr>
                   <td><input type="button" id="EjecutarRank()" value="Buscar" onclick="EjecutarRank();" /></td>
               </tr>
            
        </table>
    </td>
    

    



    <asp:Panel ID="pnTablasOperadores" runat="server"></asp:Panel>
    <asp:Panel runat="server" ID="pnlExportar">
       
        <asp:Button runat="server" ID="btnExportarExcel" Text="Exportar a Excel" OnClick="btnExportarExcel_Click" />
        <asp:Button runat="server" ID="btnExportarWord" Text="Exportar a Word" OnClick="btnExportarWord_Click" />
        <input type="button" value="Imprimir" onclick="this.parentNode.style.display = 'none'; window.print();" />
        
    </asp:Panel>



</asp:Content>