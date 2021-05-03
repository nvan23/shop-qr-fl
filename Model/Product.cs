using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class Product
    {
        private int id { get; set; }
        private string name { get; set; }
        private int price { get; set }
        
        public Product()
        {

        }
        
        public Product(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public static List<Product> Read()
        {
            List<Product> list = new List<Product>();
            return list;
        }

        public static void Delete(Product obj)
        {
        }

        public static void Create(Product obj)
        {
        }

        public static void Update(Product obj)
        {
        }
    }
}
