namespace products_mng.PL
{
    partial class FORM_DAILY_SPENT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_CNCLPAID = new System.Windows.Forms.Button();
            this.button_PRTPAID = new System.Windows.Forms.Button();
            this.button_ADDPAID = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_DATEPAID = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NOTESPAID = new System.Windows.Forms.TextBox();
            this.textBox_MONEYPAID = new System.Windows.Forms.TextBox();
            this.button_NEWPAID = new System.Windows.Forms.Button();
            this.label_PAIDID = new System.Windows.Forms.Label();
            this.comboBox_SPENTTYPE = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_CNCLPAID
            // 
            this.button_CNCLPAID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_CNCLPAID.FlatAppearance.BorderSize = 2;
            this.button_CNCLPAID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CNCLPAID.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_CNCLPAID.ForeColor = System.Drawing.Color.White;
            this.button_CNCLPAID.Location = new System.Drawing.Point(378, 382);
            this.button_CNCLPAID.Name = "button_CNCLPAID";
            this.button_CNCLPAID.Size = new System.Drawing.Size(100, 50);
            this.button_CNCLPAID.TabIndex = 53;
            this.button_CNCLPAID.Text = "الغاء";
            this.button_CNCLPAID.UseVisualStyleBackColor = true;
            // 
            // button_PRTPAID
            // 
            this.button_PRTPAID.Enabled = false;
            this.button_PRTPAID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRTPAID.FlatAppearance.BorderSize = 2;
            this.button_PRTPAID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRTPAID.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRTPAID.ForeColor = System.Drawing.Color.White;
            this.button_PRTPAID.Location = new System.Drawing.Point(274, 382);
            this.button_PRTPAID.Name = "button_PRTPAID";
            this.button_PRTPAID.Size = new System.Drawing.Size(100, 50);
            this.button_PRTPAID.TabIndex = 52;
            this.button_PRTPAID.Text = "طباعة";
            this.button_PRTPAID.UseVisualStyleBackColor = true;
            this.button_PRTPAID.Click += new System.EventHandler(this.button_PRTPAID_Click);
            // 
            // button_ADDPAID
            // 
            this.button_ADDPAID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ADDPAID.FlatAppearance.BorderSize = 2;
            this.button_ADDPAID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADDPAID.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_ADDPAID.ForeColor = System.Drawing.Color.White;
            this.button_ADDPAID.Location = new System.Drawing.Point(170, 382);
            this.button_ADDPAID.Name = "button_ADDPAID";
            this.button_ADDPAID.Size = new System.Drawing.Size(100, 50);
            this.button_ADDPAID.TabIndex = 50;
            this.button_ADDPAID.Text = "حفظ";
            this.button_ADDPAID.UseVisualStyleBackColor = true;
            this.button_ADDPAID.Click += new System.EventHandler(this.button_ADDPAID_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 26);
            this.label3.TabIndex = 57;
            this.label3.Text = "تاريخ";
            // 
            // dateTimePicker_DATEPAID
            // 
            this.dateTimePicker_DATEPAID.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_DATEPAID.Enabled = false;
            this.dateTimePicker_DATEPAID.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DATEPAID.Location = new System.Drawing.Point(187, 170);
            this.dateTimePicker_DATEPAID.Name = "dateTimePicker_DATEPAID";
            this.dateTimePicker_DATEPAID.RightToLeftLayout = true;
            this.dateTimePicker_DATEPAID.Size = new System.Drawing.Size(130, 34);
            this.dateTimePicker_DATEPAID.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 56;
            this.label2.Text = "ملاحظات";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "المبلغ الواصل";
            // 
            // textBox_NOTESPAID
            // 
            this.textBox_NOTESPAID.Enabled = false;
            this.textBox_NOTESPAID.Location = new System.Drawing.Point(187, 235);
            this.textBox_NOTESPAID.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_NOTESPAID.Multiline = true;
            this.textBox_NOTESPAID.Name = "textBox_NOTESPAID";
            this.textBox_NOTESPAID.Size = new System.Drawing.Size(293, 74);
            this.textBox_NOTESPAID.TabIndex = 49;
            this.textBox_NOTESPAID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_MONEYPAID
            // 
            this.textBox_MONEYPAID.Enabled = false;
            this.textBox_MONEYPAID.Location = new System.Drawing.Point(187, 104);
            this.textBox_MONEYPAID.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_MONEYPAID.Multiline = true;
            this.textBox_MONEYPAID.Name = "textBox_MONEYPAID";
            this.textBox_MONEYPAID.Size = new System.Drawing.Size(130, 35);
            this.textBox_MONEYPAID.TabIndex = 47;
            this.textBox_MONEYPAID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_MONEYPAID.Leave += new System.EventHandler(this.textBox_MONEYPAID_Leave);
            // 
            // button_NEWPAID
            // 
            this.button_NEWPAID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_NEWPAID.FlatAppearance.BorderSize = 2;
            this.button_NEWPAID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NEWPAID.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_NEWPAID.ForeColor = System.Drawing.Color.White;
            this.button_NEWPAID.Location = new System.Drawing.Point(66, 382);
            this.button_NEWPAID.Name = "button_NEWPAID";
            this.button_NEWPAID.Size = new System.Drawing.Size(100, 50);
            this.button_NEWPAID.TabIndex = 51;
            this.button_NEWPAID.Text = "جديد";
            this.button_NEWPAID.UseVisualStyleBackColor = true;
            this.button_NEWPAID.Click += new System.EventHandler(this.button_NEWPAID_Click);
            // 
            // label_PAIDID
            // 
            this.label_PAIDID.AutoSize = true;
            this.label_PAIDID.Location = new System.Drawing.Point(401, 128);
            this.label_PAIDID.Name = "label_PAIDID";
            this.label_PAIDID.Size = new System.Drawing.Size(63, 26);
            this.label_PAIDID.TabIndex = 59;
            this.label_PAIDID.Text = "PAID_ID";
            this.label_PAIDID.Visible = false;
            // 
            // comboBox_SPENTTYPE
            // 
            this.comboBox_SPENTTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SPENTTYPE.Enabled = false;
            this.comboBox_SPENTTYPE.FormattingEnabled = true;
            this.comboBox_SPENTTYPE.Items.AddRange(new object[] {
            "رواتب",
            "صرفيات نقل",
            "صرفيات ايفاد",
            "صرفيات تشغيلة",
            "صرفيات طعام",
            "مكافاءات",
            "صرفيات اخرى"});
            this.comboBox_SPENTTYPE.Location = new System.Drawing.Point(187, 36);
            this.comboBox_SPENTTYPE.Name = "comboBox_SPENTTYPE";
            this.comboBox_SPENTTYPE.Size = new System.Drawing.Size(130, 34);
            this.comboBox_SPENTTYPE.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "نوع الصرف";
            // 
            // FORM_DAILY_PAID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_SPENTTYPE);
            this.Controls.Add(this.label_PAIDID);
            this.Controls.Add(this.button_CNCLPAID);
            this.Controls.Add(this.button_PRTPAID);
            this.Controls.Add(this.button_ADDPAID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_DATEPAID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NOTESPAID);
            this.Controls.Add(this.textBox_MONEYPAID);
            this.Controls.Add(this.button_NEWPAID);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_DAILY_PAID";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الصرفيات اليومية";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button_CNCLPAID;
        public System.Windows.Forms.Button button_PRTPAID;
        public System.Windows.Forms.Button button_ADDPAID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DATEPAID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_NOTESPAID;
        public System.Windows.Forms.TextBox textBox_MONEYPAID;
        public System.Windows.Forms.Button button_NEWPAID;
        private System.Windows.Forms.Label label_PAIDID;
        private System.Windows.Forms.ComboBox comboBox_SPENTTYPE;
        private System.Windows.Forms.Label label4;
    }
}