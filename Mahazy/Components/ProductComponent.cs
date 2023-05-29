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
                if (value.Length > 62)
                    lblDescription.Text = Utils.CompressString(value, 62);
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

        private bool showBuyRemove = false;

        public bool ShowBuyRemove
        {
            get => showBuyRemove;
            set
            {
                showBuyRemove = value;
                btnBuyRemove.Enabled = showBuyRemove;
                btnBuyRemove.Visible = showBuyRemove;
            }
        }

        private bool buyView = false;

        public bool BuyView
        {
            get => buyView;
            set
            {
                buyView = value;
                btnBuyRemove.Text = buyView ? "Buy" : "Remove";
            }
        }


        public ProductComponent()
        {
            InitializeComponent();
        }

        private void UpdatePrice()
        {
            if (CurrencyPosition == CurrencyPos.LEFT)
                lblPrice.Text = $"{Currency} {Price.ToString("0.00")}";
            else
                lblPrice.Text = $"{Price.ToString("0.00")} {Currency}";
        }
    }
}
