namespace Mahazy.Components
{
    partial class ReviewComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rate1 = new System.Windows.Forms.PictureBox();
            this.rate2 = new System.Windows.Forms.PictureBox();
            this.rate4 = new System.Windows.Forms.PictureBox();
            this.rate3 = new System.Windows.Forms.PictureBox();
            this.rate5 = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rate1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(2, 2);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(72, 24);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // txtReview
            // 
            this.txtReview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReview.BackColor = System.Drawing.Color.White;
            this.txtReview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReview.Location = new System.Drawing.Point(3, 35);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.ReadOnly = true;
            this.txtReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReview.Size = new System.Drawing.Size(350, 54);
            this.txtReview.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Valutazione:";
            // 
            // rate1
            // 
            this.rate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rate1.Image = global::Mahazy.Properties.Resources.star_blank;
            this.rate1.Location = new System.Drawing.Point(88, 89);
            this.rate1.Name = "rate1";
            this.rate1.Size = new System.Drawing.Size(24, 24);
            this.rate1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rate1.TabIndex = 6;
            this.rate1.TabStop = false;
            // 
            // rate2
            // 
            this.rate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rate2.Image = global::Mahazy.Properties.Resources.star_blank;
            this.rate2.Location = new System.Drawing.Point(115, 89);
            this.rate2.Name = "rate2";
            this.rate2.Size = new System.Drawing.Size(24, 24);
            this.rate2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rate2.TabIndex = 7;
            this.rate2.TabStop = false;
            // 
            // rate4
            // 
            this.rate4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rate4.Image = global::Mahazy.Properties.Resources.star_blank;
            this.rate4.Location = new System.Drawing.Point(169, 89);
            this.rate4.Name = "rate4";
            this.rate4.Size = new System.Drawing.Size(24, 24);
            this.rate4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rate4.TabIndex = 9;
            this.rate4.TabStop = false;
            // 
            // rate3
            // 
            this.rate3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rate3.Image = global::Mahazy.Properties.Resources.star_blank;
            this.rate3.Location = new System.Drawing.Point(142, 89);
            this.rate3.Name = "rate3";
            this.rate3.Size = new System.Drawing.Size(24, 24);
            this.rate3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rate3.TabIndex = 8;
            this.rate3.TabStop = false;
            // 
            // rate5
            // 
            this.rate5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rate5.Image = global::Mahazy.Properties.Resources.star_blank;
            this.rate5.Location = new System.Drawing.Point(196, 89);
            this.rate5.Name = "rate5";
            this.rate5.Size = new System.Drawing.Size(24, 24);
            this.rate5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rate5.TabIndex = 10;
            this.rate5.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(278, 90);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Rimuovi";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ReviewComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.rate5);
            this.Controls.Add(this.rate4);
            this.Controls.Add(this.rate3);
            this.Controls.Add(this.rate2);
            this.Controls.Add(this.rate1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.lblAuthor);
            this.Name = "ReviewComponent";
            this.Size = new System.Drawing.Size(367, 123);
            ((System.ComponentModel.ISupportInitialize)(this.rate1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rate5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox rate1;
        private System.Windows.Forms.PictureBox rate2;
        private System.Windows.Forms.PictureBox rate4;
        private System.Windows.Forms.PictureBox rate3;
        private System.Windows.Forms.PictureBox rate5;
        private System.Windows.Forms.Button btnRemove;
    }
}
