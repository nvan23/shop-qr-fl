using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class MManager
    {
        public static void Create(Manager user)
        {
            DataShopDataContext db = new DataShopDataContext();
            db.Managers.InsertOnSubmit(user);
            db.SubmitChanges();

        }
        public static Manager Verify(Manager user)
        {
            DataShopDataContext db = new DataShopDataContext();
            Manager _user =  db.Managers.FirstOrDefault(u => u.Email.Equals(user.Email) && u.Password.Equals(user.Password)) ;
            return _user;

        }
       
    }
}
