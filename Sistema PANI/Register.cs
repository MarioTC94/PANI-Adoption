using MetroFramework;
using Sistema_PANI.Auth;
using Sistema_PANI.Presenter;
using Sistema_PANI.View;
using System;
using System.Windows.Forms;

namespace Sistema_PANI
{
	public partial class Register : MetroFramework.Forms.MetroForm, IUserRegisterView
	{
		private readonly IUserRegisterPresenter registerPresenter;
		public Register()
		{
			InitializeComponent();
			registerPresenter = new UserRegisterPresenter(this);
		}


		public DialogResult ShowView()
		{
			return this.ShowDialog();
		}
		public UserDTO User {
			get {
				return new UserDTO
				{
					Name = NameUserTextBox.Text,
					FirstLastName = FirstLastNameTextbox.Text,
					SecondLastName = SecondLastNameTextBox.Text,
					Email = EmailUserTextbox.Text,
					Password = PasswordUserTextBox.Text

				};
			}
		}

		private async void HandleRegisterUser(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(User.Name) || string.IsNullOrEmpty(User.FirstLastName) || string.IsNullOrEmpty(User.SecondLastName) || string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password))
			{
				MetroMessageBox.Show(this, "Campos vacios, escriba las credenciales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, 200);
				return;
			}
			var result = await registerPresenter.SaveUser();
			this.DialogResult = DialogResult.OK;
			MetroMessageBox.Show(this, "Información guardada exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 200);

		}

		private void HandleCancel(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Abort;
		}
	}
}
