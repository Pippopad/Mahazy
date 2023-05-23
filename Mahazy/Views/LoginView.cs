using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahazy.Views
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnShowLogin_MouseDown(object sender, MouseEventArgs e)
        {
            txtPasswordLogin.UseSystemPasswordChar = false;
        }

        private void btnShowLogin_MouseUp(object sender, MouseEventArgs e)
        {
            txtPasswordLogin.UseSystemPasswordChar = true;
        }

        private void btnShowJoinUs_MouseDown(object sender, MouseEventArgs e)
        {
            txtPasswordLogin.UseSystemPasswordChar = false;
        }

        private void btnShowJoinUs_MouseUp(object sender, MouseEventArgs e)
        {
            txtPasswordLogin.UseSystemPasswordChar = true;
        }
    }
}
