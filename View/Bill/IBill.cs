using System.Collections.Generic;
using shop_qr.Model;

namespace shop_qr.View
{
    interface IBill
    {
        long Total { get; set; }
        long Tax { get; set; }
        long Pay { get; set; }
        List<Model.Product> Products { get; set; }
        List<MProductBill> BillDetails { get; set; }
        string Search { get; set; }
        string CustomerId { get; set; }
        string CustomerFullName { get; set; }
        string CustomerPhone { get; set; }
    }
}
