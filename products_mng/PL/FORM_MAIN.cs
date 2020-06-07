using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraReports.UI;
namespace products_mng.PL
{
    public partial class FORM_MAIN : Form
    {
        private static FORM_MAIN frm;
        BL.CLS_ORDERS ORD = new BL.CLS_ORDERS ();
        BL.CLS_REPORT_LIST RPTCLS = new BL.CLS_REPORT_LIST ();

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
            BL.CLS_ORDERS.ORDER_TYPES = 0;
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
            BL.CLS_REPORT_LIST.ReportFlag = 0;
            BL.CLS_ORDERS.ORDER_TYPES = 0;
            PL.FORM_RPTDATE form = new FORM_RPTDATE ();

            if (form.ShowDialog () == DialogResult.OK)
            {
                RPT.RPT_ALL_INVOS_BETWEEN_DATES y = new RPT.RPT_ALL_INVOS_BETWEEN_DATES ();
                var DT = ORD.SEARCH_ORDER_DATE (BL.CLS_ORDERS.ORDER_TYPES, form.dateTimePicker_BEGIN_DATE.Value.ToString ("yyyy-MM-dd"), form.dateTimePicker_END_DATE.Value.ToString ("yyyy-MM-dd"));
                y.xrTableCell_BeginDate.Text = form.dateTimePicker_BEGIN_DATE.Value.ToString ("yyyy-MM-dd");
                y.xrTableCell_EndDate.Text = form.dateTimePicker_END_DATE.Value.ToString ("yyyy-MM-dd");
                if (DT.Rows.Count > 0)
                {
                    y.DataSource = DT;
                    y.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد بيانات للفترة المحددة");
                }
            }

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

        private void ToolStripMenuItem_USRS_Click(object sender, EventArgs e)
        {
            RPT.FORM_RPT_USRS FORM = new RPT.FORM_RPT_USRS ();
            FORM.ShowDialog ();
        }

        private void ToolStripMenuItem_RPT_PAID_SPENT_Click(object sender, EventArgs e)
        {
            RPT.FORM_RPT_PAID_SPENT_WITH_COUSTOMERS FORM = new RPT.FORM_RPT_PAID_SPENT_WITH_COUSTOMERS ();
            FORM.ShowDialog ();
        }

        private void ToolStripMenuItem_RPT_NETMONEY_Click(object sender, EventArgs e)
        {
            BL.CLS_REPORT_LIST.ReportFlag = 2;
            PL.FORM_RPTDATE form = new FORM_RPTDATE ();
            if (form.ShowDialog () == DialogResult.OK)
            {
                RPT.RPT_NETMONEY rpt_netmoney = new RPT.RPT_NETMONEY ();
                var DT = RPTCLS.RPT_NETMONEY (form.dateTimePicker_BEGIN_DATE.Value.ToString ("yyyy-MM-dd"), form.dateTimePicker_END_DATE.Value.ToString ("yyyy-MM-dd"));
                if (DT.Rows.Count > 0)
                {
                    rpt_netmoney.DataSource = DT;
                    rpt_netmoney.xrLabel_BeginDate.Text = form.dateTimePicker_BEGIN_DATE.Value.ToString ("yyyy-MM-dd");
                    rpt_netmoney.xrLabel_EndDate.Text = form.dateTimePicker_BEGIN_DATE.Value.ToString ("yyyy-MM-dd");
                    rpt_netmoney.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد بيانات للفترة المحددة");
                }
            }

        }

        //private void ToolStripMenuItem_PRD_COST_AND_PROFITS_Click(object sender, EventArgs e)
        //{

        //}

        private void ToolStripMenuItem_PROFIT_COST_Click(object sender, EventArgs e)
        {
            BL.CLS_REPORT_LIST.ReportFlag = 3;
            PL.FORM_RPTDATE form = new FORM_RPTDATE ();
            if (form.ShowDialog () == DialogResult.OK)
            {
                RPT.RPT_CALC_PROFT_COST RPT_COST = new RPT.RPT_CALC_PROFT_COST ();
                var DT = RPTCLS.RPT_CALC_PROFT_COST (form.dateTimePicker_BEGIN_DATE.Value.ToString ("yyyy-MM-dd"), form.dateTimePicker_END_DATE.Value.ToString ("yyyy-MM-dd"));
                if (DT.Rows.Count > 0)
                {
                    RPT_COST.DataSource = DT;
                    RPT_COST.xrLabel_BEGIN_DATE.Text = form.dateTimePicker_BEGIN_DATE.Value.ToString ("yyyy-MM-dd");
                    RPT_COST.xrLabel_END_DATE.Text = form.dateTimePicker_END_DATE.Value.ToString ("yyyy-MM-dd");
                    RPT_COST.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد بيانات للفترة المحددة");
                }

            }

        }

        private void Tool_DIRECTPURCHASE_Click(object sender, EventArgs e)
        {
            BL.CLS_ORDERS.ORDER_TYPES = 1;
            PL.FORM_PURCHASES FORM = new FORM_PURCHASES ();
            FORM.ShowDialog ();
        }

        private void Tool_MNGPURCHASE_Click(object sender, EventArgs e)
        {
            BL.CLS_ORDERS.ORDER_TYPES = 1;
            PL.FORM_MNG_PURCHASES FORM = new FORM_MNG_PURCHASES ();
            FORM.ShowDialog ();
        }

        private void FORM_MAIN_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char) Keys.Enter)
            {
                // Your logic here....
                FORM_LOGIN form = new FORM_LOGIN ();
                form.ShowDialog ();
            }
        }

        private void ToolStripMenuItem_PurchaseRepo_Click(object sender, EventArgs e)
        {
            BL.CLS_ORDERS.ORDER_TYPES = 1;
            BL.CLS_REPORT_LIST.ReportFlag = 1;
            PL.FORM_RPTDATE form = new FORM_RPTDATE ();
            if (form.ShowDialog () == DialogResult.OK)
            {
                RPT.RPT_ALL_INVOS_BETWEEN_DATES y = new RPT.RPT_ALL_INVOS_BETWEEN_DATES ();
                var DT = ORD.SEARCH_ORDER_DATE (BL.CLS_ORDERS.ORDER_TYPES, form.dateTimePicker_BEGIN_DATE.Value.ToString ("yyyy-MM-dd"), form.dateTimePicker_END_DATE.Value.ToString ("yyyy-MM-dd"));
                y.xrTableCell_BeginDate.Text = form.dateTimePicker_BEGIN_DATE.Value.ToString ("yyyy-MM-dd");
                y.xrTableCell_EndDate.Text = form.dateTimePicker_END_DATE.Value.ToString ("yyyy-MM-dd");
                y.xrLabel_ReportTitle.Text = "قوائم المشتريات للفترة المحددة";
                y.xrTableCell_RPT_FOOTER.Text = "مجموع المشتريات خلال هذه الفترة";
                if (DT.Rows.Count > 0)
                {
                    y.DataSource = DT;
                    y.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد بيانات للفترة المحددة");
                }
            }

        }
    }
}
