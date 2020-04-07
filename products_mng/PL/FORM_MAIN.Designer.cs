namespace products_mng.PL
{
    partial class FORM_MAIN
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.Tool_FILE = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_login = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_importBakup = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_SALES = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_DIRSALES = new System.Windows.Forms.ToolStripMenuItem();
            this.tool_MNGSALESS = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_PURCHAES = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_DIRECTPURCHASE = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_MNGPURCHASE = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_ITEMS = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_ADDITEM = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_MNGITEMS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tool_MNGCAT = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_CUSTOMER = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_ADDCUSTOMER = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_MNGCUSTOMER = new System.Windows.Forms.ToolStripMenuItem();
            this.Too_USERS = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_ADDUSER = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_MNGUSERS = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_MONEY = new System.Windows.Forms.ToolStripMenuItem();
            this.TooL_PAIDMONEY = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_SPENTMONEY = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_GET_TAKEMONEY = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_DAILYSPENT = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_mngdocs = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_REPORTS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SLAESREP = new System.Windows.Forms.ToolStripMenuItem();
            this.تقريرمشترياتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_REPORITMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_COUST = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_USRS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RPT_PAID_SPENT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Cairo", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_FILE,
            this.tool_SALES,
            this.Tool_PURCHAES,
            this.Tool_ITEMS,
            this.Tool_CUSTOMER,
            this.Too_USERS,
            this.Tool_MONEY,
            this.ToolStripMenuItem_REPORTS});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(3);
            this.menuStrip.Size = new System.Drawing.Size(792, 34);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Tool_FILE
            // 
            this.Tool_FILE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_login,
            this.tool_Backup,
            this.tool_importBakup,
            this.tool_Logout});
            this.Tool_FILE.Name = "Tool_FILE";
            this.Tool_FILE.Size = new System.Drawing.Size(50, 28);
            this.Tool_FILE.Text = "ملف";
            // 
            // tool_login
            // 
            this.tool_login.Name = "tool_login";
            this.tool_login.Size = new System.Drawing.Size(221, 28);
            this.tool_login.Text = "تسجيل الدخول";
            this.tool_login.Click += new System.EventHandler(this.tool_login_Click);
            // 
            // tool_Backup
            // 
            this.tool_Backup.Enabled = false;
            this.tool_Backup.Name = "tool_Backup";
            this.tool_Backup.Size = new System.Drawing.Size(221, 28);
            this.tool_Backup.Text = "أنشاء نسخة احتياطية";
            // 
            // tool_importBakup
            // 
            this.tool_importBakup.Enabled = false;
            this.tool_importBakup.Name = "tool_importBakup";
            this.tool_importBakup.Size = new System.Drawing.Size(221, 28);
            this.tool_importBakup.Text = "أستعادة نسخة محفوظة";
            // 
            // tool_Logout
            // 
            this.tool_Logout.Name = "tool_Logout";
            this.tool_Logout.Size = new System.Drawing.Size(221, 28);
            this.tool_Logout.Text = "تسجيل الخروج";
            this.tool_Logout.Click += new System.EventHandler(this.tool_Logout_Click);
            // 
            // tool_SALES
            // 
            this.tool_SALES.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_DIRSALES,
            this.tool_MNGSALESS});
            this.tool_SALES.Enabled = false;
            this.tool_SALES.Name = "tool_SALES";
            this.tool_SALES.Size = new System.Drawing.Size(76, 28);
            this.tool_SALES.Text = "المبيعات";
            // 
            // tool_DIRSALES
            // 
            this.tool_DIRSALES.Enabled = false;
            this.tool_DIRSALES.Name = "tool_DIRSALES";
            this.tool_DIRSALES.Size = new System.Drawing.Size(164, 28);
            this.tool_DIRSALES.Text = "بيع مباشر";
            this.tool_DIRSALES.Click += new System.EventHandler(this.tool_DIRSALES_Click);
            // 
            // tool_MNGSALESS
            // 
            this.tool_MNGSALESS.Enabled = false;
            this.tool_MNGSALESS.Name = "tool_MNGSALESS";
            this.tool_MNGSALESS.Size = new System.Drawing.Size(164, 28);
            this.tool_MNGSALESS.Text = "أدارة المبيعات";
            this.tool_MNGSALESS.Click += new System.EventHandler(this.tool_MNGSALESS_Click);
            // 
            // Tool_PURCHAES
            // 
            this.Tool_PURCHAES.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_DIRECTPURCHASE,
            this.Tool_MNGPURCHASE});
            this.Tool_PURCHAES.Enabled = false;
            this.Tool_PURCHAES.Name = "Tool_PURCHAES";
            this.Tool_PURCHAES.Size = new System.Drawing.Size(81, 28);
            this.Tool_PURCHAES.Text = "المشتريات";
            this.Tool_PURCHAES.Visible = false;
            // 
            // Tool_DIRECTPURCHASE
            // 
            this.Tool_DIRECTPURCHASE.Name = "Tool_DIRECTPURCHASE";
            this.Tool_DIRECTPURCHASE.Size = new System.Drawing.Size(172, 28);
            this.Tool_DIRECTPURCHASE.Text = "شراء مباشر";
            // 
            // Tool_MNGPURCHASE
            // 
            this.Tool_MNGPURCHASE.Name = "Tool_MNGPURCHASE";
            this.Tool_MNGPURCHASE.Size = new System.Drawing.Size(172, 28);
            this.Tool_MNGPURCHASE.Text = "أدارة  المشتريات";
            // 
            // Tool_ITEMS
            // 
            this.Tool_ITEMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_ADDITEM,
            this.Tool_MNGITEMS,
            this.toolStripSeparator1,
            this.Tool_MNGCAT});
            this.Tool_ITEMS.Enabled = false;
            this.Tool_ITEMS.Name = "Tool_ITEMS";
            this.Tool_ITEMS.Size = new System.Drawing.Size(82, 28);
            this.Tool_ITEMS.Text = "المنتوجات";
            // 
            // Tool_ADDITEM
            // 
            this.Tool_ADDITEM.Name = "Tool_ADDITEM";
            this.Tool_ADDITEM.Size = new System.Drawing.Size(190, 28);
            this.Tool_ADDITEM.Text = "أضافة  منتوج جديد";
            this.Tool_ADDITEM.Click += new System.EventHandler(this.Tool_ADDITEM_Click);
            // 
            // Tool_MNGITEMS
            // 
            this.Tool_MNGITEMS.Name = "Tool_MNGITEMS";
            this.Tool_MNGITEMS.Size = new System.Drawing.Size(190, 28);
            this.Tool_MNGITEMS.Text = "أدارة المنتوجات";
            this.Tool_MNGITEMS.Click += new System.EventHandler(this.Tool_MNGITEMS_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // Tool_MNGCAT
            // 
            this.Tool_MNGCAT.Name = "Tool_MNGCAT";
            this.Tool_MNGCAT.Size = new System.Drawing.Size(190, 28);
            this.Tool_MNGCAT.Text = "أدارة الاصناف";
            this.Tool_MNGCAT.Click += new System.EventHandler(this.Tool_MNGCAT_Click);
            // 
            // Tool_CUSTOMER
            // 
            this.Tool_CUSTOMER.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_ADDCUSTOMER,
            this.Tool_MNGCUSTOMER});
            this.Tool_CUSTOMER.Enabled = false;
            this.Tool_CUSTOMER.Name = "Tool_CUSTOMER";
            this.Tool_CUSTOMER.Size = new System.Drawing.Size(64, 28);
            this.Tool_CUSTOMER.Text = "العملاء";
            // 
            // Tool_ADDCUSTOMER
            // 
            this.Tool_ADDCUSTOMER.Enabled = false;
            this.Tool_ADDCUSTOMER.Name = "Tool_ADDCUSTOMER";
            this.Tool_ADDCUSTOMER.Size = new System.Drawing.Size(184, 28);
            this.Tool_ADDCUSTOMER.Text = "أضافة عميل جديد";
            this.Tool_ADDCUSTOMER.Click += new System.EventHandler(this.Tool_ADDCUSTOMER_Click);
            // 
            // Tool_MNGCUSTOMER
            // 
            this.Tool_MNGCUSTOMER.Enabled = false;
            this.Tool_MNGCUSTOMER.Name = "Tool_MNGCUSTOMER";
            this.Tool_MNGCUSTOMER.Size = new System.Drawing.Size(184, 28);
            this.Tool_MNGCUSTOMER.Text = "أدارة العملاء";
            this.Tool_MNGCUSTOMER.Click += new System.EventHandler(this.Tool_MNGCUSTOMER_Click);
            // 
            // Too_USERS
            // 
            this.Too_USERS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_ADDUSER,
            this.Tool_MNGUSERS});
            this.Too_USERS.Enabled = false;
            this.Too_USERS.Name = "Too_USERS";
            this.Too_USERS.Size = new System.Drawing.Size(99, 28);
            this.Too_USERS.Text = "المستخدمون";
            // 
            // Tool_ADDUSER
            // 
            this.Tool_ADDUSER.Enabled = false;
            this.Tool_ADDUSER.Name = "Tool_ADDUSER";
            this.Tool_ADDUSER.Size = new System.Drawing.Size(184, 28);
            this.Tool_ADDUSER.Text = "أضافة  مستخدم";
            this.Tool_ADDUSER.Click += new System.EventHandler(this.Tool_ADDUSER_Click);
            // 
            // Tool_MNGUSERS
            // 
            this.Tool_MNGUSERS.Enabled = false;
            this.Tool_MNGUSERS.Name = "Tool_MNGUSERS";
            this.Tool_MNGUSERS.Size = new System.Drawing.Size(184, 28);
            this.Tool_MNGUSERS.Text = "أدارة المستخدمين";
            this.Tool_MNGUSERS.Click += new System.EventHandler(this.Tool_MNGUSERS_Click);
            // 
            // Tool_MONEY
            // 
            this.Tool_MONEY.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TooL_PAIDMONEY,
            this.Tool_SPENTMONEY,
            this.Tool_GET_TAKEMONEY,
            this.Tool_DAILYSPENT,
            this.ToolStripMenuItem_mngdocs});
            this.Tool_MONEY.Enabled = false;
            this.Tool_MONEY.Name = "Tool_MONEY";
            this.Tool_MONEY.Size = new System.Drawing.Size(73, 28);
            this.Tool_MONEY.Text = "الحسابات";
            // 
            // TooL_PAIDMONEY
            // 
            this.TooL_PAIDMONEY.Name = "TooL_PAIDMONEY";
            this.TooL_PAIDMONEY.Size = new System.Drawing.Size(182, 28);
            this.TooL_PAIDMONEY.Text = "سندات القبض";
            this.TooL_PAIDMONEY.Click += new System.EventHandler(this.TooL_PAIDMONEY_Click);
            // 
            // Tool_SPENTMONEY
            // 
            this.Tool_SPENTMONEY.Name = "Tool_SPENTMONEY";
            this.Tool_SPENTMONEY.Size = new System.Drawing.Size(182, 28);
            this.Tool_SPENTMONEY.Text = "سندات الصرف";
            this.Tool_SPENTMONEY.Click += new System.EventHandler(this.Tool_SPENTMONEY_Click);
            // 
            // Tool_GET_TAKEMONEY
            // 
            this.Tool_GET_TAKEMONEY.Name = "Tool_GET_TAKEMONEY";
            this.Tool_GET_TAKEMONEY.Size = new System.Drawing.Size(182, 28);
            this.Tool_GET_TAKEMONEY.Text = "سندات القيد";
            this.Tool_GET_TAKEMONEY.Visible = false;
            // 
            // Tool_DAILYSPENT
            // 
            this.Tool_DAILYSPENT.Name = "Tool_DAILYSPENT";
            this.Tool_DAILYSPENT.Size = new System.Drawing.Size(182, 28);
            this.Tool_DAILYSPENT.Text = "الصرفيات اليومية";
            this.Tool_DAILYSPENT.Click += new System.EventHandler(this.Tool_DAILYSPENT_Click);
            // 
            // ToolStripMenuItem_mngdocs
            // 
            this.ToolStripMenuItem_mngdocs.Name = "ToolStripMenuItem_mngdocs";
            this.ToolStripMenuItem_mngdocs.Size = new System.Drawing.Size(182, 28);
            this.ToolStripMenuItem_mngdocs.Text = "ادارة المستندات";
            this.ToolStripMenuItem_mngdocs.Click += new System.EventHandler(this.ToolStripMenuItem_mngdocs_Click);
            // 
            // ToolStripMenuItem_REPORTS
            // 
            this.ToolStripMenuItem_REPORTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_SLAESREP,
            this.تقريرمشترياتToolStripMenuItem,
            this.ToolStripMenuItem_REPORITMS,
            this.ToolStripMenuItem_COUST,
            this.ToolStripMenuItem_USRS,
            this.ToolStripMenuItem_RPT_PAID_SPENT});
            this.ToolStripMenuItem_REPORTS.Enabled = false;
            this.ToolStripMenuItem_REPORTS.Name = "ToolStripMenuItem_REPORTS";
            this.ToolStripMenuItem_REPORTS.Size = new System.Drawing.Size(64, 28);
            this.ToolStripMenuItem_REPORTS.Text = "التقارير";
            // 
            // ToolStripMenuItem_SLAESREP
            // 
            this.ToolStripMenuItem_SLAESREP.Name = "ToolStripMenuItem_SLAESREP";
            this.ToolStripMenuItem_SLAESREP.Size = new System.Drawing.Size(189, 28);
            this.ToolStripMenuItem_SLAESREP.Text = "تقرير مبيعات";
            this.ToolStripMenuItem_SLAESREP.Click += new System.EventHandler(this.ToolStripMenuItem_SLAESREP_Click);
            // 
            // تقريرمشترياتToolStripMenuItem
            // 
            this.تقريرمشترياتToolStripMenuItem.Name = "تقريرمشترياتToolStripMenuItem";
            this.تقريرمشترياتToolStripMenuItem.Size = new System.Drawing.Size(189, 28);
            this.تقريرمشترياتToolStripMenuItem.Text = "تقرير مشتريات";
            this.تقريرمشترياتToolStripMenuItem.Visible = false;
            // 
            // ToolStripMenuItem_REPORITMS
            // 
            this.ToolStripMenuItem_REPORITMS.Name = "ToolStripMenuItem_REPORITMS";
            this.ToolStripMenuItem_REPORITMS.Size = new System.Drawing.Size(189, 28);
            this.ToolStripMenuItem_REPORITMS.Text = "تقرير مواد";
            this.ToolStripMenuItem_REPORITMS.Click += new System.EventHandler(this.ToolStripMenuItem_REPORITMS_Click);
            // 
            // ToolStripMenuItem_COUST
            // 
            this.ToolStripMenuItem_COUST.Name = "ToolStripMenuItem_COUST";
            this.ToolStripMenuItem_COUST.Size = new System.Drawing.Size(189, 28);
            this.ToolStripMenuItem_COUST.Text = "تقرير العملاء";
            this.ToolStripMenuItem_COUST.Click += new System.EventHandler(this.ToolStripMenuItem_COUST_Click);
            // 
            // ToolStripMenuItem_USRS
            // 
            this.ToolStripMenuItem_USRS.Name = "ToolStripMenuItem_USRS";
            this.ToolStripMenuItem_USRS.Size = new System.Drawing.Size(189, 28);
            this.ToolStripMenuItem_USRS.Text = "تقرير المستخدمين";
            this.ToolStripMenuItem_USRS.Click += new System.EventHandler(this.ToolStripMenuItem_USRS_Click);
            // 
            // ToolStripMenuItem_RPT_PAID_SPENT
            // 
            this.ToolStripMenuItem_RPT_PAID_SPENT.Name = "ToolStripMenuItem_RPT_PAID_SPENT";
            this.ToolStripMenuItem_RPT_PAID_SPENT.Size = new System.Drawing.Size(189, 28);
            this.ToolStripMenuItem_RPT_PAID_SPENT.Text = "تقرير الحسابات";
            this.ToolStripMenuItem_RPT_PAID_SPENT.Click += new System.EventHandler(this.ToolStripMenuItem_RPT_PAID_SPENT_Click);
            // 
            // FORM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(70)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(792, 464);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_MAIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "النافذة  الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem Tool_FILE;
        private System.Windows.Forms.ToolStripMenuItem tool_Logout;
        private System.Windows.Forms.ToolStripMenuItem Tool_ADDITEM;
        private System.Windows.Forms.ToolStripMenuItem Tool_MNGITEMS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Tool_MNGCAT;
        private System.Windows.Forms.ToolStripMenuItem TooL_PAIDMONEY;
        private System.Windows.Forms.ToolStripMenuItem Tool_SPENTMONEY;
        private System.Windows.Forms.ToolStripMenuItem Tool_GET_TAKEMONEY;
        private System.Windows.Forms.ToolStripMenuItem Tool_DAILYSPENT;
        public System.Windows.Forms.ToolStripMenuItem tool_Backup;
        public System.Windows.Forms.ToolStripMenuItem tool_importBakup;
        public System.Windows.Forms.ToolStripMenuItem tool_SALES;
        public System.Windows.Forms.ToolStripMenuItem Tool_PURCHAES;
        public System.Windows.Forms.ToolStripMenuItem Tool_ITEMS;
        public System.Windows.Forms.ToolStripMenuItem Tool_CUSTOMER;
        public System.Windows.Forms.ToolStripMenuItem Too_USERS;
        public System.Windows.Forms.ToolStripMenuItem Tool_MONEY;
        public System.Windows.Forms.ToolStripMenuItem tool_login;
        private System.Windows.Forms.ToolStripMenuItem Tool_DIRECTPURCHASE;
        private System.Windows.Forms.ToolStripMenuItem Tool_MNGPURCHASE;
        public System.Windows.Forms.ToolStripMenuItem tool_DIRSALES;
        public System.Windows.Forms.ToolStripMenuItem tool_MNGSALESS;
        public System.Windows.Forms.ToolStripMenuItem Tool_ADDCUSTOMER;
        public System.Windows.Forms.ToolStripMenuItem Tool_MNGCUSTOMER;
        public System.Windows.Forms.ToolStripMenuItem Tool_ADDUSER;
        public System.Windows.Forms.ToolStripMenuItem Tool_MNGUSERS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SLAESREP;
        private System.Windows.Forms.ToolStripMenuItem تقريرمشترياتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_REPORITMS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_COUST;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_USRS;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RPT_PAID_SPENT;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_mngdocs;
        public System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_REPORTS;
    }
}