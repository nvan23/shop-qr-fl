using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class MCustomer
    {
        public void Create(Customer customer)
        {
            DataShopDataContext db = new DataShopDataContext();
            db.Customers.InsertOnSubmit(customer);
            db.SubmitChanges();

        }
        public List<Customer> Read()
        {
            DataShopDataContext db = new DataShopDataContext();
            List<Customer> list = db.Customers.ToList<Customer>();
            return list;

        }
        public void Update(Customer customer)
        {
            DataShopDataContext db = new DataShopDataContext();
            Customer _customer = db.Customers.FirstOrDefault(e => e.Id.Equals(customer.Id));
            _customer.FullName = customer.FullName;
            _customer.Phone = customer.Phone;
            db.SubmitChanges();
        }

        public void Delete(Customer customer)
        {
            DataShopDataContext db = new DataShopDataContext();
            Customer _customer = db.Customers.FirstOrDefault(e => e.Id.Equals(customer.Id));
            db.Customers.DeleteOnSubmit(_customer);
            db.SubmitChanges();
        }
    }
}
