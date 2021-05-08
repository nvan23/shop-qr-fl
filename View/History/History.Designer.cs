
namespace shop_qr.View
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.formHistory = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.bunifuLabel46 = new Bunifu.UI.WinForms.BunifuLabel();
            this.dataGridViewBillDetailHistory = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel21 = new System.Windows.Forms.Panel();
            this.dataGridViewBillHistory = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel24 = new System.Windows.Forms.Panel();
            this.labelCustomerPhoneInHistory = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator10 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel28 = new Bunifu.UI.WinForms.BunifuLabel();
            this.labelCustomerNameInHistory = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuSeparator11 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuSeparator12 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuLabel30 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel32 = new Bunifu.UI.WinForms.BunifuLabel();
            this.buttonGetCustomerInfoInHistory = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formHistory.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillDetailHistory)).BeginInit();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillHistory)).BeginInit();
            this.panel24.SuspendLayout();
            this.SuspendLayout();
            // 
            // formHistory
            // 
            this.formHistory.Controls.Add(this.panel20);
            this.formHistory.Controls.Add(this.panel21);
            this.formHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formHistory.Location = new System.Drawing.Point(0, 0);
            this.formHistory.Name = "formHistory";
            this.formHistory.Size = new System.Drawing.Size(956, 697);
            this.formHistory.TabIndex = 1;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.White;
            this.panel20.Controls.Add(this.panel22);
            this.panel20.Controls.Add(this.dataGridViewBillDetailHistory);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel20.Location = new System.Drawing.Point(0, 280);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(956, 417);
            this.panel20.TabIndex = 10;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.bunifuLabel46);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(956, 34);
            this.panel22.TabIndex = 7;
            // 
            // bunifuLabel46
            // 
            this.bunifuLabel46.AllowParentOverrides = false;
            this.bunifuLabel46.AutoEllipsis = false;
            this.bunifuLabel46.CursorType = null;
            this.bunifuLabel46.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel46.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel46.Location = new System.Drawing.Point(3, 3);
            this.bunifuLabel46.Name = "bunifuLabel46";
            this.bunifuLabel46.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel46.Size = new System.Drawing.Size(139, 25);
            this.bunifuLabel46.TabIndex = 6;
            this.bunifuLabel46.Text = "Chi tiết hóa đơn";
            this.bunifuLabel46.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel46.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dataGridViewBillDetailHistory
            // 
            this.dataGridViewBillDetailHistory.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBillDetailHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBillDetailHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBillDetailHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBillDetailHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBillDetailHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewBillDetailHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBillDetailHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBillDetailHistory.ColumnHeadersHeight = 40;
            this.dataGridViewBillDetailHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.dataGridViewBillDetailHistory.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewBillDetailHistory.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewBillDetailHistory.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBillDetailHistory.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewBillDetailHistory.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBillDetailHistory.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewBillDetailHistory.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewBillDetailHistory.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewBillDetailHistory.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewBillDetailHistory.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewBillDetailHistory.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewBillDetailHistory.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewBillDetailHistory.CurrentTheme.Name = null;
            this.dataGridViewBillDetailHistory.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewBillDetailHistory.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewBillDetailHistory.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBillDetailHistory.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewBillDetailHistory.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBillDetailHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBillDetailHistory.EnableHeadersVisualStyles = false;
            this.dataGridViewBillDetailHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewBillDetailHistory.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewBillDetailHistory.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewBillDetailHistory.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewBillDetailHistory.Location = new System.Drawing.Point(0, 34);
            this.dataGridViewBillDetailHistory.Name = "dataGridViewBillDetailHistory";
            this.dataGridViewBillDetailHistory.RowHeadersVisible = false;
            this.dataGridViewBillDetailHistory.RowTemplate.Height = 40;
            this.dataGridViewBillDetailHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBillDetailHistory.Size = new System.Drawing.Size(957, 370);
            this.dataGridViewBillDetailHistory.TabIndex = 6;
            this.dataGridViewBillDetailHistory.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel21.Controls.Add(this.dataGridViewBillHistory);
            this.panel21.Controls.Add(this.panel24);
            this.panel21.Location = new System.Drawing.Point(3, 16);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(947, 265);
            this.panel21.TabIndex = 9;
            // 
            // dataGridViewBillHistory
            // 
            this.dataGridViewBillHistory.AllowCustomTheming = false;
            this.dataGridViewBillHistory.AllowUserToAddRows = false;
            this.dataGridViewBillHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBillHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBillHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBillHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBillHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBillHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewBillHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBillHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBillHistory.ColumnHeadersHeight = 40;
            this.dataGridViewBillHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.billDate,
            this.dataGridViewTextBoxColumn8,
            this.Customer});
            this.dataGridViewBillHistory.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewBillHistory.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewBillHistory.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBillHistory.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewBillHistory.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBillHistory.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewBillHistory.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewBillHistory.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewBillHistory.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewBillHistory.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewBillHistory.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewBillHistory.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewBillHistory.CurrentTheme.Name = null;
            this.dataGridViewBillHistory.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewBillHistory.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewBillHistory.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewBillHistory.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewBillHistory.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBillHistory.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBillHistory.EnableHeadersVisualStyles = false;
            this.dataGridViewBillHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewBillHistory.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewBillHistory.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewBillHistory.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewBillHistory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBillHistory.Name = "dataGridViewBillHistory";
            this.dataGridViewBillHistory.ReadOnly = true;
            this.dataGridViewBillHistory.RowHeadersVisible = false;
            this.dataGridViewBillHistory.RowTemplate.Height = 40;
            this.dataGridViewBillHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBillHistory.Size = new System.Drawing.Size(568, 265);
            this.dataGridViewBillHistory.TabIndex = 7;
            this.dataGridViewBillHistory.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewBillHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBillHistory_CellClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // billDate
            // 
            this.billDate.DataPropertyName = "CreatedAt";
            this.billDate.HeaderText = "Thời gian";
            this.billDate.Name = "billDate";
            this.billDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã KH";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Column1";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            this.Customer.Visible = false;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.White;
            this.panel24.Controls.Add(this.labelCustomerPhoneInHistory);
            this.panel24.Controls.Add(this.bunifuSeparator10);
            this.panel24.Controls.Add(this.bunifuLabel28);
            this.panel24.Controls.Add(this.labelCustomerNameInHistory);
            this.panel24.Controls.Add(this.bunifuSeparator11);
            this.panel24.Controls.Add(this.bunifuSeparator12);
            this.panel24.Controls.Add(this.bunifuLabel30);
            this.panel24.Controls.Add(this.bunifuLabel32);
            this.panel24.Controls.Add(this.buttonGetCustomerInfoInHistory);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel24.Location = new System.Drawing.Point(594, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(353, 265);
            this.panel24.TabIndex = 6;
            // 
            // labelCustomerPhoneInHistory
            // 
            this.labelCustomerPhoneInHistory.AllowParentOverrides = false;
            this.labelCustomerPhoneInHistory.AutoEllipsis = false;
            this.labelCustomerPhoneInHistory.CursorType = null;
            this.labelCustomerPhoneInHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerPhoneInHistory.ForeColor = System.Drawing.Color.DimGray;
            this.labelCustomerPhoneInHistory.Location = new System.Drawing.Point(12, 186);
            this.labelCustomerPhoneInHistory.Name = "labelCustomerPhoneInHistory";
            this.labelCustomerPhoneInHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCustomerPhoneInHistory.Size = new System.Drawing.Size(0, 0);
            this.labelCustomerPhoneInHistory.TabIndex = 14;
            this.labelCustomerPhoneInHistory.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelCustomerPhoneInHistory.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator10
            // 
            this.bunifuSeparator10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator10.BackgroundImage")));
            this.bunifuSeparator10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator10.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator10.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator10.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator10.LineThickness = 1;
            this.bunifuSeparator10.Location = new System.Drawing.Point(6, 204);
            this.bunifuSeparator10.Name = "bunifuSeparator10";
            this.bunifuSeparator10.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator10.Size = new System.Drawing.Size(333, 14);
            this.bunifuSeparator10.TabIndex = 13;
            // 
            // bunifuLabel28
            // 
            this.bunifuLabel28.AllowParentOverrides = false;
            this.bunifuLabel28.AutoEllipsis = false;
            this.bunifuLabel28.CursorType = null;
            this.bunifuLabel28.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel28.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel28.Location = new System.Drawing.Point(10, 160);
            this.bunifuLabel28.Name = "bunifuLabel28";
            this.bunifuLabel28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel28.Size = new System.Drawing.Size(96, 21);
            this.bunifuLabel28.TabIndex = 12;
            this.bunifuLabel28.Text = "Số điện thoại";
            this.bunifuLabel28.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel28.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // labelCustomerNameInHistory
            // 
            this.labelCustomerNameInHistory.AllowParentOverrides = false;
            this.labelCustomerNameInHistory.AutoEllipsis = false;
            this.labelCustomerNameInHistory.CursorType = null;
            this.labelCustomerNameInHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerNameInHistory.ForeColor = System.Drawing.Color.DimGray;
            this.labelCustomerNameInHistory.Location = new System.Drawing.Point(12, 100);
            this.labelCustomerNameInHistory.Name = "labelCustomerNameInHistory";
            this.labelCustomerNameInHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCustomerNameInHistory.Size = new System.Drawing.Size(0, 0);
            this.labelCustomerNameInHistory.TabIndex = 11;
            this.labelCustomerNameInHistory.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelCustomerNameInHistory.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuSeparator11
            // 
            this.bunifuSeparator11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator11.BackgroundImage")));
            this.bunifuSeparator11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator11.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator11.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator11.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator11.LineThickness = 1;
            this.bunifuSeparator11.Location = new System.Drawing.Point(6, 118);
            this.bunifuSeparator11.Name = "bunifuSeparator11";
            this.bunifuSeparator11.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator11.Size = new System.Drawing.Size(333, 14);
            this.bunifuSeparator11.TabIndex = 10;
            // 
            // bunifuSeparator12
            // 
            this.bunifuSeparator12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator12.BackgroundImage")));
            this.bunifuSeparator12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator12.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator12.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator12.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator12.LineThickness = 1;
            this.bunifuSeparator12.Location = new System.Drawing.Point(3, 43);
            this.bunifuSeparator12.Name = "bunifuSeparator12";
            this.bunifuSeparator12.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator12.Size = new System.Drawing.Size(340, 14);
            this.bunifuSeparator12.TabIndex = 9;
            // 
            // bunifuLabel30
            // 
            this.bunifuLabel30.AllowParentOverrides = false;
            this.bunifuLabel30.AutoEllipsis = false;
            this.bunifuLabel30.CursorType = null;
            this.bunifuLabel30.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel30.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel30.Location = new System.Drawing.Point(73, 13);
            this.bunifuLabel30.Name = "bunifuLabel30";
            this.bunifuLabel30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel30.Size = new System.Drawing.Size(208, 30);
            this.bunifuLabel30.TabIndex = 8;
            this.bunifuLabel30.Text = "Thông tin thành viên";
            this.bunifuLabel30.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel30.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel32
            // 
            this.bunifuLabel32.AllowParentOverrides = false;
            this.bunifuLabel32.AutoEllipsis = false;
            this.bunifuLabel32.CursorType = null;
            this.bunifuLabel32.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel32.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuLabel32.Location = new System.Drawing.Point(10, 74);
            this.bunifuLabel32.Name = "bunifuLabel32";
            this.bunifuLabel32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel32.Size = new System.Drawing.Size(106, 21);
            this.bunifuLabel32.TabIndex = 3;
            this.bunifuLabel32.Text = "Tên thành viên";
            this.bunifuLabel32.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel32.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // buttonGetCustomerInfoInHistory
            // 
            this.buttonGetCustomerInfoInHistory.AllowAnimations = true;
            this.buttonGetCustomerInfoInHistory.AllowMouseEffects = true;
            this.buttonGetCustomerInfoInHistory.AllowToggling = false;
            this.buttonGetCustomerInfoInHistory.AnimationSpeed = 200;
            this.buttonGetCustomerInfoInHistory.AutoGenerateColors = false;
            this.buttonGetCustomerInfoInHistory.AutoRoundBorders = false;
            this.buttonGetCustomerInfoInHistory.AutoSizeLeftIcon = true;
            this.buttonGetCustomerInfoInHistory.AutoSizeRightIcon = true;
            this.buttonGetCustomerInfoInHistory.BackColor = System.Drawing.Color.Transparent;
            this.buttonGetCustomerInfoInHistory.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.buttonGetCustomerInfoInHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGetCustomerInfoInHistory.BackgroundImage")));
            this.buttonGetCustomerInfoInHistory.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonGetCustomerInfoInHistory.ButtonText = "Quét thẻ";
            this.buttonGetCustomerInfoInHistory.ButtonTextMarginLeft = 0;
            this.buttonGetCustomerInfoInHistory.ColorContrastOnClick = 45;
            this.buttonGetCustomerInfoInHistory.ColorContrastOnHover = 45;
            this.buttonGetCustomerInfoInHistory.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.buttonGetCustomerInfoInHistory.CustomizableEdges = borderEdges1;
            this.buttonGetCustomerInfoInHistory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonGetCustomerInfoInHistory.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonGetCustomerInfoInHistory.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonGetCustomerInfoInHistory.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonGetCustomerInfoInHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGetCustomerInfoInHistory.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonGetCustomerInfoInHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetCustomerInfoInHistory.ForeColor = System.Drawing.Color.White;
            this.buttonGetCustomerInfoInHistory.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGetCustomerInfoInHistory.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonGetCustomerInfoInHistory.IconLeftPadding = new System.Windows.Forms.Padding(125, 3, 3, 3);
            this.buttonGetCustomerInfoInHistory.IconMarginLeft = 11;
            this.buttonGetCustomerInfoInHistory.IconPadding = 10;
            this.buttonGetCustomerInfoInHistory.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGetCustomerInfoInHistory.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonGetCustomerInfoInHistory.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonGetCustomerInfoInHistory.IconSize = 25;
            this.buttonGetCustomerInfoInHistory.IdleBorderColor = System.Drawing.Color.White;
            this.buttonGetCustomerInfoInHistory.IdleBorderRadius = 1;
            this.buttonGetCustomerInfoInHistory.IdleBorderThickness = 1;
            this.buttonGetCustomerInfoInHistory.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.buttonGetCustomerInfoInHistory.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("buttonGetCustomerInfoInHistory.IdleIconLeftImage")));
            this.buttonGetCustomerInfoInHistory.IdleIconRightImage = null;
            this.buttonGetCustomerInfoInHistory.IndicateFocus = false;
            this.buttonGetCustomerInfoInHistory.Location = new System.Drawing.Point(0, 226);
            this.buttonGetCustomerInfoInHistory.Name = "buttonGetCustomerInfoInHistory";
            this.buttonGetCustomerInfoInHistory.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonGetCustomerInfoInHistory.OnDisabledState.BorderRadius = 1;
            this.buttonGetCustomerInfoInHistory.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonGetCustomerInfoInHistory.OnDisabledState.BorderThickness = 1;
            this.buttonGetCustomerInfoInHistory.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonGetCustomerInfoInHistory.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonGetCustomerInfoInHistory.OnDisabledState.IconLeftImage = null;
            this.buttonGetCustomerInfoInHistory.OnDisabledState.IconRightImage = null;
            this.buttonGetCustomerInfoInHistory.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonGetCustomerInfoInHistory.onHoverState.BorderRadius = 1;
            this.buttonGetCustomerInfoInHistory.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonGetCustomerInfoInHistory.onHoverState.BorderThickness = 1;
            this.buttonGetCustomerInfoInHistory.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.buttonGetCustomerInfoInHistory.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonGetCustomerInfoInHistory.onHoverState.IconLeftImage = null;
            this.buttonGetCustomerInfoInHistory.onHoverState.IconRightImage = null;
            this.buttonGetCustomerInfoInHistory.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.buttonGetCustomerInfoInHistory.OnIdleState.BorderRadius = 1;
            this.buttonGetCustomerInfoInHistory.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonGetCustomerInfoInHistory.OnIdleState.BorderThickness = 1;
            this.buttonGetCustomerInfoInHistory.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttonGetCustomerInfoInHistory.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonGetCustomerInfoInHistory.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("buttonGetCustomerInfoInHistory.OnIdleState.IconLeftImage")));
            this.buttonGetCustomerInfoInHistory.OnIdleState.IconRightImage = null;
            this.buttonGetCustomerInfoInHistory.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonGetCustomerInfoInHistory.OnPressedState.BorderRadius = 1;
            this.buttonGetCustomerInfoInHistory.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonGetCustomerInfoInHistory.OnPressedState.BorderThickness = 1;
            this.buttonGetCustomerInfoInHistory.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.buttonGetCustomerInfoInHistory.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonGetCustomerInfoInHistory.OnPressedState.IconLeftImage = null;
            this.buttonGetCustomerInfoInHistory.OnPressedState.IconRightImage = null;
            this.buttonGetCustomerInfoInHistory.Size = new System.Drawing.Size(353, 39);
            this.buttonGetCustomerInfoInHistory.TabIndex = 7;
            this.buttonGetCustomerInfoInHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonGetCustomerInfoInHistory.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonGetCustomerInfoInHistory.TextMarginLeft = 0;
            this.buttonGetCustomerInfoInHistory.TextPadding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonGetCustomerInfoInHistory.UseDefaultRadiusAndThickness = true;
            this.buttonGetCustomerInfoInHistory.Click += new System.EventHandler(this.buttonGetCustomerInfoInHistory_Click);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mã SP";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn11.FillWeight = 150F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Tên SP";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn12.FillWeight = 80F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn13.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 697);
            this.Controls.Add(this.formHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "History";
            this.Text = "History";
            this.formHistory.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillDetailHistory)).EndInit();
            this.panel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillHistory)).EndInit();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formHistory;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel22;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel46;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewBillDetailHistory;
        private System.Windows.Forms.Panel panel21;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewBillHistory;
        private System.Windows.Forms.Panel panel24;
        private Bunifu.UI.WinForms.BunifuLabel labelCustomerPhoneInHistory;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator10;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel28;
        private Bunifu.UI.WinForms.BunifuLabel labelCustomerNameInHistory;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator11;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator12;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel30;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel32;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonGetCustomerInfoInHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}