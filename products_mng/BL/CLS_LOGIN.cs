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

        public void ADD_NEW_USR(string USR_FLNAME,  string USRNAME, string USR_PWD, int[] USER_ACS)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[14];
            PARAM[0] = new SqlParameter ("@USR_FLNAME", SqlDbType.NVarChar,50);
            PARAM[1] = new SqlParameter ("@USRNAME", SqlDbType.NVarChar, 50);
            PARAM[2] = new SqlParameter ("@USR_PWD", SqlDbType.NVarChar, 50);
            PARAM[3] = new SqlParameter ("@ACS1", SqlDbType.Bit);
            PARAM[4] = new SqlParameter ("@ACS2", SqlDbType.Bit);
            PARAM[5] = new SqlParameter ("@ACS3", SqlDbType.Bit);
            PARAM[6] = new SqlParameter ("@ACS4", SqlDbType.Bit);
            PARAM[7] = new SqlParameter ("@ACS5", SqlDbType.Bit);
            PARAM[8] = new SqlParameter ("@ACS6", SqlDbType.Bit);
            PARAM[9] = new SqlParameter ("@ACS7", SqlDbType.Bit);
            PARAM[10] = new SqlParameter ("@ACS8", SqlDbType.Bit);
            PARAM[11] = new SqlParameter ("@ACS9", SqlDbType.Bit);
            PARAM[12] = new SqlParameter ("@ACS10", SqlDbType.Bit);
            PARAM[13] = new SqlParameter ("@ACS11", SqlDbType.Bit);
            PARAM[0].Value = USR_FLNAME;
            PARAM[1].Value = USRNAME;
            PARAM[2].Value = USR_PWD;
            PARAM[3].Value = USER_ACS[1];
            PARAM[4].Value = USER_ACS[2];
            PARAM[5].Value = USER_ACS[3];
            PARAM[6].Value = USER_ACS[4];
            PARAM[7].Value = USER_ACS[5];
            PARAM[8].Value = USER_ACS[6];
            PARAM[9].Value = USER_ACS[7];
            PARAM[10].Value = USER_ACS[8];
            PARAM[11].Value = USER_ACS[9];
            PARAM[12].Value = USER_ACS[10];
            PARAM[13].Value = USER_ACS[11];
            dal.ExecuteCommand ("ADD_NEW_USR", PARAM);
            dal.ConClose ();

        }

        public void UPDATE_USR(int USR_ID, string USR_FLNAME, string USRNAME,  int[] USER_ACS)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[14];
            PARAM[0] = new SqlParameter ("@USR_FLNAME", SqlDbType.NVarChar, 50);
            PARAM[1] = new SqlParameter ("@USRNAME", SqlDbType.NVarChar, 50);
            PARAM[2] = new SqlParameter ("@USR_ID", SqlDbType.NVarChar, 50);
            PARAM[3] = new SqlParameter ("@ACS1", SqlDbType.Bit);
            PARAM[4] = new SqlParameter ("@ACS2", SqlDbType.Bit);
            PARAM[5] = new SqlParameter ("@ACS3", SqlDbType.Bit);
            PARAM[6] = new SqlParameter ("@ACS4", SqlDbType.Bit);
            PARAM[7] = new SqlParameter ("@ACS5", SqlDbType.Bit);
            PARAM[8] = new SqlParameter ("@ACS6", SqlDbType.Bit);
            PARAM[9] = new SqlParameter ("@ACS7", SqlDbType.Bit);
            PARAM[10] = new SqlParameter ("@ACS8", SqlDbType.Bit);
            PARAM[11] = new SqlParameter ("@ACS9", SqlDbType.Bit);
            PARAM[12] = new SqlParameter ("@ACS10", SqlDbType.Bit);
            PARAM[13] = new SqlParameter ("@ACS11", SqlDbType.Bit);
            PARAM[0].Value = USR_FLNAME;
            PARAM[1].Value = USRNAME;
            PARAM[2].Value = USR_ID;
            PARAM[3].Value = USER_ACS[1];
            PARAM[4].Value = USER_ACS[2];
            PARAM[5].Value = USER_ACS[3];
            PARAM[6].Value = USER_ACS[4];
            PARAM[7].Value = USER_ACS[5];
            PARAM[8].Value = USER_ACS[6];
            PARAM[9].Value = USER_ACS[7];
            PARAM[10].Value = USER_ACS[8];
            PARAM[11].Value = USER_ACS[9];
            PARAM[12].Value = USER_ACS[10];
            PARAM[13].Value = USER_ACS[11];
            dal.ExecuteCommand ("UPDATE_USR", PARAM);
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

        public DataTable VERFIY_SALESMAN(string USRNAME)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@USRNAME", SqlDbType.NVarChar, 50);
            param[0].Value = USRNAME;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("VERFIY_SALESMAN", param);
            dal.ConClose ();
            return dt;
        }

        public void DLT_USR(int USR_ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[1];
            PARAM[0] = new SqlParameter ("@USR_ID", SqlDbType.Int);
            PARAM[0].Value = USR_ID;
            dal.ExecuteCommand ("DLT_USR", PARAM);
            dal.ConClose ();

        }

        public void BLOCKUSR(int USR_ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[1];
            PARAM[0] = new SqlParameter ("@USR_ID", SqlDbType.Int);
            PARAM[0].Value = USR_ID;
            dal.ExecuteCommand ("BLOCKUSR", PARAM);
            dal.ConClose ();

        }



    }
}
