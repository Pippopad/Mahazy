namespace Mahazy.Views
{
    partial class LoginView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowLogin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.txtUsernameLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtPasswordSignUp = new System.Windows.Forms.TextBox();
            this.txtUsernameSignUp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnShowJoinUs = new System.Windows.Forms.Button();
            this.txtSurnameSignUp = new System.Windows.Forms.TextBox();
            this.txtNameSignUp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnShowLogin);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPasswordLogin);
            this.panel1.Controls.Add(this.txtUsernameLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 398);
            this.panel1.TabIndex = 0;
            // 
            // btnShowLogin
            // 
            this.btnShowLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowLogin.Location = new System.Drawing.Point(319, 211);
            this.btnShowLogin.Name = "btnShowLogin";
            this.btnShowLogin.Size = new System.Drawing.Size(53, 23);
            this.btnShowLogin.TabIndex = 6;
            this.btnShowLogin.Text = "Mostra";
            this.btnShowLogin.UseVisualStyleBackColor = true;
            this.btnShowLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShow_MouseDown);
            this.btnShowLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShow_MouseUp);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogin.Location = new System.Drawing.Point(238, 237);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Location = new System.Drawing.Point(177, 211);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.Size = new System.Drawing.Size(136, 20);
            this.txtPasswordLogin.TabIndex = 4;
            this.txtPasswordLogin.UseSystemPasswordChar = true;
            // 
            // txtUsernameLogin
            // 
            this.txtUsernameLogin.Location = new System.Drawing.Point(177, 180);
            this.txtUsernameLogin.Name = "txtUsernameLogin";
            this.txtUsernameLogin.Size = new System.Drawing.Size(136, 20);
            this.txtUsernameLogin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(81, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(81, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(172, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSignUp.Location = new System.Drawing.Point(682, 282);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 23);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // txtPasswordSignUp
            // 
            this.txtPasswordSignUp.Location = new System.Drawing.Point(621, 256);
            this.txtPasswordSignUp.Name = "txtPasswordSignUp";
            this.txtPasswordSignUp.Size = new System.Drawing.Size(136, 20);
            this.txtPasswordSignUp.TabIndex = 10;
            this.txtPasswordSignUp.UseSystemPasswordChar = true;
            // 
            // txtUsernameSignUp
            // 
            this.txtUsernameSignUp.Location = new System.Drawing.Point(621, 230);
            this.txtUsernameSignUp.Name = "txtUsernameSignUp";
            this.txtUsernameSignUp.Size = new System.Drawing.Size(136, 20);
            this.txtUsernameSignUp.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(525, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(525, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(616, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Join Us";
            // 
            // btnShowJoinUs
            // 
            this.btnShowJoinUs.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowJoinUs.Location = new System.Drawing.Point(763, 254);
            this.btnShowJoinUs.Name = "btnShowJoinUs";
            this.btnShowJoinUs.Size = new System.Drawing.Size(53, 23);
            this.btnShowJoinUs.TabIndex = 7;
            this.btnShowJoinUs.Text = "Mostra";
            this.btnShowJoinUs.UseVisualStyleBackColor = true;
            this.btnShowJoinUs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShow_MouseDown);
            this.btnShowJoinUs.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShow_MouseUp);
            // 
            // txtSurnameSignUp
            // 
            this.txtSurnameSignUp.Location = new System.Drawing.Point(621, 204);
            this.txtSurnameSignUp.Name = "txtSurnameSignUp";
            this.txtSurnameSignUp.Size = new System.Drawing.Size(136, 20);
            this.txtSurnameSignUp.TabIndex = 15;
            // 
            // txtNameSignUp
            // 
            this.txtNameSignUp.Location = new System.Drawing.Point(621, 178);
            this.txtNameSignUp.Name = "txtNameSignUp";
            this.txtNameSignUp.Size = new System.Drawing.Size(136, 20);
            this.txtNameSignUp.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(525, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cognome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(525, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nome:";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 398);
            this.Controls.Add(this.txtSurnameSignUp);
            this.Controls.Add(this.txtNameSignUp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnShowJoinUs);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPasswordSignUp);
            this.Controls.Add(this.txtUsernameSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.TextBox txtUsernameLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox txtPasswordSignUp;
        private System.Windows.Forms.TextBox txtUsernameSignUp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnShowLogin;
        private System.Windows.Forms.Button btnShowJoinUs;
        private System.Windows.Forms.TextBox txtSurnameSignUp;
        private System.Windows.Forms.TextBox txtNameSignUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}