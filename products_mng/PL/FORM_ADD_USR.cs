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
        int[] USR_ACSS = new int[12];
        public FORM_ADD_USR()
        {
            InitializeComponent ();
        }

        private int CHECK_USR_ACC()
        {
            int COUNT = 0;
            for (int i = 0; i < USR_ACSS.Length; i++)
            {
                if (USR_ACSS[i] == 0)
                {
                    COUNT++;
                }
                else continue;
            }
            return COUNT;
        }

        private void Initialize_Function()
        {
            textBox_USRPWD.Text = textBox_USRPWD2.Text = textBox_USRNAME.Text = txt_USRFLNAME.Text = "";
            checkBox_ACS1.Checked = checkBox_ACS2.Checked = checkBox_ACS3.Checked = checkBox_ACS4.Checked = false;
            checkBox_ACS5.Checked = checkBox_ACS6.Checked = checkBox_ACS7.Checked = checkBox_ACS8.Checked = false;
            checkBox_ACS9.Checked = checkBox_ACS10.Checked = false;
        }

        private void ADD_NEW_USR()
        {
            var USR_FL_NAME = txt_USRFLNAME.Text.Trim ();
            var USR_NAME = textBox_USRNAME.Text.Trim ();
            var USR_PWD = textBox_USRPWD.Text.Trim ();
            var USR_PWD2 = textBox_USRPWD2.Text.Trim ();
            USR.ADD_NEW_USR (USR_FL_NAME, USR_NAME, USR_PWD, USR_ACSS);
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

        private void button_CANCL_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void button_ADD_USR_Click(object sender, EventArgs e)
        {
            if (CHECK_INPUTS_FUNC ())
            {
                if (CHECK_USR_ACC ()==12)
                {
                    MessageBox.Show ("يرجى تحديد صلاحية واحدة على الاقل", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ADD_NEW_USR ();
                    MessageBox.Show ("تمت عملية الحفظ بنجاح", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Initialize_Function ();
                }

            }
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
            if (textBox_USRPWD2.Text != "")
            {
                if (textBox_USRPWD.Text != textBox_USRPWD2.Text)
                {
                    MessageBox.Show ("كلمتي السر غير متطابقتان", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_USRPWD.Text = textBox_USRPWD2.Text = "";
                    textBox_USRPWD.Focus ();
                }
            }
        }

        private void checkBox_ACS1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ACS1.Checked)
            {
                USR_ACSS[1] = 1;
            }
            else
            {
                USR_ACSS[1] = 0;
            }
        }

        private void checkBox_ACS2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ACS2.Checked)
            {
                USR_ACSS[2] = 1;
            }
            else
            {
                USR_ACSS[2] = 0;
            }
        }

        private void checkBox_ACS5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ACS5.Checked)
            {
                USR_ACSS[5] = 1;
            }
            else
            {
                USR_ACSS[5] = 0;
            }
        }

        private void checkBox_ACS6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ACS6.Checked)
            {
                USR_ACSS[6] = 1;
            }
            else
            {
                USR_ACSS[6] = 0;
            }
        }

        private void checkBox_ACS7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ACS7.Checked)
            {
                USR_ACSS[7] = 1;
            }
            else
            {
                USR_ACSS[7] = 0;
            }
        }

        private void checkBox_ACS8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ACS8.Checked)
            {
                USR_ACSS[8] = 1;
            }
            else
            {
                USR_ACSS[8] = 8;
            }
        }

        private void checkBox_ACS9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ACS9.Checked)
            {
                USR_ACSS[9] = 1;
            }
            else
            {
                USR_ACSS[9] = 0;
            }
        }

        private void checkBox_ACS10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ACS10.Checked)
            {
                USR_ACSS[10] = 1;
            }
            else
            {
                USR_ACSS[10] = 0;
            }
        }

        private void checkBox_ACS3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_ACS4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_ACS11_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
