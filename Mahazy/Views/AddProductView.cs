﻿using Mahazy.Models;
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

        public void Init()
        {
            txtPrice.Maximum = decimal.MaxValue;
            txtAmt.Maximum = decimal.MaxValue;

            previewPC.Seller = "you";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.SetActiveView(new StoreView(mainForm, ctx));
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            previewPC.Title = Utils.IsStringValid(txtTitle.Text) ? txtTitle.Text : "Titolo";
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            previewPC.Description = Utils.IsStringValid(txtDescription.Text) ? txtDescription.Text : "Descrizione";
        }

        private void txtPrice_ValueChanged(object sender, EventArgs e)
        {
            previewPC.Price = (double)txtPrice.Value;
        }

        private void txtAmt_ValueChanged(object sender, EventArgs e)
        {
            previewPC.Amount = (int)txtAmt.Value;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string desc = txtDescription.Text.Trim();
            float price = (float)txtPrice.Value;
            int amount = (int)txtAmt.Value;

            if (!Utils.IsStringValid(title))
            {
                Utils.ShowError("Inserisci il titolo!");
                Utils.FocusControl(txtTitle);
                return;
            }
            if (!Utils.CheckStringLength(title, 3, 64))
            {
                Utils.ShowError("Il nome può avere dai 3 ai 64 caratteri!");
                Utils.FocusControl(txtTitle);
                return;
            }

            Prodotto p = new Prodotto();
            p.Nome = title;
            p.Descrizione = desc;
            p.Prezzo = price;
            p.Quantita = amount;
            p.IdUtente = Utils.Session.IdUtente;

            try
            {
                ctx.AddProdotto(p);
                Utils.ShowInfo("Prodotto aggiunto!");
            }
            catch (Exception)
            {
                Utils.ShowError("Qualcosa è andato storto! Riprovare più tardi :/");
            }
            mainForm.SetActiveView(new StoreView(mainForm, ctx));
        }
    }
}
