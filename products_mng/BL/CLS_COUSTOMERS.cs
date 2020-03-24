using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace products_mng.BL
{
    class CLS_COUSTOMERS
    {

        public int GET_ID_COUST()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            int ID = 1;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ID_COUST", null);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ID = int.Parse (dt.Rows[i]["ID_COUSTOMER"].ToString ());
                }
                ID = ID + 1;
            }
            dal.ConClose ();
            return ID;
        }

        public DataTable GET_ALL_COUSTOMERS()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ALL_COUSTOMERS", null);
            dal.ConClose ();
            return dt;

        }

        public DataTable SEARCH_COUSTOMER(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            dt = dal.SelectData ("SEARCH_COUSTOMER", param);
            dal.ConClose ();
            return dt;
        }

        public void ADD_NEW_COUSTOMER(int ID_COUST ,String COUST_NAME, String COUST_TEL, String COUST_ADD, String COUST_TYPE, byte[] COUST_IMG)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[6];
            PARAM[0] = new SqlParameter ("@COUST_NAME", SqlDbType.NVarChar,50);
            PARAM[1] = new SqlParameter ("@TEL", SqlDbType.NVarChar, 50);
            PARAM[2] = new SqlParameter ("@ADD", SqlDbType.NVarChar, 50);
            PARAM[3] = new SqlParameter ("@COUST_TYPE", SqlDbType.NVarChar, 50);
            PARAM[4] = new SqlParameter ("@COUST_IMG", SqlDbType.Image);
            PARAM[5] = new SqlParameter ("@ID_COUST", SqlDbType.Int);
            PARAM[0].Value = COUST_NAME;
            PARAM[1].Value = COUST_TEL;
            PARAM[2].Value = COUST_ADD;
            PARAM[3].Value = COUST_TYPE;
            PARAM[4].Value = COUST_IMG;
            PARAM[5].Value = ID_COUST;
            dal.ExecuteCommand ("ADD_NEW_COUSTOMER", PARAM);
            dal.ConClose ();
        }

        public DataTable Verfiy_COUSTOMER(string ID)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter ("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            dt = dal.SelectData ("Verfiy_COUSTOMER", param);
            dal.ConClose ();
            return dt;
        }

        public void DELETE_COUSTOMER(String ID_COUST)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[1];
            PARAM[0] = new SqlParameter ("@ID_COUST", SqlDbType.Int);
            PARAM[0].Value = ID_COUST;
            dal.ExecuteCommand ("DELETE_COUSTOMER", PARAM);
            dal.ConClose ();
        }

        public void UPDATE_COUSTOMER(int ID_COUST, String COUST_NAME, String COUST_TEL, String COUST_ADD, String COUST_TYPE, byte[] COUST_IMG)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[6];
            PARAM[0] = new SqlParameter ("@COUST_NAME", SqlDbType.NVarChar, 50);
            PARAM[1] = new SqlParameter ("@TEL", SqlDbType.NVarChar, 50);
            PARAM[2] = new SqlParameter ("@ADD", SqlDbType.NVarChar, 50);
            PARAM[3] = new SqlParameter ("@COUST_TYPE", SqlDbType.NVarChar, 50);
            PARAM[4] = new SqlParameter ("@COUST_IMG", SqlDbType.Image);
            PARAM[5] = new SqlParameter ("@ID_COUST", SqlDbType.Int);
            PARAM[0].Value = COUST_NAME;
            PARAM[1].Value = COUST_TEL;
            PARAM[2].Value = COUST_ADD;
            PARAM[3].Value = COUST_TYPE;
            PARAM[4].Value = COUST_IMG;
            PARAM[5].Value = ID_COUST;
            dal.ExecuteCommand ("UPDATE_COUSTOMER", PARAM);
            dal.ConClose ();

        }
    }
}
