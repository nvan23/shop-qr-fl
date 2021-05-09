using shop_qr.Model;
using shop_qr.Presenter;
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

namespace shop_qr.View.Bill
{
    public partial class formBill : Form, IBill
    {
        private PBill presenter;
        public formBill()
        {
            InitializeComponent();
            presenter = new PBill(this);
            presenter.ReadProduct();
            BillDetails = new List<MProductBill>();
            presenter.CalculateTotal();

        }

        MJPEGStream stream;

        FilterInfoCollection filterInfoCollectionInBill;
        VideoCaptureDevice videoCaptureDeviceInBill;

        public long Total { get => Int64.Parse(labelTotalInBill.Text); set => labelTotalInBill.Text = value.ToString(); }
        public long Tax { get => Int64.Parse(labelTaxInBill.Text); set => labelTaxInBill.Text = value.ToString(); }
        public long Pay { get => Int64.Parse(labelPayInBill.Text); set => labelPayInBill.Text = value.ToString(); }
        public List<MProductBill> BillDetails { get => (List<MProductBill>)dataGridViewBillDetail.DataSource; set => dataGridViewBillDetail.DataSource = value; }
        public string FullName { get => labelCustomerNameInBill.Text; set => labelCustomerNameInBill.Text = value.ToString(); }
        public string Phone { get => labelCustomerPhoneInBill.Text; set => labelCustomerPhoneInBill.Text = value.ToString(); }
        public List<Model.Product> Products { get => (List<Model.Product>)dataGridViewProductInBill.DataSource; set => dataGridViewProductInBill.DataSource = value; }
        public string Search { get => textBoxSearchProductInBill.Text; set => textBoxSearchProductInBill.Text = value.ToString(); }
        public string CustomerId { get => labelCustomerId.Text; set => labelCustomerId.Text = value.ToString(); }
        public string CustomerFullName { get => labelCustomerNameInBill.Text; set => labelCustomerNameInBill.Text = value.ToString(); }

        public string CustomerPhone { get => labelCustomerPhoneInBill.Text; set => labelCustomerPhoneInBill.Text = value.ToString(); }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBoxQRScannerInBill.Image = (Bitmap)eventArgs.Frame.Clone();

            }
            catch (Exception e)
            {

            }
        }

        private void buttonGetCustomerInfoInBill_Click(object sender, EventArgs e)
        {
            panelCustomerProfile.Visible = false;
            panelQRScannerInBill.Visible = true;

            timerQRScannerInBill.Enabled = true;

            videoCaptureDeviceInBill = new VideoCaptureDevice(filterInfoCollectionInBill[comboBoxQRScannerInBill.SelectedIndex].MonikerString);
            videoCaptureDeviceInBill.NewFrame += FinalFrame_NewFrame;
            videoCaptureDeviceInBill.Start();
            timerQRScannerInBill.Start();
        }

        private void dataGridViewProductInBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool found = false;
            Model.Product row = dataGridViewProductInBill.Rows[e.RowIndex].DataBoundItem as Model.Product;
            List<MProductBill> arr = (List<MProductBill>)BillDetails;
            foreach (MProductBill b in arr)
            {
                if (b.ProductId.Equals(row.Id.ToString()))
                {
                    b.Quantity += 1;
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MProductBill billDetail = new MProductBill();
                billDetail.ProductId = row.Id.ToString();
                billDetail.Price = (long)row.Price;
                billDetail.ProductName = row.Name;
                billDetail.Quantity = 1;
                arr.Add(billDetail);
            }
            BillDetails = arr.ToList<MProductBill>();
            presenter.CalculateTotal();
        }

        private void buttonCancelBill_Click(object sender, EventArgs e)
        {
            BillDetails = new List<MProductBill>();
            presenter.CalculateTotal();

        }

        private void buttonSearchProductInBill_Click(object sender, EventArgs e)
        {
            presenter.Search();
        }

        private void s_Click(object sender, EventArgs e)
        {
            presenter.Create();
            presenter.CalculateTotal();
        }

        private void formBill_Load(object sender, EventArgs e)
        {
            filterInfoCollectionInBill = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollectionInBill)
                comboBoxQRScannerInBill.Items.Add(Device.Name);
            comboBoxQRScannerInBill.SelectedIndex = 0;
            videoCaptureDeviceInBill = new VideoCaptureDevice();
        }

        private void timerQRScannerInBill_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Bitmap bitmap = (Bitmap)pictureBoxQRScannerInBill.Image;
            if (bitmap == null)
            {
                return;
            }

            Result result = Reader.Decode(bitmap);
            if (result != null)
            {
                presenter.GetCustomerById(Int32.Parse(result.Text));
                videoCaptureDeviceInBill.Stop();
                panelQRScannerInBill.Visible = false;
                panelCustomerProfile.Visible = true;
            }
                
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            videoCaptureDeviceInBill.Stop();

            this.CustomerId = "";
            this.CustomerFullName = "";
            this.CustomerPhone = "";

            panelQRScannerInBill.Visible = false;
            panelCustomerProfile.Visible = true;
        }

        private void dataGridViewBillDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewBillDetail_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            presenter.CalculateTotal();
        }
    }
}
