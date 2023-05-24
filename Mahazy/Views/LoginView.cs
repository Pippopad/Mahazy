using Mahazy.Models;
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
            string username = txtUsernameLogin.Text.Trim();
            string password = txtPasswordLogin.Text.Trim();

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
            if (u == null || u.Password != Utils.CreateMD5(password))
            {
                Utils.ShowError("Utente non trovato!");
                ClearLoginField();
                return;
            }

            if (chkKeepMeLogged.Checked) Utils.CreateCredFile(username, password);

            Utils.ShowInfo("Loggato!");
            ClearLoginField();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtNameSignUp.Text.Trim();
            string surname = txtSurnameSignUp.Text.Trim();
            string username = txtUsernameSignUp.Text.Trim();
            string password = txtPasswordSignUp.Text;

            if (!Utils.IsStringValid(name))
            {
                Utils.ShowError("Inserisci il tuo nome!");
                FocusControl(txtNameSignUp);
                return;
            }
            if (!Utils.CheckStringMaxLength(name, 64))
            {
                Utils.ShowError("Il nome non deve superare i 64 caratteri!");
                FocusControl(txtNameSignUp);
                return;
            }

            if (!Utils.IsStringValid(surname))
            {
                Utils.ShowError("Inserisci il tuo cognome!");
                FocusControl(txtSurnameSignUp);
                return;
            }
            if (!Utils.CheckStringMaxLength(surname, 64))
            {
                Utils.ShowError("Il cognome non deve superare i 64 caratteri!");
                FocusControl(txtSurnameSignUp);
                return;
            }

            if (!Utils.IsStringValid(username))
            {
                Utils.ShowError("Inserisci un username!");
                FocusControl(txtUsernameSignUp);
                return;
            }
            if (!Utils.CheckStringLength(username, 3, 64))
            {
                Utils.ShowError("L'username può avere dai 3 ai 64 caratteri!");
                FocusControl(txtUsernameSignUp);
                return;
            }

            if (!Utils.IsStringValid(password))
            {
                Utils.ShowError("Inserisci una password!");
                FocusControl(txtPasswordSignUp);
                return;
            }
            if (!Utils.CheckStringMinLength(name, 3))
            {
                Utils.ShowError("La password deve avere più di 3 caratteri!");
                FocusControl(txtPasswordSignUp);
                return;
            }

            /////////////////////

            if (ctx.Utente.GetUtente(new Utente() { Username = username }) != null)
            {
                Utils.ShowError("Username già preso!");
                FocusControl(txtUsernameLogin);
                return;
            }

            ctx.Utente.AddUtente(new Utente() { Nome = name, Cognome = surname, Username = username, Password = Utils.CreateMD5(password) });

            Utils.ShowInfo("Account creato! Ora esegui il login.");
            ClearSignUpField();

            FocusControl(txtUsernameLogin);
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
