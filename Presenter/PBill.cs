using shop_qr.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Presenter
{
    class PBill
    {
        private IBill view;

        public PBill(IBill view)
        {
            this.view = view;
        }

        public void ReadProduct()
        {
            view.Products = Model.MProduct.Read();
        }
    }
}
