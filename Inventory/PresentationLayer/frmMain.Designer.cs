namespace Inventory.PresentationLayer
{
    partial class frmMain
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.mnApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.LBLBottomLeft = new System.Windows.Forms.ToolStripStatusLabel();
            this.LBLBottomRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbLogin = new System.Windows.Forms.ToolStripButton();
            this.tsbLogout = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbInventory = new System.Windows.Forms.ToolStripButton();
            this.tsbInquiry = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReport = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.mnLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnApplication,
            this.mnTransaction,
            this.mnSetup,
            this.mnReport,
            this.mnAbout});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(774, 24);
            this.msMain.TabIndex = 1;
            // 
            // mnApplication
            // 
            this.mnApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLogin,
            this.mnLogout,
            this.toolStripSeparator1,
            this.mnExit});
            this.mnApplication.Name = "mnApplication";
            this.mnApplication.Size = new System.Drawing.Size(123, 20);
            this.mnApplication.Text = "Application Control";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnTransaction
            // 
            this.mnTransaction.Name = "mnTransaction";
            this.mnTransaction.Size = new System.Drawing.Size(80, 20);
            this.mnTransaction.Text = "Transaction";
            // 
            // mnSetup
            // 
            this.mnSetup.Name = "mnSetup";
            this.mnSetup.Size = new System.Drawing.Size(49, 20);
            this.mnSetup.Text = "Setup";
            // 
            // mnReport
            // 
            this.mnReport.Name = "mnReport";
            this.mnReport.Size = new System.Drawing.Size(54, 20);
            this.mnReport.Text = "Report";
            // 
            // mnAbout
            // 
            this.mnAbout.Name = "mnAbout";
            this.mnAbout.Size = new System.Drawing.Size(52, 20);
            this.mnAbout.Text = "About";
            // 
            // ssMain
            // 
            this.ssMain.BackColor = System.Drawing.Color.DimGray;
            this.ssMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LBLBottomLeft,
            this.LBLBottomRight});
            this.ssMain.Location = new System.Drawing.Point(0, 453);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(774, 22);
            this.ssMain.TabIndex = 9;
            // 
            // LBLBottomLeft
            // 
            this.LBLBottomLeft.ForeColor = System.Drawing.Color.White;
            this.LBLBottomLeft.Name = "LBLBottomLeft";
            this.LBLBottomLeft.Size = new System.Drawing.Size(379, 17);
            this.LBLBottomLeft.Spring = true;
            this.LBLBottomLeft.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LBLBottomRight
            // 
            this.LBLBottomRight.AutoSize = false;
            this.LBLBottomRight.ForeColor = System.Drawing.Color.White;
            this.LBLBottomRight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBLBottomRight.Name = "LBLBottomRight";
            this.LBLBottomRight.Size = new System.Drawing.Size(379, 17);
            this.LBLBottomRight.Spring = true;
            this.LBLBottomRight.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.Gainsboro;
            this.tsMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMain.BackgroundImage")));
            this.tsMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLogin,
            this.tsbLogout,
            this.tsSeparator1,
            this.tsbInventory,
            this.tsbInquiry,
            this.tsSeparator2,
            this.tsbReport,
            this.tsSeparator3,
            this.tsbExit});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(774, 54);
            this.tsMain.TabIndex = 5;
            // 
            // tsbLogin
            // 
            this.tsbLogin.ForeColor = System.Drawing.Color.White;
            this.tsbLogin.Image = global::Inventory.Properties.Resources.Keys;
            this.tsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogin.Name = "tsbLogin";
            this.tsbLogin.Size = new System.Drawing.Size(46, 51);
            this.tsbLogin.Text = "Log-In";
            this.tsbLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLogin.Click += new System.EventHandler(this.tsbLogin_Click);
            // 
            // tsbLogout
            // 
            this.tsbLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tsbLogout.ForeColor = System.Drawing.Color.White;
            this.tsbLogout.Image = global::Inventory.Properties.Resources.Logout;
            this.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogout.Name = "tsbLogout";
            this.tsbLogout.Size = new System.Drawing.Size(55, 51);
            this.tsbLogout.Text = "Log-Out";
            this.tsbLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLogout.Click += new System.EventHandler(this.tsbLogout_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.ForeColor = System.Drawing.Color.Black;
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbInventory
            // 
            this.tsbInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tsbInventory.ForeColor = System.Drawing.Color.White;
            this.tsbInventory.Image = global::Inventory.Properties.Resources.Inventory;
            this.tsbInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInventory.Name = "tsbInventory";
            this.tsbInventory.Size = new System.Drawing.Size(59, 51);
            this.tsbInventory.Text = "Inventory";
            this.tsbInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbInquiry
            // 
            this.tsbInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbInquiry.ForeColor = System.Drawing.Color.White;
            this.tsbInquiry.Image = global::Inventory.Properties.Resources.Inquiry;
            this.tsbInquiry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInquiry.Name = "tsbInquiry";
            this.tsbInquiry.Size = new System.Drawing.Size(47, 51);
            this.tsbInquiry.Text = "Inquiry";
            this.tsbInquiry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.ForeColor = System.Drawing.Color.Black;
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbReport
            // 
            this.tsbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tsbReport.ForeColor = System.Drawing.Color.White;
            this.tsbReport.Image = global::Inventory.Properties.Resources.Printer;
            this.tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReport.Name = "tsbReport";
            this.tsbReport.Size = new System.Drawing.Size(48, 51);
            this.tsbReport.Text = "Report";
            this.tsbReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbReport.ToolTipText = "Report";
            // 
            // tsSeparator3
            // 
            this.tsSeparator3.ForeColor = System.Drawing.Color.Black;
            this.tsSeparator3.Name = "tsSeparator3";
            this.tsSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbExit
            // 
            this.tsbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tsbExit.ForeColor = System.Drawing.Color.White;
            this.tsbExit.Image = global::Inventory.Properties.Resources.Exit;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(36, 51);
            this.tsbExit.Text = "Exit";
            this.tsbExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // mnLogin
            // 
            this.mnLogin.Image = global::Inventory.Properties.Resources.Keys;
            this.mnLogin.Name = "mnLogin";
            this.mnLogin.Size = new System.Drawing.Size(152, 22);
            this.mnLogin.Text = "Log-In";
            this.mnLogin.Click += new System.EventHandler(this.mnLogin_Click);
            // 
            // mnLogout
            // 
            this.mnLogout.Image = global::Inventory.Properties.Resources.Logout;
            this.mnLogout.Name = "mnLogout";
            this.mnLogout.Size = new System.Drawing.Size(152, 22);
            this.mnLogout.Text = "Log-Out";
            this.mnLogout.Click += new System.EventHandler(this.mnLogout_Click);
            // 
            // mnExit
            // 
            this.mnExit.Image = global::Inventory.Properties.Resources.Exit;
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(152, 22);
            this.mnExit.Text = "Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 475);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "frmMain";
            this.Text = "Inventory System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem mnApplication;
        private System.Windows.Forms.ToolStripMenuItem mnTransaction;
        private System.Windows.Forms.ToolStripMenuItem mnSetup;
        private System.Windows.Forms.ToolStripMenuItem mnReport;
        private System.Windows.Forms.ToolStripMenuItem mnAbout;
        private System.Windows.Forms.ToolStripMenuItem mnLogin;
        private System.Windows.Forms.ToolStripMenuItem mnLogout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbLogin;
        internal System.Windows.Forms.ToolStripButton tsbLogout;
        internal System.Windows.Forms.ToolStripSeparator tsSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbInventory;
        internal System.Windows.Forms.ToolStripButton tsbInquiry;
        internal System.Windows.Forms.ToolStripSeparator tsSeparator2;
        internal System.Windows.Forms.ToolStripButton tsbReport;
        internal System.Windows.Forms.ToolStripSeparator tsSeparator3;
        internal System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        internal System.Windows.Forms.StatusStrip ssMain;
        internal System.Windows.Forms.ToolStripStatusLabel LBLBottomLeft;
        internal System.Windows.Forms.ToolStripStatusLabel LBLBottomRight;
    }
}