using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;



namespace Cobranzas.Emergentes
{
    public partial class DocumentosInteres : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {


            
            //......................................................................................................................................

            DirectoryInfo dirtxt = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\File");

            FileInfo[] archivos2txt = dirtxt.GetFiles("*.txt");


            if (!string.IsNullOrEmpty(Request.QueryString["descarga"]))
            {

                TableCell lblresume = new TableCell();

                lblresume.Text = @"\\VECCSVS008\Cobranzas\Soportes\File" + Request.QueryString["descarga"].ToString();
                if (lblresume.Text != string.Empty)
                {
                    string filePath = lblresume.Text;
                    Response.ContentType = "doc/docx";
                    Response.AddHeader("Content-Disposition", @"\\VECCSVS008\Cobranzas\Soportes\File" + Request.QueryString["descarga"].ToString());
                    //Response.TransmitFile(Server.MapPath(filePath));  
                    Response.TransmitFile(@"\\VECCSVS008\Cobranzas\Soportes\File\" + Request.QueryString["descarga"].ToString());
                    Response.End();
                }



            }


            if (!string.IsNullOrEmpty(Request.QueryString["archivo"]))
            {

                FileInfo f1txt = new FileInfo(@"\\VECCSVS008\Cobranzas\Soportes\File\" + Request.QueryString["archivo"].ToString());
                f1txt.Delete();



            }


            


            string[] archivostxt = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\File");

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

                FileInfo f1txtDes = new FileInfo(@"\\VECCSVS008\Cobranzas\Soportes\File\" + f.Name.ToString());
                HyperLink hltxt = new HyperLink();
                hltxt.Text = "Descargar";
                hltxt.Attributes.Add("onclick", "javascript:return confirm('Desea descargar el documento?')");
                hltxt.NavigateUrl = "DocumentosInteres.aspx?descarga=" + f.Name;
                td2txt.Controls.Add(hltxt);

                if (!(Sesion.Operador.Tipo.Contains("SU") ||
                    Sesion.Operador.Tipo.Contains("AD") ||
                    Sesion.Operador.Tipo.Contains("GE") ||
                    Sesion.Operador.Tipo.Contains("CO") ||
                    Sesion.Operador.Tipo.Contains("DI")))
                {
                    trtxt.Controls.Add(tdtxt);
                    trtxt.Controls.Add(td2txt);
                }
                else
                {

                    HyperLink h2txt = new HyperLink();
                    
                    h2txt.Text = "Eliminar";
                    h2txt.Attributes.Add("onclick", "javascript:return confirm('Desea eliminar el documento?')");
                    h2txt.NavigateUrl = "DocumentosInteres.aspx?archivo=" + f.Name;
                    td3txt.Controls.Add(h2txt);



                    trtxt.Controls.Add(tdtxt);
                    trtxt.Controls.Add(td2txt);
                    trtxt.Controls.Add(td3txt);
                }

                


                tablatxt.Controls.Add(trtxt);



            }



            pnlContenttxt.Controls.Add(tablatxt);
            //......................................................................................................................................

            DirectoryInfo dirPDF = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\File");

            FileInfo[] archivos2PDF = dirPDF.GetFiles("*.pdf");


            if (!string.IsNullOrEmpty(Request.QueryString["descarga"]))
            {

                TableCell lblresume = new TableCell();

                lblresume.Text = @"\\VECCSVS008\Cobranzas\Soportes\File" + Request.QueryString["descarga"].ToString();
                if (lblresume.Text != string.Empty)
                {
                    string filePath = lblresume.Text;
                    Response.ContentType = "doc/docx";
                    Response.AddHeader("Content-Disposition", @"\\VECCSVS008\Cobranzas\Soportes\File" + Request.QueryString["descarga"].ToString());
                    //Response.TransmitFile(Server.MapPath(filePath));  
                    Response.TransmitFile(@"\\VECCSVS008\Cobranzas\Soportes\File\" + Request.QueryString["descarga"].ToString());
                    Response.End();
                }



            }


            if (!string.IsNullOrEmpty(Request.QueryString["archivo"]))
            {

                FileInfo f1PDF = new FileInfo(@"\\VECCSVS008\Cobranzas\Soportes\File\" + Request.QueryString["archivo"].ToString());
                f1PDF.Delete();



            }


            string[] archivosPDF = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\File");

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

                FileInfo f1PDFDes = new FileInfo(@"\\VECCSVS008\Cobranzas\Soportes\File\" + f.Name.ToString());
                HyperLink hlPDF = new HyperLink();
                hlPDF.Text = "Descargar";
                hlPDF.Attributes.Add("onclick", "javascript:return confirm('Desea descargar el documento?')");
                hlPDF.NavigateUrl = "DocumentosInteres.aspx?descarga=" + f.Name;
                td2PDF.Controls.Add(hlPDF);

                if (!(Sesion.Operador.Tipo.Contains("SU") ||
                    Sesion.Operador.Tipo.Contains("AD") ||
                    Sesion.Operador.Tipo.Contains("GE") ||
                    Sesion.Operador.Tipo.Contains("CO") ||
                    Sesion.Operador.Tipo.Contains("DI")))
                {
                    trPDF.Controls.Add(tdPDF);
                    trPDF.Controls.Add(td2PDF);

                }
                else
                {
                    HyperLink h2PDF = new HyperLink();
                    h2PDF.Text = "Eliminar";
                    h2PDF.Attributes.Add("onclick", "javascript:return confirm('Desea eliminar el documento?')");
                    h2PDF.NavigateUrl = "DocumentosInteres.aspx?archivo=" + f.Name;
                    td3PDF.Controls.Add(h2PDF);



                    trPDF.Controls.Add(tdPDF);
                    trPDF.Controls.Add(td2PDF);
                    trPDF.Controls.Add(td3PDF);

                }

                


                tablatxt.Controls.Add(trPDF);



            }



            pnlContentPDF.Controls.Add(tablaPDF);

            //......................................................................................................................................

            DirectoryInfo dirDOC = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\File");

            FileInfo[] archivos2DOC = dirtxt.GetFiles("*.doc");


            if (!string.IsNullOrEmpty(Request.QueryString["descarga"]))
            {

                TableCell lblresume = new TableCell();

                lblresume.Text = @"\\VECCSVS008\Cobranzas\Soportes\File" + Request.QueryString["descarga"].ToString();
                if (lblresume.Text != string.Empty)
                {
                    string filePath = lblresume.Text;
                    Response.ContentType = "doc/docx";
                    Response.AddHeader("Content-Disposition", @"\\VECCSVS008\Cobranzas\Soportes\File" + filePath.ToString());
                    //Response.TransmitFile(Server.MapPath(filePath));  
                    Response.TransmitFile(@"\\VECCSVS008\Cobranzas\Soportes\File\" + filePath.ToString());
                    Response.End();
                }



            }


            if (!string.IsNullOrEmpty(Request.QueryString["archivo"]))
            {

                FileInfo f1DOC = new FileInfo(@"\\VECCSVS008\Cobranzas\Soportes\File\" + Request.QueryString["archivo"].ToString());
                f1DOC.Delete();



            }


            string[] archivosDOC = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\File");

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

                FileInfo f1DOCDes = new FileInfo(@"\\VECCSVS008\Cobranzas\Soportes\File\" + f.Name.ToString());
                HyperLink hlDOC = new HyperLink();
                hlDOC.Text = "Descargar";
                hlDOC.Attributes.Add("onclick", "javascript:return confirm('Desea descargar el documento?')");
                hlDOC.NavigateUrl = "DocumentosInteres.aspx?descarga=" + f.Name; 
                td2DOC.Controls.Add(hlDOC);

                if (!(Sesion.Operador.Tipo.Contains("SU") ||
                    Sesion.Operador.Tipo.Contains("AD") ||
                    Sesion.Operador.Tipo.Contains("GE") ||
                    Sesion.Operador.Tipo.Contains("CO") ||
                    Sesion.Operador.Tipo.Contains("DI")))
                {
                    trDOC.Controls.Add(tdDOC);
                    trDOC.Controls.Add(td2DOC);
                }
                else
                {
                    HyperLink h2DOC = new HyperLink();
                    h2DOC.Text = "Eliminar";
                    h2DOC.Attributes.Add("onclick", "javascript:return confirm('Desea eliminar el documento?')");
                    h2DOC.NavigateUrl = "DocumentosInteres.aspx?archivo=" + f.Name;
                    td3DOC.Controls.Add(h2DOC);
                    trDOC.Controls.Add(tdDOC);
                    trDOC.Controls.Add(td2DOC);
                    trDOC.Controls.Add(td3DOC);

                }


                
                



                tablatxt.Controls.Add(trDOC);



            }



            pnlContentDOC.Controls.Add(tablaDOC);
            //......................................................................................................................................
            DirectoryInfo dirXLS = new DirectoryInfo(@"\\VECCSVS008\Cobranzas\Soportes\File");

            FileInfo[] archivos2XLS = dirXLS.GetFiles("*.xls");

            if (!string.IsNullOrEmpty(Request.QueryString["descarga"]))
            {

                TableCell lblresume = new TableCell();

                lblresume.Text = @"\\VECCSVS008\Cobranzas\Soportes\File" + Request.QueryString["descarga"].ToString();
                if (lblresume.Text != string.Empty)
                {
                    string filePath = lblresume.Text;
                    Response.ContentType = "doc/docx";
                    Response.AddHeader("Content-Disposition", @"\\VECCSVS008\Cobranzas\Soportes\File" + Request.QueryString["descarga"].ToString());
                    //Response.TransmitFile(Server.MapPath(filePath));  
                    Response.TransmitFile(@"\\VECCSVS008\Cobranzas\Soportes\File\" + Request.QueryString["descarga"].ToString());
                    Response.End();
                }



            }

            if (!string.IsNullOrEmpty(Request.QueryString["archivo"]))
            {

                FileInfo f1XLS = new FileInfo(@"\\VECCSVS008\Cobranzas\Soportes\File\" + Request.QueryString["archivo"].ToString());
                f1XLS.Delete();
               
            }

            string[] archivosXLS = Directory.GetFiles(@"\\VECCSVS008\Cobranzas\Soportes\File");
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


                FileInfo f1XLSDes = new FileInfo(@"\\VECCSVS008\Cobranzas\Soportes\File\" + f.Name.ToString());
                HyperLink hlXLS = new HyperLink();
                hlXLS.Text = "Descargar";
                hlXLS.Attributes.Add("onclick", "javascript:return confirm('Desea descargar el documento?')");
                hlXLS.NavigateUrl = "DocumentosInteres.aspx?descarga=" + f.Name;
                td2XLS.Controls.Add(hlXLS);

                if (!(Sesion.Operador.Tipo.Contains("SU") ||
                    Sesion.Operador.Tipo.Contains("AD") ||
                    Sesion.Operador.Tipo.Contains("GE") ||
                    Sesion.Operador.Tipo.Contains("CO") ||
                    Sesion.Operador.Tipo.Contains("DI")))
                {
                    trXLS.Controls.Add(tdXLS);
                    trXLS.Controls.Add(td2XLS);
                }
                else
                {
                    HyperLink h2XLS = new HyperLink();
                    h2XLS.Text = "Eliminar";
                    h2XLS.Attributes.Add("onclick", "javascript:return confirm('Desea eliminar el documento?')");
                    h2XLS.NavigateUrl = "DocumentosInteres.aspx?archivo=" + f.Name;
                    td3XLS.Controls.Add(h2XLS);

                    trXLS.Controls.Add(tdXLS);
                    trXLS.Controls.Add(td2XLS);
                    trXLS.Controls.Add(td3XLS);

                }

                

                tablatxt.Controls.Add(trXLS);

            }
            pnlContentXLS.Controls.Add(tablaXLS);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string strfilename = FileUpload1.FileName;
                FileUpload1.SaveAs(@"\\VECCSVS008\Cobranzas\Soportes\File\" + strfilename);
                Response.Write("<script>alert('Archivo cargado con exito');</script>");
            }
            else
            {
                Response.Write("<script>alert('Por favor selecccionar el Archivo');</script>");

            }
        }

        

    }
}







//{
//    using (CobranzasDataContext db = new CobranzasDataContext())
//    {
//        try
//        {


//            if (!IsPostBack)
//            {
//                FillData();
//            }



//        }

//         catch (Exception Ex)
//        {
//            throw Ex.Informar();
//        }
//    }

//}
//protected void AbrirDocumento(object sender, EventArgs e)
//{

//    LinkButton lnk = (LinkButton)sender;
//    GridViewRow gr = (GridViewRow)lnk.NamingContainer;

//    int id = int.Parse(DocumentosInt.DataKeys[gr.RowIndex].Value.ToString());
//    Download(id);

//}
//private void Download(int id)
//{
//    DataTable dt = new DataTable();


//    String CS;
//    using (CobranzasDataContext db = new CobranzasDataContext()) { CS = db.Connection.ConnectionString; }
//    {
//        SqlConnection Conn = new SqlConnection(CS);
//        SqlCommand Comm = Conn.CreateCommand();
//        Comm.CommandType = CommandType.StoredProcedure;
//        Comm.Parameters.Add("@idDocumento", SqlDbType.Int).Value = id;
//        Comm.CommandText = "VerDocumento";
//        Conn.Open();
//        SqlDataReader reader = Comm.ExecuteReader();


//        dt.Load(reader);
//    }

//    string name = dt.Rows[0]["NombreDoc"].ToString();
//    byte[] documentBytes = (byte[])dt.Rows[0]["TipoDoc"];

//    Response.ClearContent();
//    Response.ContentType = "application/octetstream";
//    Response.AddHeader("Content-Disposition", string.Format("attachment; filename={0}",name));
//    Response.AddHeader("Content-Length",documentBytes.Length.ToString());
//    Response.Flush();
//    Response.Close();
//}



//private void FillData()
//{
//    DataTable dt = new DataTable();


//    String CS;
//    using (CobranzasDataContext db = new CobranzasDataContext()) { CS = db.Connection.ConnectionString; }
//    { 
//    SqlConnection Conn = new SqlConnection(CS);
//    SqlCommand Comm = Conn.CreateCommand();
//    Comm.CommandType = CommandType.StoredProcedure;

//    Comm.CommandText = "VistaDocumentosInteres";
//    Conn.Open();
//    SqlDataReader reader = Comm.ExecuteReader();


//    dt.Load(reader);
//    }

//    if (dt.Rows.Count > 0)
//    {
//        DocumentosInt.DataSource = dt;
//        DocumentosInt.DataBind();

//    }


//}


//protected void Button1_Click(object sender, EventArgs e)
//{

//        try
//        {

//            FileInfo fi = new FileInfo(FileUpload1.FileName);
//            byte[] DocumentContent = (FileUpload1.FileBytes);

//            string name = fi.Name;
//            string extn = fi.Extension;


//            String CS;
//            using (CobranzasDataContext db = new CobranzasDataContext()) { CS = db.Connection.ConnectionString; }
//            SqlConnection Conn = new SqlConnection(CS);
//            SqlCommand Comm = Conn.CreateCommand();
//            Comm.CommandType = CommandType.StoredProcedure;

//            Comm.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = name;
//            Comm.Parameters.Add("@TipoDocumento", SqlDbType.VarBinary).Value = DocumentContent;
//            Comm.Parameters.Add("@Extn", SqlDbType.VarChar).Value = extn;
//            Comm.CommandText = "InsDocumentosInteres";
//            Conn.Open();
//            Comm.ExecuteNonQuery();






//        }


//        catch (Exception Ex)
//        {
//            throw Ex.Informar();
//        }

//    }


