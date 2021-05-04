using System.Collections.Generic;
using shop_qr.Model;

namespace shop_qr.View
{
    interface ICustomer
    {
        string FullName { get; set; }
        string Phone { get; set; }
        List<Model.Customer> Customers { get; set; }
    }
}
