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
	public class AddAdoptionProccessPresenter : IAddAdoptionProccessPresenter
	{
		private readonly IAddAdoptionProcessView AddAdoptionView;
		private readonly AddressServicesClient AddressService;
		private readonly AdoptionServicesClient AdoptionService;
		private readonly MaritalStateServicesClient MaritalService;
		private readonly WorkerTypeServicesClient WorkerTypeService;
		private readonly StateFileServicesClient StateFile;
		private readonly RoomHouseServicesClient RoomHouse;

		private ICollection<ProvinceDTO> addressSource;

		public AddAdoptionProccessPresenter(IAddAdoptionProcessView AddAdoptionView)
		{
			this.AddressService = new AddressServicesClient();
			this.AdoptionService = new AdoptionServicesClient();
			this.MaritalService = new MaritalStateServicesClient();
			this.WorkerTypeService = new WorkerTypeServicesClient();
			this.StateFile = new StateFileServicesClient();
			this.RoomHouse = new RoomHouseServicesClient();
			this.AddAdoptionView = AddAdoptionView;

			if (!this.AddAdoptionView.isEditMode) {
				LoadAdrressCatalog();
			}

			LoadWorkerTypeCatalog();
			LoadStateFileCatalog();
			LoadMaritalStateCatalog();
			LoadRoomHouseCatalog();
		}

		private async void LoadAdrressCatalog()
		{
			this.addressSource = await AddressService.GetProvinceAsync();
			this.AddAdoptionView.ProvincesCatalog = this.addressSource.ToList();
			this.AddAdoptionView.CountiesCatalog = this.addressSource.First().Counties.ToList();
			this.AddAdoptionView.DistrictsCatalog = this.addressSource.First().Counties.First().Districts.ToList();
		}

		private async void LoadWorkerTypeCatalog() {
			var workerTypes = await this.WorkerTypeService.GetWorkerTypesAsync();
			this.AddAdoptionView.FatherWorkerTypesCatalog = workerTypes;
			this.AddAdoptionView.MotherWorkerTypesCatalog = workerTypes;
		}

		private async void LoadStateFileCatalog() {
			this.AddAdoptionView.StateFilesCatalog = await this.StateFile.GetStateFilesAsync();
		}

		private async void LoadMaritalStateCatalog() {
			this.AddAdoptionView.MaritalStatesCatalog = await this.MaritalService.GetMaritalStatesAsync();
		}

		private async void LoadRoomHouseCatalog() {
			this.AddAdoptionView.RoomHousesCatalog = await this.RoomHouse.GetRoomHousesAsync();
		}

		public void HandleProvinceChange(int provinceId)
		{
			var provinces = this.addressSource.FirstOrDefault(x => x.Id == provinceId);
			this.AddAdoptionView.CountiesCatalog = provinces.Counties.ToList();
			this.AddAdoptionView.DistrictsCatalog = provinces.Counties.First().Districts.ToList();
		}

		public void HandleCountyChange(int provinceId, int countyId)
		{
			var counties =  this.addressSource.FirstOrDefault(x => x.Id == provinceId).Counties.ToList();
			this.AddAdoptionView.DistrictsCatalog = counties.FirstOrDefault(x => x.Id == countyId).Districts.ToList();
		}

		public async Task<AdoptionRequestDTO> SaveAdoptionRequest() {
			return await this.AdoptionService.AddAdoptionProcessAsync(this.AddAdoptionView.Adoption);
		}
		public async Task<AdoptionRequestDTO> UpdateAdoptionRequest(int id)
		{
			return await this.AdoptionService.UpdateAdoptionProcessAsync(id, this.AddAdoptionView.Adoption);
		}

		public async void GetAdoptionToEdit(int id)
		{
			var result = await AdoptionService.GetadoptionProcessAsync(id);
			PopulateAddressOnEdit(result.MarriageInformation.Address);
			this.AddAdoptionView.Adoption = MapFromSaveAdoptionRequest(result);
		}

		private async void PopulateAddressOnEdit(AddressDTO address) {
			this.addressSource = await AddressService.GetProvinceAsync();
			this.AddAdoptionView.ProvincesCatalog = this.addressSource.ToList();
			this.AddAdoptionView.CountiesCatalog = this.addressSource.FirstOrDefault(x => x.Id == address.Province.Id).Counties.ToList();
			this.AddAdoptionView.DistrictsCatalog = this.addressSource.FirstOrDefault(x => x.Id == address.Province.Id).Counties.FirstOrDefault(x => x.Id == address.County.Id).Districts.ToList();
		}

		private SaveAdoptionRequestDTO MapFromSaveAdoptionRequest(AdoptionRequestDTO adoption) {
			return new SaveAdoptionRequestDTO
			{
				AllDocuments = adoption.AllDocuments,
				FamilyVisit = adoption.FamilyVisit,
				IDKid = adoption.IDKid,
				StateFileId = adoption.StateFile.Id,
				ParentsInterview = adoption.ParentsInterview,
				ProcessDescripction = adoption.ProcessDescripction,
				MarriageInformation = new SaveMarriageInformationDTO
				{
					RoomHouseId = adoption.MarriageInformation.RoomHouse.Id,
					MaritalStateId = adoption.MarriageInformation.MaritalState.Id,
					MarriageDate = adoption.MarriageInformation.MarriageDate,
					Address = new SaveAddressDTO {
						CountyId = adoption.MarriageInformation.Address.County.Id,
						ProvinceId = adoption.MarriageInformation.Address.Province.Id,
						DistrictId = adoption.MarriageInformation.Address.District.Id,
						Description = adoption.MarriageInformation.Address.Description
					},
					Father = new SavePersonDTO {
						Id = adoption.MarriageInformation.Father.Id,
						BirthDay = adoption.MarriageInformation.Father.BirthDay,
						Email = adoption.MarriageInformation.Father.Email,
						Name = adoption.MarriageInformation.Father.Name,
						LastName = adoption.MarriageInformation.Father.LastName,
						SecondLastName = adoption.MarriageInformation.Father.SecondLastName,
						Phone = adoption.MarriageInformation.Father.Phone,
						PersonTypeId = 1,
						JobInformation = new SaveJobInformationDTO {
							ActualPosition = adoption.MarriageInformation.Father.JobInformation.FirstOrDefault().ActualPosition,
							AddressCompany = adoption.MarriageInformation.Father.JobInformation.FirstOrDefault().AddressCompany,
							AnualSalary = adoption.MarriageInformation.Father.JobInformation.FirstOrDefault().AnualSalary,
							Phone = adoption.MarriageInformation.Father.JobInformation.FirstOrDefault().Phone,
							CompanyName = adoption.MarriageInformation.Father.JobInformation.FirstOrDefault().CompanyName,
							WorkerTypeId = adoption.MarriageInformation.Father.JobInformation.FirstOrDefault().WorkerType.Id
						}
					},
					Mother = new SavePersonDTO
					{
						Id = adoption.MarriageInformation.Mother.Id,
						BirthDay = adoption.MarriageInformation.Mother.BirthDay,
						Email = adoption.MarriageInformation.Mother.Email,
						Name = adoption.MarriageInformation.Mother.Name,
						LastName = adoption.MarriageInformation.Mother.LastName,
						SecondLastName = adoption.MarriageInformation.Mother.SecondLastName,
						Phone = adoption.MarriageInformation.Mother.Phone,
						PersonTypeId = 1,
						JobInformation = new SaveJobInformationDTO
						{
							ActualPosition = adoption.MarriageInformation.Mother.JobInformation.FirstOrDefault().ActualPosition,
							AddressCompany = adoption.MarriageInformation.Mother.JobInformation.FirstOrDefault().AddressCompany,
							AnualSalary = adoption.MarriageInformation.Mother.JobInformation.FirstOrDefault().AnualSalary,
							Phone = adoption.MarriageInformation.Mother.JobInformation.FirstOrDefault().Phone,
							CompanyName = adoption.MarriageInformation.Mother.JobInformation.FirstOrDefault().CompanyName,
							WorkerTypeId = adoption.MarriageInformation.Mother.JobInformation.FirstOrDefault().WorkerType.Id
						}
					}
				}
			};
		}

	}
}
