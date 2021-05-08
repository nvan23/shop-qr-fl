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
            bill.CreatedAt = DateTime.Now;

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
            Console.WriteLine("asdasdsadasdsd",list.Count);
            return list;

        }        
        public static List<Bill> ReadByCustomer(Customer customer)
        {
            DataShopDataContext db = new DataShopDataContext();
            List<Bill> list = db.Bills.Where(b=>b.CustomerId == customer.Id).ToList();
            return list;
        }
        public static List<MProductBill> ReadDetail(int Id)
        {
            List<MProductBill> r = new List<MProductBill>();
            DataShopDataContext db = new DataShopDataContext();
            List<BillDetail> list = db.BillDetails.Where(b => b.BillId == Id).ToList();
            Console.WriteLine("List infor" + list.Count);

            foreach (BillDetail b in list)
            {
                MProductBill m = new MProductBill();
                m.ProductId = b.ProductId.ToString();
                m.ProductName = b.Product.Name;
                m.Quantity = (int)b.Quantity;
                m.Price = (int)b.ProductPrice;
                r.Add(m);
            }
            return r;
        }
    }
}
