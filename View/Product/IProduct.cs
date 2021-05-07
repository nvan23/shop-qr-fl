using System.Collections.Generic;
using shop_qr.Model;

namespace shop_qr.View
{
    public interface IProduct
    {
        string Name { get; set; }
        int Price { get; set; }
        List<Model.Product> Products { get; set; }
    }
}
