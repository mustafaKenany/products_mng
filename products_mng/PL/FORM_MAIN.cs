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
    public partial class FORM_MAIN : Form
    {
        private static FORM_MAIN frm;
        public FORM_MAIN()
        {
            if (frm == null)
            {
                frm = this;
            }
            InitializeComponent ();
        }

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static FORM_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_MAIN ();
                    frm.FormClosed += new FormClosedEventHandler (frm_FormClosed);
                }
                return frm;
            }
        }

        private void tool_login_Click(object sender, EventArgs e)
        {
            FORM_LOGIN FORM = new FORM_LOGIN ();
            FORM.ShowDialog ();
        }

        private void Tool_ADDITEM_Click(object sender, EventArgs e)
        {
            FORM_ADD_PRODUCTS form = new FORM_ADD_PRODUCTS ();
            form.ShowDialog ();
        }

        private void Tool_MNGITEMS_Click(object sender, EventArgs e)
        {
            FORM_MNG_PRODUCTS form = new FORM_MNG_PRODUCTS ();
            form.ShowDialog ();
        }

        private void Tool_MNGCAT_Click(object sender, EventArgs e)
        {
            FORM_MNG_CATEGORIES FORM = new FORM_MNG_CATEGORIES ();
            FORM.ShowDialog ();
        }

        private void Tool_MNGCUSTOMER_Click(object sender, EventArgs e)
        {
            FORM_MNG_COUSTOMERS FORM = new FORM_MNG_COUSTOMERS ();
            FORM.ShowDialog ();
        }

        private void Tool_ADDCUSTOMER_Click(object sender, EventArgs e)
        {
            FORM_COUSTOMERS FORM = new FORM_COUSTOMERS ();
            FORM.ShowDialog ();
        }

        private void tool_DIRSALES_Click(object sender, EventArgs e)
        {
            BL.CLS_ORDERS.ORDER_TYPES = 0;
            FORM_SALES FORM = new FORM_SALES ();
            FORM.ShowDialog ();
        }

        private void tool_MNGSALESS_Click(object sender, EventArgs e)
        {
           
            FORM_MNG_ORDERS FORM = new FORM_MNG_ORDERS ();
            FORM.ShowDialog ();
        }

        private void tool_Logout_Click(object sender, EventArgs e)
        {
            Application.Exit ();
        }

        private void Tool_ADDUSER_Click(object sender, EventArgs e)
        {
            FORM_ADD_USR FORM = new FORM_ADD_USR ();
            FORM.ShowDialog ();
        }

        private void Tool_MNGUSERS_Click(object sender, EventArgs e)
        {
            FORM_MNG_USRS form = new FORM_MNG_USRS ();
            form.ShowDialog ();
        }

        private void TooL_PAIDMONEY_Click(object sender, EventArgs e)
        {
            FORM_PAID_MONEY FORM = new FORM_PAID_MONEY ();
            FORM.ShowDialog ();
        }

        private void Tool_SPENTMONEY_Click(object sender, EventArgs e)
        {
            FORM_SPENT_MONEY FORM = new FORM_SPENT_MONEY ();
            FORM.ShowDialog ();
        }

        private void Tool_DAILYSPENT_Click(object sender, EventArgs e)
        {
            FORM_DAILY_SPENT FORM = new FORM_DAILY_SPENT ();
            FORM.ShowDialog ();
        }

        private void ToolStripMenuItem_mngdocs_Click(object sender, EventArgs e)
        {
            FORM_MNG_PAID_SPENT_DOCS FORM = new FORM_MNG_PAID_SPENT_DOCS ();
            FORM.ShowDialog ();
        }

        private void ToolStripMenuItem_SLAESREP_Click(object sender, EventArgs e)
        {
            PL.FORM_RPTDATE form = new FORM_RPTDATE ();
            form.ShowDialog ();
        }

        private void ToolStripMenuItem_REPORITMS_Click(object sender, EventArgs e)
        {
            RPT.FORM_RPT_ITEMS FORM = new RPT.FORM_RPT_ITEMS ();
            FORM.ShowDialog ();
        }

        private void ToolStripMenuItem_COUST_Click(object sender, EventArgs e)
        {
            RPT.FORM_RPT_COUSTOMERS FORM = new RPT.FORM_RPT_COUSTOMERS ();
            FORM.ShowDialog ();
        }
    }
}
