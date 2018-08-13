using MetroFramework;
using MetroFramework.Forms;
using Sistema_PANI.Interfaces;
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
	public partial class ReportAdoptionForm : MetroForm, IReportAdoptionView
	{
		private readonly IReportAdoptionPresenter ReportAdoptionPresenter;
		private int SelectedId {
			get {
				return Convert.ToInt32(this.InfoAdoptionGridView.CurrentRow.Cells["Id"].Value);
			}
		}

		public ReportAdoptionForm()
		{
			InitializeComponent();
			this.ReportAdoptionPresenter = new ReportAdoptionPresenter(this);
		}

		public ICollection<dynamic> GridAdoptionSource {
			set {
				InfoAdoptionGridView.DataSource = value;
			}
		}

		public void ShowView()
		{
			this.Show();
		}

		private void HandleFilter(object sender, KeyEventArgs e)
		{
			this.ReportAdoptionPresenter.FilterAdoptionSource(SearchAdoptionTextbox.Text);
		}

		private void HandleEditClick(object sender, EventArgs e)
		{
			IAddAdoptionProcessView view = new AddAdoptionProcessForm();
			view.ShowToEdit(SelectedId);
		}

		private async void HandleDeleteClick(object sender, EventArgs e)
		{
			var result = MetroMessageBox.Show(
				this,
				"¿Está seguro que quiere eliminar este proceso de adopción?",
				"Confirmación",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning,
				300
			);

			if (DialogResult.Yes == result) {
				await ReportAdoptionPresenter.DeleteAdoptionProcess(SelectedId);
				ReportAdoptionPresenter.FilterAdoptionSource(SearchAdoptionTextbox.Text);

				MetroMessageBox.Show(
					this,
					"Proceso eliminado",
					"Éxito",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation,
					300
				);
			}
		}
	}
}
