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

        public void Create()
        {
            Model.Customer customer = new Model.Customer();
            customer.FullName = view.FullName;
            customer.Phone = view.Phone;
            Model.MCustomer.Create(customer);
        }

        public void Read()
        {
            view.Customers =  Model.MCustomer.Read();
        }

    }
}
