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
    public partial class AddProductView : Form, IViewForm
    {
        private MainForm mainForm;
        private DBContext ctx;

        public AddProductView(MainForm mainForm, DBContext ctx)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.ctx = ctx;
        }

        public void Init() { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.SetActiveForm(new StoreView(mainForm, ctx));
        }
    }
}
