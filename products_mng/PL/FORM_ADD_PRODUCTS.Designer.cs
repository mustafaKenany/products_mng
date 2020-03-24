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
            this.label5 = new System.Windows.Forms.Label();
            this.ID_PRODUCT = new System.Windows.Forms.TextBox();
            this.btn_SAVE_PRODUCT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_UPLODPICTURE = new System.Windows.Forms.Button();
            this.textBox_LABEL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_PRODUCTS = new System.Windows.Forms.PictureBox();
            this.comboBox_CATEGORIES = new System.Windows.Forms.ComboBox();
            this.textBox_BARCODE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PRODUCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ID_PRODUCT);
            this.groupBox1.Controls.Add(this.btn_SAVE_PRODUCT);
            this.groupBox1.Controls.Add(this.button1);
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
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(753, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أضافة مادة جديدة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "رقم المادة";
            // 
            // ID_PRODUCT
            // 
            this.ID_PRODUCT.Enabled = false;
            this.ID_PRODUCT.Location = new System.Drawing.Point(97, 40);
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
            this.btn_SAVE_PRODUCT.Location = new System.Drawing.Point(640, 445);
            this.btn_SAVE_PRODUCT.Name = "btn_SAVE_PRODUCT";
            this.btn_SAVE_PRODUCT.Size = new System.Drawing.Size(100, 50);
            this.btn_SAVE_PRODUCT.TabIndex = 10;
            this.btn_SAVE_PRODUCT.Text = "حفظ";
            this.btn_SAVE_PRODUCT.UseVisualStyleBackColor = true;
            this.btn_SAVE_PRODUCT.Click += new System.EventHandler(this.btn_SAVE_PRODUCT_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(524, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "الغاء";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_UPLODPICTURE
            // 
            this.btn_UPLODPICTURE.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btn_UPLODPICTURE.FlatAppearance.BorderSize = 2;
            this.btn_UPLODPICTURE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UPLODPICTURE.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_UPLODPICTURE.ForeColor = System.Drawing.Color.White;
            this.btn_UPLODPICTURE.Location = new System.Drawing.Point(81, 313);
            this.btn_UPLODPICTURE.Name = "btn_UPLODPICTURE";
            this.btn_UPLODPICTURE.Size = new System.Drawing.Size(100, 50);
            this.btn_UPLODPICTURE.TabIndex = 8;
            this.btn_UPLODPICTURE.Text = "صورة";
            this.btn_UPLODPICTURE.UseVisualStyleBackColor = true;
            this.btn_UPLODPICTURE.Click += new System.EventHandler(this.btn_UPLODPICTURE_Click);
            // 
            // textBox_LABEL
            // 
            this.textBox_LABEL.Location = new System.Drawing.Point(97, 202);
            this.textBox_LABEL.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_LABEL.Multiline = true;
            this.textBox_LABEL.Name = "textBox_LABEL";
            this.textBox_LABEL.Size = new System.Drawing.Size(300, 35);
            this.textBox_LABEL.TabIndex = 7;
            this.textBox_LABEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "صورة المادة ان وجد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "أسم المادة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "صنف او مجموعة الخاصة بالمادة";
            // 
            // pictureBox_PRODUCTS
            // 
            this.pictureBox_PRODUCTS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_PRODUCTS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_PRODUCTS.Location = new System.Drawing.Point(194, 263);
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
            this.comboBox_CATEGORIES.Location = new System.Drawing.Point(97, 150);
            this.comboBox_CATEGORIES.Margin = new System.Windows.Forms.Padding(10);
            this.comboBox_CATEGORIES.Name = "comboBox_CATEGORIES";
            this.comboBox_CATEGORIES.Size = new System.Drawing.Size(300, 32);
            this.comboBox_CATEGORIES.TabIndex = 2;
            // 
            // textBox_BARCODE
            // 
            this.textBox_BARCODE.Location = new System.Drawing.Point(97, 95);
            this.textBox_BARCODE.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_BARCODE.Multiline = true;
            this.textBox_BARCODE.Name = "textBox_BARCODE";
            this.textBox_BARCODE.Size = new System.Drawing.Size(300, 35);
            this.textBox_BARCODE.TabIndex = 1;
            this.textBox_BARCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_BARCODE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_BARCODE_KeyPress);
            this.textBox_BARCODE.Validated += new System.EventHandler(this.textBox_BARCODE_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "الباركود الخاص بالمادة ان وجد";
            // 
            // FORM_ADD_PRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(763, 529);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_UPLODPICTURE;
        public System.Windows.Forms.TextBox textBox_LABEL;
        public System.Windows.Forms.PictureBox pictureBox_PRODUCTS;
        public System.Windows.Forms.ComboBox comboBox_CATEGORIES;
        public System.Windows.Forms.TextBox textBox_BARCODE;
        public System.Windows.Forms.Button btn_SAVE_PRODUCT;
        public System.Windows.Forms.TextBox ID_PRODUCT;
        private System.Windows.Forms.Label label5;
    }
}