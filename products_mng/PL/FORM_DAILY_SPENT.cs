using DevExpress.XtraReports.UI;
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
    public partial class FORM_DAILY_SPENT : Form
    {
        public FORM_DAILY_SPENT()
        {
            InitializeComponent ();
        }
        BL.CLS_MONEYIES PAID = new BL.CLS_MONEYIES ();
        BL.CLS_REPORT_LIST RPTCLS = new BL.CLS_REPORT_LIST ();
        float PAID_MONEY;
        int PAID_ID;
        string PAID_NOTES, SALES_MAN;
        DateTime PAID_DATE;
        private void Initialize_Function()
        {


            var PAID_ID = PAID.GET_ID_PAID_SPENT ();
            label_PAIDID.Text = PAID_ID.ToString ();
            comboBox_SPENTTYPE.Text = textBox_MONEYPAID.Text = textBox_NOTESPAID.Text = "";
            button_PRTPAID.Enabled = false;
            comboBox_SPENTTYPE.Enabled = textBox_MONEYPAID.Enabled = textBox_NOTESPAID.Enabled = dateTimePicker_DATEPAID.Enabled = true;
            button_PRTPAID.Enabled = false;
        }
        private void button_NEWPAID_Click(object sender, EventArgs e)
        {
            Initialize_Function ();
        }

        private void button_ADDPAID_Click(object sender, EventArgs e)
        {
            if (comboBox_SPENTTYPE.Text == "" || textBox_MONEYPAID.Text == "" || textBox_NOTESPAID.Text == "")
            {
                MessageBox.Show ("يرجى اكمال ادخل معلومات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PAID_MONEY = float.Parse (textBox_MONEYPAID.Text);
                PAID_ID = int.Parse (label_PAIDID.Text);
                PAID_DATE = dateTimePicker_DATEPAID.Value;
                PAID_NOTES = textBox_NOTESPAID.Text + "  / " + comboBox_SPENTTYPE.Text;
                SALES_MAN = BL.CLS_LOGIN.SALES_MAN;
                PAID.ADD_PAID_SPENT_MONEY (PAID_ID, 4, PAID_MONEY * -1, PAID_DATE, "صرفيات يومية", PAID_NOTES, SALES_MAN);
                if (comboBox_SPENTTYPE.SelectedIndex == 7)
                {

                    PAID_ID = PAID.GET_ID_PAID_SPENT ();
                    DateTime NEXT_DATE = dateTimePicker_DATEPAID.Value.AddDays (1);
                    PAID.ADD_PAID_SPENT_MONEY (PAID_ID, 4, PAID_MONEY, NEXT_DATE, "سندات قبض", "حساب مدور سابق", SALES_MAN);
                }
                MessageBox.Show ("تم الحفظ بنجاح", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox_SPENTTYPE.Enabled = textBox_MONEYPAID.Enabled = textBox_NOTESPAID.Enabled = dateTimePicker_DATEPAID.Enabled = false;
                button_PRTPAID.Enabled = true;
            }
        }

        private void button_PRTPAID_Click(object sender, EventArgs e)
        {
            RPT.RPT_PAID_SPENT x = new RPT.RPT_PAID_SPENT ();
            x.xrLabelTITLE.Text = "صرفيات يومية";
            x.xrLabelDETLS.Text = " تم صرف هذا المبغ عن " + textBox_MONEYPAID.Text + "  " + comboBox_SPENTTYPE.Text + "  " + " وفق الملاحظة التالية " + textBox_NOTESPAID.Text;
            x.xrLabel_date.Text = dateTimePicker_DATEPAID.Text;
            x.xrLabel_DOCSNO.Text = label_PAIDID.Text;
            x.xrLabel_SLAESMAN.Text = BL.CLS_LOGIN.SALES_MAN;
            x.ShowPreviewDialog ();

        }

        private void textBox_MONEYPAID_Leave(object sender, EventArgs e)
        {
            if (textBox_MONEYPAID.Text != "")
            {
                textBox_MONEYPAID.Text = int.Parse (textBox_MONEYPAID.Text).ToString ("n1");
            }
        }

        private void textBox_MONEYPAID_Enter(object sender, EventArgs e)
        {
            textBox_MONEYPAID.Text = "";
        }

        private void button_CNCLPAID_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void comboBox_SPENTTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SPENTTYPE.SelectedIndex == 7)
            {
                PAID_DATE = dateTimePicker_DATEPAID.Value;
                var dt = RPTCLS.RPT_NETMONEY (PAID_DATE.ToString ("yyyy-MM-dd"), PAID_DATE.ToString ("yyyy-MM-dd"));
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PAID_MONEY = PAID_MONEY + float.Parse (dt.Rows[i]["PAID_AMOUNT"].ToString ());
                    }
                    textBox_MONEYPAID.Text = PAID_MONEY.ToString ();
                    textBox_MONEYPAID.Enabled = textBox_NOTESPAID.Enabled = false;
                    textBox_MONEYPAID.Text = int.Parse (textBox_MONEYPAID.Text).ToString ("n1");
                    textBox_NOTESPAID.Text = "تدوير الحساب";
                }
            }
            else
            {
                textBox_MONEYPAID.Enabled = textBox_NOTESPAID.Enabled = true;
                textBox_MONEYPAID.Text = "";
                textBox_NOTESPAID.Text = "";
            }
        }
    }
}
