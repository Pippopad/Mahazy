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
        public string Title
        {
            get => lblTitle.Text;
            set
            {
                if (value.Length > 30)
                    lblTitle.Text = value.Substring(0, 30 - 3) + "...";
                else
                    lblTitle.Text = value;
            }
        }

        public string Description
        {
            get => lblDescription.Text;
            set
            {
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
                Currency = value;
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

        private string seller = "By user";
        public string Seller
        {
            get => seller;
            set
            {
                if (value.Length > 14)
                    lblSeller.Text = "By " + value.Substring(0, 14 - 3) + "...";
                else
                    lblSeller.Text = "By " + value;
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
