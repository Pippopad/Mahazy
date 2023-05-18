using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahazy
{
    public partial class MainForm : Form
    {
        private Point startPoint;
        private bool clicked;

        public MainForm()
        {
            InitializeComponent();

            this.clicked = false;
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            clicked = true;
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);

                this.Location = p3;
            }
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            string senderName = (sender as Control).Name;

            Color btnCloseColor = Color.FromName("Red");
            Color btnMinimizeColor = Color.FromName("Lime");

            switch (senderName)
            {
                case "picBtnClose":
                    picBtnClose.BackColor = btnCloseColor;
                    break;
                case "picBtnMinimize":
                    picBtnMinimize.BackColor = btnMinimizeColor;
                    break;
                default:
                    break;
            }
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Color btnDefaultColor = Color.FromName("LightGray");

            (sender as Control).BackColor = btnDefaultColor;
        }

        private void Control_Click(object sender, EventArgs e)
        {
            string senderName = (sender as Control).Name;

            switch (senderName)
            {
                case "picBtnClose":
                    Application.Exit();
                    break;
                case "picBtnMinimize":
                    this.WindowState = FormWindowState.Minimized;
                    break;
                default:
                    break;
            }
        }
    }
}
