namespace products_mng.PL
{
    partial class FORM_RPTDATE
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_END_DATE = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_BEGIN_DATE = new System.Windows.Forms.DateTimePicker();
            this.button_PRTDOCS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "الى";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "من";
            // 
            // dateTimePicker_END_DATE
            // 
            this.dateTimePicker_END_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_END_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_END_DATE.Location = new System.Drawing.Point(134, 126);
            this.dateTimePicker_END_DATE.Name = "dateTimePicker_END_DATE";
            this.dateTimePicker_END_DATE.Size = new System.Drawing.Size(102, 34);
            this.dateTimePicker_END_DATE.TabIndex = 29;
            // 
            // dateTimePicker_BEGIN_DATE
            // 
            this.dateTimePicker_BEGIN_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_BEGIN_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BEGIN_DATE.Location = new System.Drawing.Point(134, 66);
            this.dateTimePicker_BEGIN_DATE.Name = "dateTimePicker_BEGIN_DATE";
            this.dateTimePicker_BEGIN_DATE.Size = new System.Drawing.Size(102, 34);
            this.dateTimePicker_BEGIN_DATE.TabIndex = 28;
            // 
            // button_PRTDOCS
            // 
            this.button_PRTDOCS.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_PRTDOCS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_PRTDOCS.FlatAppearance.BorderSize = 2;
            this.button_PRTDOCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PRTDOCS.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_PRTDOCS.ForeColor = System.Drawing.Color.White;
            this.button_PRTDOCS.Location = new System.Drawing.Point(134, 190);
            this.button_PRTDOCS.Name = "button_PRTDOCS";
            this.button_PRTDOCS.Size = new System.Drawing.Size(100, 50);
            this.button_PRTDOCS.TabIndex = 32;
            this.button_PRTDOCS.Text = "طباعة";
            this.button_PRTDOCS.UseVisualStyleBackColor = true;
            // 
            // FORM_RPTDATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(330, 308);
            this.Controls.Add(this.button_PRTDOCS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_END_DATE);
            this.Controls.Add(this.dateTimePicker_BEGIN_DATE);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_RPTDATE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FORM_SALESREPO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button_PRTDOCS;
        public System.Windows.Forms.DateTimePicker dateTimePicker_END_DATE;
        public System.Windows.Forms.DateTimePicker dateTimePicker_BEGIN_DATE;
    }
}