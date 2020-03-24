using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace products_mng.BL
{
    class CLS_SALES
    {
        public int GET_ID_ORDER()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer ();
            int ID = 1;
            DataTable dt = new DataTable ();
            dt = dal.SelectData ("GET_ID_ORDER", null);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ID = int.Parse (dt.Rows[i]["ID_ORDER"].ToString ());
                }
                ID = ID + 1;
            }
            dal.ConClose ();
            return ID;
        }
    }
}
