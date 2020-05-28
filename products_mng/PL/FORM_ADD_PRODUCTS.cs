using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OnBarcode.Barcode;

namespace products_mng.PL
{
    public partial class FORM_ADD_PRODUCTS : Form
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS ();
        public String stat = "add";
        public FORM_ADD_PRODUCTS()
        {
            InitializeComponent ();
            comboBox_CATEGORIES.DataSource = prd.GET_ALL_CATEGORIES ();
            this.ID_PRODUCT.Text = prd.GET_ID_PRODUCT ().ToString ();
            comboBox_CATEGORIES.DisplayMember = "CAT_DESCRPTION";
            comboBox_CATEGORIES.ValueMember = "ID_CAT";
        }



        private void Clear_Function()
        {
            this.ID_PRODUCT.Text = prd.GET_ID_PRODUCT ().ToString ();
            textBox_BARCODE.Text = textBox_LABEL.Text = "";
            pictureBox_PRODUCTS.Image = null;
        }

        private void CheckBarcode()
        {
            if (textBox_BARCODE.Text != "")
            {
                DataTable dt = new DataTable ();
                dt = prd.VerfiyProductID (textBox_BARCODE.Text.Trim ());
                if (dt.Rows.Count > 0)
                {

                    MessageBox.Show ("هذا باركود مستخدم سابقا", "Error");
                    textBox_BARCODE.Focus ();
                    textBox_BARCODE.SelectionStart = 0;
                    textBox_BARCODE.SelectionLength = textBox_BARCODE.TextLength;

                }
            }
        }

        private void textBox_BARCODE_Validated(object sender, EventArgs e)
        {
            //CheckBarcode ();
        }


        #region btn clicks
        private void btn_UPLODPICTURE_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog ();
            OFD.Filter = "IMAGE |*.JPG; *.PNG";
            if (OFD.ShowDialog () == DialogResult.OK)
            {
                pictureBox_PRODUCTS.Image = Image.FromFile (OFD.FileName);
            }
        }

        private void btn_SAVE_PRODUCT_Click(object sender, EventArgs e)
        {


            if (CheckInputs ())
            {
                if (stat == "add")
                {
                    MemoryStream ms = new MemoryStream ();
                    pictureBox_PRODUCTS.Image.Save (ms, pictureBox_PRODUCTS.Image.RawFormat);
                    byte[] ImageByte = ms.ToArray ();
                    prd.ADD_PRODUCT (int.Parse (ID_PRODUCT.Text), int.Parse (comboBox_CATEGORIES.SelectedValue.ToString ()), textBox_BARCODE.Text, textBox_LABEL.Text, ImageByte);
                    MessageBox.Show ("تمت عملية الحفظ بنجاح", "SAVE");
                    Clear_Function ();
                }
                else
                {
                    MemoryStream ms = new MemoryStream ();
                    pictureBox_PRODUCTS.Image.Save (ms, pictureBox_PRODUCTS.Image.RawFormat);
                    byte[] ImageByte = ms.ToArray ();
                    prd.UPDATE_PRODCUT (int.Parse (comboBox_CATEGORIES.SelectedValue.ToString ()), textBox_BARCODE.Text, textBox_LABEL.Text, ImageByte, ID_PRODUCT.Text);
                    MessageBox.Show ("تمت عملية التعديل بنجاح", "UPDATE");
                    FORM_MNG_PRODUCTS.getMainForm.GridControl_PRODUCTS.DataSource = prd.GET_ALL_PRODUCTS ();

                    this.Close ();
                }
            }

        }

        private bool CheckInputs()
        {
            if (textBox_BARCODE.Text == "" || comboBox_CATEGORIES.Text == "" || textBox_LABEL.Text == "" || pictureBox_PRODUCTS.Image == null)
            {
                MessageBox.Show ("الرجاء من تاكد من ادخال معلومات بشكل صحيح او ملئ الحقول المطلوبة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        private void textBox_BARCODE_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress (e);
            if (!char.IsControl (e.KeyChar) && !char.IsDigit (e.KeyChar))
            {

                e.Handled = true;
                MessageBox.Show ("ادخال ارقام فقط", "textBox_BARCODE ERORR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox_LABEL_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_BARCODE_Click(object sender, EventArgs e)
        {
            //Linear code128 = new Linear ();
            //code128.Type = BarcodeType.CODE128;
            //code128.Data = "0123456789";
            //code128.X = 1;
            //code128.Y = 60;

            //// Generate Code-128 and encode barcode to gif format
            //code128.Format = System.Drawing.Imaging.ImageFormat.Gif;
            //code128.drawBarcode ("C://csharp-code128.gif");

            //// Print Code 128 C# Bitmap object
            //Bitmap code128Bitmap = code128.drawBarcode ();
            textBox_BARCODE.Text = ID_PRODUCT.Text;
        }

        private void buttonBarcode_Click(object sender, EventArgs e)
        {

            if (buttonBarcode.Text == "تحديث باركود")
            {
                buttonBarcode.Text = "الغاء باركود";
                textBox_BARCODE.Enabled = true;
                textBox_BARCODE.Focus ();
                textBox_BARCODE.SelectionStart = 0;
                textBox_BARCODE.SelectionLength = textBox_BARCODE.TextLength;
            }
            else
            {
                //textBox_BARCODE.Enabled = false;
                //buttonBarcode.Text = "تحديث باركود";
                comboBox_CATEGORIES.Focus ();
            }

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void textBox_BARCODE_Leave(object sender, EventArgs e)
        {
            CheckBarcode ();
        }
    }
}
