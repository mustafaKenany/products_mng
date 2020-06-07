using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace products_mng.RPT
{
    public partial class FORM_RPT_USRS : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN ();
        BL.CLS_REPORT_LIST RPTCLS = new BL.CLS_REPORT_LIST ();
        string BEGIN_DATE, END_DATE;
        DataTable dt = new DataTable ();

        public FORM_RPT_USRS()
        {
            InitializeComponent ();
        }

        private void button_displayData_Click(object sender, EventArgs e)
        {
            this.gridControl_USRS.DataSource = log.GET_ALL_USRS ();
        }

        private void button_RPT_USR_PAID_SPENT_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                 BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                 END_DATE = dateTimePicker_END_DATE.Text;

                string USR_NAME = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["USR_FLNAME"]).ToString ();
                RPT.RPT_USR_PAID_SPENT_MONEY X = new RPT_USR_PAID_SPENT_MONEY ();
                X.xrLabel_title.Text = "تقرير مالي خاص بسندات القبض المقبوضة من قبل هذا الكاشير وحسب فترة محددة";
                X.xrLabel_BEGINDATE.Text = BEGIN_DATE;
                X.xrLabel_ENDDATE.Text = END_DATE;
                X.xrLabel_USR_NAME.Text = USR_NAME;
                X.xrLabelFOOTER_TITLE.Text = "مجموع المبالغ المقبوضة من قبل هذا الكاشير خلال الفترة المححدة";
                dt = RPTCLS.RPT_USR_PAID_SPENT_MONEY (BEGIN_DATE, END_DATE, USR_NAME, "سندات قبض");
                if (dt.Rows.Count > 0)
                {
                    X.DataSource = dt;
                    X.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد مستندات قبض خاصة بهذا الكاشير خلال الفترة المحددة", "Message");
                }

            }
        }

        private void button_RPT_SPENT_MONEY_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                 BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                 END_DATE = dateTimePicker_END_DATE.Text;

                string USR_NAME = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["USR_FLNAME"]).ToString ();
                RPT.RPT_USR_PAID_SPENT_MONEY X = new RPT_USR_PAID_SPENT_MONEY ();
                X.xrLabel_BEGINDATE.Text = BEGIN_DATE;
                X.xrLabel_ENDDATE.Text = END_DATE;
                X.xrLabel_USR_NAME.Text = USR_NAME;
                X.xrLabel_title.Text = "تقرير مالي خاص بسندات الصرف المصروفة من قبل هذا الكاشير وحسب فترة محددة";
                dt = RPTCLS.RPT_USR_PAID_SPENT_MONEY (BEGIN_DATE, END_DATE, USR_NAME, "سندات صرف");
                X.xrLabelFOOTER_TITLE.Text = "مجموع المبالغ المصروفة من قبل هذا الكاشير خلال الفترة المححدة";
                if (dt.Rows.Count > 0)
                {
                    X.DataSource = dt;
                    X.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد مستندات صرف خاصة بهذا الكاشير خلال الفترة المحددة", "Message");
                }

            }
        }

        private void button_RPT_USR_DAILY_SPENT_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                 BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                 END_DATE = dateTimePicker_END_DATE.Text;

                string USR_NAME = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["USR_FLNAME"]).ToString ();
                RPT.RPT_USR_PAID_SPENT_MONEY X = new RPT_USR_PAID_SPENT_MONEY ();
                X.xrLabel_BEGINDATE.Text = BEGIN_DATE;
                X.xrLabel_ENDDATE.Text = END_DATE;
                X.xrLabel_USR_NAME.Text = USR_NAME;
                X.xrLabel_title.Text = "تقرير مالي خاص بسندات الصرف اليومية من قبل هذا الكاشير وحسب فترة محددة";

                X.xrLabelFOOTER_TITLE.Text = "مجموع الصرفيات اليومية التي تم صرفها من قبل هذا الكاشير ولفترة المحددة";
                dt = RPTCLS.RPT_USR_PAID_SPENT_MONEY (BEGIN_DATE, END_DATE, USR_NAME, "صرفيات يومية");
                if (dt.Rows.Count > 0)
                {
                    X.DataSource = dt;
                    X.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد مستندات صرف يومية خاصة بهذا الكاشير خلال الفترة المحددة", "Message");
                }

            }
        }

        private void button_RPT_USR_SALES_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                 BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                 END_DATE = dateTimePicker_END_DATE.Text;

                //int ID_USR = Convert.ToInt16 (gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_USER"]).ToString ());
                string USR_NAME = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["USR_FLNAME"]).ToString ();
                RPT.RPT_USR_SALES X = new RPT_USR_SALES ();
                X.xrLabel_BEGINDATE.Text = BEGIN_DATE;
                X.xrLabel_ENDDATE.Text = END_DATE;
                X.xrLabel_USR_NAME.Text = USR_NAME;
                dt = RPTCLS.RPT_USR_SALES (0, BEGIN_DATE, END_DATE, USR_NAME);
                if (dt.Rows.Count > 0)
                {
                    X.DataSource = dt;
                    X.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد مبيعات لهذا المستخدم خلال الفترة المحددة", "MESSAGE");
                }
            }
        }

        private void button_RPT_USR_PURCHASE_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                END_DATE = dateTimePicker_END_DATE.Text;

                //int ID_USR = Convert.ToInt16 (gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["ID_USER"]).ToString ());
                string USR_NAME = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["USR_FLNAME"]).ToString ();
                RPT.RPT_USR_SALES X = new RPT_USR_SALES ();
                X.xrLabel_BEGINDATE.Text = BEGIN_DATE;
                X.xrLabel_ENDDATE.Text = END_DATE;
                X.xrLabel_USR_NAME.Text = USR_NAME;
                X.xrLabel_title.Text = "تقرير مشتريات خاص بكاشير محدد وحسب فترة محددة";
                 
                dt = RPTCLS.RPT_USR_SALES (1, BEGIN_DATE, END_DATE, USR_NAME);
                if (dt.Rows.Count > 0)
                {
                    X.DataSource = dt;
                    X.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد مبيعات لهذا المستخدم خلال الفترة المحددة", "MESSAGE");
                }
            }
        }

        private void button_RPT_NETMONEY_with_usr_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                BEGIN_DATE = dateTimePicker_BEGIN_DATE.Text;
                END_DATE = dateTimePicker_END_DATE.Text;
                string USR_NAME = gridView1.GetRowCellValue (gridView1.FocusedRowHandle, gridView1.Columns["USR_FLNAME"]).ToString ();
                RPT.RPT_NETMONEY_WITH_USR X = new RPT_NETMONEY_WITH_USR ();
                X.xrLabel1.Text = USR_NAME;
                X.xrLabel_BeginDate.Text = BEGIN_DATE;
                X.xrLabel_EndDate.Text = END_DATE;
                dt = RPTCLS.RPT_NETMONEY_WITH_USR (BEGIN_DATE, END_DATE, USR_NAME);
                if (dt.Rows.Count > 0)
                {
                    X.DataSource = dt;
                    X.ShowPreviewDialog ();
                }
                else
                {
                    MessageBox.Show ("لا توجد بيانات صندوق لهذا المستخدم خلال الفترة المحددة", "MESSAGE");
                }

            }
        }
    }
}
