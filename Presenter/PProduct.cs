using shop_qr.View;

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
            product.Price = view.Price;
            Model.MProduct.Create(product);
        }

        public void Read()
        {
            view.Products =  Model.MProduct.Read();
        }

    }
}
