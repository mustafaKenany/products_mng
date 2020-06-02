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
    public partial class FORM_SPENT_MONEY : Form
    {
        BL.CLS_COUSTOMERS COUST = new BL.CLS_COUSTOMERS ();
        BL.CLS_MONEYIES paid = new BL.CLS_MONEYIES ();

        public FORM_SPENT_MONEY()
        {
            InitializeComponent ();
        }

        private void Initialize_Function()
        {
            DataTable dt = new DataTable ();
            dt = COUST.GET_ALL_COUSTOMERS ();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    COUS_NAME.AutoCompleteCustomSource.Add (dt.Rows[i]["COUST_NAME"].ToString ());
                }
            }
            button_ADDCOUST.Enabled = true;
            var PAID_ID = paid.GET_ID_PAID_SPENT ();
            label_PAIDID.Text = PAID_ID.ToString ();
            COUS_NAME.Text = textBox_MONEYPAID.Text = textBox_NOTESPAID.Text = "";
            button_PRTPAID.Enabled = false;
            COUS_NAME.Enabled = textBox_MONEYPAID.Enabled = textBox_NOTESPAID.Enabled = dateTimePicker_DATEPAID.Enabled = true;
            button_PRTPAID.Enabled = false;
        }

        private void button_NEWPAID_Click(object sender, EventArgs e)
        {
            Initialize_Function ();
        }

        private void button_ADDPAID_Click(object sender, EventArgs e)
        {
            if (COUS_NAME.Text == "" || textBox_MONEYPAID.Text == "" || textBox_NOTESPAID.Text == "")
            {
                MessageBox.Show ("يرجى اكمال ادخل معلومات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                float PAID_MONEY = float.Parse (textBox_MONEYPAID.Text);
                int COUST_ID = int.Parse (label_COUSTID.Text);
                int PAID_ID = int.Parse (label_PAIDID.Text) ;
                DateTime PAID_DATE = dateTimePicker_DATEPAID.Value;
                string PAID_NOTES = textBox_NOTESPAID.Text;
                String SALES_MAN = BL.CLS_LOGIN.SALES_MAN;
                paid.ADD_PAID_SPENT_MONEY (PAID_ID, COUST_ID, PAID_MONEY*-1, PAID_DATE, "سندات صرف", PAID_NOTES,SALES_MAN);
                MessageBox.Show ("تم الحفظ بنجاح", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                COUS_NAME.Enabled = textBox_MONEYPAID.Enabled = textBox_NOTESPAID.Enabled = dateTimePicker_DATEPAID.Enabled = false;
                button_PRTPAID.Enabled = true;
            }

        }

        private void button_PRTPAID_Click(object sender, EventArgs e)
        {
            RPT.RPT_PAID_SPENT x = new RPT.RPT_PAID_SPENT ();
            x.xrLabelTITLE.Text = "مستند صرف";
            x.xrLabelDETLS.Text = " دفعت الى السيد/السيدة " + COUS_NAME.Text + "  مبلغ مالي مقداره  " + textBox_MONEYPAID.Text + "   وذلك عن  " + textBox_NOTESPAID.Text + "  ولأجله وقعت";
            x.xrLabel_date.Text = dateTimePicker_DATEPAID.Text;
            x.xrLabel_SLAESMAN.Text = BL.CLS_LOGIN.SALES_MAN;
            x.xrLabel_DOCSNO.Text = label_PAIDID.Text;
            x.ShowPreviewDialog ();

        }

        private void button_ADDCOUST_Click(object sender, EventArgs e)
        {
            FORM_COUSTOMERS FORM = new FORM_COUSTOMERS ();
            FORM.ShowDialog ();
        }

        private void button_CNCLPAID_Click(object sender, EventArgs e)
        {
            COUS_NAME.Text = textBox_MONEYPAID.Text = textBox_NOTESPAID.Text = "";
            this.Close ();
        }

        private void COUS_NAME_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable ();
            dt = COUST.SEARCH_COUSTOMER (COUS_NAME.Text.Trim ());
            if (dt.Rows.Count > 0)
            {

                label_COUSTID.Text = dt.Rows[0]["ID_COUSTOMER"].ToString ();
            }
            else
            {
                MessageBox.Show ("هذا الزبون غير موجود في قاعدة البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                COUS_NAME.Text = "";
                COUS_NAME.Focus ();
            }
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
    }
}
