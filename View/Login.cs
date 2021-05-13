using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop_qr.View
{
    public partial class Login : Form, ILogin
    {
        public string Username { get => textBoxUsername.Text; set => textBoxUsername.Text = value.ToString(); }
        public string Password { get => textBoxUsername.Text; set => textBoxPassword.Text = value.ToString(); }

        public Login()
        {
            InitializeComponent();
       
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Presenter.PManager presenter = new Presenter.PManager(this);
            if (presenter.Verify())
            {
                new AppLayout().Show();
            }
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
