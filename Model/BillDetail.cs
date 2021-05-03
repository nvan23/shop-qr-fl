using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class BillDetail
    {
        private int billId { get; set; }
        private int productId { get; set; }
        private int productPrice { get; set; }
        private int quantity { get; set; }
        public BillDetail()
        {

        }
        public BillDetail(int billId, int productId, int productPrice, int quantity)
        {
            this.billId = billId;
            this.productId = productId;
            this.productPrice = productPrice;
            this.quantity = quantity;
        }

        public static void Create(BillDetail obj)
        {

        }
        public static void Update(BillDetail obj)
        {

        }
        public static List<BillDetail> Read()
        {
            List<BillDetail> list = new List<BillDetail>();
            return list;
        }
        public static void Delete(BillDetail obj)
        {

        }

    }
}
