using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Model
{
    class MMManager
    {
        public static void Create(MManager user)
        {
            DataShopDataContext db = new DataShopDataContext();
            db.Managers.InsertOnSubmit(user);
            db.SubmitChanges();

        }
        public static MManager Verify(MManager user)
        {
            DataShopDataContext db = new DataShopDataContext();
            MManager _user =  db.Managers.FirstOrDefault(u => u.Email.Equals(user.Email) && u.Password.Equals(user.Password)) ;
            return _user;

        }
       
    }
}
