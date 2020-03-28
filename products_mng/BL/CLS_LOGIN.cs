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
        public DataTable LOGIN(string ID, string PWD)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter ("@USRNAME", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            param[1] = new SqlParameter ("@USRPWD", SqlDbType.NVarChar, 50);
            param[1].Value = PWD;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("SP_LOGIN", param);
            dal.ConClose ();
            return dt;
        }

        public void ADD_NEW_USR(string USR_FLNAME,  string USRNAME, string USR_PWD, int USER_ACS)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[4];
            PARAM[0] = new SqlParameter ("@USR_FLNAME", SqlDbType.NVarChar,50);
            PARAM[1] = new SqlParameter ("@USRNAME", SqlDbType.NVarChar, 50);
            PARAM[2] = new SqlParameter ("@USR_PWD", SqlDbType.NVarChar, 50);
            PARAM[3] = new SqlParameter ("@USER_ACS", SqlDbType.Int);
            PARAM[0].Value = USR_FLNAME;
            PARAM[1].Value = USRNAME;
            PARAM[2].Value = USR_PWD;
            PARAM[3].Value = USER_ACS;
            dal.ExecuteCommand ("ADD_NEW_USR", PARAM);
            dal.ConClose ();

        }

        public DataTable USRFLNAME_VERFIY(string USR_FLNAME)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@USR_FLNAME", SqlDbType.NVarChar, 50);
            param[0].Value = USR_FLNAME;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("USRFLNAME_VERFIY", param);
            dal.ConClose ();
            return dt;
        }

        public DataTable USRNAME_VERFIY(string USRNAME)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@USRNAME", SqlDbType.NVarChar, 50);
            param[0].Value = USRNAME;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("USRNAME_VERFIY", param);
            dal.ConClose ();
            return dt;
        }

        public DataTable GET_ALL_USRS()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ALL_USRS", null);
            dal.ConClose ();
            return dt;
        }


    }
}
