using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace products_mng.BL
{
    class CLS_LOGIN
    {
        public static string SALES_MAN = "";
        //method check login
        public  DataTable LOGIN(string ID, string PWD)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter ("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            param[1] = new SqlParameter ("@PWD", SqlDbType.VarChar, 50);
            param[1].Value = PWD;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("SP_LOGIN", param);
            dal.ConClose ();
            return dt;
           
        }
    }
}
