using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class MBill
    {
        public static bool Create(string Id, List<MProductBill> list)
        {
            int customerId = Int32.Parse(Id);
            DataShopDataContext db = new DataShopDataContext();
            

            Customer customer = (Customer)db.Customers.FirstOrDefault<Customer>(e => e.Id == customerId);
            if(customer == null)
            {
                return false;
            }
            Bill bill = new Bill();
            bill.Customer = customer;
            bill.CustomerId = customerId;

            db.Bills.InsertOnSubmit(bill);
            db.SubmitChanges();
            foreach ( MProductBill bd in list)
            {
                BillDetail billDetail = new BillDetail();
                billDetail.BillId = bill.Id;
                billDetail.ProductId = Int32.Parse(bd.ProductId);
                billDetail.Quantity = bd.Quantity;
                billDetail.ProductPrice = bd.Price;
                db.BillDetails.InsertOnSubmit(billDetail);
            }
            db.SubmitChanges();

            return true;
            
        }
        public static List<Bill> Read()
        {
            DataShopDataContext db = new DataShopDataContext();
            List<Bill> list = db.Bills.ToList<Bill>();
            return list;

        }        
        public static List<Bill> ReadByCustomer(Customer customer)
        {
            DataShopDataContext db = new DataShopDataContext();
            List<Bill> list = db.Bills.Where(b=>b.CustomerId == customer.Id).ToList();
            return list;
        }
    }
}
