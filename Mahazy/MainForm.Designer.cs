namespace Mahazy
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.picBtnMinimize = new System.Windows.Forms.PictureBox();
            this.picBtnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pnlTitleBar.Controls.Add(this.label1);
            this.pnlTitleBar.Controls.Add(this.picBtnMinimize);
            this.pnlTitleBar.Controls.Add(this.picBtnClose);
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(858, 36);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.pnlTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // picBtnMinimize
            // 
            this.picBtnMinimize.BackColor = System.Drawing.Color.LightGray;
            this.picBtnMinimize.Location = new System.Drawing.Point(34, 10);
            this.picBtnMinimize.Name = "picBtnMinimize";
            this.picBtnMinimize.Size = new System.Drawing.Size(16, 16);
            this.picBtnMinimize.TabIndex = 2;
            this.picBtnMinimize.TabStop = false;
            this.picBtnMinimize.Click += new System.EventHandler(this.Control_Click);
            this.picBtnMinimize.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.picBtnMinimize.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // picBtnClose
            // 
            this.picBtnClose.BackColor = System.Drawing.Color.LightGray;
            this.picBtnClose.Location = new System.Drawing.Point(12, 10);
            this.picBtnClose.Name = "picBtnClose";
            this.picBtnClose.Size = new System.Drawing.Size(16, 16);
            this.picBtnClose.TabIndex = 1;
            this.picBtnClose.TabStop = false;
            this.picBtnClose.Click += new System.EventHandler(this.Control_Click);
            this.picBtnClose.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.picBtnClose.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mahazy";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 434);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mahazy";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.PictureBox picBtnClose;
        private System.Windows.Forms.PictureBox picBtnMinimize;
        private System.Windows.Forms.Label label1;
    }
}

