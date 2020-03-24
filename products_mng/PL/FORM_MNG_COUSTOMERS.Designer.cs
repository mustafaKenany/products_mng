namespace products_mng.PL
{
    partial class FORM_MNG_COUSTOMERS
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
            this.textBox_COUST_FILTER = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_DLT_COUST = new System.Windows.Forms.Button();
            this.button_EDIT_COUST = new System.Windows.Forms.Button();
            this.gridControl_COUSTOMERS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_COUST_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_TEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_COUST_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_ID_COUSTOMER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_COUSTOMERS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_COUST_FILTER);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_DLT_COUST);
            this.groupBox1.Controls.Add(this.button_EDIT_COUST);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(934, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاجراءات المتاحة";
            // 
            // textBox_COUST_FILTER
            // 
            this.textBox_COUST_FILTER.Location = new System.Drawing.Point(656, 95);
            this.textBox_COUST_FILTER.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_COUST_FILTER.Multiline = true;
            this.textBox_COUST_FILTER.Name = "textBox_COUST_FILTER";
            this.textBox_COUST_FILTER.Size = new System.Drawing.Size(264, 35);
            this.textBox_COUST_FILTER.TabIndex = 24;
            this.textBox_COUST_FILTER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_COUST_FILTER.TextChanged += new System.EventHandler(this.textBox_COUST_FILTER_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(755, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "ابحث هنا";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(13, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 50);
            this.button5.TabIndex = 22;
            this.button5.Text = "سندات الصرف";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(129, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 50);
            this.button4.TabIndex = 21;
            this.button4.Text = "سندات القبض";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(245, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 50);
            this.button3.TabIndex = 20;
            this.button3.Text = "فاتورة معينة";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(361, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 50);
            this.button2.TabIndex = 19;
            this.button2.Text = "كافة الفواتير";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_DLT_COUST
            // 
            this.button_DLT_COUST.AutoSize = true;
            this.button_DLT_COUST.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DLT_COUST.FlatAppearance.BorderSize = 2;
            this.button_DLT_COUST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DLT_COUST.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_DLT_COUST.ForeColor = System.Drawing.Color.White;
            this.button_DLT_COUST.Location = new System.Drawing.Point(477, 80);
            this.button_DLT_COUST.Name = "button_DLT_COUST";
            this.button_DLT_COUST.Size = new System.Drawing.Size(80, 50);
            this.button_DLT_COUST.TabIndex = 18;
            this.button_DLT_COUST.Text = "حذف";
            this.button_DLT_COUST.UseVisualStyleBackColor = true;
            this.button_DLT_COUST.Click += new System.EventHandler(this.button_DLT_COUST_Click);
            // 
            // button_EDIT_COUST
            // 
            this.button_EDIT_COUST.AutoSize = true;
            this.button_EDIT_COUST.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_EDIT_COUST.FlatAppearance.BorderSize = 2;
            this.button_EDIT_COUST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EDIT_COUST.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_EDIT_COUST.ForeColor = System.Drawing.Color.White;
            this.button_EDIT_COUST.Location = new System.Drawing.Point(563, 80);
            this.button_EDIT_COUST.Name = "button_EDIT_COUST";
            this.button_EDIT_COUST.Size = new System.Drawing.Size(80, 50);
            this.button_EDIT_COUST.TabIndex = 17;
            this.button_EDIT_COUST.Text = "تعديل";
            this.button_EDIT_COUST.UseVisualStyleBackColor = true;
            this.button_EDIT_COUST.Click += new System.EventHandler(this.button_EDIT_COUST_Click);
            // 
            // gridControl_COUSTOMERS
            // 
            this.gridControl_COUSTOMERS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_COUSTOMERS.Location = new System.Drawing.Point(0, 150);
            this.gridControl_COUSTOMERS.MainView = this.gridView1;
            this.gridControl_COUSTOMERS.Name = "gridControl_COUSTOMERS";
            this.gridControl_COUSTOMERS.Size = new System.Drawing.Size(934, 412);
            this.gridControl_COUSTOMERS.TabIndex = 3;
            this.gridControl_COUSTOMERS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 30;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_COUST_NAME,
            this.gridColumn_ADDRESS,
            this.gridColumn_TEL,
            this.gridColumn_COUST_TYPE,
            this.gridColumn_ID_COUSTOMER});
            this.gridView1.GridControl = this.gridControl_COUSTOMERS;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowHeight = 30;
            // 
            // gridColumn_COUST_NAME
            // 
            this.gridColumn_COUST_NAME.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_COUST_NAME.AppearanceCell.Options.UseFont = true;
            this.gridColumn_COUST_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_COUST_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_COUST_NAME.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_COUST_NAME.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_COUST_NAME.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_COUST_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_COUST_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_COUST_NAME.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_COUST_NAME.Caption = "أسم الزبون";
            this.gridColumn_COUST_NAME.FieldName = "COUST_NAME";
            this.gridColumn_COUST_NAME.Name = "gridColumn_COUST_NAME";
            this.gridColumn_COUST_NAME.OptionsColumn.AllowEdit = false;
            this.gridColumn_COUST_NAME.Visible = true;
            this.gridColumn_COUST_NAME.VisibleIndex = 1;
            // 
            // gridColumn_ADDRESS
            // 
            this.gridColumn_ADDRESS.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_ADDRESS.AppearanceCell.Options.UseFont = true;
            this.gridColumn_ADDRESS.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_ADDRESS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_ADDRESS.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_ADDRESS.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_ADDRESS.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_ADDRESS.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_ADDRESS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_ADDRESS.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_ADDRESS.Caption = "العنوان";
            this.gridColumn_ADDRESS.FieldName = "ADDRESS";
            this.gridColumn_ADDRESS.Name = "gridColumn_ADDRESS";
            this.gridColumn_ADDRESS.OptionsColumn.AllowEdit = false;
            this.gridColumn_ADDRESS.Visible = true;
            this.gridColumn_ADDRESS.VisibleIndex = 2;
            // 
            // gridColumn_TEL
            // 
            this.gridColumn_TEL.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_TEL.AppearanceCell.Options.UseFont = true;
            this.gridColumn_TEL.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_TEL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_TEL.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_TEL.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_TEL.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_TEL.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_TEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_TEL.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_TEL.Caption = "رقم الموبايل";
            this.gridColumn_TEL.FieldName = "TEL";
            this.gridColumn_TEL.Name = "gridColumn_TEL";
            this.gridColumn_TEL.OptionsColumn.AllowEdit = false;
            this.gridColumn_TEL.Visible = true;
            this.gridColumn_TEL.VisibleIndex = 3;
            // 
            // gridColumn_COUST_TYPE
            // 
            this.gridColumn_COUST_TYPE.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn_COUST_TYPE.AppearanceCell.Options.UseFont = true;
            this.gridColumn_COUST_TYPE.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_COUST_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_COUST_TYPE.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_COUST_TYPE.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_COUST_TYPE.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_COUST_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_COUST_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_COUST_TYPE.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_COUST_TYPE.Caption = "صنف الزبون";
            this.gridColumn_COUST_TYPE.FieldName = "COUST_TYPE";
            this.gridColumn_COUST_TYPE.Name = "gridColumn_COUST_TYPE";
            this.gridColumn_COUST_TYPE.OptionsColumn.AllowEdit = false;
            this.gridColumn_COUST_TYPE.Visible = true;
            this.gridColumn_COUST_TYPE.VisibleIndex = 4;
            // 
            // gridColumn_ID_COUSTOMER
            // 
            this.gridColumn_ID_COUSTOMER.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_ID_COUSTOMER.AppearanceCell.Options.UseFont = true;
            this.gridColumn_ID_COUSTOMER.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn_ID_COUSTOMER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_ID_COUSTOMER.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_ID_COUSTOMER.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn_ID_COUSTOMER.AppearanceHeader.Options.UseFont = true;
            this.gridColumn_ID_COUSTOMER.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn_ID_COUSTOMER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn_ID_COUSTOMER.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn_ID_COUSTOMER.Caption = "ID";
            this.gridColumn_ID_COUSTOMER.FieldName = "ID_COUSTOMER";
            this.gridColumn_ID_COUSTOMER.Name = "gridColumn_ID_COUSTOMER";
            this.gridColumn_ID_COUSTOMER.OptionsColumn.AllowEdit = false;
            this.gridColumn_ID_COUSTOMER.Visible = true;
            this.gridColumn_ID_COUSTOMER.VisibleIndex = 0;
            // 
            // FORM_MNG_COUSTOMERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(65)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.gridControl_COUSTOMERS);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_MNG_COUSTOMERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة الزبائن";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_COUSTOMERS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button_DLT_COUST;
        public System.Windows.Forms.Button button_EDIT_COUST;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.TextBox textBox_COUST_FILTER;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_COUST_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_TEL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_COUST_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_ID_COUSTOMER;
        public DevExpress.XtraGrid.GridControl gridControl_COUSTOMERS;
    }
}