using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace products_mng.PL
{
    public partial class FORM_COUSTOMERS : Form
    {
        BL.CLS_COUSTOMERS COUST = new BL.CLS_COUSTOMERS ();
        private static FORM_COUSTOMERS frm;
        public String stat = "add";
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FORM_COUSTOMERS getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FORM_COUSTOMERS ();
                    frm.FormClosed += new FormClosedEventHandler (frm_FormClosed);
                }
                return frm;
            }
        }
        #region functions
        private void clearFunction()
        {
            textBox_COUST_ADD.Text = textBox_COUST_NAME.Text = textBox_COUST_TEL.Text = "";
            pictureBox_COUST.Image = null;
            ID_COUST.Text = COUST.GET_ID_COUST ().ToString ();
            comboBox_COUST_TYPE.Text = "";
        }


        #endregion




        public FORM_COUSTOMERS()
        {
            if (frm == null)
            {
                frm = this;
            }
            InitializeComponent ();
            ID_COUST.Text = COUST.GET_ID_COUST ().ToString ();
        }

        private void button_ADD_NEW_COUST_Click(object sender, EventArgs e)
        {
            try
            {

                String COUST_TYPE;
                byte[] ImageByte;
                if (comboBox_COUST_TYPE.Text == "")
                {
                    COUST_TYPE = "زبون";
                }
                else
                {
                    COUST_TYPE = comboBox_COUST_TYPE.Text;
                }
                if (pictureBox_COUST.Image == null)
                {
                    ImageByte = new byte[0];
                }
                else
                {
                    MemoryStream ms = new MemoryStream ();
                    pictureBox_COUST.Image.Save (ms, pictureBox_COUST.Image.RawFormat);
                    ImageByte = ms.ToArray ();
                }

                switch (stat)
                {
                    case "add":
                        COUST.ADD_NEW_COUSTOMER (int.Parse (ID_COUST.Text), textBox_COUST_NAME.Text, textBox_COUST_TEL.Text, textBox_COUST_ADD.Text, COUST_TYPE, ImageByte);
                        MessageBox.Show ("تمت عملية الحفظ بنجاح", "SAVE");
                        clearFunction ();
                        break;
                    case "update":
                        COUST.UPDATE_COUSTOMER (int.Parse (ID_COUST.Text), textBox_COUST_NAME.Text, textBox_COUST_TEL.Text, textBox_COUST_ADD.Text, COUST_TYPE, ImageByte);
                        MessageBox.Show ("تمت عملية التعديل بنجاح", "Update");
                        FORM_MNG_COUSTOMERS.getMainForm.gridControl_COUSTOMERS.DataSource = COUST.GET_ALL_COUSTOMERS ();
                        this.Close ();

                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show (ex.Message);
            }
        }



        private void pictureBox_COUST_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog ();
            OFD.Filter = "IMAGE |*.JPG; *.PNG";
            if (OFD.ShowDialog () == DialogResult.OK)
            {
                pictureBox_COUST.Image = Image.FromFile (OFD.FileName);
            }

        }

        private void textBox_COUST_NAME_Validated(object sender, EventArgs e)
        {
            if (textBox_COUST_NAME.Text != "")
            {
                var dt = COUST.SEARCH_COUSTOMER (textBox_COUST_NAME.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show ("هذا الاسم موجود مسبقا", "Error");
                    textBox_COUST_NAME.Focus ();
                    textBox_COUST_NAME.SelectionStart = 0;
                    textBox_COUST_NAME.SelectionLength = textBox_COUST_NAME.TextLength;
                }
            }
        }

        private void button_CANCEL_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
