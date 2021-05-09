using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class MManger
    {
        public static bool Verify(Model.Manager manager)
        {
            DataShopDataContext db = new DataShopDataContext();
            return db.Managers.First<Manager>(m =>
            m.Email.Equals(manager.Email) &&
            m.Password.Equals(manager.Password)
            ) != null; 
        }

    }
}
