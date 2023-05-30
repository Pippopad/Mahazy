using Mahazy.Components;
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
            lblWelcome.Text = $"Benvenuto {Utils.Session.Nome} {Utils.Session.Cognome} ({Utils.Session.Username})";
            RefreshProductsList();
        }

        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            mainForm.SetActiveForm(new OrdersView(mainForm, ctx));
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

        private void RefreshProductsList()
        {
            productContainer.Controls.Clear();

            var prods = ctx.GetProdottiAvailable();

            foreach (var p in prods)
            {
                ProductComponent pc = new ProductComponent();
                pc.Prodotto = p;
                pc.Title = p.Nome;
                pc.Description = p.Descrizione;
                pc.Price = p.Prezzo;
                pc.Seller = p.Venditore.Username;
                pc.Amount = p.Quantita;

                if (p.Venditore.Username == Utils.Session.Username)
                {
                    pc.BackColor = Utils.OwnContentBackgroundColor;
                    pc.ShowRemove = true;
                    pc.OnRemoveClicked += RemoveProduct;
                }

                pc.Click += OnProductClick;

                productContainer.Controls.Add(pc);
            }
        }

        private void OnProductClick(object sender, EventArgs e)
        {
            mainForm.SetActiveForm(new DetailsView(mainForm, ctx, (sender as ProductComponent).Prodotto));
        }

        private void RemoveProduct(object sender, EventArgs e)
        {
            ctx.RemoveProdotto((sender as ProductComponent).Prodotto);
            RefreshProductsList();
        }
    }
}
