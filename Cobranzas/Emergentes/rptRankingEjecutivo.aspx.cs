using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cobranzas.Emergentes
{
    public partial class rptRankingEjecutivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnExportarExcel_Click(object sender, EventArgs e)
        {
            pnlExportar.Visible = false;
            Response.AddHeader("Content-disposition", "attachment;FileName=\"Ranking.xls\"");
            Response.AddHeader("content-type", "text/html");//application/xls
        }

        protected void btnExportarWord_Click(object sender, EventArgs e)
        {
            pnlExportar.Visible = false;
            Response.AddHeader("Content-disposition", "attachment;FileName=\"Ranking.doc\"");
            Response.AddHeader("content-type", "text/html");//application/msword

        }
    }
}