using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products_mng.BL
{
    class CLS_MNG_CAT
    {
        public DataTable GET_ALL_CATEGORIES()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ALL_CATEGORIES", null);
            dal.ConClose ();
            return dt;

        }
        public void ADD_NEW_CATEGORIES(string CAT_LABEL)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[1];
            PARAM[0] = new SqlParameter ("@CAT_LABEL", SqlDbType.NVarChar,50);
            PARAM[0].Value = CAT_LABEL;
            dal.ExecuteCommand ("ADD_NEW_CATEGORIES", PARAM);
            dal.ConClose ();

        }

        public void DELETE_CATEGORIES(String ID_CAT)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[1];
            PARAM[0] = new SqlParameter ("@ID_CAT", SqlDbType.NVarChar, 50);
            PARAM[0].Value = ID_CAT;
            dal.ExecuteCommand ("DELETE_CATEGORIES", PARAM);
            dal.ConClose ();

        }

        public void UPDATE_CAT(int ID_CAT, string CAT_LABEL)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            dal.ConOpen ();
            SqlParameter[] PARAM = new SqlParameter[2];
            PARAM[0] = new SqlParameter ("@ID_CAT", SqlDbType.Int);
            PARAM[1] = new SqlParameter ("@CAT_LABEL", SqlDbType.NVarChar, 50);
            
            PARAM[0].Value = ID_CAT;
            PARAM[1].Value = CAT_LABEL;
           
            dal.ExecuteCommand ("UPDATE_CAT", PARAM);
            dal.ConClose ();

        }

    }
}
