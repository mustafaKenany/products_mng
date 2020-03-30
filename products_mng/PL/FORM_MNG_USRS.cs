using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace products_mng.PL
{
    public partial class FORM_MNG_USRS : Form
    {
        BL.CLS_LOGIN USR = new BL.CLS_LOGIN ();
        public FORM_MNG_USRS()
        {
            InitializeComponent ();
        }

        private void button_ALL_USRS_Click(object sender, EventArgs e)
        {
            this.gridControl_MNGUSR.DataSource = USR.GET_ALL_USRS ();
        }

        private void button_UPDATEUSR_Click(object sender, EventArgs e)
        {
            int[] USR_ACS = new int[12];
            if (gridView1.RowCount > 0)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    int ID_USR = Convert.ToInt16 (gridView1.GetRowCellValue (i, gridView1.Columns["ID_USER"]).ToString ());
                    string USRFLNAME = gridView1.GetRowCellValue (i, gridView1.Columns["USR_FLNAME"]).ToString ();
                    string USRNAME = gridView1.GetRowCellValue (i, gridView1.Columns["USRNAME"]).ToString ();
                    USR_ACS[1] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS1"])));
                    USR_ACS[2] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS2"])));
                    USR_ACS[3] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS3"])));
                    USR_ACS[4] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS4"])));
                    USR_ACS[5] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS5"])));
                    USR_ACS[6] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS6"])));
                    USR_ACS[7] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS7"])));
                    USR_ACS[8] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS8"])));
                    USR_ACS[9] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS9"])));
                    USR_ACS[10] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS10"])));
                    USR_ACS[11] = Convert.ToInt16 ((gridView1.GetRowCellValue (i, gridView1.Columns["ACS11"])));
                    USR.UPDATE_USR (ID_USR, USRFLNAME, USRNAME, USR_ACS);
                }
                MessageBox.Show ("تمت عملية التعديل", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void button_DLTUSR_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                var DT = new DataTable ();
                string USRNAME = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["USRNAME"]).ToString ();
                int ID_USR = Convert.ToInt16 (gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_USER"]).ToString ());

                DT = USR.VERFIY_SALESMAN (USRNAME);
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show ("عذرا هذا المستخدم لديه قوائم مسجلة باسمه لايمكن حذفه", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    USR.DLT_USR (ID_USR);
                    MessageBox.Show ("تم حذف المستخدم", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.gridControl_MNGUSR.DataSource = USR.GET_ALL_USRS ();
                }
            }
        }

        private void button_BLOCKUSR_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                int ID_USR = Convert.ToInt16 (gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_USER"]).ToString ());
                USR.BLOCKUSR (ID_USR);
                MessageBox.Show ("تم حظر المستخدم", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
