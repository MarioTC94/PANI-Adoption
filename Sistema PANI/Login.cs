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
	public partial class Login : MetroFramework.Forms.MetroForm{

		public Login()
		{
			InitializeComponent();
		}

		private void Btn_IniciarSesión_Click(object sender, EventArgs e)
		{
		
			try
			{
				this.Hide();

				if (new Menu().ShowDialog() == DialogResult.OK)
				{
					this.DialogResult = DialogResult.OK;

				}
				
			}
			catch (Exception ex)
			{

				throw ex;
			}
			this.Close();
		}

		private void Btn_Registrarse_Click(object sender, EventArgs e)
		{
			this.Hide();

			if (new Register().ShowDialog() == DialogResult.OK)
			{
				this.DialogResult = DialogResult.OK;

			}

			this.Close();
		}
	}
}
