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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productComponent1 = new Mahazy.ProductComponent();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.productComponent1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(834, 307);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // productComponent1
            // 
            this.productComponent1.BackColor = System.Drawing.Color.White;
            this.productComponent1.Currency = "€";
            this.productComponent1.CurrencyPosition = Mahazy.ProductComponent.CurrencyPos.RIGHT;
            this.productComponent1.Description = "Get a new PS5!!! :)";
            this.productComponent1.Location = new System.Drawing.Point(3, 3);
            this.productComponent1.Name = "productComponent1";
            this.productComponent1.Price = 599.99D;
            this.productComponent1.Seller = "XX_Sella_XX";
            this.productComponent1.Size = new System.Drawing.Size(359, 98);
            this.productComponent1.TabIndex = 0;
            this.productComponent1.Title = "PS5 Digital Edition";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(771, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(15, 363);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // StoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 398);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreView";
            this.Text = "StoreView";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ProductComponent productComponent1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSell;
    }
}