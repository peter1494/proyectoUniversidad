using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class DataAccessLayer
    {
        string conectionString = "data source=proyectoIngenieria.mssql.somee.com;initial catalog=proyectoIngenieria;user id=peter1494_SQLLogin_1;password=tamarindo1;";
        //data source = ServidorSQL; initial catalog = BaseDatos; user id = Usuario; password = Contraseña
        //workstation id=proyectoIngenieria.mssql.somee.com;packet size=4096;persist security info=False;
        //data source=proyectoIngenieria.mssql.somee.com;initial catalog=proyectoIngenieria;user id=peter1494_SQLLogin_1;password=tamarindo1;
        public DataTable cargarProductos()
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = conectionString;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_mostrarProductos";
            try
            {
                conn.Open();
                da.SelectCommand = cmd;
                da.Fill(dt);
                conn.Close();
            } catch(Exception e)
            {
                string mensaje = e.Message;
               
            }
            return dt;
        }

        public DataTable buscarProductoPorCodigo(string codigo)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            conn.ConnectionString = conectionString;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_buscarProductoPorCodigo";

            cmd.Parameters.AddWithValue("@p_id", codigo);
            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public string modificarProducto(string nombre, int cantidad, bool activo,string codigo)
        {
            string mensaje = "Producto modificado correctamente";

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            //@p_codigo VARCHAR(MAX),
            //@p_nombre   VARCHAR(MAX),
            //@p_cantidad VARCHAR(MAX)
            conn.ConnectionString = conectionString;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[sp_modificarProducto]";

            cmd.Parameters.AddWithValue("@p_codigo", codigo);
            cmd.Parameters.AddWithValue("@p_nombre", nombre);
            cmd.Parameters.AddWithValue("@p_cantidad", cantidad);
            cmd.Parameters.AddWithValue("@p_activo", activo);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }catch(Exception e)
            {
                mensaje = e.Message;
            }

            return mensaje;
        }
    }
}
