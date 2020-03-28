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
    public partial class FORM_ADD_USR : Form
    {
        BL.CLS_LOGIN USR = new BL.CLS_LOGIN ();
        public FORM_ADD_USR()
        {
            InitializeComponent ();
        }

        private void button_CANCL_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void button_ADD_USR_Click(object sender, EventArgs e)
        {
            if (CHECK_INPUTS_FUNC ())
            {
                if (CHECK_USR_ACS () <1)
                {
                    MessageBox.Show ("يرجى تحديد صلاحية واحدة على الاقل", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ADD_NEW_USR ();
                    MessageBox.Show ("تمت عملية الحفظ بنجاح", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_USRPWD.Text = textBox_USRPWD2.Text = textBox_USRNAME.Text = txt_USRFLNAME.Text = "";
                }
            }
        }

        private void ADD_NEW_USR()
        {
            var USR_FL_NAME = txt_USRFLNAME.Text.Trim ();
            var USR_NAME = textBox_USRNAME.Text.Trim ();
            var USR_PWD = textBox_USRPWD.Text.Trim ();
            var USR_PWD2 = textBox_USRPWD2.Text.Trim ();
            var USR_ACS = CHECK_USR_ACS ();
            USR.ADD_NEW_USR (USR_FL_NAME, USR_NAME, USR_PWD, USR_ACS);
        }

        private bool CHECK_INPUTS_FUNC()
        {
            if (txt_USRFLNAME.Text == "" || textBox_USRNAME.Text == "" || textBox_USRPWD.Text == "" || textBox_USRPWD2.Text == "")
            {
                MessageBox.Show ("يرجى اكمال ادخال معلومات بشكل صحيح", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private int CHECK_USR_ACS()
        {
            int USR_TOTAL_ACS = 0;
            if (checkBox_ACS1.Checked)
            {
                USR_TOTAL_ACS=1;
                //بيع مباشر
            }
            if (checkBox_ACS2.Checked)
            {
                USR_TOTAL_ACS=2;
                //ادارة مبيعات
            }
            if (checkBox_ACS1.Checked&&checkBox_ACS2.Checked)
            {
                USR_TOTAL_ACS = 3;
                //البيع المباشر والادارة مالت مبيعات
            }
            if (checkBox_ACS3.Checked)
            {
                USR_TOTAL_ACS=10;
                //المنتوجات والاصناف
            }
            if (checkBox_ACS4.Checked)
            {
                USR_TOTAL_ACS=11;
                //العملاء
            }
            if (checkBox_ACS5.Checked)
            {
                USR_TOTAL_ACS=12;
                //ادارة العملاء
            }
            if (checkBox_ACS4.Checked && checkBox_ACS5.Checked)
            {
                USR_TOTAL_ACS = 23;
                //العملاء وادارة العملاء
            }
            if (checkBox_ACS6.Checked)
            {
                USR_TOTAL_ACS=13;
                //المستخدمون
            }
            if (checkBox_ACS7.Checked)
            {
                USR_TOTAL_ACS=14;
                //ادارة المستخدمين
            }
            if (checkBox_ACS6.Checked && checkBox_ACS7.Checked)
            {
                USR_TOTAL_ACS = 27;
                //المستخدمين وادارة المستخدمين
            }
            if (checkBox_ACS8.Checked)
            {
                USR_TOTAL_ACS=28;
                //الحسابات
            }
            if (checkBoxACS_ADMIN.Checked)
            {
                USR_TOTAL_ACS = 100;
                //مدير النظام
            }
            return USR_TOTAL_ACS;
        }

        private void txt_USRFLNAME_Validated(object sender, EventArgs e)
        {
            if (txt_USRFLNAME.Text != "")
            {
                var USRFLNAME = txt_USRFLNAME.Text.Trim ();
                DataTable dt = new DataTable ();
                dt = USR.USRFLNAME_VERFIY (USRFLNAME);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show ("هذا الاسم موجود مسبقا", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_USRFLNAME.Focus ();
                    txt_USRFLNAME.Text = "";
                }
            }
        }

        private void textBox_USRNAME_Validated(object sender, EventArgs e)
        {
            if (textBox_USRNAME.Text != "")
            {
                var USRFLNAME = textBox_USRNAME.Text.Trim ();
                DataTable dt = new DataTable ();
                dt = USR.USRNAME_VERFIY (USRFLNAME);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show ("هذا الاسم موجود مسبقا", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_USRNAME.Focus ();
                    textBox_USRNAME.Text = "";
                }
            }
        }

        private void textBox_USRPWD2_Validated(object sender, EventArgs e)
        {
            if (textBox_USRPWD2.Text!="")
            {
                if (textBox_USRPWD.Text!=textBox_USRPWD2.Text)
                {
                    MessageBox.Show ("كلمتي السر غير متطابقتان", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_USRPWD.Text = textBox_USRPWD2.Text = "";
                    textBox_USRPWD.Focus ();
                }
            }
        }

        private void checkBoxACS_ADMIN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxACS_ADMIN.Checked)
            {
                checkBox_ACS1.Checked = checkBox_ACS2.Checked = checkBox_ACS3.Checked = checkBox_ACS4.Checked = true;
                checkBox_ACS5.Checked = checkBox_ACS6.Checked = checkBox_ACS7.Checked = checkBox_ACS8.Checked = true;
            }
            else
            {
                checkBox_ACS1.Checked = checkBox_ACS2.Checked = checkBox_ACS3.Checked = checkBox_ACS4.Checked = false;
                checkBox_ACS5.Checked = checkBox_ACS6.Checked = checkBox_ACS7.Checked = checkBox_ACS8.Checked = false;

            }
        }
    }
}
