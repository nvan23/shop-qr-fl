using System.Collections.Generic;
using shop_qr.Model;
using System.Drawing;

namespace shop_qr.View
{
    public interface IProduct
    {
        string Id { get; set; }
        string Search { get; set; }
        string Name { get; set; }
        string Price { get; set; }
        Bitmap ProductImage { get; set; }
        string ProductImagePath { get; set; }
        List<Model.Product> Products { get; set; }
    }
}
