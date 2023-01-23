using AccesoADB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccesoADB.paginas
{
    public partial class ProductoNombre : System.Web.UI.Page
    {
        readonly datos dt;
        DataSet ds;
        string msg;

        public ProductoNombre()
        {
            ds = new DataSet();
            dt = new datos();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string id, msg;
            DataTable dataT;

            if (!IsPostBack)
            {
                DropDownList1.AutoPostBack = true;
                dataT = dt.LlenarDropDown_Nombre();
                if (dataT.Rows.Count > 0)
                {
                    DropDownList1.Items.Clear();
                    for (int i = 0; i < dataT.Rows.Count; i++)
                    {
                        id = dataT.Rows[i]["NombreProducto"].ToString();
                        DropDownList1.Items.Add(id);
                    }
                }
                else
                {
                    msg = dt.P_error;
                    Mensaje(msg);
                }
            }
        }

        public void Mensaje(string mensaje)
        {
            string msg = mensaje;
            string msg1 = msg.Replace("'", " ");
            string msg2 = msg.Replace("\r", " ");
            string msg3 = msg.Replace("\n", " ");
            string msg4 = msg.Replace("\\", " ");
            string msg5 = msg.Replace("\"", " ");

            string script = "alert('" + msg5 + "');)";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM productos WHERE NombreProducto ='" + DropDownList1.SelectedValue + "';";
            try
            {
                SqlDataReader datos = dt.ConsultaReader(query);
                DataTable table = new DataTable();
                table.Load(datos);
                GridView1.DataSource = table;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Mensaje(ex.Message);
            }
        }
    }
}