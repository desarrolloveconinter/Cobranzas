using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cobranzas.Emergentes
{
    public partial class ctrlDetallesPago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int dato = int.Parse(Request.QueryString["idPago"]);
            BuscarDatosPago(dato);
        }

        private void BuscarDatosPago(int idPago)
        {

            using (CobranzasDataContext db = new CobranzasDataContext())
            {
                lbderror.Visible = false;
                DataTable dt = new DataTable();
                dt = Negocios.DetPago(idPago);


                var listado = dt;
                

                string Codigo = dt.Rows[0]["Codigo"].ToString();
                string Referencia = dt.Rows[0]["Referencia"].ToString();
                string Fecha = dt.Rows[0]["Fecha"].ToString();
                string MontoTotal = dt.Rows[0]["MontoTotal"].ToString();


                TableRow trContenido = new TableRow();
                TableRow trTitulo = new TableRow();

                TableCell tdTituloCodigo = new TableCell();
                TableCell tdTituloReferencia = new TableCell();
                TableCell tdTituloFecha = new TableCell();
                TableCell tdTituloMontoTotal = new TableCell();



                TableCell tdContenidoCodigo = new TableCell();
                TableCell tdContenidoReferencia = new TableCell();
                TableCell tdContenidoFecha = new TableCell();
                TableCell tdContenidoMontoTotal = new TableCell();




                tdTituloCodigo.Text = "Codigo";
                tdTituloReferencia.Text = "Referencia";
                tdTituloFecha.Text = "Fecha";
                tdTituloMontoTotal.Text = "Monto Total (VEF)";



                tdContenidoCodigo.Text = Referencia.ToString();
                tdContenidoReferencia.Text = Codigo.ToString();
                tdContenidoFecha.Text = Fecha.ToString();
                tdContenidoMontoTotal.Text = MontoTotal.ToString();

                trTitulo.BackColor = System.Drawing.Color.Blue;
                trTitulo.Controls.Add(tdTituloCodigo);
                trTitulo.Controls.Add(tdTituloReferencia);
                trTitulo.Controls.Add(tdTituloFecha);
                trTitulo.Controls.Add(tdTituloMontoTotal);


                trContenido.Controls.Add(tdContenidoCodigo);
                trContenido.Controls.Add(tdContenidoReferencia);
                trContenido.Controls.Add(tdContenidoFecha);
                trContenido.Controls.Add(tdContenidoMontoTotal);

                Table tablaDetallesPago = new Table();
                tablaDetallesPago.Width = Unit.Percentage(200);

                tablaDetallesPago.Controls.Add(trTitulo);

                tablaDetallesPago.Controls.Add(trContenido);

                pnDetallesPago.Controls.Add(tablaDetallesPago);

                //-------------------------------------------------------------------------------------

                try
                {

                    DirectoryInfo dirtxt = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);

                    FileInfo[] archivos2txt = dirtxt.GetFiles("*.txt");

                    string[] archivostxt = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);

                    int cantidadtxt = archivostxt.Count();

                    Table tablatxt = new Table();



                    tablatxt.Width = Unit.Percentage(300);
                    foreach (FileInfo f in archivos2txt)
                    {



                        TableRow trtxt = new TableRow();
                        TableCell tdtxt = new TableCell();
                        TableCell td2txt = new TableCell();
                        TableCell td3txt = new TableCell();


                        tdtxt.Text = f.Name;


                        HyperLink hltxt = new HyperLink();
                        hltxt.Text = "Descargar";
                        hltxt.Attributes.Add("onclick", "javascript:return confirm('Desea Descargar el documento?')");
                        hltxt.NavigateUrl = @"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago + "/" + f.Name;

                        td2txt.Controls.Add(hltxt);
                        trtxt.Controls.Add(tdtxt);
                        trtxt.Controls.Add(td2txt);

                        tablatxt.Controls.Add(trtxt);



                    }



                    pnDocumentoPagotxt.Controls.Add(tablatxt);



                    //------------------------------------------------------------------------

                    DirectoryInfo dirPDF = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);

                    FileInfo[] archivos2PDF = dirPDF.GetFiles("*.pdf");

                    string[] archivosPDF = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);

                    int cantidadPDF = archivosPDF.Count();

                    Table tablaPDF = new Table();



                    tablaPDF.Width = Unit.Percentage(300);
                    foreach (FileInfo f in archivos2PDF)
                    {
                        TableRow trPDF = new TableRow();
                        TableCell tdPDF = new TableCell();
                        TableCell td2PDF = new TableCell();
                        TableCell td3PDF = new TableCell();

                        tdPDF.Text = f.Name;

                        HyperLink hlPDF = new HyperLink();
                        hlPDF.Text = "Descargar";
                        hlPDF.Attributes.Add("onclick", "javascript:return confirm('Desea descargar el documento?')");
                        hlPDF.NavigateUrl = @"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago + "/" + f.Name;

                        td2PDF.Controls.Add(hlPDF);

                        trPDF.Controls.Add(tdPDF);
                        trPDF.Controls.Add(td2PDF);


                        tablatxt.Controls.Add(trPDF);



                    }



                    pnDocumentoPagoPDF.Controls.Add(tablaPDF);

                    //-------------------------------------------------------------------------

                    DirectoryInfo dirDOC = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);

                    FileInfo[] archivos2DOC = dirtxt.GetFiles("*.doc");

                    string[] archivosDOC = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);

                    int cantidadDOC = archivostxt.Count();

                    Table tablaDOC = new Table();



                    tablaDOC.Width = Unit.Percentage(300);
                    foreach (FileInfo f in archivos2DOC)
                    {



                        TableRow trDOC = new TableRow();
                        TableCell tdDOC = new TableCell();
                        TableCell td2DOC = new TableCell();
                        TableCell td3DOC = new TableCell();


                        tdDOC.Text = f.Name;


                        HyperLink hlDOC = new HyperLink();
                        hlDOC.Text = "Descargar";
                        hlDOC.Attributes.Add("onclick", "javascript:return confirm('Desea descargar el documento?')");
                        hlDOC.NavigateUrl = @"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago + "/" + f.Name;
                        td2DOC.Controls.Add(hlDOC);


                        trDOC.Controls.Add(tdDOC);
                        trDOC.Controls.Add(td2DOC);


                        tablatxt.Controls.Add(trDOC);



                    }



                    pnDocumentoPagoDOC.Controls.Add(tablaDOC);

                    //----------------------------------------------------------------

                    DirectoryInfo dirXLS = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);

                    FileInfo[] archivos2XLS = dirXLS.GetFiles("*.xls");


                    string[] archivosXLS = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);
                    int cantidadXLS = archivosXLS.Count();
                    Table tablaXLS = new Table();
                    tablaXLS.Width = Unit.Percentage(300);
                    foreach (FileInfo f in archivos2XLS)
                    {
                        TableRow trXLS = new TableRow();
                        TableCell tdXLS = new TableCell();
                        TableCell td2XLS = new TableCell();
                        TableCell td3XLS = new TableCell();

                        tdXLS.Text = f.Name;

                        HyperLink hlXLS = new HyperLink();
                        hlXLS.Text = "Descargar";
                        hlXLS.Attributes.Add("onclick", "javascript:return confirm('Desea descargar el documento?')");
                        hlXLS.NavigateUrl = @"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago + "/" + f.Name;
                        td2XLS.Controls.Add(hlXLS);


                        trXLS.Controls.Add(tdXLS);
                        trXLS.Controls.Add(td2XLS);



                        tablatxt.Controls.Add(trXLS);

                    }
                    pnDocumentoPagoXLS.Controls.Add(tablaXLS);

                    //---------------------------------------------------------

                    DirectoryInfo dirMSG = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);

                    FileInfo[] archivos2MSG = dirMSG.GetFiles("*.msg");



                    string[] archivosMSG = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);
                    int cantidadMSG = archivosMSG.Count();
                    Table tablaMSG = new Table();
                    tablaMSG.Width = Unit.Percentage(300);
                    foreach (FileInfo f in archivos2MSG)
                    {
                        TableRow trMSG = new TableRow();
                        TableCell tdMSG = new TableCell();
                        TableCell td2MSG = new TableCell();
                        TableCell td3MSG = new TableCell();

                        tdMSG.Text = f.Name;

                        HyperLink hlMSG = new HyperLink();
                        hlMSG.Text = "Descargar";
                        hlMSG.Attributes.Add("onclick", "javascript:return confirm('Desea descargar el documento?')");
                        hlMSG.NavigateUrl = @"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago + "/" + f.Name;
                        td2MSG.Controls.Add(hlMSG);


                        trMSG.Controls.Add(tdMSG);
                        trMSG.Controls.Add(td2MSG);

                        tablaMSG.Controls.Add(trMSG);

                    }
                    pnDocumentoPagoMSG.Controls.Add(tablaMSG);

                    //-------------------------------------------------------------

                    DirectoryInfo dirBMP = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);

                    FileInfo[] archivos2BMP = dirMSG.GetFiles("*.bmp");



                    string[] archivosBMP = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);
                    int cantidadBMP = archivosBMP.Count();
                    Table tablaBMP = new Table();
                    tablaBMP.Width = Unit.Percentage(300);
                    foreach (FileInfo f in archivos2BMP)
                    {
                        TableRow trBMP = new TableRow();
                        TableCell tdBMP = new TableCell();
                        TableCell td2BMP = new TableCell();
                        TableCell td3BMP = new TableCell();

                        tdBMP.Text = f.Name;

                        HyperLink hlBMP = new HyperLink();
                        hlBMP.Text = "Descargar";
                        hlBMP.Attributes.Add("onclick", "javascript:return confirm('Desea descargar el documento?')");
                        hlBMP.NavigateUrl = @"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago + "/" + f.Name;
                        td2BMP.Controls.Add(hlBMP);


                        trBMP.Controls.Add(tdBMP);
                        trBMP.Controls.Add(td2BMP);

                        tablaBMP.Controls.Add(trBMP);

                    }

                    pnDocumentoPagoBMP.Controls.Add(tablaBMP);

                    //-------------------------------------------------------------

                    DirectoryInfo dirJPG = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);

                    FileInfo[] archivos2JPG = dirMSG.GetFiles("*.jpg");



                    string[] archivosJPG = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago);
                    int cantidadJPG = archivosJPG.Count();
                    Table tablaJPG = new Table();
                    tablaJPG.Width = Unit.Percentage(300);
                    foreach (FileInfo f in archivos2JPG)
                    {
                        TableRow trJPG = new TableRow();
                        TableCell tdJPG = new TableCell();
                        TableCell td2JPG = new TableCell();
                        TableCell td3JPG = new TableCell();

                        tdJPG.Text = f.Name;

                        HyperLink hlJPG = new HyperLink();
                        hlJPG.Text = "Descargar";
                        hlJPG.Attributes.Add("onclick", "javascript:return confirm('Desea descargar el documento?')");
                        hlJPG.NavigateUrl = @"\\VECCSVS008\Cobranzas\Soportes\Pagos\Pago_" + idPago + "/" + f.Name;
                        td2JPG.Controls.Add(hlJPG);


                        trJPG.Controls.Add(tdJPG);
                        trJPG.Controls.Add(td2JPG);

                        tablaJPG.Controls.Add(trJPG);

                    }

                    pnDocumentoPagoJPG.Controls.Add(tablaJPG);


                    int jpg = pnDocumentoPagoJPG.Controls.Count;
                    int txt = pnDocumentoPagotxt.Controls.Count;
                    int pdf = pnDocumentoPagoPDF.Controls.Count;
                    int xls = pnDocumentoPagoXLS.Controls.Count;
                    int msg = pnDocumentoPagoMSG.Controls.Count;
                    int bmp = pnDocumentoPagoBMP.Controls.Count;
                    int doc = pnDocumentoPagoDOC.Controls.Count;



                    if (jpg == 0 & txt == 0 & pdf == 0 & xls == 0 & msg == 0 & bmp == 0 & doc == 0)
                    {
                        UI.Mensaje("Sistema de Cobranzas", "No se encuentran los soporte de la factura para el pago correspondiente", "", Page);
                        return;
                    }
                }

                catch (Exception Ex)
                {
                    lbderror.Visible = true;
                    UI.Mensaje("Sistema de Cobranzas", "Ya hay una sesion activa con este usuario", "", Page);

                }

            }
        }
    }
}