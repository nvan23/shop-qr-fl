using shop_qr.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Presenter
{
    class PBill
    {
        private IBill view;

        public PBill(IBill view)
        {
            this.view = view;
        }

        public void Create()
        {
            
            List<Model.MProductBill> list = view.BillDetails;
            String customerId = view.CustomerId; 
            if (list.Count ==0 || customerId.Length == 0)
            {
                return;
            }
           

            bool isDone = Model.MBill.Create(customerId, list);
            if (isDone)
            {
                view.BillDetails = new List<Model.MProductBill>();
            }
        }
        public void ReadProduct()
        {
            view.Products = Model.MProduct.Read();
        }
        public void CalculateTotal()
        {
            
            int sum = 0;
            List<Model.MProductBill> list = view.BillDetails;
            foreach (Model.MProductBill p in list)
            {
                sum += p.Quantity * p.Price;
            }
            view.Tax = ((int)(sum * 0.1));
            view.Total = sum;
            view.Pay = sum + (int)(sum * 0.1);
        }
        public void Search()
        {
            view.Products = Model.MProduct.Search(view.Search);
        }
        public void  GetCustomerById(int Id)
        {
            Model.Customer customer = Model.MCustomer.GetById(Id);
            Console.WriteLine(customer.FullName);
            if(customer == null)
            {
                return;
            }
            view.CustomerId = customer.Id.ToString();
            view.CustomerFullName = customer.FullName;
            view.CustomerPhone = customer.Phone;
        }
    }
}
