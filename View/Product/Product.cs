using shop_qr.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_qr.View.Product
{
    public partial class formProduct : Form, IProduct
    {
        public formProduct()
        {
            InitializeComponent();
        }
        public string Name { get => textBoxProductName.Text; set => textBoxProductName.Text = value.ToString(); }
        public int Price { get => Int32.Parse(textBoxProductPrice.Text); set => textBoxProductPrice.Text = value.ToString(); }
        public List<Model.Product> Products { get => (List<Model.Product>)dataGridViewProduct.DataSource; set => dataGridViewProduct.DataSource = value; }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
            PProduct presenter = new PProduct(this);
            presenter.Create();
            presenter.Read();
        }

        private void dataGridViewProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
