using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.View
{
    class ProductModel
    {
        private int id { get; set; }
        private string name { get; set; }
        private int price { get; set; }

        public ProductModel()
        {

        }
        public ProductModel(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

    }
}
