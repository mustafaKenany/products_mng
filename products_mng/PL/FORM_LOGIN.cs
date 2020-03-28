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
            dt = log.LOGIN (txb_userID.Text.Trim(), txb_PwdUsr.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                BL.CLS_LOGIN.SALES_MAN = txb_userID.Text;
                FORM_MAIN.getMainForm.tool_Backup.Enabled = true;
                FORM_MAIN.getMainForm.tool_importBakup.Enabled= true;
                FORM_MAIN.getMainForm.Tool_CUSTOMER.Enabled = true;
                FORM_MAIN.getMainForm.Tool_ITEMS.Enabled = true;
                FORM_MAIN.getMainForm.Tool_MONEY.Enabled = true;
                FORM_MAIN.getMainForm.Tool_PURCHAES.Enabled = true;
                FORM_MAIN.getMainForm.tool_SALES.Enabled = true;
                FORM_MAIN.getMainForm.Too_USERS.Enabled = true;
                FORM_MAIN.getMainForm.tool_login.Enabled = false;
                this.Close ();
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
