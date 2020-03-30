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
    public partial class FORM_LOGIN : Form
    {
        public FORM_LOGIN()
        {
            InitializeComponent ();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            BL.CLS_LOGIN log = new BL.CLS_LOGIN ();
            DataTable dt = new DataTable ();
            int[] USR_ACC = new int[12];
            dt = log.LOGIN (txb_userID.Text.Trim (), txb_PwdUsr.Text.Trim ());
            if (dt.Rows.Count > 0)
            {
                var blockusr = Convert.ToInt32 (dt.Rows[0]["BLOCK_USR"]);
                if (blockusr == 0)
                {
                    USR_ACC[1] = Convert.ToInt16 (dt.Rows[0]["ACS1"]);
                    USR_ACC[2] = Convert.ToInt16 (dt.Rows[0]["ACS2"]);
                    USR_ACC[3] = Convert.ToInt16 (dt.Rows[0]["ACS3"]);
                    USR_ACC[4] = Convert.ToInt16 (dt.Rows[0]["ACS4"]);
                    USR_ACC[5] = Convert.ToInt16 (dt.Rows[0]["ACS5"]);
                    USR_ACC[6] = Convert.ToInt16 (dt.Rows[0]["ACS6"]);
                    USR_ACC[7] = Convert.ToInt16 (dt.Rows[0]["ACS7"]);
                    USR_ACC[8] = Convert.ToInt16 (dt.Rows[0]["ACS8"]);
                    USR_ACC[9] = Convert.ToInt16 (dt.Rows[0]["ACS9"]);
                    USR_ACC[10] = Convert.ToInt16 (dt.Rows[0]["ACS10"]);
                    USR_ACC[11] = Convert.ToInt16 (dt.Rows[0]["ACS11"]);
                    BL.CLS_LOGIN.SALES_MAN = txb_userID.Text;
                    FORM_MAIN.getMainForm.tool_Backup.Enabled = true;

                    if (USR_ACC[1] == 1)
                    {
                        FORM_MAIN.getMainForm.tool_DIRSALES.Enabled = true;
                        FORM_MAIN.getMainForm.tool_SALES.Enabled = true;

                    }
                    if (USR_ACC[2] == 1)
                    {
                        FORM_MAIN.getMainForm.tool_MNGSALESS.Enabled = true;
                        FORM_MAIN.getMainForm.tool_SALES.Enabled = true;

                    }
                    if (USR_ACC[3] == 1)
                    {

                    }
                    if (USR_ACC[4] == 1)
                    {

                    }
                    if (USR_ACC[5] == 1)
                    {
                        FORM_MAIN.getMainForm.Tool_ITEMS.Enabled = true;
                    }
                    if (USR_ACC[6] == 1)
                    {
                        FORM_MAIN.getMainForm.Tool_ADDCUSTOMER.Enabled = true;

                    }
                    if (USR_ACC[7] == 1)
                    {
                        FORM_MAIN.getMainForm.Tool_MNGCUSTOMER.Enabled = true;

                    }
                    if (USR_ACC[8] == 1)
                    {
                        FORM_MAIN.getMainForm.Tool_ADDUSER.Enabled = true;

                    }
                    if (USR_ACC[9] == 1)
                    {
                        FORM_MAIN.getMainForm.Tool_MNGUSERS.Enabled = true;

                    }
                    if (USR_ACC[10] == 1)
                    {
                        FORM_MAIN.getMainForm.Tool_MONEY.Enabled = true;

                    }
                    if (USR_ACC[11] == 1)
                    {

                    }

                   
                    this.Close ();
                }
                else
                {
                    MessageBox.Show ("هذا مستخدم تم حضره من قبل مدير النظام", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit ();
                }
            }
            else
            {
                MessageBox.Show ("Log Fail");
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit ();
        }
    }
}
