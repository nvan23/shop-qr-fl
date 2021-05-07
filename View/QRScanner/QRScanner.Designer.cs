
namespace shop_qr.View.QRScanner
{
    partial class formQRScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQRScanner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelQRScannerTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelBindCustomerInfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelCustomerPhoneInBill = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel15 = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelCustomerNameInBill = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 697);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labelBindCustomerInfo);
            this.panel2.Controls.Add(this.labelQRScannerTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 42);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.bunifuShadowPanel1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(956, 655);
            this.panel3.TabIndex = 1;
            // 
            // labelQRScannerTitle
            // 
            this.labelQRScannerTitle.AllowParentOverrides = false;
            this.labelQRScannerTitle.AutoEllipsis = false;
            this.labelQRScannerTitle.CursorType = null;
            this.labelQRScannerTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQRScannerTitle.Location = new System.Drawing.Point(348, 12);
            this.labelQRScannerTitle.Name = "labelQRScannerTitle";
            this.labelQRScannerTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelQRScannerTitle.Size = new System.Drawing.Size(141, 21);
            this.labelQRScannerTitle.TabIndex = 1;
            this.labelQRScannerTitle.Text = "Quét mã thành viên";
            this.labelQRScannerTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelQRScannerTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // labelBindCustomerInfo
            // 
            this.labelBindCustomerInfo.AllowParentOverrides = false;
            this.labelBindCustomerInfo.AutoEllipsis = false;
            this.labelBindCustomerInfo.CursorType = null;
            this.labelBindCustomerInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBindCustomerInfo.Location = new System.Drawing.Point(872, 12);
            this.labelBindCustomerInfo.Name = "labelBindCustomerInfo";
            this.labelBindCustomerInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBindCustomerInfo.Size = new System.Drawing.Size(59, 21);
            this.labelBindCustomerInfo.TabIndex = 2;
            this.labelBindCustomerInfo.Text = "Tiếp tục";
            this.labelBindCustomerInfo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelBindCustomerInfo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.labelCustomerPhoneInBill);
            this.panel5.Controls.Add(this.bunifuSeparator3);
            this.panel5.Controls.Add(this.bunifuLabel15);
            this.panel5.Controls.Add(this.labelCustomerNameInBill);
            this.panel5.Controls.Add(this.bunifuSeparator2);
            this.panel5.Controls.Add(this.bunifuSeparator1);
            this.panel5.Controls.Add(this.bunifuLabel7);
            this.panel5.Controls.Add(this.bunifuLabel5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(603, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(353, 655);
            this.panel5.TabIndex = 7;
            // 
            // labelCustomerPhoneInBill
            // 
            this.labelCustomerPhoneInBill.AllowParentOverrides = false;
            this.labelCustomerPhoneInBill.AutoEllipsis = false;
            this.labelCustomerPhoneInBill.CursorType = null;
            this.labelCustomerPhoneInBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerPhoneInBill.ForeColor = System.Drawing.Color.DimGray;
            this.labelCustomerPhoneInBill.Location = new System.Drawing.Point(17, 179);
            this.labelCustomerPhoneInBill.Name = "labelCustomerPhoneInBill";
            this.labelCustomerPhoneInBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCustomerPhoneInBill.Size = new System.Drawing.Size(99, 21);
            this.labelCustomerPhoneInBill.TabIndex = 14;
            this.labelCustomerPhoneInBill.Text = "09633487566";
            this.labelCustomerPhoneInBill.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelCustomerPhoneInBill.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator3.BackgroundImage")));
            this.bunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(11, 197);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator3.Size = new System.Drawing.Size(333, 14);
            this.bunifuSeparator3.TabIndex = 13;
            // 
            // bunifuLabel15
            // 
            this.bunifuLabel15.AllowParentOverrides = false;
            this.bunifuLabel15.AutoEllipsis = false;
            this.bunifuLabel15.CursorType = null;
            this.bunifuLabel15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel15.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel15.Location = new System.Drawing.Point(15, 153);
            this.bunifuLabel15.Name = "bunifuLabel15";
            this.bunifuLabel15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel15.Size = new System.Drawing.Size(96, 21);
            this.bunifuLabel15.TabIndex = 12;
            this.bunifuLabel15.Text = "Số điện thoại";
            this.bunifuLabel15.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel15.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // labelCustomerNameInBill
            // 
            this.labelCustomerNameInBill.AllowParentOverrides = false;
            this.labelCustomerNameInBill.AutoEllipsis = false;
            this.labelCustomerNameInBill.CursorType = null;
            this.labelCustomerNameInBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerNameInBill.ForeColor = System.Drawing.Color.DimGray;
            this.labelCustomerNameInBill.Location = new System.Drawing.Point(17, 93);
            this.labelCustomerNameInBill.Name = "labelCustomerNameInBill";
            this.labelCustomerNameInBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCustomerNameInBill.Size = new System.Drawing.Size(100, 21);
            this.labelCustomerNameInBill.TabIndex = 11;
            this.labelCustomerNameInBill.Text = "Nguyễn Văn A";
            this.labelCustomerNameInBill.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelCustomerNameInBill.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator2.BackgroundImage")));
            this.bunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(11, 111);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator2.Size = new System.Drawing.Size(333, 14);
            this.bunifuSeparator2.TabIndex = 10;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(8, 36);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(340, 14);
            this.bunifuSeparator1.TabIndex = 9;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel7.Location = new System.Drawing.Point(78, 6);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(208, 30);
            this.bunifuLabel7.TabIndex = 8;
            this.bunifuLabel7.Text = "Thông tin thành viên";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel5.Location = new System.Drawing.Point(15, 67);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(106, 21);
            this.bunifuLabel5.TabIndex = 3;
            this.bunifuLabel5.Text = "Tên thành viên";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(12, 6);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(585, 637);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 8;
            // 
            // formQRScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 697);
            this.Controls.Add(this.panel1);
            this.Name = "formQRScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QRScanner";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuLabel labelQRScannerTitle;
        private Bunifu.UI.WinForms.BunifuLabel labelBindCustomerInfo;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.UI.WinForms.BunifuLabel labelCustomerPhoneInBill;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel15;
        private Bunifu.UI.WinForms.BunifuLabel labelCustomerNameInBill;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator2;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
    }
}