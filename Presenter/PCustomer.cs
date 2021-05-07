using shop_qr.View;
using System;

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

        public void Search()
        {
            view.Customers = Model.MCustomer.Search(view.Search);
        }
        public void Update()
        {
            if(view.Id.Length > 0)
            {
                Model.Customer customer = new Model.Customer();
                customer.Id = Int32.Parse( view.Id);
                customer.FullName = view.FullName;
                customer.Phone = view.Phone;
                Model.MCustomer.Update(customer);

            }
        }

    }
}
