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

        public string CustomerName { get => labelCustomerNameInHistory.Text; set => labelCustomerNameInHistory.Text = value.ToString(); }
        public string CustomerPhone { get => labelCustomerPhoneInHistory.Text; set => labelCustomerPhoneInHistory.Text = value.ToString(); }
        public List<Model.Bill> Bills { get => (List<Model.Bill>)dataGridViewBillHistory.DataSource; set => dataGridViewBillHistory.DataSource = value; }
        public List<Model.MProductBill> Details { get => (List<Model.MProductBill>)dataGridViewBillDetailHistory.DataSource; set => dataGridViewBillDetailHistory.DataSource = value; }

        private void dataGridViewBillHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Model.Bill row = dataGridViewBillHistory.Rows[e.RowIndex].DataBoundItem as Model.Bill;
                Console.WriteLine("ROw id " + row.Id);
                presenter.ReadDetail(row.Id);
            }
        }

        private void buttonGetCustomerInfoInHistory_Click(object sender, EventArgs e)
        {
            new View.QRScanner.formQRScanner().ShowDialog();
        }
    }
}
