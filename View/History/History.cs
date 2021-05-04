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

namespace shop_qr.View
{
    public partial class History : Form, IHistory
    {
        public History()
        {
            InitializeComponent();
        }

        public string CustomerName { get => labelCustomerNameInHistory.Text; set => labelCustomerNameInHistory.Text = value.ToString(); }
        public string CustomerPhone { get => labelCustomerPhoneInHistory.Text; set => labelCustomerPhoneInHistory.Text = value.ToString(); }
        public List<Model.Bill> Bills { get => (List<Model.Bill>)dataGridViewBillHistory.DataSource; set => dataGridViewBillHistory.DataSource = value; }
        public List<Model.BillDetail> Details { get => (List<Model.BillDetail>)dataGridViewBillDetailHistory.DataSource; set => dataGridViewBillDetailHistory.DataSource = value; }
    }
}
