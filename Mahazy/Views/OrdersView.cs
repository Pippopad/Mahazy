using Mahazy.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahazy.Views
{
    public partial class OrdersView : Form, IViewForm
    {
        private MainForm mainForm;
        private DBContext ctx;

        public OrdersView(MainForm mainForm, DBContext ctx)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.ctx = ctx;
        }

        public void Init()
        {
            RefreshOrdersList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.SetActiveView(new StoreView(mainForm, ctx));
        }

        private void RefreshOrdersList()
        {
            ordersContainer.Controls.Clear();

            var orders = ctx.GetOrders(Utils.Session);

            foreach (var o in orders)
            {
                OrderComponent oc = new OrderComponent();
                oc.Ordina = o;
                oc.Id = o.IdOrdine;
                oc.Title = o.Prodotto.Nome;
                oc.Price = o.Prodotto.Prezzo;

                oc.Width = ordersContainer.Width - 3 * 3;

                oc.Click += OnOrderClick;

                ordersContainer.Controls.Add(oc);
            }
        }

        private void OnOrderClick(object sender, EventArgs e)
        {
            mainForm.SetActiveView(new DetailsView(mainForm, ctx, (sender as OrderComponent).Ordina.Prodotto));
        }
    }
}
