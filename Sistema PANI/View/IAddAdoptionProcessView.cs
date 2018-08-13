using Sistema_PANI.Address;
using Sistema_PANI.Adoption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PANI.Interfaces
{
	public interface IAddAdoptionProcessView
	{
		bool isEditMode { get; set; }
		SavePersonDTO Father { get; set; }
		SavePersonDTO Mother { get; set; }
		SaveAdoptionRequestDTO Adoption { get; set; }
		SaveMarriageInformationDTO Marriage { get; set; }
		SaveJobInformationDTO FatherJobInformation { get; set; }
		SaveJobInformationDTO MotherJobInformation { get; set; }

		SaveAddressDTO MarriageAddress { get; set; }

		ICollection<ProvinceDTO> ProvincesCatalog { set; }
		ICollection<CountyDTO> CountiesCatalog { set; }
		ICollection<Address.KeyValuePairDTO> DistrictsCatalog { set; }
		ICollection<WorkerType.KeyValuePairDTO> FatherWorkerTypesCatalog { set; }
		ICollection<WorkerType.KeyValuePairDTO> MotherWorkerTypesCatalog { set; }
		ICollection<RoomHouse.KeyValuePairDTO> RoomHousesCatalog { set; }
		ICollection<MaritalState.KeyValuePairDTO> MaritalStatesCatalog { set; }
		ICollection<StateFile.KeyValuePairDTO> StateFilesCatalog { set; }

		void ShowToEdit(int Id);

		void ShowView();

	}
}
