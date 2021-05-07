using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop_qr.View.QRScanner
{
    interface IQRScanner
    {
        string Fullname { get; set; }
        string Phone { get; set; }
    }
}
