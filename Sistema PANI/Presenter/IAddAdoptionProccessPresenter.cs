using Sistema_PANI.Adoption;
using System.Threading.Tasks;

namespace Sistema_PANI.Presenter
{
	public interface IAddAdoptionProccessPresenter
	{
		void HandleCountyChange(int provinceId, int countyId);
		void HandleProvinceChange(int provinceId);
		Task<AdoptionRequestDTO> SaveAdoptionRequest();
		Task<AdoptionRequestDTO> UpdateAdoptionRequest(int id);
		void GetAdoptionToEdit(int id);
	}
}