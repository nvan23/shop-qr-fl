using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_qr.View
{
    public partial class AppLayout : Form
    {
        public AppLayout()
        {
            InitializeComponent();

            this.panelFormLoader.Controls.Clear();
            View.Bill.formBill FormCustomer_Vrb = new View.Bill.formBill() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormCustomer_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormCustomer_Vrb);
            FormCustomer_Vrb.Show();
        }

        private void buttonBillTab_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;

            this.panelFormLoader.Controls.Clear();
            View.Bill.formBill FormCustomer_Vrb = new View.Bill.formBill() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormCustomer_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormCustomer_Vrb);
            FormCustomer_Vrb.Show();
        }

        private void buttonExitTab_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonProductTab_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;

            this.panelFormLoader.Controls.Clear();
            View.Product.formProduct FormCustomer_Vrb = new View.Product.formProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormCustomer_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormCustomer_Vrb);
            FormCustomer_Vrb.Show();
        }

        private void buttonCustomerTab_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;

            this.panelFormLoader.Controls.Clear();
            View.Customer.Customer FormCustomer_Vrb = new View.Customer.Customer() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormCustomer_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormCustomer_Vrb);
            FormCustomer_Vrb.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            this.panelFormLoader.Controls.Clear();
            View.History FormCustomer_Vrb = new View.History() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormCustomer_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FormCustomer_Vrb);
            FormCustomer_Vrb.Show();
        }

        private void buttonLogoutTab_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
        }
    }
}
