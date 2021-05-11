using shop_qr.View;
using System;
using System.IO;

namespace shop_qr.Presenter
{
    class PProduct
    {
        private IProduct view;

        public PProduct(IProduct view)
        {
            this.view = view;
        }

        public void Create()
        {
            Model.Product product = new Model.Product();
            
            product.Name = view.Name;
            product.Price = Decimal.Parse(view.Price);
            MemoryStream ms = new MemoryStream();
            view.ProductImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            product.Image = new System.Data.Linq.Binary(ms.ToArray());
            Model.MProduct.Create(product);
        }

        public void Read()
        {
            view.Products = Model.MProduct.Read();
        }

        public void Search()
        {
            view.Products = Model.MProduct.Search(view.Search);
        }
        public void Update()
        {
            if (view.Id.Length > 0)
            {
                Model.Product product = new Model.Product();
                product.Id = Int32.Parse(view.Id);
                product.Name = view.Name;
                product.Price = Decimal.Parse(view.Price);

                MemoryStream ms = new MemoryStream();
                view.ProductImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                product.Image = new System.Data.Linq.Binary(ms.ToArray());
                Model.MProduct.Update(product);

            }
        }
        public void Delete()
        {
            if (view.Id.Length > 0)
            {
                Model.Product product = new Model.Product();
                product.Id = Int32.Parse(view.Id);
                product.Name = view.Name;
                product.Price = Decimal.Parse(view.Price);
                Model.MProduct.Delete(product);
            }
        }

    }
}
