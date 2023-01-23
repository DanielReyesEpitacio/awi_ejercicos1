using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI.WebControls;

namespace AccesoADB.Models
{
    public class datos
    {
        public int IDProductos { set; get; }
        public string NombreProducto { set; get; }
        public string Descripcion { set; get; }
        public string ImagenPath { set; get; }
        public double PrecioUnitario { set; get; }
        public int IdCategoria { set; get; }

        public string dbconexion;//para almacenar 
        private string Error = "";//Para capturar errores
        SqlConnection Cn;//Para crear el objeto coneccion

        public string P_error //Para el almacenamiento y recuperacion
        {
            set
            {
                Error = value;
            }
            get
            {
                return (Error);
            }
        }
        public SqlConnection P_Cn
        {
            get
            {
                return (Cn);
            }

        }
        public datos()
        {
            //La cadena de coneccion es nombrada "ConectaJuguetes"
            //Se va al archivo web.config para recuperar los datos de la cadea de conexion
            //Agregar el espacio de nombres "using System.Configuration" para la clase
            //Cofiguration Manager
            dbconexion = ConfigurationManager.ConnectionStrings["ConectaJuguetes"].ConnectionString;
        }
        //Agregar el espacio de nombres "using System.Data" para la clase DataSet
        //Agregar el espacio de nombres "using System.Data.SqlClient" para las clases
        //SqlCommand y SqlAdapter

        public DataSet ObtenerProductos()
        {
             DataSet ds = new DataSet();//Creamos el contenedor dataset
            SqlCommand dbCommand = new SqlCommand();
            string consulta;
            //Creamos el objeto para establecer la conexion con la DB
            Cn = new SqlConnection(dbconexion);
            //La clausula sql a ejecutar 
            consulta = "select * from productos";
            //Configuramos las propiedades del objeto Command
            dbCommand.CommandText = consulta;
            dbCommand.Connection = Cn;
            //Creamos el objeto Adapter ya contiene los datos para ejecutar la consulta
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = dbCommand;
            try
            {
                //Se ejecuta la consulta y se guardan los registros
                //En el objeto DataSet
                adapter.Fill(ds);
            }
            catch(Exception e)
            {
                //Si ocurrió algun error, se cacha este y se guarda 
                //Su descripcion en el propiedad error
                Error = e.Message;
            }
            //Se liberan de memeoria los objetos
            dbCommand.Connection.Close();
            dbCommand.Dispose();
            adapter.Dispose();
            //Se regresa el DataSet con los registros
            return (ds);

        }

        public SqlDataReader ConsultaReader()
        {
            SqlDataReader dr = null;
            SqlCommand dbCommand = new SqlCommand();
            Cn = new SqlConnection(dbconexion);
            string consulta = "select * from productos";
            dbCommand.CommandText = consulta;
            dbCommand.Connection = Cn;
            try
            {
                Cn.Open();
                dr = dbCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                Error = e.Message;
                Cn.Close();
                return null;
            }
            return dr;
        }

        public SqlDataReader ConsultaReader(String query) 
        {
            SqlDataReader dr = null;
            SqlCommand dbCommand = new SqlCommand();
            Cn = new SqlConnection(dbconexion);
            string consulta = query;
            dbCommand.CommandText = consulta;
            dbCommand.Connection = Cn;
            try
            {
                Cn.Open();
                dr = dbCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                Error = e.Message;
                Cn.Close();
                return null;
            }
            return dr;
        }

        public DataTable LlenarDropDownId()
        {
            DataTable dt = new DataTable();

            Cn = new SqlConnection(dbconexion);
            string consulta = "select IdProducto from productos";

            SqlCommand dbbCommand = new SqlCommand();
            dbbCommand.CommandText = consulta;
            dbbCommand.Connection = Cn;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = dbbCommand;

            try
            {
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                Error = e.Message;
            }

            dbbCommand.Connection.Close();
            dbbCommand.Dispose();
            adapter.Dispose();

            return dt;
        }

        public DataSet ObtenerProductosId(string id)
        {
            DataSet ds = new DataSet();
            Cn = new SqlConnection(dbconexion);
            SqlCommand dboman = new SqlCommand();
            string consulta = "SELECT * FROM productos where idproducto =" + id;

            dboman.CommandText = consulta;
            dboman.Connection = Cn;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = dboman;

            try
            {
                adapter.Fill(ds);
            }
            catch (Exception e)
            {
                Error = e.Message;
            }

            dboman.Connection.Close();
            dboman.Dispose();
            adapter.Dispose();

            return ds;
            
        }

        public DataTable LlenarDropDown_Nombre()
        {
            DataTable dt = new DataTable();
            Cn = new SqlConnection(dbconexion);
            string consulta = "SELECT NombreProducto FROM productos";

            SqlCommand dbCommand = new SqlCommand();
            dbCommand.CommandText = consulta;
            dbCommand.Connection = Cn;

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = dbCommand;

            try
            {
                adapter.Fill(dt);
            }
            catch (Exception e) 
            {
                Error = e.Message;
            }

            return dt;
        }

    }
}