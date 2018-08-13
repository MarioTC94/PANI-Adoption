using Sistema_PANI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_PANI
{
	static class Program
	{
		/// <summary>
		/// Punto de entrada principal para la aplicación.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			IUserLoginView view = new Login();

			var result = view.ShowViewForLogin();

			if(result == DialogResult.OK)
				Application.Run(new MenuAdoption());
		}
	}
}
