using shop_qr.Model;
using shop_qr.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

        public int Total { get => Int32.Parse(labelTotalInBill.Text); set => labelTotalInBill.Text = value.ToString(); }
        public int Tax { get => Int32.Parse(labelTaxInBill.Text); set => labelTaxInBill.Text = value.ToString(); }
        public int Pay { get => Int32.Parse(labelPayInBill.Text); set => labelPayInBill.Text = value.ToString(); }
        public int CustomerPay { get => Int32.Parse(labelCustomerPayInBill.Text); set => labelCustomerPayInBill.Text = value.ToString(); }
        public int Balance { get => Int32.Parse(labelBalanceInBill.Text); set => labelBalanceInBill.Text = value.ToString(); }
        public List<MProductBill> BillDetails { get => (List<MProductBill>)dataGridViewBillDetail.DataSource; set => dataGridViewBillDetail.DataSource = value; }
        public string FullName { get => labelCustomerNameInBill.Text; set => labelCustomerNameInBill.Text = value.ToString(); }
        public string Phone { get => labelCustomerPhoneInBill.Text; set => labelCustomerPhoneInBill.Text = value.ToString(); }
        public List<Model.Product> Products { get => (List<Model.Product>)dataGridViewProductInBill.DataSource; set => dataGridViewProductInBill.DataSource = value; }
        public string Search { get => textBoxSearchProductInBill.Text; set => textBoxSearchProductInBill.Text = value.ToString(); }
        private void buttonGetCustomerInfoInBill_Click(object sender, EventArgs e)
        {
            new View.QRScanner.formQRScanner().ShowDialog();
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
                billDetail.Price = (int)row.Price;
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
        }
    }
}
