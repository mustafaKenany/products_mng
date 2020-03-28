namespace products_mng.PL
{
    partial class FORM_PURCHASES
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_COUST_ID = new System.Windows.Forms.Label();
            this.label_SALES_MAN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.panel_top.Controls.Add(this.label_COUST_ID);
            this.panel_top.Controls.Add(this.label_SALES_MAN);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.button_close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel_top.Name = "panel_top";
            this.panel_top.Padding = new System.Windows.Forms.Padding(5);
            this.panel_top.Size = new System.Drawing.Size(1250, 50);
            this.panel_top.TabIndex = 1;
            // 
            // label_COUST_ID
            // 
            this.label_COUST_ID.ForeColor = System.Drawing.Color.White;
            this.label_COUST_ID.Location = new System.Drawing.Point(450, 5);
            this.label_COUST_ID.Name = "label_COUST_ID";
            this.label_COUST_ID.Size = new System.Drawing.Size(99, 40);
            this.label_COUST_ID.TabIndex = 3;
            this.label_COUST_ID.Text = "COUST_ID";
            this.label_COUST_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_SALES_MAN
            // 
            this.label_SALES_MAN.ForeColor = System.Drawing.Color.White;
            this.label_SALES_MAN.Location = new System.Drawing.Point(589, 5);
            this.label_SALES_MAN.Name = "label_SALES_MAN";
            this.label_SALES_MAN.Size = new System.Drawing.Size(99, 40);
            this.label_SALES_MAN.TabIndex = 2;
            this.label_SALES_MAN.Text = "المستخدم";
            this.label_SALES_MAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1173, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "مشتريات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_close
            // 
            this.button_close.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_close.FlatAppearance.BorderSize = 2;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.ForeColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(5, 5);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 40);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // FORM_PURCHASES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1250, 700);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_PURCHASES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        public System.Windows.Forms.Label label_COUST_ID;
        private System.Windows.Forms.Label label_SALES_MAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_close;
    }
}