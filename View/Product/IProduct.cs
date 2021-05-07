using System.Collections.Generic;
using shop_qr.Model;

namespace shop_qr.View
{
    public interface IProduct
    {
        string Id { get; set; }
        string Search { get; set; }
        string Name { get; set; }
        string Price { get; set; }
        List<Model.Product> Products { get; set; }
    }
}
