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
    public partial class StoreView : Form
    {
        public StoreView()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Utils.DeleteCredFile();
            // TODO: Ritornare alla schermata di login
        }
    }
}
