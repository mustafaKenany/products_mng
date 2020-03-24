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
            FORM_SALES FORM = new FORM_SALES ();
            FORM.ShowDialog ();
        }
    }
}
