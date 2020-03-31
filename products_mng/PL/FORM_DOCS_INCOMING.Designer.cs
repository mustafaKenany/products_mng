namespace products_mng.PL
{
    partial class FORM_DOCS_INCOMING
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
            this.label5 = new System.Windows.Forms.Label();
            this.COUS_NAME = new System.Windows.Forms.TextBox();
            this.button_NEWPAID = new System.Windows.Forms.Button();
            this.textBox_MONEYPAID = new System.Windows.Forms.TextBox();
            this.textBox_NOTESPAID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_DATEPAID = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ADDPAID = new System.Windows.Forms.Button();
            this.button_PRTPAID = new System.Windows.Forms.Button();
            this.button_CNCLPAID = new System.Windows.Forms.Button();
            this.label_COUSTID = new System.Windows.Forms.Label();
            this.label_PAIDID = new System.Windows.Forms.Label();
            this.button_ADDCOUST = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "أسم الزبون";
            // 
            // COUS_NAME
            // 
            this.COUS_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.COUS_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.COUS_NAME.Enabled = false;
            this.COUS_NAME.Location = new System.Drawing.Point(201, 48);
            this.COUS_NAME.Margin = new System.Windows.Forms.Padding(10);
            this.COUS_NAME.Name = "COUS_NAME";
            this.COUS_NAME.Size = new System.Drawing.Size(223, 34);
            this.COUS_NAME.TabIndex = 1;
            this.COUS_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.COUS_NAME.Leave += new System.EventHandler(this.COUS_NAME_Leave);
            // 
            // button_NEWPAID
            // 
            this.button_NEWPAID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_NEWPAID.FlatAppearance.BorderSize = 2;
            this.button_NEWPAID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NEWPAID.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_NEWPAID.ForeColor = System.Drawing.Color.White;
            this.button_NEWPAID.Location = new System.Drawing.Point(80, 392);
            this.button_NEWPAID.Name = "button_NEWPAID";
            this.button_NEWPAID.Size = new System.Drawing.Size(100, 50);
            this.button_NEWPAID.TabIndex = 6;
            this.button_NEWPAID.Text = "جديد";
            this.button_NEWPAID.UseVisualStyleBackColor = true;
            this.button_NEWPAID.Click += new System.EventHandler(this.button_NEWPAID_Click);
            // 
            // textBox_MONEYPAID
            // 
            this.textBox_MONEYPAID.Enabled = false;
            this.textBox_MONEYPAID.Location = new System.Drawing.Point(201, 114);
            this.textBox_MONEYPAID.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_MONEYPAID.Multiline = true;
            this.textBox_MONEYPAID.Name = "textBox_MONEYPAID";
            this.textBox_MONEYPAID.Size = new System.Drawing.Size(130, 35);
            this.textBox_MONEYPAID.TabIndex = 2;
            this.textBox_MONEYPAID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_NOTESPAID
            // 
            this.textBox_NOTESPAID.Enabled = false;
            this.textBox_NOTESPAID.Location = new System.Drawing.Point(201, 245);
            this.textBox_NOTESPAID.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_NOTESPAID.Multiline = true;
            this.textBox_NOTESPAID.Name = "textBox_NOTESPAID";
            this.textBox_NOTESPAID.Size = new System.Drawing.Size(293, 74);
            this.textBox_NOTESPAID.TabIndex = 4;
            this.textBox_NOTESPAID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "المبلغ الواصل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "ملاحظات";
            // 
            // dateTimePicker_DATEPAID
            // 
            this.dateTimePicker_DATEPAID.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_DATEPAID.Enabled = false;
            this.dateTimePicker_DATEPAID.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DATEPAID.Location = new System.Drawing.Point(201, 180);
            this.dateTimePicker_DATEPAID.Name = "dateTimePicker_DATEPAID";
            this.dateTimePicker_DATEPAID.RightToLeftLayout = true;
            this.dateTimePicker_DATEPAID.Size = new System.Drawing.Size(130, 34);
            this.dateTimePicker_DATEPAID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "تاريخ";
            // 
            // button_ADDPAID
            // 
            this.button_ADDPAID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ADDPAID.FlatAppearance.BorderSize = 2;
            this.button_ADDPAID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADDPAID.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_ADDPAID.ForeColor = System.Drawing.Color.White;
            this.button_ADDPAID.Location = new System.Drawing.Point(184, 392);
            this.button_ADDPAID.Name = "button_ADDPAID";
            this.button_ADDPAID.Size = new System.Drawing.Size(100, 50);
            this.button_ADDPAID.TabIndex = 5;
            this.button_ADDPAID.Text = "حفظ";
            this.button_ADDPAID.UseVisualStyleBackColor = true;
            this.button_ADDPAID.Click += new System.EventHandler(this.button_ADDPAID_Click);
            // 
            // button_PRTPAID
            // 
            this.button_PRTPAID.Enabled = false;
            this.button_PRTPAID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRTPAID.FlatAppearance.BorderSize = 2;
            this.button_PRTPAID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRTPAID.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRTPAID.ForeColor = System.Drawing.Color.White;
            this.button_PRTPAID.Location = new System.Drawing.Point(288, 392);
            this.button_PRTPAID.Name = "button_PRTPAID";
            this.button_PRTPAID.Size = new System.Drawing.Size(100, 50);
            this.button_PRTPAID.TabIndex = 7;
            this.button_PRTPAID.Text = "طباعة";
            this.button_PRTPAID.UseVisualStyleBackColor = true;
            this.button_PRTPAID.Click += new System.EventHandler(this.button_PRTPAID_Click);
            // 
            // button_CNCLPAID
            // 
            this.button_CNCLPAID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_CNCLPAID.FlatAppearance.BorderSize = 2;
            this.button_CNCLPAID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CNCLPAID.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_CNCLPAID.ForeColor = System.Drawing.Color.White;
            this.button_CNCLPAID.Location = new System.Drawing.Point(392, 392);
            this.button_CNCLPAID.Name = "button_CNCLPAID";
            this.button_CNCLPAID.Size = new System.Drawing.Size(100, 50);
            this.button_CNCLPAID.TabIndex = 8;
            this.button_CNCLPAID.Text = "الغاء";
            this.button_CNCLPAID.UseVisualStyleBackColor = true;
            this.button_CNCLPAID.Click += new System.EventHandler(this.button_CNCLPAID_Click);
            // 
            // label_COUSTID
            // 
            this.label_COUSTID.AutoSize = true;
            this.label_COUSTID.Location = new System.Drawing.Point(415, 102);
            this.label_COUSTID.Name = "label_COUSTID";
            this.label_COUSTID.Size = new System.Drawing.Size(75, 26);
            this.label_COUSTID.TabIndex = 28;
            this.label_COUSTID.Text = "COUST_ID";
            this.label_COUSTID.Visible = false;
            // 
            // label_PAIDID
            // 
            this.label_PAIDID.AutoSize = true;
            this.label_PAIDID.Location = new System.Drawing.Point(415, 138);
            this.label_PAIDID.Name = "label_PAIDID";
            this.label_PAIDID.Size = new System.Drawing.Size(63, 26);
            this.label_PAIDID.TabIndex = 29;
            this.label_PAIDID.Text = "PAID_ID";
            this.label_PAIDID.Visible = false;
            // 
            // button_ADDCOUST
            // 
            this.button_ADDCOUST.Enabled = false;
            this.button_ADDCOUST.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ADDCOUST.FlatAppearance.BorderSize = 2;
            this.button_ADDCOUST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADDCOUST.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_ADDCOUST.ForeColor = System.Drawing.Color.White;
            this.button_ADDCOUST.Location = new System.Drawing.Point(437, 40);
            this.button_ADDCOUST.Name = "button_ADDCOUST";
            this.button_ADDCOUST.Size = new System.Drawing.Size(100, 50);
            this.button_ADDCOUST.TabIndex = 30;
            this.button_ADDCOUST.Text = "أضافة";
            this.button_ADDCOUST.UseVisualStyleBackColor = true;
            this.button_ADDCOUST.Click += new System.EventHandler(this.button_ADDCOUST_Click);
            // 
            // FORM_DOCS_INCOMING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(580, 458);
            this.Controls.Add(this.button_ADDCOUST);
            this.Controls.Add(this.label_PAIDID);
            this.Controls.Add(this.label_COUSTID);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.COUS_NAME);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_DOCS_INCOMING";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "سندات القبض";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox COUS_NAME;
        public System.Windows.Forms.Button button_NEWPAID;
        public System.Windows.Forms.TextBox textBox_MONEYPAID;
        public System.Windows.Forms.TextBox textBox_NOTESPAID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DATEPAID;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button_ADDPAID;
        public System.Windows.Forms.Button button_PRTPAID;
        public System.Windows.Forms.Button button_CNCLPAID;
        private System.Windows.Forms.Label label_COUSTID;
        private System.Windows.Forms.Label label_PAIDID;
        public System.Windows.Forms.Button button_ADDCOUST;
    }
}