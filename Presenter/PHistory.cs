using shop_qr.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.Presenter
{
    class PHistory
    {
        private IHistory view;
        public PHistory(IHistory view)
        {
            this.view = view;
        }
        public void Read()
        {
            view.Bills = Model.MBill.Read();
        }
        public void ReadDetail(int Id)
        {
            view.Details = Model.MBill.ReadDetail(Id);
        }

    }
}
