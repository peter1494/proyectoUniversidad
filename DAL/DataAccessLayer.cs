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
        string conectionString = "workstation id=proyectoIngenieria.mssql.somee.com;packet size=4096;user id=peter1494_SQLLogin_1;pwd=tamarindo1;data source=proyectoIngenieria.mssql.somee.com;persist security info=False;initial catalog=proyectoIngenieria;";
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

            conn.Open();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
