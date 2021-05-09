using System.Collections.Generic;
using shop_qr.Model;

namespace shop_qr.View
{
    public interface IHistory
    {
        long Total { get; set; }
        long Tax { get; set; }
        long Pay { get; set; }
        string CustomerId { get; set; }
        string CustomerName { get; set; }
        string CustomerPhone { get; set; }
        List<Model.Bill> Bills { get; set; }
        List<Model.MProductBill> Details { get; set; }
    }
}
