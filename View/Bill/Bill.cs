using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shop_qr.Model;
using shop_qr.View;

namespace shop_qr.View.Bill
{
    public partial class formBill : Form, IBill
    {
        public formBill()
        {
            InitializeComponent();
        }

        public int Total { get => Int32.Parse(labelTotalInBill.Text); set => labelTotalInBill.Text = value.ToString(); }
        public int Tax { get => Int32.Parse(labelTaxInBill.Text); set => labelTaxInBill.Text = value.ToString(); }
        public int Pay { get => Int32.Parse(labelPayInBill.Text); set => labelPayInBill.Text = value.ToString(); }
        public int CustomerPay { get => Int32.Parse(labelCustomerPayInBill.Text); set => labelCustomerPayInBill.Text = value.ToString(); }
        public int Balance { get => Int32.Parse(labelBalanceInBill.Text); set => labelBalanceInBill.Text = value.ToString(); }
        public List<BillDetail> BillDetails { get => (List<BillDetail>)dataGridViewBillDetail.DataSource; set => dataGridViewBillDetail.DataSource = value; }
        public string FullName { get => labelCustomerNameInBill.Text; set => labelCustomerNameInBill.Text = value.ToString(); }
        public string Phone { get => labelCustomerPhoneInBill.Text; set => labelCustomerPhoneInBill.Text = value.ToString(); }
        public List<Model.Product> Products { get => (List<Model.Product>)dataGridViewProductInBill.DataSource; set => dataGridViewProductInBill.DataSource = value; }
    }
}
