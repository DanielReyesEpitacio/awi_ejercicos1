using AccesoADB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccesoADB.paginas
{
    public partial class productosDr : System.Web.UI.Page
    {
        readonly datos dt;
        public productosDr()
        {
            dt = new datos();
        }
        public void Mensaje(string mensaje)
        {
            string msg = mensaje;
            string msg1 = msg.Replace("'", " ");
            string msg2 = msg1.Replace("\r", " ");
            string msg3 = msg2.Replace("\n", " ");
            string msg4 = msg3.Replace("\\", " ");
            string msg5 = msg4.Replace("\" ", " ");
            string script = "alert('" + msg5 + "');";
            //ScriptManager define la funcion "alert" de javascript para su ejecucuoin
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader dr;
            SqlConnection conn;
            string msg;
            dr = dt.ConsultaReader();
            if(dr != null)
            {
                try
                {
                    DataTable Tabla = new DataTable();
                    Tabla.Load(dr);
                    GridView1.DataSource = Tabla;
                    GridView1.DataBind();
                    dr.Close();
                    conn = dt.P_Cn;
                    conn.Close();
                }
                catch(Exception error)
                {
                    dr.Close();
                    conn = dt.P_Cn;
                    conn.Close();
                    msg = error.ToString();
                    Mensaje(msg);
                }
            }
            else
            {
                conn = dt.P_Cn;
                conn.Close();
                msg = dt.P_error;
                Mensaje(msg);
            }
        }
    }
}