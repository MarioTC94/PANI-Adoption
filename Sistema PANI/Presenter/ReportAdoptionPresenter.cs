using Sistema_PANI.Adoption;
using Sistema_PANI.View;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_PANI.Presenter
{
	public class ReportAdoptionPresenter : IReportAdoptionPresenter
	{
		private readonly IReportAdoptionView reportAdoptionView;
		private readonly AdoptionServicesClient adoptionServices;

		private ICollection<AdoptionRequestDTO> adoptionRequests;

		public ReportAdoptionPresenter(IReportAdoptionView reportAdoptionView)
		{
			this.reportAdoptionView = reportAdoptionView;
			this.adoptionServices = new AdoptionServicesClient();
			LoadAdoptionGrid();
		}
		public async Task<int> DeleteAdoptionProcess(int id)
		{
			adoptionRequests = adoptionRequests.Where(ad => ad.Id != id).ToList();
			this.reportAdoptionView.GridAdoptionSource = GetDataSource(adoptionRequests);
			return await adoptionServices.RemoveAdoptionProcessAsync(id);
		}

		public void FilterAdoptionSource(string filter)
		{
			filter = filter.ToLower();

			ICollection<AdoptionRequestDTO> result = adoptionRequests
				.Where(
					ad => ad.Id.ToString().ToLower().Contains(filter)
					|| ad.MarriageInformation.Father.Id.ToLower().Contains(filter)
					|| (ad.MarriageInformation.Father.Name + " " + ad.MarriageInformation.Father.LastName).ToLower().Contains(filter)
					|| ad.MarriageInformation.Mother.Id.ToLower().Contains(filter)
					|| (ad.MarriageInformation.Mother.Name + " " + ad.MarriageInformation.Mother.LastName).ToLower().Contains(filter)
					|| ad.IDKid.ToLower().Contains(filter)
					|| ad.StateFile.Description.ToLower().Contains(filter)
				).ToList();

			this.reportAdoptionView.GridAdoptionSource = GetDataSource(result);
		}

		private async void LoadAdoptionGrid() {
			adoptionRequests =  await adoptionServices.GetAllAdoptionProcessAsync();
			this.reportAdoptionView.GridAdoptionSource = GetDataSource(adoptionRequests);
		}

		private List<dynamic> GetDataSource(ICollection<AdoptionRequestDTO> adoptions) {
			return adoptions.Select(ad => new
			{
				ad.Id,
				CedulaPadre = ad.MarriageInformation.Father.Id,
				NombrePadre = $"{ad.MarriageInformation.Father.Name} {ad.MarriageInformation.Father.LastName}",
				CedulaMadre = ad.MarriageInformation.Mother.Id,
				NombreMadre = $"{ad.MarriageInformation.Mother.Name} {ad.MarriageInformation.Mother.LastName}",
				CedulaNiño = ad.IDKid,
				Estado = ad.StateFile.Description
			}).ToList<dynamic>();
		}

	}
}
