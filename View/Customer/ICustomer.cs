using System.Collections.Generic;
using shop_qr.Model;

namespace shop_qr.View
{
    interface ICustomer
    {
        string Id { get; set; }
        string FullName { get; set; }
        string Phone { get; set; }
        
        string Search { get; set; }
        List<Model.Customer> Customers { get; set; }
    }
}
