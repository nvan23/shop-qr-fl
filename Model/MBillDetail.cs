using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class MBillDetail
    {
        public static void Create(List<BillDetail> billDetails)
        {
            DataShopDataContext db = new DataShopDataContext();
            db.BillDetails.InsertAllOnSubmit(billDetails);
            db.SubmitChanges();
        }

        public static List<BillDetail> Read(Bill bill)
        {
            DataShopDataContext db = new DataShopDataContext();
            List<BillDetail> list = db.BillDetails.Where(d => d.BillId == bill.Id).ToList();
            return list;

        }
    }
}
