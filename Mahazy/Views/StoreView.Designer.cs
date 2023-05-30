namespace Mahazy.Views
{
    partial class StoreView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productContainer
            // 
            this.productContainer.AutoScroll = true;
            this.productContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.productContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productContainer.Location = new System.Drawing.Point(12, 39);
            this.productContainer.Name = "productContainer";
            this.productContainer.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.productContainer.Size = new System.Drawing.Size(834, 307);
            this.productContainer.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(771, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(15, 363);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(91, 23);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Vendi oggetto";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(132, 20);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Benvenuto Nome";
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.Location = new System.Drawing.Point(690, 10);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(75, 23);
            this.btnMyOrders.TabIndex = 4;
            this.btnMyOrders.Text = "I miei ordini";
            this.btnMyOrders.UseVisualStyleBackColor = true;
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
            // 
            // StoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 398);
            this.Controls.Add(this.btnMyOrders);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.productContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreView";
            this.Text = "StoreView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel productContainer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnMyOrders;
    }
}