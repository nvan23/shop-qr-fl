using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_qr
{
    public partial class Layout : Form
    {
        public Layout()
        {
            InitializeComponent();
            formDockLayout.SubscribeControlToDragEvents(panelLayoutTabs);
            formDockLayout.SubscribeControlToDragEvents(panelProfile);
        }

        private void buttonExitTab_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBillTab_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            pageContent.SetPage("Bill");
        }

        private void buttonProductTab_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            pageContent.SetPage("Product");
        }

        private void buttonCustomerTab_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            pageContent.SetPage("Customer");
        }

        private void buttonLogoutTab_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
        }
    }
}
