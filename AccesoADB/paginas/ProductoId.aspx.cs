using AccesoADB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccesoADB.paginas
{
    public partial class ProductoId : System.Web.UI.Page
    {
        readonly datos dt;
        DataSet ds;
        string msg; 

        public ProductoId()
        {
            ds = new DataSet();
            dt= new datos();
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
        protected void Page_Load(object sender, EventArgs e)
        {
            string id, msg;
            DataTable dataT;

            if (!IsPostBack)
            {
                DropDownList1.AutoPostBack = true;
                dataT = dt.LlenarDropDownId();
                if (dataT.Rows.Count>0)
                {
                    DropDownList1.Items.Clear();
                    for (int i=0; i < dataT.Rows.Count; i++)
                    {
                        id = dataT.Rows[i]["IdProducto"].ToString();
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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string id = DropDownList1.SelectedValue;

            ds = dt.ObtenerProductosId(id);

            Label1.Text = ds.Tables[0].Rows[0]["idproducto"].ToString();
            Label2.Text = ds.Tables[0].Rows[0]["NombreProducto"].ToString();
            Label3.Text = ds.Tables[0].Rows[0]["Descripcion"].ToString();
            Label4.Text = ds.Tables[0].Rows[0]["PrecioUnitario"].ToString();
        }
    }
}