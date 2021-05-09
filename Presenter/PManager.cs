using shop_qr.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_qr.Presenter
{   
    class PManager
    {
        private ILogin view;
        public PManager(ILogin view)
        {
            this.view = view;
        }
        public bool Verify()
        {
            if(this.view.Username.Length == 0 || this.view.Password.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi");
                return false;
            }
            Model.Manager user = new Model.Manager();
            user.Email = this.view.Username;
            user.Password = this.view.Password;
            return Model.MManger.Verify(user);          
        }

    }
}
