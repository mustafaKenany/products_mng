using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace products_mng.DAL
{
    class DataAccessLayer
    {
        SqlConnection con;
        //This constructor is initialize the sql connection
        public DataAccessLayer()
        {
            con = new SqlConnection (@"Data Source=.;Initial Catalog=Pharmacy_DB;User ID=sa;Password=123");
        }

        //This method open conection with SQL
        public void ConOpen()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open ();
            }
        }

        //this method close connection
        public void ConClose()
        {
            if (con.State!=ConnectionState.Closed)
            {
                con.Close ();
            }
        }

        //method to read data from  db
        public DataTable SelectData(string Stored_procedure, SqlParameter[] parameters)
        {
            SqlCommand sqlcmd = new SqlCommand ();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_procedure;
            sqlcmd.Connection = con;
            if (parameters != null)
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    sqlcmd.Parameters.Add (parameters[i]);
                }
            }

            SqlDataAdapter sda = new SqlDataAdapter (sqlcmd);
            DataTable dt = new DataTable ();
            sda.Fill (dt);
            return dt;
        }

        //method to insert or update or delete 
        public void ExecuteCommand(string Stored_procedure, SqlParameter[] parameters)
        {
            SqlCommand sqlcmd = new SqlCommand ();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_procedure;
            sqlcmd.Connection = con;
            if (parameters != null)
            {
                sqlcmd.Parameters.AddRange (parameters);
            }
            sqlcmd.ExecuteNonQuery ();

        }
    }
}
