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

namespace Mahazy.Components
{
    public partial class OrderComponent : UserControl
    {
        public Ordina Ordina { get; set; }

        private int id = 0;
        public int Id
        {
            get => id;
            set
            {
                id = value;
                lblId.Text = $"ID: {value}";
            }
        }

        private string title = "Title";
        public string Title
        {
            get => title;
            set
            {
                title = value;
                if (value.Length > 14)
                    lblTitle.Text = "Titolo: " + value.Substring(0, 14 - 3) + $"... (ID: {Ordina.IdProdotto})";
                else
                    lblTitle.Text = "Titolo: " + value + $" (ID: { Ordina.IdProdotto})";
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

        public OrderComponent()
        {
            InitializeComponent();
        }

        private void UpdatePrice()
        {
            if (CurrencyPosition == CurrencyPos.LEFT)
                lblPrice.Text = $"Price: {Currency} {Price.ToString("0.00")}";
            else
                lblPrice.Text = $"Price: {Price.ToString("0.00")} {Currency}";
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
    }
}
