using Mahazy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahazy
{
    public partial class ProductComponent : UserControl
    {
        public event EventHandler OnRemoveClicked;

        public Prodotto Prodotto { get; set; }

        private string title = "Title";
        public string Title
        {
            get => title;
            set
            {
                title = value;
                if (value.Length > 24)
                    lblTitle.Text = Utils.CompressString(value, 24);
                else
                    lblTitle.Text = value;
            }
        }

        private string description = "Description";
        public string Description
        {
            get => description;
            set
            {
                description = value;
                if (value.Length > 140)
                    lblDescription.Text = value.Substring(0, 140 - 3) + "...";
                else
                    lblDescription.Text = value;
            }
        }

        private double price = 0.00;
        public double Price
        {
            get => price;
            set
            {
                price = value;
                UpdatePrice();
            }
        }

        private string currency = "€";
        public string Currency
        {
            get => currency;
            set
            {
                currency = value;
                UpdatePrice();
            }
        }

        public enum CurrencyPos
        { LEFT, RIGHT }

        private CurrencyPos currencyPosition = CurrencyPos.RIGHT;
        public CurrencyPos CurrencyPosition
        {
            get => currencyPosition;
            set
            {
                currencyPosition = value;
                UpdatePrice();
            }
        }

        private string seller = "user";
        public string Seller
        {
            get => seller;
            set
            {
                seller = value;
                if (value.Length > 14)
                {
                    lblSeller.Text = "By " + Utils.CompressString(value, 14);
                }
                else
                    lblSeller.Text = "By " + value;
            }
        }

        private bool showRemove = false;
        public bool ShowRemove
        {
            get => showRemove;
            set
            {
                showRemove = value;
                if (ShowRemove)
                {
                    btnRemove.Enabled = true;
                    btnRemove.Visible = true;
                    lblSeller.Visible = false;
                    lblSeller.Enabled = false;
                }
                else
                {
                    btnRemove.Enabled = false;
                    btnRemove.Visible = false;
                    lblSeller.Visible = true;
                    lblSeller.Enabled = true;
                }
            }
        }

        private int amount = 1;
        public int Amount
        {
            get => amount;
            set
            {
                amount = value;
                lblAmt.Text = $"Quantità: {Amount}";
            }
        }

        public ProductComponent()
        {
            InitializeComponent();

            WireAllControls(this);
            btnRemove.Click -= ctl_Click;
        }

        private void UpdatePrice()
        {
            if (CurrencyPosition == CurrencyPos.LEFT)
                lblPrice.Text = $"{Currency} {Price.ToString("0.00")}";
            else
                lblPrice.Text = $"{Price.ToString("0.00")} {Currency}";
        }

        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void ctl_Click(object sender, EventArgs e)
        {
            this.InvokeOnClick(this, EventArgs.Empty);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OnRemoveClicked.Invoke(this, new EventArgs());
        }
    }
}
