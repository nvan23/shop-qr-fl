using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shop_qr.View;

namespace shop_qr.View
{
    public partial class Splash : Form
    {
        Random randomTimer = new Random();
        public Splash()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (progressSplash.Value > 100)
            {
                timerSplash.Stop();
                this.Hide();
                new Login().Show();
                return;
            }
            try
            {
                progressSplash.Value += randomTimer.Next(1, 10);
            }
            catch (Exception)
            {
                timerSplash.Stop();
                this.Hide();
                new Login().Show();
            }
        }
    }
}
