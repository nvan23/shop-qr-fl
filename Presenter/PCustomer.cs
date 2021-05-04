using shop_qr.View;

namespace shop_qr.Presenter
{
    class PCustomer 
    {
        private ICustomer view;

        public PCustomer(ICustomer view)
        {
            this.view = view;
        }

        public void Create(Model.Customer customer)
        {
            Model.MCustomer.Create(customer);
        }

        public void Read()
        {
            view.Customers =  Model.MCustomer.Read();
        }

    }
}
