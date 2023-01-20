using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AccesoADB.Models;

namespace AccesoADB.paginas
{
    public partial class ProductoDs : System.Web.UI.Page
    {
        readonly datos dt;
        DataSet ds;
        string msg;
        public ProductoDs()
        {
            ds = new DataSet();
            dt = new datos();
        }
        //Para visualizar los errores si existieran por medio de la funcion "alert" de javascript
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
            ds = dt.ObtenerProductos();
            if (string.IsNullOrEmpty(dt.P_error))
            {
                try
                {
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                    GridView1.Dispose();
                }
                catch(Exception error)
                {
                    //Si hay error al cargar los datos en el GridView
                    msg = error.ToString();
                    Mensaje(msg);
                }

            }
            else
            {
                //Si ocurrió un error al ejecutar la consulta
                msg = dt.P_error;
                Mensaje(msg);
            }
        }
    }
}