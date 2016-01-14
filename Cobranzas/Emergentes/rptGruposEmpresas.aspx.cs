using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cobranzas.Emergentes
{
    public partial class rptGruposEmpresas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccessLayer da = new DataAccessLayer();
            DataTable dt = new DataTable();

            SqlParameter[] SqlParametros = new SqlParameter[1];

            SqlParametros[0] = new SqlParameter("@idOperador", SqlDbType.Int);
            SqlParametros[0].Value = Request.QueryString["idOperador"];



            dt = da.EjecutarConsulta("pa_listar_grupos_empresas", SqlParametros);

            grdGrupos.DataSource = dt;
            grdGrupos.DataBind();


            
        }
    }
}