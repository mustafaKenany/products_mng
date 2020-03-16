namespace products_mng.PL
{
    partial class FORM_PRODUCTS
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
            this.textBox_BARCODE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SEARCH_PRODUCTS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_BARCODE
            // 
            this.textBox_BARCODE.Location = new System.Drawing.Point(230, 38);
            this.textBox_BARCODE.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_BARCODE.Multiline = true;
            this.textBox_BARCODE.Name = "textBox_BARCODE";
            this.textBox_BARCODE.Size = new System.Drawing.Size(300, 35);
            this.textBox_BARCODE.TabIndex = 3;
            this.textBox_BARCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(620, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "أدخل اسم او رمز المادة المراد البحث عنها";
            // 
            // btn_SEARCH_PRODUCTS
            // 
            this.btn_SEARCH_PRODUCTS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btn_SEARCH_PRODUCTS.FlatAppearance.BorderSize = 2;
            this.btn_SEARCH_PRODUCTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SEARCH_PRODUCTS.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_SEARCH_PRODUCTS.ForeColor = System.Drawing.Color.White;
            this.btn_SEARCH_PRODUCTS.Location = new System.Drawing.Point(305, 172);
            this.btn_SEARCH_PRODUCTS.Name = "btn_SEARCH_PRODUCTS";
            this.btn_SEARCH_PRODUCTS.Size = new System.Drawing.Size(100, 50);
            this.btn_SEARCH_PRODUCTS.TabIndex = 11;
            this.btn_SEARCH_PRODUCTS.Text = "بحث";
            this.btn_SEARCH_PRODUCTS.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_BARCODE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(872, 122);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البحث عن مادة";
            // 
            // FORM_PRODUCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(882, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_SEARCH_PRODUCTS);
            this.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FORM_PRODUCTS";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FORM_PRODUCTS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_BARCODE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SEARCH_PRODUCTS;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}