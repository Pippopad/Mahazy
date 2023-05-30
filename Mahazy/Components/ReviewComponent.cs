using Mahazy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahazy.Components
{
    public partial class ReviewComponent : UserControl
    {
        public event EventHandler OnRemoveClicked;

        public Recensione Recensione { get; set; }

        private string author = "Author";
        public string Author
        {
            get => author;
            set
            {
                author = value;
                if (value.Length > 14)
                    lblAuthor.Text = Utils.CompressString(value, 14);
                else
                    lblAuthor.Text = value;
            }
        }

        private string description = "Description";
        public string Description
        {
            get => description;
            set
            {
                txtReview.Text = value;
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
                }
                else
                {
                    btnRemove.Enabled = false;
                    btnRemove.Visible = false;
                }
            }
        }


        private int rate = 0;
        public int Rate
        {
            get => rate;
            set
            {
                rate = value;

                ResetStar();

            if (rate >= 1) rate1.Image = Utils.StarFill;
            if (rate >= 2) rate2.Image = Utils.StarFill;
            if (rate >= 3) rate3.Image = Utils.StarFill;
            if (rate >= 4) rate4.Image = Utils.StarFill;
            if (rate >= 5) rate5.Image = Utils.StarFill;
            }
        }

        public Color ContentBackground
        {
            get => txtReview.BackColor;
            set
            {
                txtReview.BackColor = value;
            }
        }


        public ReviewComponent()
        {
            InitializeComponent();

            txtReview.GotFocus += TextBoxGotFocus;
        }

        private void TextBoxGotFocus(object sender, EventArgs args)
        {
            txtReview.Enabled = false;
            txtReview.Enabled = true;
        }

        private void ResetStar()
        {
            rate1.Image = Utils.StarBlank;
            rate2.Image = Utils.StarBlank;
            rate3.Image = Utils.StarBlank;
            rate4.Image = Utils.StarBlank;
            rate5.Image = Utils.StarBlank;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OnRemoveClicked.Invoke(this, new EventArgs());
        }
    }
}
