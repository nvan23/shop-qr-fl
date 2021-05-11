using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class MProduct
    {
        public static void Create(Product product)
        {
            DataShopDataContext db = new DataShopDataContext();
            db.Products.InsertOnSubmit(product);
            db.SubmitChanges();

        }
        public static List<Product> Read()
        {
            DataShopDataContext db = new DataShopDataContext();
            List<Product> list = db.Products.ToList<Product>();
            return list;

        }
        public static void Update(Product product)
        {
            DataShopDataContext db = new DataShopDataContext();
            Product _product = db.Products.FirstOrDefault(e => e.Id.Equals(product.Id));
            if (_product == null)
            {
                return;
            }
            _product.Name = product.Name;
            _product.Price = product.Price;
            _product.Image = product.Image;
            db.SubmitChanges();
        }

        public static void Delete(Product product)
        {
            DataShopDataContext db = new DataShopDataContext();
            Product _product = db.Products.FirstOrDefault(e => e.Id.Equals(product.Id));
            if (_product == null)
            {
                return;
            }
            db.Products.DeleteOnSubmit(_product);
            db.SubmitChanges();
        }
        public static List<Product> Search(string key)
        {
            List<Product> list = new List<Product>();
            DataShopDataContext db = new DataShopDataContext();
            if (key.Length > 0)
            {
                list = db.Products.Where<Product>(e =>
                    e.Name.Contains(key) ||
                    e.Price.ToString().Contains(key)
                ).ToList<Product>();
            }
            else
            {
                list = db.Products.ToList<Product>();

            }
            return list;
        }
    }
}
