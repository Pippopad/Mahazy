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
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.productComponent1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(481, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(365, 374);
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
            // StoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 398);
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
    }
}