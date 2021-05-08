using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class MBill
    {
        public static Bill Create(string customerId, List<MProductBill> list)
        {
            DataShopDataContext db = new DataShopDataContext();
            Bill bill = new Bill();
            bill.CustomerId = Int32.Parse(customerId);
            bill.CreatedAt = new DateTime();
            db.Bills.InsertOnSubmit(bill);
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
