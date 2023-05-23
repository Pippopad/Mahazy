﻿using Mahazy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mahazy.MainForm;

namespace Mahazy.Views
{
    public partial class LoginView : Form
    {
        private DatabaseContext ctx;

        public LoginView(DatabaseContext ctx)
        {
            InitializeComponent();

            this.ctx = ctx;
        }

        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            if ((sender as Control).Name.Contains("Login"))
            {
                txtPasswordLogin.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordSignUp.UseSystemPasswordChar = false;
            }
        }

        private void btnShow_MouseUp(object sender, MouseEventArgs e)
        {
            if ((sender as Control).Name.Contains("Login"))
            {
                txtPasswordLogin.UseSystemPasswordChar = true;
            }
            else
            {
                txtPasswordSignUp.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

            if (!Utils.IsStringValid(username))
            {
                Utils.ShowError("Inserisci un username!");
                FocusControl(txtUsernameLogin);
                return;
            }

            if (!Utils.IsStringValid(password))
            {
                Utils.ShowError("Inserisci la password!");
                FocusControl(txtPasswordLogin);
                return;
            }

            Utente u = ctx.Utente.GetUtente(new Utente() { Username = username });
            if (u == null || u.Password != Utils.CreateMD5(txtPasswordLogin.Text))
            {
                Utils.ShowError("Utente non trovato!");
                ClearLoginField();
                return;
            }

            Utils.ShowInfo("Loggato!");
            ClearLoginField();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtNameSignUp.Text;
            string surname = txtSurnameSignUp.Text;
            string username = txtUsernameSignUp.Text;
            string password = txtPasswordSignUp.Text;

            if (!Utils.IsStringValid(name))
            {
                Utils.ShowError("Inserisci il tuo nome!");
                FocusControl(txtNameSignUp);
                return;
            }

            if (!Utils.IsStringValid(surname))
            {
                Utils.ShowError("Inserisci il tuo cognome!");
                FocusControl(txtSurnameSignUp);
                return;
            }

            if (!Utils.IsStringValid(username))
            {
                Utils.ShowError("Inserisci un username!");
                FocusControl(txtUsernameSignUp);
                return;
            }

            if (!Utils.IsStringValid(password))
            {
                Utils.ShowError("Inserisci una password!");
                FocusControl(txtPasswordSignUp);
                return;
            }

            if (ctx.Utente.GetUtente(new Utente() { Username = username }) != null)
            {
                Utils.ShowError("Username già preso!");
                FocusControl(txtUsernameLogin);
                return;
            }

            ctx.Utente.AddUtente(new Utente() { Nome = name, Cognome = surname, Username = username, Password = Utils.CreateMD5(password) });

            Utils.ShowInfo("Account creato!");
            ClearSignUpField();
        }

        private void FocusControl(Control c)
        {
            c.Focus();
        }

        private void ClearLoginField() {
            txtUsernameLogin.Clear();
            txtPasswordLogin.Clear();

            FocusControl(txtUsernameLogin);
        }

        private void ClearSignUpField()
        {
            txtNameSignUp.Clear();
            txtSurnameSignUp.Clear();
            txtUsernameSignUp.Clear();
            txtPasswordSignUp.Clear();

            FocusControl(txtNameSignUp);
        }
    }
}
