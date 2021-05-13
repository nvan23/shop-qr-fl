using shop_qr.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace shop_qr.View.Product
{
    public partial class formProduct : Form, IProduct
    {
        PProduct presenter;
        public formProduct()
        {
            InitializeComponent();
            presenter = new PProduct(this);
            presenter.Read();
        }
        public string Id { get =>labelProductID.Text; set => labelProductID.Text = value.ToString(); }
        public string Search { get => textBoxSearchProduct.Text; set => textBoxSearchProduct.Text = value.ToString(); }
        public string Name { get => textBoxProductName.Text; set => textBoxProductName.Text = value.ToString(); }
        public string Price { get => textBoxProductPrice.Text; set => textBoxProductPrice.Text = value.ToString(); }
        public List<Model.Product> Products { get => (List<Model.Product>)dataGridViewProduct.DataSource; set => dataGridViewProduct.DataSource = value; }
        public Bitmap ProductImage { get => (Bitmap)pictureBoxProductImage.Image; set => pictureBoxProductImage.Image = value; }
        public string ProductImagePath { get => textBoxProductImagePath.Text; set => textBoxProductImagePath.Text = value.ToString(); }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {
           

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
                this.ProductImage = null;
                this.ProductImagePath = "";
            }
            presenter.Read();
        }

        private void dataGridViewProduct_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               
                Model.Product row = dataGridViewProduct.Rows[e.RowIndex].DataBoundItem as Model.Product;
                this.Name = row.Name;
                this.Price = ((long)row.Price).ToString();
                this.Id = row.Id.ToString();
                MemoryStream ms = new MemoryStream(row.Image.ToArray());
                this.ProductImage = (Bitmap)Bitmap.FromStream(ms);
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
            this.Name = "";
            this.Price = "";
            this.ProductImage = null;
            this.ProductImagePath = "";
            presenter.Read();
        }

        private void buttonCancelProduct_Click(object sender, EventArgs e)
        {
            this.Id = "";
            this.Name = "";
            this.Price = "";
            this.ProductImage = null;
            this.ProductImagePath = "";
            buttonUploadProductImage.Text = "Thêm hình ảnh";
        }

        private void buttonUploadProductImage_Click(object sender, EventArgs e)
        {
            try
            {
                // open file dialog
                OpenFileDialog open = new OpenFileDialog();
                // image filters
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box
                    ProductImage = new Bitmap(open.FileName);
                    Console.WriteLine("Size of image "+ProductImage.Size);
                    // image file path
                    ProductImagePath = open.FileName;

                    buttonUploadProductImage.Text = "Đổi ảnh";
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Hình ảnh không thể hiển thị lúc này");
            }
        }
    }
}
    