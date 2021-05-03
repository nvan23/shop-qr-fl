using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shop_qr.View;
using shop_qr.Model;

namespace shop_qr
{
    public partial class Layout : Form
    {
       
        public Layout()
        {
            InitializeComponent();
            formDockLayout.SubscribeControlToDragEvents(panelLayoutTabs);
            formDockLayout.SubscribeControlToDragEvents(panelProfile);

            ProductModel[] arr = new ProductModel[5];
            arr[0] = new ProductModel(0, "Ban phim Logitech 0", 0);
            arr[1] = new ProductModel(1, "Ban phim Logitech 1", 1);
            arr[2] = new ProductModel(2, "Ban phim Logitech 2", 2);
            arr[3] = new ProductModel(3, "Ban phim Logitech 3", 3);
            arr[4] = new ProductModel(4, "Ban phim Logitech 4", 4);
            dataGridViewProductToAdd.DataSource = arr;
       
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

        private void getProfileCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
