namespace Sistema_PANI.Presenter
{
	public interface IMenuPresenter
	{
		void HandleCountyChange(int provinceId, int countyId);
		void HandleProvinceChange(int provinceId);
		void SaveAdoptionRequest();
	}
}