using Mahazy.Components;
using Mahazy.Models;
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
    public partial class DetailsView : Form, IViewForm
    {
        private MainForm mainForm;
        private DBContext ctx;

        private Prodotto prodotto;

        public DetailsView(MainForm mainForm, DBContext ctx, Prodotto prodotto)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.ctx = ctx;
            this.prodotto = prodotto;
        }

        public void Init()
        {
            lblTitle.Text = prodotto.Nome;
            lblDescription.Text = prodotto.Descrizione;

            lblPrice.Text = $"Prezzo: {prodotto.Prezzo.ToString("0.00")} €";
            lblAmt.Text = $"Quantità: {prodotto.Quantita}";

            RefreshReviewsList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.SetActiveForm(new StoreView(mainForm, ctx));
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            string content = txtReview.Text.Trim();
            int rate = (int)txtRate.Value;

            if (!Utils.IsStringValid(content))
            {
                Utils.ShowError("Inserisci del testo!");
                Utils.FocusControl(txtReview);
                return;
            }

            Recensione r = new Recensione();
            r.IdUtente = Utils.Session.IdUtente;
            r.IdProdotto = prodotto.IdProdotto;
            r.Contenuto = content;
            r.NumeroStelle = rate;

            try
            {
                ctx.AddRecensione(r);
                RefreshReviewsList();
            }
            catch (Exception)
            {
                Utils.ShowError("Qualcosa è andato storto! Riprovare più tardi :/");
            }
        }

        void RefreshReviewsList()
        {
            var reviews = ctx.GetRecensioni(prodotto);

            reviewsContainer.Controls.Clear();

            foreach (var r in reviews)
            {
                ReviewComponent rc = new ReviewComponent();
                rc.Recensione = r;
                rc.Author = r.Autore.Username;
                rc.Description = r.Contenuto;
                rc.Rate = r.NumeroStelle;

                rc.Width = reviewsContainer.Width - 3 * 3;

                if (r.Autore.Username == Utils.Session.Username)
                {
                    rc.BackColor = Utils.OwnContentBackgroundColor;
                    rc.ContentBackground = Utils.OwnContentBackgroundColor;
                    rc.ShowRemove = true;

                    rc.OnRemoveClicked += RemoveReview;
                }

                reviewsContainer.Controls.Add(rc);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            // Funzione molto semplice perchè
            // sono too lazy per farla :)
            if (prodotto.Quantita > 0)
            {
                prodotto.Quantita--;
                ctx.UpdateProdotto(prodotto);
                ctx.AddOrdine(new Ordina { IdUtente = Utils.Session.IdUtente, IdProdotto = prodotto.IdProdotto });
                Utils.ShowInfo("Acquistato!");
                mainForm.SetActiveForm(new DetailsView(mainForm, ctx, prodotto));
            }
            else
            {
                Utils.ShowWarn("Scorte terminate!");
            }
        }

        private void RemoveReview(object sender, EventArgs e)
        {
            ctx.RemoveRecensione((sender as ReviewComponent).Recensione);
            RefreshReviewsList();
        }
    }
}
