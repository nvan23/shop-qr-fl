using System;
using System.Collections.Generic;
using System.Windows.Forms;
using shop_qr.Presenter;

namespace shop_qr.View.Customer
{
    public partial class Customer : Form, ICustomer
    {
        private PCustomer presenter;

        public Customer()
        {
            InitializeComponent();
            presenter = new PCustomer(this);
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
    }
}
