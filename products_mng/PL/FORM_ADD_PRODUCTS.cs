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
namespace products_mng.PL
{
    public partial class FORM_ADD_PRODUCTS : Form
    {
        BL.CLS_ADD_PRODUCTS prd = new BL.CLS_ADD_PRODUCTS ();
        public String stat = "add";
        public FORM_ADD_PRODUCTS()
        {
            InitializeComponent ();
            comboBox_CATEGORIES.DataSource = prd.GET_ALL_CATEGORIES ();
            this.ID_PRODUCT.Text = prd.GET_ID_PRODUCT ().ToString ();
            comboBox_CATEGORIES.DisplayMember = "CAT_DESCRPTION";
            comboBox_CATEGORIES.ValueMember = "ID_CAT";
        }

        private byte pictureConvert()
        {
            throw new NotImplementedException ();
        }

        private void Clear_Function()
        {
            this.ID_PRODUCT.Text = prd.GET_ID_PRODUCT ().ToString ();
            textBox_BARCODE.Text = textBox_LABEL.Text = "";
            pictureBox_PRODUCTS.Image = null;
        }

        private void textBox_BARCODE_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable ();
            dt = prd.VerfiyProductID (textBox_BARCODE.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show ("موجود مسبقا");
                textBox_BARCODE.Focus ();
                textBox_BARCODE.SelectionStart = 0;
                textBox_BARCODE.SelectionLength = textBox_BARCODE.TextLength;
            }
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
            try
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
            catch (Exception)
            {

                MessageBox.Show ("الرجاء من تاكد من ادخال معلومات بشكل صحيح او ملئ الحقول المطلوبة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void textBox_BARCODE_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.OnKeyPress (e);
            if (!char.IsControl (e.KeyChar) && !char.IsDigit (e.KeyChar))
                e.Handled = true;
        }
    }
}
