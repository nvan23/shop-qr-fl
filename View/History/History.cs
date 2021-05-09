using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using shop_qr.Presenter;
using shop_qr.View;

namespace shop_qr.View
{
    public partial class History : Form, IHistory
    {
        private PHistory presenter;
        public History()
        {
            InitializeComponent();
            presenter = new PHistory(this);
            presenter.Read();
        }

        MJPEGStream stream;

        FilterInfoCollection filterInfoCollectionInHistory;
        VideoCaptureDevice videoCaptureDeviceInHistory;
       
        public long Total { get => Int64.Parse(labelTotalInBill.Text); set => labelTotalInBill.Text = value.ToString(); }
        public long Tax { get => Int64.Parse(labelTaxInBill.Text); set => labelTaxInBill.Text = value.ToString(); }
        public long Pay { get => Int64.Parse(labelPayInBill.Text); set => labelPayInBill.Text = value.ToString(); }
        public string CustomerId { get => labelCustomerId.Text; set => labelCustomerId.Text = value; }
        public string CustomerName { get => labelCustomerNameInHistory.Text; set => labelCustomerNameInHistory.Text = value.ToString(); }
        public string CustomerPhone { get => labelCustomerPhoneInHistory.Text; set => labelCustomerPhoneInHistory.Text = value.ToString(); }
        public List<Model.Bill> Bills { get => (List<Model.Bill>)dataGridViewBillHistory.DataSource; set => dataGridViewBillHistory.DataSource = value; }
        public List<Model.MProductBill> Details { get => (List<Model.MProductBill>)dataGridViewBillDetailHistory.DataSource; set => dataGridViewBillDetailHistory.DataSource = value; }

        private void dataGridViewBillHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Model.Bill row = dataGridViewBillHistory.Rows[e.RowIndex].DataBoundItem as Model.Bill;
                presenter.ReadDetail(row.Id);
                presenter.CalculateTotal();
                presenter.GetCustomerById((int)row.CustomerId);
                presenter.ReadByCustomerId((int)row.CustomerId);
                Details = new List<Model.MProductBill>();
            }
        }

        private void buttonGetCustomerInfoInHistory_Click(object sender, EventArgs e)
        {
            new View.QRScanner.formQRScanner().ShowDialog();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxQRScannerInHistory.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        private void History_Load(object sender, EventArgs e)
        {
            filterInfoCollectionInHistory = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollectionInHistory)
                comboBoxQRScannerInBill.Items.Add(Device.Name);
            comboBoxQRScannerInBill.SelectedIndex = 0;
            videoCaptureDeviceInHistory = new VideoCaptureDevice();
        }

        private void timerPickerInHistory_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Bitmap bitmap = (Bitmap)pictureBoxQRScannerInHistory.Image;
            if (bitmap == null)
            {
                CustomerId = "";
                CustomerName = "";
                CustomerPhone = "";
                return;
            }

            Result result = Reader.Decode(bitmap); if (result != null)
            {
                presenter.GetCustomerById(Int32.Parse(result.Text));
                presenter.ReadByCustomerId(Int32.Parse(result.Text));
                videoCaptureDeviceInHistory.Stop();
                panelQRScannerInHistory.Visible = false;
                panelCustomerProfileInHistory.Visible = true;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            videoCaptureDeviceInHistory.Stop();
            CustomerId = "";
            CustomerName = "";
            CustomerPhone = "";
            panelQRScannerInHistory.Visible = false;
            panelCustomerProfileInHistory.Visible = true;
            Details = new List<Model.MProductBill>();
            presenter.Read();

        }

        private void panelCustomerProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGetCustomerInfoInHistory_Click_1(object sender, EventArgs e)
        {
            panelCustomerProfileInHistory.Visible = false;
            panelQRScannerInHistory.Visible = true;

            timerPickerInHistory.Enabled = true;

            videoCaptureDeviceInHistory = new VideoCaptureDevice(filterInfoCollectionInHistory[comboBoxQRScannerInBill.SelectedIndex].MonikerString);
            videoCaptureDeviceInHistory.NewFrame += FinalFrame_NewFrame;
            videoCaptureDeviceInHistory.Start();
            timerPickerInHistory.Start();
        }
    }
}
