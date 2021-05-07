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
        PProduct presenter;
        public formProduct()
        {
            InitializeComponent();
            presenter = new PProduct(this);
        }
        public string Id { get =>labelProductID.Text; set => labelProductID.Text = value.ToString(); }
        public string Search { get => textBoxSearchProduct.Text; set => textBoxSearchProduct.Text = value.ToString(); }
        public string Name { get => textBoxProductName.Text; set => textBoxProductName.Text = value.ToString(); }
        public string Price { get => textBoxProductPrice.Text; set => textBoxProductPrice.Text = value.ToString(); }
        public List<Model.Product> Products { get => (List<Model.Product>)dataGridViewProduct.DataSource; set => dataGridViewProduct.DataSource = value; }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
            if (this.Name.Length == 0 || this.Price.Length == 0)
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
                this.Name = "";
                this.Price = "";
            }
           
            presenter.Read();
        }

        private void dataGridViewProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Model.Product row = dataGridViewProduct.Rows[e.RowIndex].DataBoundItem as Model.Product;
                this.Name = row.Name;
                this.Price = row.Price.ToString();
                this.Id = row.Id.ToString();
            }
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            presenter.Search();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            presenter.Delete();
            this.Id = "";
            presenter.Read();
        }
    }
}
    