using Sistema_PANI.Address;
using Sistema_PANI.Adoption;
using Sistema_PANI.Interfaces;
using Sistema_PANI.MaritalState;
using Sistema_PANI.RoomHouse;
using Sistema_PANI.StateFile;
using Sistema_PANI.WorkerType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PANI.Presenter
{
	public class MenuPresenter : IMenuPresenter
	{
		private readonly IMenuView view;
		private readonly AddressServicesClient AddressService;
		private readonly AdoptionServicesClient AdoptionService;
		private readonly MaritalStateServicesClient MaritalService;
		private readonly WorkerTypeServicesClient WorkerTypeService;
		private readonly StateFileServicesClient StateFile;
		private readonly RoomHouseServicesClient RoomHouse;

		private ICollection<ProvinceDTO> addressSource;

		public MenuPresenter(IMenuView view)
		{
			this.AddressService = new AddressServicesClient();
			this.AdoptionService = new AdoptionServicesClient();
			this.MaritalService = new MaritalStateServicesClient();
			this.WorkerTypeService = new WorkerTypeServicesClient();
			this.StateFile = new StateFileServicesClient();
			this.RoomHouse = new RoomHouseServicesClient();

			this.view = view;

			LoadAdrressCatalog();
			LoadWorkerTypeCatalog();
			LoadStateFileCatalog();
			LoadMaritalStateCatalog();
			LoadRoomHouseCatalog();
		}

		private async void LoadAdrressCatalog()
		{
			this.addressSource = await AddressService.GetProvinceAsync();
			this.view.Provinces = this.addressSource.ToList();
			this.view.Counties = this.addressSource.First().Counties.ToList();
			this.view.Districts = this.addressSource.First().Counties.First().Districts.ToList();
		}

		private async void LoadWorkerTypeCatalog() {
			var workerTypes = await this.WorkerTypeService.GetWorkerTypesAsync();
			this.view.FatherWorkerTypes = workerTypes;
			this.view.MotherWorkerTypes = workerTypes;
		}

		private async void LoadStateFileCatalog() {
			this.view.StateFiles = await this.StateFile.GetStateFilesAsync();
		}

		private async void LoadMaritalStateCatalog() {
			this.view.MaritalStates = await this.MaritalService.GetMaritalStatesAsync();
		}

		private async void LoadRoomHouseCatalog() {
			this.view.RoomHouses = await this.RoomHouse.GetRoomHousesAsync();
		}

		public void HandleProvinceChange(int provinceId)
		{
			var provinces = this.addressSource.FirstOrDefault(x => x.Id == provinceId);
			this.view.Counties = provinces.Counties.ToList();
			this.view.Districts = provinces.Counties.First().Districts.ToList();
		}

		public void HandleCountyChange(int provinceId, int countyId)
		{
			var counties =  this.addressSource.FirstOrDefault(x => x.Id == provinceId).Counties.ToList();
			this.view.Districts = counties.FirstOrDefault(x => x.Id == countyId).Districts.ToList();
		}

		public void SaveAdoptionRequest() {
			this.AdoptionService.AddAdoptionProcessAsync(this.view.Adoption);
		}
	}
}
