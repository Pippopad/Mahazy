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
    public partial class StoreView : Form, IViewForm
    {
        private MainForm mainForm;
        private DBContext ctx;

        public StoreView(MainForm mainForm, DBContext ctx)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.ctx = ctx;
        }

        public void Init()
        {
            RefreshProductList();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Utils.DeleteCredFile();

            mainForm.SetActiveForm(new LoginView(mainForm, ctx));
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            mainForm.SetActiveForm(new AddProductView(mainForm, ctx));
        }

        private void RefreshProductList()
        {
            productContainer.Controls.Clear();

            var prods = ctx.GetProdotti();

            foreach (var p in prods)
            {
                ProductComponent pc = new ProductComponent();
                pc.Title = p.Nome;
                pc.Description = p.Descrizione;
                pc.Price = p.Prezzo;
                pc.Seller = p.Venditore.Username;

                productContainer.Controls.Add(pc);
            }
        }
    }
}
