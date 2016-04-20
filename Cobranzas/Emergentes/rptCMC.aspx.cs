using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cobranzas.Emergentes
{
    public partial class rptCMC : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

       


        private void Ejecutar() { String CS = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=Cobranzas;Password=&&admin%%abc;Initial Catalog=milleniumv2;Data Source=SERV005";

            using (OleDbConnection Conn = new OleDbConnection(CS))
            {
                OleDbCommand Comm = Conn.CreateCommand();
                Comm.CommandType = CommandType.StoredProcedure;
                Comm.CommandText = "Cobranzas.RPTCmc";
                Comm.Parameters.Add("cliente", OleDbType.VarChar).Value = txtCodigoPersona.Text;

                DataSet DS = new DataSet();
                OleDbDataAdapter DA = new OleDbDataAdapter(Comm);
                DA.Fill(DS);


                DataAccessLayer dal = new DataAccessLayer();

                SqlParameter[] SqlParametros = new SqlParameter[1];
                SqlParametros[0] = new SqlParameter("@UsuSesion", SqlDbType.VarChar);
                SqlParametros[0].Value = Sesion.Operador.Login.ToString();
                dal.EjecutarAccion("EliminaDatosCMC", SqlParametros);



                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    DataRow Fila = DS.Tables[0].Rows[i];



                    SqlParameter[] SqlParametros2 = new SqlParameter[9];

                    SqlParametros2[0] = new SqlParameter("@FechaDesde", SqlDbType.VarChar);
                    SqlParametros2[0].Value = Fila["fechaDesde"].ToString();

                    SqlParametros2[1] = new SqlParameter("@FechaHasta", SqlDbType.VarChar);
                    SqlParametros2[1].Value = Fila["fechaHasta"].ToString();

                    SqlParametros2[2] = new SqlParameter("@Cobrador", SqlDbType.VarChar);
                    SqlParametros2[2].Value = Fila["cobradorNombre"].ToString();



                    SqlParametros2[3] = new SqlParameter("@Cliente", SqlDbType.VarChar);
                    SqlParametros2[3].Value = Fila["clinombre"].ToString();



                    string valoractivo = "";
                    if (Fila["clianulado"].ToString() == "False")
                    {

                        valoractivo = "SI";


                    }
                    else {
                        valoractivo = "NO";
                    }
                    SqlParametros2[4] = new SqlParameter("@Activo", SqlDbType.VarChar);
                    SqlParametros2[4].Value = valoractivo;


                    SqlParametros2[5] = new SqlParameter("@Categoria", SqlDbType.VarChar);
                    SqlParametros2[5].Value = Fila["categoriadesc"].ToString();



                    string valoroperacion = "";
                    switch (Fila["operacion"].ToString())
                    {
                        case "I":
                            valoroperacion = "Incluyó el Cliente";
                            break;
                        case "U":
                            valoroperacion = "Modifico Cliente";
                            break;
                        case "D":
                            valoroperacion = "Elimino Cliente";
                            break;
                        default:
                            valoroperacion = "Modifico Cliente";
                            break;
                    }

                    SqlParametros2[6] = new SqlParameter("@Operacion", SqlDbType.VarChar);
                    SqlParametros2[6].Value = valoroperacion;

                    SqlParametros2[7] = new SqlParameter("@UsuModif", SqlDbType.VarChar);
                    SqlParametros2[7].Value = Fila["usuario"].ToString();

                    SqlParametros2[8] = new SqlParameter("@UsuSesion", SqlDbType.VarChar);
                    SqlParametros2[8].Value = Sesion.Operador.Login.ToString();
    
                    dal.EjecutarAccion("AgregarReporteCMCTemporal", SqlParametros2);
                }

            }}


        protected void btnReporteCMC_Click(object sender, EventArgs e)
        {
            Ejecutar();
            Response.Redirect("http://cantv.veconinter.com.ve:7000/contenedorReporteCMC.aspx?usuario=" + Sesion.Operador.Login.ToString());
        }
    }
}