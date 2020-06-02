namespace products_mng.PL
{
    partial class FORM_ADD_PRODUCTS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBarcode = new System.Windows.Forms.Button();
            this.button_BARCODEPRT = new System.Windows.Forms.Button();
            this.button_BARCODE = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_PRODUCT = new System.Windows.Forms.TextBox();
            this.btn_SAVE_PRODUCT = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.btn_UPLODPICTURE = new System.Windows.Forms.Button();
            this.textBox_LABEL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_PRODUCTS = new System.Windows.Forms.PictureBox();
            this.comboBox_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.textBox_BARCODE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_EXPIREDATE = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PRODUCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker_EXPIREDATE);
            this.groupBox1.Controls.Add(this.buttonBarcode);
            this.groupBox1.Controls.Add(this.button_BARCODEPRT);
            this.groupBox1.Controls.Add(this.button_BARCODE);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ID_PRODUCT);
            this.groupBox1.Controls.Add(this.btn_SAVE_PRODUCT);
            this.groupBox1.Controls.Add(this.button_Close);
            this.groupBox1.Controls.Add(this.btn_UPLODPICTURE);
            this.groupBox1.Controls.Add(this.textBox_LABEL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox_PRODUCTS);
            this.groupBox1.Controls.Add(this.comboBox_CATEGORIES);
            this.groupBox1.Controls.Add(this.textBox_BARCODE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(750, 548);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أضافة مادة جديدة ";
            // 
            // buttonBarcode
            // 
            this.buttonBarcode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.buttonBarcode.FlatAppearance.BorderSize = 2;
            this.buttonBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarcode.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonBarcode.ForeColor = System.Drawing.Color.White;
            this.buttonBarcode.Location = new System.Drawing.Point(13, 487);
            this.buttonBarcode.Name = "buttonBarcode";
            this.buttonBarcode.Size = new System.Drawing.Size(100, 50);
            this.buttonBarcode.TabIndex = 15;
            this.buttonBarcode.Text = "تحديث باركود";
            this.buttonBarcode.UseVisualStyleBackColor = true;
            this.buttonBarcode.Visible = false;
            this.buttonBarcode.Click += new System.EventHandler(this.buttonBarcode_Click);
            // 
            // button_BARCODEPRT
            // 
            this.button_BARCODEPRT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_BARCODEPRT.FlatAppearance.BorderSize = 2;
            this.button_BARCODEPRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BARCODEPRT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_BARCODEPRT.ForeColor = System.Drawing.Color.White;
            this.button_BARCODEPRT.Location = new System.Drawing.Point(13, 84);
            this.button_BARCODEPRT.Name = "button_BARCODEPRT";
            this.button_BARCODEPRT.Size = new System.Drawing.Size(100, 50);
            this.button_BARCODEPRT.TabIndex = 14;
            this.button_BARCODEPRT.Text = "طبع باركود";
            this.button_BARCODEPRT.UseVisualStyleBackColor = true;
            // 
            // button_BARCODE
            // 
            this.button_BARCODE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_BARCODE.FlatAppearance.BorderSize = 2;
            this.button_BARCODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_BARCODE.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_BARCODE.ForeColor = System.Drawing.Color.White;
            this.button_BARCODE.Location = new System.Drawing.Point(119, 84);
            this.button_BARCODE.Name = "button_BARCODE";
            this.button_BARCODE.Size = new System.Drawing.Size(71, 50);
            this.button_BARCODE.TabIndex = 13;
            this.button_BARCODE.Text = "باركود";
            this.button_BARCODE.UseVisualStyleBackColor = true;
            this.button_BARCODE.Click += new System.EventHandler(this.button_BARCODE_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(651, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "رقم المادة";
            // 
            // ID_PRODUCT
            // 
            this.ID_PRODUCT.Enabled = false;
            this.ID_PRODUCT.Location = new System.Drawing.Point(204, 40);
            this.ID_PRODUCT.Margin = new System.Windows.Forms.Padding(10);
            this.ID_PRODUCT.Multiline = true;
            this.ID_PRODUCT.Name = "ID_PRODUCT";
            this.ID_PRODUCT.Size = new System.Drawing.Size(300, 35);
            this.ID_PRODUCT.TabIndex = 11;
            this.ID_PRODUCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_SAVE_PRODUCT
            // 
            this.btn_SAVE_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btn_SAVE_PRODUCT.FlatAppearance.BorderSize = 2;
            this.btn_SAVE_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SAVE_PRODUCT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_SAVE_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.btn_SAVE_PRODUCT.Location = new System.Drawing.Point(632, 487);
            this.btn_SAVE_PRODUCT.Name = "btn_SAVE_PRODUCT";
            this.btn_SAVE_PRODUCT.Size = new System.Drawing.Size(90, 50);
            this.btn_SAVE_PRODUCT.TabIndex = 10;
            this.btn_SAVE_PRODUCT.Text = "حفظ";
            this.btn_SAVE_PRODUCT.UseVisualStyleBackColor = true;
            this.btn_SAVE_PRODUCT.Click += new System.EventHandler(this.btn_SAVE_PRODUCT_Click);
            // 
            // button_Close
            // 
            this.button_Close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button_Close.FlatAppearance.BorderSize = 2;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.Location = new System.Drawing.Point(524, 487);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(90, 50);
            this.button_Close.TabIndex = 9;
            this.button_Close.Text = "الغاء";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // btn_UPLODPICTURE
            // 
            this.btn_UPLODPICTURE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btn_UPLODPICTURE.FlatAppearance.BorderSize = 2;
            this.btn_UPLODPICTURE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UPLODPICTURE.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_UPLODPICTURE.ForeColor = System.Drawing.Color.White;
            this.btn_UPLODPICTURE.Location = new System.Drawing.Point(90, 344);
            this.btn_UPLODPICTURE.Name = "btn_UPLODPICTURE";
            this.btn_UPLODPICTURE.Size = new System.Drawing.Size(100, 50);
            this.btn_UPLODPICTURE.TabIndex = 8;
            this.btn_UPLODPICTURE.Text = "صورة";
            this.btn_UPLODPICTURE.UseVisualStyleBackColor = true;
            this.btn_UPLODPICTURE.Click += new System.EventHandler(this.btn_UPLODPICTURE_Click);
            // 
            // textBox_LABEL
            // 
            this.textBox_LABEL.Location = new System.Drawing.Point(204, 193);
            this.textBox_LABEL.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_LABEL.Multiline = true;
            this.textBox_LABEL.Name = "textBox_LABEL";
            this.textBox_LABEL.Size = new System.Drawing.Size(300, 35);
            this.textBox_LABEL.TabIndex = 7;
            this.textBox_LABEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_LABEL.TextChanged += new System.EventHandler(this.textBox_LABEL_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "صورة المادة ان وجد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(648, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "أسم المادة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "صنف او مجموعة الخاصة بالمادة";
            // 
            // pictureBox_PRODUCTS
            // 
            this.pictureBox_PRODUCTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_PRODUCTS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_PRODUCTS.Location = new System.Drawing.Point(204, 294);
            this.pictureBox_PRODUCTS.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox_PRODUCTS.Name = "pictureBox_PRODUCTS";
            this.pictureBox_PRODUCTS.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBox_PRODUCTS.Size = new System.Drawing.Size(125, 150);
            this.pictureBox_PRODUCTS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_PRODUCTS.TabIndex = 3;
            this.pictureBox_PRODUCTS.TabStop = false;
            // 
            // comboBox_CATEGORIES
            // 
            this.comboBox_CATEGORIES.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CATEGORIES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_CATEGORIES.FormattingEnabled = true;
            this.comboBox_CATEGORIES.ItemHeight = 24;
            this.comboBox_CATEGORIES.Location = new System.Drawing.Point(204, 144);
            this.comboBox_CATEGORIES.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_CATEGORIES.Name = "comboBox_CATEGORIES";
            this.comboBox_CATEGORIES.Size = new System.Drawing.Size(300, 32);
            this.comboBox_CATEGORIES.TabIndex = 2;
            // 
            // textBox_BARCODE
            // 
            this.textBox_BARCODE.Location = new System.Drawing.Point(204, 92);
            this.textBox_BARCODE.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_BARCODE.Multiline = true;
            this.textBox_BARCODE.Name = "textBox_BARCODE";
            this.textBox_BARCODE.Size = new System.Drawing.Size(300, 35);
            this.textBox_BARCODE.TabIndex = 1;
            this.textBox_BARCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_BARCODE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_BARCODE_KeyPress);
            this.textBox_BARCODE.Leave += new System.EventHandler(this.textBox_BARCODE_Leave);
            this.textBox_BARCODE.Validated += new System.EventHandler(this.textBox_BARCODE_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "الباركود الخاص بالمادة ان وجد";
            // 
            // dateTimePicker_EXPIREDATE
            // 
            this.dateTimePicker_EXPIREDATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_EXPIREDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EXPIREDATE.Location = new System.Drawing.Point(204, 245);
            this.dateTimePicker_EXPIREDATE.Name = "dateTimePicker_EXPIREDATE";
            this.dateTimePicker_EXPIREDATE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_EXPIREDATE.RightToLeftLayout = true;
            this.dateTimePicker_EXPIREDATE.ShowUpDown = true;
            this.dateTimePicker_EXPIREDATE.Size = new System.Drawing.Size(300, 32);
            this.dateTimePicker_EXPIREDATE.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "تاريخ صلاحية مادة";
            // 
            // FORM_ADD_PRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(760, 558);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_ADD_PRODUCTS";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أدارة المنتوجات";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PRODUCTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button btn_UPLODPICTURE;
        public System.Windows.Forms.TextBox textBox_LABEL;
        public System.Windows.Forms.PictureBox pictureBox_PRODUCTS;
        public System.Windows.Forms.ComboBox comboBox_CATEGORIES;
        public System.Windows.Forms.TextBox textBox_BARCODE;
        public System.Windows.Forms.Button btn_SAVE_PRODUCT;
        public System.Windows.Forms.TextBox ID_PRODUCT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_BARCODEPRT;
        private System.Windows.Forms.Button button_BARCODE;
        public System.Windows.Forms.Button buttonBarcode;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker dateTimePicker_EXPIREDATE;
    }
}