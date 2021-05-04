using System.Collections.Generic;
using shop_qr.Model;

namespace shop_qr.View
{
    interface IBill
    {
        int Total { get; set; }
        int Tax { get; set; }
        int Pay { get; set; }
        int CustomerPay { get; set; }
        int Balance { get; set; }
        List<Model.Product> Products { get; set; }
        List<Model.BillDetail> BillDetails { get; set; }
    }
}
