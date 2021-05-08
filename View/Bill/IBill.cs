using System.Collections.Generic;
using shop_qr.Model;

namespace shop_qr.View
{
    interface IBill
    {
        int Total { get; set; }
        int Tax { get; set; }
        int Pay { get; set; }
        List<Model.Product> Products { get; set; }
        List<MProductBill> BillDetails { get; set; }
        string Search { get; set; }
        string CustomerId { get; set; }
        string CustomerFullName { get; set; }
        string CustomerPhone { get; set; }
    }
}
