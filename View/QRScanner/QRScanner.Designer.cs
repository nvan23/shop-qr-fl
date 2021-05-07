
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQRScanner));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pictureBoxQRSCanner = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelCustomerPhoneInBill = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator3 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel15 = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelCustomerNameInBill = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelBindCustomerInfo = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelQRScannerTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.timerQRScanner = new System.Windows.Forms.Timer(this.components);
            this.buttonOpenScanner = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.textBoxResult = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRSCanner)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.cboCamera);
            this.bunifuShadowPanel1.Controls.Add(this.buttonOpenScanner);
            this.bunifuShadowPanel1.Controls.Add(this.pictureBoxQRSCanner);
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
            // pictureBoxQRSCanner
            // 
            this.pictureBoxQRSCanner.Location = new System.Drawing.Point(12, 50);
            this.pictureBoxQRSCanner.Name = "pictureBoxQRSCanner";
            this.pictureBoxQRSCanner.Size = new System.Drawing.Size(559, 573);
            this.pictureBoxQRSCanner.TabIndex = 0;
            this.pictureBoxQRSCanner.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.textBoxResult);
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
            // timerQRScanner
            // 
            this.timerQRScanner.Interval = 1000;
            this.timerQRScanner.Tick += new System.EventHandler(this.timerQRScanner_Tick);
            // 
            // buttonOpenScanner
            // 
            this.buttonOpenScanner.AllowAnimations = true;
            this.buttonOpenScanner.AllowMouseEffects = true;
            this.buttonOpenScanner.AllowToggling = false;
            this.buttonOpenScanner.AnimationSpeed = 200;
            this.buttonOpenScanner.AutoGenerateColors = false;
            this.buttonOpenScanner.AutoRoundBorders = false;
            this.buttonOpenScanner.AutoSizeLeftIcon = true;
            this.buttonOpenScanner.AutoSizeRightIcon = true;
            this.buttonOpenScanner.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenScanner.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonOpenScanner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenScanner.BackgroundImage")));
            this.buttonOpenScanner.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonOpenScanner.ButtonText = "Quét";
            this.buttonOpenScanner.ButtonTextMarginLeft = 0;
            this.buttonOpenScanner.ColorContrastOnClick = 45;
            this.buttonOpenScanner.ColorContrastOnHover = 45;
            this.buttonOpenScanner.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.buttonOpenScanner.CustomizableEdges = borderEdges2;
            this.buttonOpenScanner.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonOpenScanner.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonOpenScanner.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonOpenScanner.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonOpenScanner.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonOpenScanner.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenScanner.ForeColor = System.Drawing.Color.White;
            this.buttonOpenScanner.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenScanner.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpenScanner.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonOpenScanner.IconMarginLeft = 11;
            this.buttonOpenScanner.IconPadding = 10;
            this.buttonOpenScanner.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonOpenScanner.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpenScanner.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonOpenScanner.IconSize = 25;
            this.buttonOpenScanner.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenScanner.IdleBorderRadius = 1;
            this.buttonOpenScanner.IdleBorderThickness = 1;
            this.buttonOpenScanner.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenScanner.IdleIconLeftImage = null;
            this.buttonOpenScanner.IdleIconRightImage = null;
            this.buttonOpenScanner.IndicateFocus = false;
            this.buttonOpenScanner.Location = new System.Drawing.Point(421, 19);
            this.buttonOpenScanner.Name = "buttonOpenScanner";
            this.buttonOpenScanner.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonOpenScanner.OnDisabledState.BorderRadius = 1;
            this.buttonOpenScanner.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonOpenScanner.OnDisabledState.BorderThickness = 1;
            this.buttonOpenScanner.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonOpenScanner.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonOpenScanner.OnDisabledState.IconLeftImage = null;
            this.buttonOpenScanner.OnDisabledState.IconRightImage = null;
            this.buttonOpenScanner.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonOpenScanner.onHoverState.BorderRadius = 1;
            this.buttonOpenScanner.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonOpenScanner.onHoverState.BorderThickness = 1;
            this.buttonOpenScanner.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonOpenScanner.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonOpenScanner.onHoverState.IconLeftImage = null;
            this.buttonOpenScanner.onHoverState.IconRightImage = null;
            this.buttonOpenScanner.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenScanner.OnIdleState.BorderRadius = 1;
            this.buttonOpenScanner.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonOpenScanner.OnIdleState.BorderThickness = 1;
            this.buttonOpenScanner.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpenScanner.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonOpenScanner.OnIdleState.IconLeftImage = null;
            this.buttonOpenScanner.OnIdleState.IconRightImage = null;
            this.buttonOpenScanner.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonOpenScanner.OnPressedState.BorderRadius = 1;
            this.buttonOpenScanner.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonOpenScanner.OnPressedState.BorderThickness = 1;
            this.buttonOpenScanner.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonOpenScanner.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonOpenScanner.OnPressedState.IconLeftImage = null;
            this.buttonOpenScanner.OnPressedState.IconRightImage = null;
            this.buttonOpenScanner.Size = new System.Drawing.Size(150, 25);
            this.buttonOpenScanner.TabIndex = 1;
            this.buttonOpenScanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonOpenScanner.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonOpenScanner.TextMarginLeft = 0;
            this.buttonOpenScanner.TextPadding = new System.Windows.Forms.Padding(0);
            this.buttonOpenScanner.UseDefaultRadiusAndThickness = true;
            this.buttonOpenScanner.Click += new System.EventHandler(this.buttonOpenScanner_Click);
            // 
            // cboCamera
            // 
            this.cboCamera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCamera.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCamera.ForeColor = System.Drawing.Color.DimGray;
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(12, 19);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(403, 25);
            this.cboCamera.TabIndex = 2;
            // 
            // textBoxResult
            // 
            this.textBoxResult.AcceptsReturn = false;
            this.textBoxResult.AcceptsTab = false;
            this.textBoxResult.AnimationSpeed = 200;
            this.textBoxResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxResult.BackColor = System.Drawing.Color.Transparent;
            this.textBoxResult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxResult.BackgroundImage")));
            this.textBoxResult.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textBoxResult.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxResult.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBoxResult.BorderColorIdle = System.Drawing.Color.Silver;
            this.textBoxResult.BorderRadius = 1;
            this.textBoxResult.BorderThickness = 1;
            this.textBoxResult.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxResult.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBoxResult.DefaultText = "";
            this.textBoxResult.FillColor = System.Drawing.Color.White;
            this.textBoxResult.HideSelection = true;
            this.textBoxResult.IconLeft = null;
            this.textBoxResult.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxResult.IconPadding = 10;
            this.textBoxResult.IconRight = null;
            this.textBoxResult.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxResult.Lines = new string[0];
            this.textBoxResult.Location = new System.Drawing.Point(11, 218);
            this.textBoxResult.MaxLength = 32767;
            this.textBoxResult.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxResult.Modified = false;
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxResult.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxResult.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxResult.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxResult.OnIdleState = stateProperties8;
            this.textBoxResult.Padding = new System.Windows.Forms.Padding(3);
            this.textBoxResult.PasswordChar = '\0';
            this.textBoxResult.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBoxResult.PlaceholderText = "";
            this.textBoxResult.ReadOnly = false;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxResult.SelectedText = "";
            this.textBoxResult.SelectionLength = 0;
            this.textBoxResult.SelectionStart = 0;
            this.textBoxResult.ShortcutsEnabled = true;
            this.textBoxResult.Size = new System.Drawing.Size(330, 411);
            this.textBoxResult.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBoxResult.TabIndex = 15;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxResult.TextMarginBottom = 0;
            this.textBoxResult.TextMarginLeft = 3;
            this.textBoxResult.TextMarginTop = 0;
            this.textBoxResult.TextPlaceholder = "";
            this.textBoxResult.UseSystemPasswordChar = false;
            this.textBoxResult.WordWrap = true;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formQRScanner_FormClosing);
            this.Load += new System.EventHandler(this.formQRScanner_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.bunifuShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRSCanner)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBoxQRSCanner;
        private System.Windows.Forms.Timer timerQRScanner;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonOpenScanner;
        private System.Windows.Forms.ComboBox cboCamera;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxResult;
    }
}