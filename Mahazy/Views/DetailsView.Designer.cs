namespace Mahazy.Views
{
    partial class DetailsView
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.lblCommento = new System.Windows.Forms.Label();
            this.reviewsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Indietro";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDescription.Location = new System.Drawing.Point(13, 78);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(250, 251);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(155, 365);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(108, 24);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price: 0.00€";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(13, 363);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 9;
            this.btnBuy.Text = "Compra";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(359, 331);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(308, 58);
            this.txtReview.TabIndex = 11;
            // 
            // lblCommento
            // 
            this.lblCommento.AutoSize = true;
            this.lblCommento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommento.Location = new System.Drawing.Point(356, 313);
            this.lblCommento.Name = "lblCommento";
            this.lblCommento.Size = new System.Drawing.Size(126, 16);
            this.lblCommento.TabIndex = 12;
            this.lblCommento.Text = "Scrivi un commento:";
            // 
            // reviewsContainer
            // 
            this.reviewsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.reviewsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reviewsContainer.Location = new System.Drawing.Point(362, 42);
            this.reviewsContainer.Name = "reviewsContainer";
            this.reviewsContainer.Size = new System.Drawing.Size(484, 263);
            this.reviewsContainer.TabIndex = 13;
            // 
            // btnReview
            // 
            this.btnReview.Location = new System.Drawing.Point(778, 331);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(68, 55);
            this.btnReview.TabIndex = 14;
            this.btnReview.Text = "Commenta";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(672, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Valuta:";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(675, 331);
            this.txtRate.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(97, 20);
            this.txtRate.TabIndex = 16;
            this.txtRate.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Commenti:";
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmt.Location = new System.Drawing.Point(12, 331);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(99, 24);
            this.lblAmt.TabIndex = 18;
            this.lblAmt.Text = "Quantità: 1";
            // 
            // DetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 398);
            this.Controls.Add(this.lblAmt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.reviewsContainer);
            this.Controls.Add(this.lblCommento);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailsView";
            this.Text = "DetailsView";
            ((System.ComponentModel.ISupportInitialize)(this.txtRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Label lblCommento;
        private System.Windows.Forms.FlowLayoutPanel reviewsContainer;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmt;
    }
}