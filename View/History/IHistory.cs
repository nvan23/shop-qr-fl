using System.Collections.Generic;
using shop_qr.Model;

namespace shop_qr.View
{
    public interface IHistory
    {
        string CustomerName { get; set; }
        string CustomerPhone { get; set; }
        List<Model.Bill> Bills { get; set; }
        List<Model.BillDetail> Details { get; set; }
    }
}
