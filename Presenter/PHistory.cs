using shop_qr.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Presenter
{
    class PHistory
    {
        private IHistory view;
        public PHistory(IHistory view)
        {
            this.view = view;
        }
        public void Read()
        {
            view.Bills = Model.MBill.Read();
        }
        public void ReadByCustomerId(int Id)
        {
            view.Bills = Model.MBill.ReadByCustomerId(Id);
        }
        public void ReadDetail(int Id)
        {
            view.Details = Model.MBill.ReadDetail(Id);
        }
        public void CalculateTotal()
        {
            long sum = 0;
            List<Model.MProductBill> list = view.Details;
            foreach (Model.MProductBill p in list)
            {
                sum += p.Quantity * p.Price;
            }
            view.Tax = ((int)(sum * 0.1));
            view.Total = sum;
            view.Pay = sum + (long)(sum * 0.1);
        }
        public void GetCustomerById(int Id)
        {
            Model.Customer customer = Model.MCustomer.GetById(Id);
            view.CustomerId = customer.Id.ToString();
            view.CustomerName = customer.FullName;
            view.CustomerPhone = customer.Phone;
        }

    }
}
