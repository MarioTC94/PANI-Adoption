using MetroFramework.Forms;
using Sistema_PANI.Interfaces;
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
	public partial class MenuAdoption : MetroForm, IMenuAdoptionView
	{
		public MenuAdoption()
		{
			InitializeComponent();
		}

		private void HandleViewAdoptions(object sender, EventArgs e)
		{
			IReportAdoptionView view = new ReportAdoptionForm();
			view.ShowView();
		}

		private void HandleOpenAddAdoptionView(object sender, EventArgs e)
		{
			IAddAdoptionProcessView view = new AddAdoptionProcessForm();
			view.ShowView();
			
		}
	}
}
