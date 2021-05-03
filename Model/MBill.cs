using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class MBill
    {
        public static Bill Create(Bill bill)
        {
            DataShopDataContext db = new DataShopDataContext();
            db.Bills.InsertOnSubmit(bill);
            db.SubmitChanges();
            return bill;
            
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
