﻿namespace Mahazy.Views
{
    partial class AddProductView
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.previewPC = new Mahazy.ProductComponent();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSell = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Indietro";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(383, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 347);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // previewPC
            // 
            this.previewPC.BackColor = System.Drawing.Color.White;
            this.previewPC.Currency = "€";
            this.previewPC.CurrencyPosition = Mahazy.ProductComponent.CurrencyPos.RIGHT;
            this.previewPC.Description = "Descrizione";
            this.previewPC.Location = new System.Drawing.Point(441, 138);
            this.previewPC.Name = "previewPC";
            this.previewPC.Price = 0D;
            this.previewPC.Seller = "user";
            this.previewPC.Size = new System.Drawing.Size(359, 98);
            this.previewPC.TabIndex = 2;
            this.previewPC.Title = "Titolo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titolo:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(77, 105);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(176, 20);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(77, 156);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(176, 81);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrizione:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezzo:";
            // 
            // txtPrice
            // 
            this.txtPrice.DecimalPlaces = 2;
            this.txtPrice.Location = new System.Drawing.Point(77, 269);
            this.txtPrice.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(92, 20);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.ValueChanged += new System.EventHandler(this.txtPrice_ValueChanged);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(77, 297);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(176, 23);
            this.btnSell.TabIndex = 10;
            this.btnSell.Text = "Vendi";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(379, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preview:";
            // 
            // AddProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewPC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductView";
            this.Text = "AddProductView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ProductComponent previewPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label4;
    }
}