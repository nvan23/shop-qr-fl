using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class Bill 
    {
        private int id { get; set; }
        private int customerId { get; set; }
        private DateTime createdAt { get; set; }

        public static void Create(Bill obj)
        {
         }

        public static void Delete(Bill obj)
        {
        }

        public static List<Bill> Read()
        {
            List<Bill> list = new List<Bill>();
            return list;
        }

        public static void Update(Bill obj)
        {
        }
    }
}
