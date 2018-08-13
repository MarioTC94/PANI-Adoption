using MetroFramework;
using Sistema_PANI.Auth;
using Sistema_PANI.Presenter;
using Sistema_PANI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_PANI
{
	public partial class Login : MetroFramework.Forms.MetroForm, IUserLoginView
	{
		private readonly IUserLoginPresenter loginPresenter;

		public Login()
		{
			InitializeComponent();
			loginPresenter = new UserLoginPresenter(this);
		}

		public string Email {
			get {
				return UserEmailLoginTextbox.Text;
			}
		}



		public string Password {
			get {
				return PasswordUserTextbox.Text;
			}
		}

		public DialogResult ShowViewForLogin()
		{
			return this.ShowDialog();
		}

		private async void HandleLogIn(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
			{
				MetroMessageBox.Show(this, "Campos vacios, escriba las credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, 200);
				return;
			}
			var result = await loginPresenter.LoginUser();
			if (result is null)
			{
				MetroMessageBox.Show(this, "Login Incorrecto, Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, 200);
			}
			else
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}

			if (!string.IsNullOrEmpty(UserEmailLoginTextbox.Text) && !string.IsNullOrEmpty(PasswordUserTextbox.Text))
			{
				MetroMessageBox.Show(this, "Campos vacios, escriba las credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, 200);
			}
		}

		private void HandleShowRegiserUserView(object sender, EventArgs e)
		{
			IUserRegisterView register = new Register();
			var result = register.ShowView();
			if (result == DialogResult.OK)
				this.DialogResult = DialogResult.OK;
			
		}
	}
}

