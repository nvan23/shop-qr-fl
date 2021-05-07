using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shop_qr.Presenter;

namespace shop_qr.View.Customer
{
    public partial class Customer : Form, ICustomer
    {
        private string SelectedId;
        public Customer()
        {
            InitializeComponent();
        }

        public string FullName { get => textBoxCustomerName.Text; set => textBoxCustomerName.Text = value.ToString(); }
        public string Phone { get => textBoxCustomerPhone.Text; set => textBoxCustomerPhone.Text = value.ToString(); }
        public List<Model.Customer> Customers { get => (List<Model.Customer>)dataGridViewCustomer.DataSource; set => dataGridViewCustomer.DataSource = value; }

        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {
            PCustomer presenter = new PCustomer(this);  
            presenter.Create();
            presenter.Read();
        }

        private void buttonCancelCustomer_Click(object sender, EventArgs e)
        {
            this.FullName = "";
            this.Phone = "";
        }


        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Model.Customer row = dataGridViewCustomer.Rows[e.RowIndex].DataBoundItem as Model.Customer;
                this.FullName = row.FullName;
                this.Phone = row.Phone;
            }
        }
    }
}
