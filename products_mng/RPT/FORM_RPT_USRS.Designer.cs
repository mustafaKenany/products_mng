namespace products_mng.RPT
{
    partial class FORM_RPT_USRS
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
            this.button_displayData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_RPT_USR_DAILY_SPENT = new System.Windows.Forms.Button();
            this.button_RPT_SPENT_MONEY = new System.Windows.Forms.Button();
            this.button_RPT_USR_PAID_money = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_END_DATE = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_BEGIN_DATE = new System.Windows.Forms.DateTimePicker();
            this.button_RPT_SALES = new System.Windows.Forms.Button();
            this.gridControl_USRS = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_USRS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_displayData);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button_RPT_USR_DAILY_SPENT);
            this.groupBox1.Controls.Add(this.button_RPT_SPENT_MONEY);
            this.groupBox1.Controls.Add(this.button_RPT_USR_PAID_money);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker_END_DATE);
            this.groupBox1.Controls.Add(this.dateTimePicker_BEGIN_DATE);
            this.groupBox1.Controls.Add(this.button_RPT_SALES);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاجراءات الممكنة";
            // 
            // button_displayData
            // 
            this.button_displayData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_displayData.FlatAppearance.BorderSize = 2;
            this.button_displayData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_displayData.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_displayData.ForeColor = System.Drawing.Color.White;
            this.button_displayData.Location = new System.Drawing.Point(850, 26);
            this.button_displayData.Name = "button_displayData";
            this.button_displayData.Size = new System.Drawing.Size(85, 66);
            this.button_displayData.TabIndex = 67;
            this.button_displayData.Text = "عرض الكل";
            this.button_displayData.UseVisualStyleBackColor = true;
            this.button_displayData.Click += new System.EventHandler(this.button_displayData_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(759, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 66);
            this.button2.TabIndex = 66;
            this.button2.Text = "طباعة الصندوق";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button_RPT_USR_DAILY_SPENT
            // 
            this.button_RPT_USR_DAILY_SPENT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RPT_USR_DAILY_SPENT.FlatAppearance.BorderSize = 2;
            this.button_RPT_USR_DAILY_SPENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RPT_USR_DAILY_SPENT.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_RPT_USR_DAILY_SPENT.ForeColor = System.Drawing.Color.White;
            this.button_RPT_USR_DAILY_SPENT.Location = new System.Drawing.Point(231, 26);
            this.button_RPT_USR_DAILY_SPENT.Name = "button_RPT_USR_DAILY_SPENT";
            this.button_RPT_USR_DAILY_SPENT.Size = new System.Drawing.Size(122, 66);
            this.button_RPT_USR_DAILY_SPENT.TabIndex = 65;
            this.button_RPT_USR_DAILY_SPENT.Text = "طباعة الصرفيات اليومية";
            this.button_RPT_USR_DAILY_SPENT.UseVisualStyleBackColor = true;
            this.button_RPT_USR_DAILY_SPENT.Click += new System.EventHandler(this.button_RPT_USR_DAILY_SPENT_Click);
            // 
            // button_RPT_SPENT_MONEY
            // 
            this.button_RPT_SPENT_MONEY.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RPT_SPENT_MONEY.FlatAppearance.BorderSize = 2;
            this.button_RPT_SPENT_MONEY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RPT_SPENT_MONEY.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_RPT_SPENT_MONEY.ForeColor = System.Drawing.Color.White;
            this.button_RPT_SPENT_MONEY.Location = new System.Drawing.Point(359, 26);
            this.button_RPT_SPENT_MONEY.Name = "button_RPT_SPENT_MONEY";
            this.button_RPT_SPENT_MONEY.Size = new System.Drawing.Size(103, 66);
            this.button_RPT_SPENT_MONEY.TabIndex = 64;
            this.button_RPT_SPENT_MONEY.Text = "طباعة سندات الصرف";
            this.button_RPT_SPENT_MONEY.UseVisualStyleBackColor = true;
            this.button_RPT_SPENT_MONEY.Click += new System.EventHandler(this.button_RPT_SPENT_MONEY_Click);
            // 
            // button_RPT_USR_PAID_money
            // 
            this.button_RPT_USR_PAID_money.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RPT_USR_PAID_money.FlatAppearance.BorderSize = 2;
            this.button_RPT_USR_PAID_money.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RPT_USR_PAID_money.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_RPT_USR_PAID_money.ForeColor = System.Drawing.Color.White;
            this.button_RPT_USR_PAID_money.Location = new System.Drawing.Point(468, 26);
            this.button_RPT_USR_PAID_money.Name = "button_RPT_USR_PAID_money";
            this.button_RPT_USR_PAID_money.Size = new System.Drawing.Size(103, 66);
            this.button_RPT_USR_PAID_money.TabIndex = 63;
            this.button_RPT_USR_PAID_money.Text = "طباعة سندات القبض";
            this.button_RPT_USR_PAID_money.UseVisualStyleBackColor = true;
            this.button_RPT_USR_PAID_money.Click += new System.EventHandler(this.button_RPT_USR_PAID_SPENT_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(577, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 66);
            this.button1.TabIndex = 62;
            this.button1.Text = "طباعة المشتريات";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 61;
            this.label2.Text = "الى";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 26);
            this.label1.TabIndex = 60;
            this.label1.Text = "من";
            // 
            // dateTimePicker_END_DATE
            // 
            this.dateTimePicker_END_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_END_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_END_DATE.Location = new System.Drawing.Point(10, 62);
            this.dateTimePicker_END_DATE.Name = "dateTimePicker_END_DATE";
            this.dateTimePicker_END_DATE.Size = new System.Drawing.Size(102, 34);
            this.dateTimePicker_END_DATE.TabIndex = 59;
            // 
            // dateTimePicker_BEGIN_DATE
            // 
            this.dateTimePicker_BEGIN_DATE.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_BEGIN_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_BEGIN_DATE.Location = new System.Drawing.Point(10, 22);
            this.dateTimePicker_BEGIN_DATE.Name = "dateTimePicker_BEGIN_DATE";
            this.dateTimePicker_BEGIN_DATE.Size = new System.Drawing.Size(102, 34);
            this.dateTimePicker_BEGIN_DATE.TabIndex = 58;
            // 
            // button_RPT_SALES
            // 
            this.button_RPT_SALES.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RPT_SALES.FlatAppearance.BorderSize = 2;
            this.button_RPT_SALES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RPT_SALES.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_RPT_SALES.ForeColor = System.Drawing.Color.White;
            this.button_RPT_SALES.Location = new System.Drawing.Point(668, 26);
            this.button_RPT_SALES.Name = "button_RPT_SALES";
            this.button_RPT_SALES.Size = new System.Drawing.Size(85, 66);
            this.button_RPT_SALES.TabIndex = 57;
            this.button_RPT_SALES.Text = "طباعة المبيعات";
            this.button_RPT_SALES.UseVisualStyleBackColor = true;
            this.button_RPT_SALES.Click += new System.EventHandler(this.button_RPT_SALES_Click);
            // 
            // gridControl_USRS
            // 
            this.gridControl_USRS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_USRS.Location = new System.Drawing.Point(0, 105);
            this.gridControl_USRS.MainView = this.gridView1;
            this.gridControl_USRS.Name = "gridControl_USRS";
            this.gridControl_USRS.Size = new System.Drawing.Size(949, 482);
            this.gridControl_USRS.TabIndex = 3;
            this.gridControl_USRS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 30;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.FooterPanelHeight = 30;
            this.gridView1.GridControl = this.gridControl_USRS;
            this.gridView1.GroupRowHeight = 30;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowHeight = 30;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "رقم المستخدم";
            this.gridColumn1.FieldName = "ID_USER";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.AllowMove = false;
            this.gridColumn1.OptionsColumn.AllowShowHide = false;
            this.gridColumn1.OptionsColumn.AllowSize = false;
            this.gridColumn1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn2.AppearanceCell.Options.UseFont = true;
            this.gridColumn2.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "أسم المستخدم";
            this.gridColumn2.FieldName = "USR_FLNAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.AllowMove = false;
            this.gridColumn2.OptionsColumn.AllowShowHide = false;
            this.gridColumn2.OptionsColumn.AllowSize = false;
            this.gridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceCell.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gridColumn3.AppearanceCell.Options.UseFont = true;
            this.gridColumn3.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.AppearanceHeader.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "رمز الدخول";
            this.gridColumn3.FieldName = "USRNAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsColumn.AllowMove = false;
            this.gridColumn3.OptionsColumn.AllowShowHide = false;
            this.gridColumn3.OptionsColumn.AllowSize = false;
            this.gridColumn3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // FORM_RPT_USRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(949, 587);
            this.Controls.Add(this.gridControl_USRS);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_RPT_USRS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تقرير المستخدمين";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_USRS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button_RPT_USR_DAILY_SPENT;
        public System.Windows.Forms.Button button_RPT_SPENT_MONEY;
        public System.Windows.Forms.Button button_RPT_USR_PAID_money;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_END_DATE;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BEGIN_DATE;
        public System.Windows.Forms.Button button_RPT_SALES;
        private DevExpress.XtraGrid.GridControl gridControl_USRS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        public System.Windows.Forms.Button button_displayData;
    }
}