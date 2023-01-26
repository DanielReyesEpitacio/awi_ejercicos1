using AccesoADB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccesoADB.paginas
{
    public partial class Producto : System.Web.UI.Page
    {
        readonly datos agrega;
        
        public Producto()
        {
            agrega = new datos();
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
            
        }

        protected void agregar_producto_Click(object sender, EventArgs e)
        {
            agrega.NombreProducto = txtNombre.Value;
            agrega.Descripcion = txtDescripcion.Value;
            agrega.ImagenPath = txtImagen.Value;
            agrega.PrecioUnitario = double.Parse(txtPrecio.Value);
            agrega.IdCategoria = int.Parse(txtCategoria.Value);

            String msg = agrega.agregarProducto() ? "Producto agregado con exito" : "Ha ocurrido un error. No se agrego el producto";
            Mensaje(msg);
        }
    }
}