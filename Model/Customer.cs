using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class Customer
    {
        private int id { get; set; }
        private string name { get; set; }
        private string phone { get; set; }

        public Customer()
        {

        }
        public Customer(int id, string name, string phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }

        public static List<Customer> Read()
        {
            List<Customer> list = new List<Customer>();
            return list;
        }

        public static void Delete(Customer obj)
        {
        }

        public static void Create(Customer obj)
        {
        }

        public static void Update(Customer obj)
        {
        }
    }
}
