using System;
using System.Collections.Generic;
using System.Windows.Forms;
using shop_qr.Presenter;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace shop_qr.View.Customer
{
    public partial class Customer : Form, ICustomer
    {
        private PCustomer presenter;

        public Customer()
        {
            InitializeComponent();
            presenter = new PCustomer(this);
            presenter.Read();
        }

        public string Id { get => labelCustomerId.Text; set => labelCustomerId.Text = value.ToString(); }
        public string FullName { get => textBoxCustomerName.Text; set => textBoxCustomerName.Text = value.ToString(); }
        public string Phone { get => textBoxCustomerPhone.Text; set => textBoxCustomerPhone.Text = value.ToString(); }
        public string Search { get => textBoxSearchCustomer.Text; set => textBoxSearchCustomer.Text = value.ToString(); }
        public List<Model.Customer> Customers { get => (List<Model.Customer>)dataGridViewCustomer.DataSource; set => dataGridViewCustomer.DataSource = value; }

        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {
        
            if (this.FullName.Length == 0 || this.Phone.Length == 0)
            {
                return;
            }
            
            if (this.Id.Length > 0)
            {
                presenter.Update();
            }
            else
            {
                presenter.Create();
                this.Id = "";
                this.FullName = "";
                this.Phone = "";
            }
            presenter.Read();
        }

        private void buttonCancelCustomer_Click(object sender, EventArgs e)
        {
            this.Id = "";
            this.FullName = "";
            this.Phone = "";
            pictureBoxShowQR.Image = null;
        }


        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Model.Customer row = dataGridViewCustomer.Rows[e.RowIndex].DataBoundItem as Model.Customer;
                this.FullName = row.FullName;
                this.Phone = row.Phone;
                this.Id = row.Id.ToString();
            }
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            presenter.Search();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            presenter.Delete();
            presenter.Read();  
            this.Id = "";
            this.FullName = "";
            this.Phone = "";
            pictureBoxShowQR.Image = null;
        }

        private void buttonPrintQR_Click(object sender, EventArgs e)
        {
            if(Id != null)
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBoxShowQR.Image = qrcode.Draw(Id, 1);
            }
            
        }
    }
}
