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
            if( manager.Email.Length > 0 && manager.Password.Length > 0)
            {
                DataShopDataContext db = new DataShopDataContext();
                Model.Manager mg =  db.Managers.FirstOrDefault<Manager>(m =>
                m.Email.Equals(manager.Email) &&
                m.Password.Equals(manager.Password)
                );
                if (mg == null)
                {
                    manager.Email = "admin";
                    manager.Password = "admin";
                    //
                    if( db.Managers.FirstOrDefault<Manager>(ma =>
                      ma.Email.Equals(manager.Email) &&
                      ma.Password.Equals(manager.Password)) == null
                    ){
                        db.Managers.InsertOnSubmit(manager);
                        db.SubmitChanges();
                        return false;
                    }
                  
                    return false;

                }
                return true;
            }
            return false;
           
        }

    }
}
