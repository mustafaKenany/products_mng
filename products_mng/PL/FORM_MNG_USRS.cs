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

        private void button_SLCT_USR_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                string ID_USR = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_USER"]).ToString ();
                int USR_ACS = int.Parse(gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["USER_ACS"]).ToString ());
                USR_ACS_CHECKED (USR_ACS);
            }
        }

        private void USR_ACS_CHECKED(int USR_ACS)
        {
            switch (USR_ACS)
            {
                case 3:
                    checkBox_ACS1.Checked = true;
                    break;
                case 4:
                    checkBox_ACS2.Checked = true;
                    break;
                case 5:
                    checkBox_ACS3.Checked = true;

                    break;
                case 6:
                    checkBox_ACS4.Checked = true;
                    break;
                case 7:
                    checkBox_ACS5.Checked = true;
                    break;
                case 8:
                    checkBox_ACS6.Checked = true;

                    break;
                case 9:
                    checkBox_ACS7.Checked = true;
                    break;
                case 10:
                    checkBox_ACS8.Checked = true;
                    break;
                case 100:
                    break;
                default:
                    break;
            }
        }
    }
}
