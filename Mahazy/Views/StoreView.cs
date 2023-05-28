using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mahazy.MainForm;

namespace Mahazy.Views
{
    public partial class StoreView : Form
    {
        private MainForm mainForm;
        private DatabaseContext ctx;

        public StoreView(MainForm mainForm, DatabaseContext ctx)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.ctx = ctx;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Utils.DeleteCredFile();

            mainForm.SetActiveForm(new LoginView(mainForm, ctx));
        }

        private void RefreshProductList()
        {
            productContainer.Controls.Clear();

            // TODO: Aggiungere le query
        }
    }
}
