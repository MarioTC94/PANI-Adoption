using Sistema_PANI.Address;
using Sistema_PANI.Adoption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PANI.Interfaces
{
	public interface IMenuView
	{
		SavePersonDTO Father { get; set; }
		SavePersonDTO Mother { get; set; }
		SaveAdoptionRequestDTO Adoption { get; set; }
		SaveMarriageInformationDTO Marriage { get; set; }
		SaveJobInformationDTO FatherJobInformation { get; set; }
		SaveJobInformationDTO MotherJobInformation { get; set; }

		ICollection<ProvinceDTO> Provinces { set; }
		ICollection<CountyDTO> Counties { set; }
		ICollection<Address.KeyValuePairDTO> Districts { set; }
		ICollection<WorkerType.KeyValuePairDTO> FatherWorkerTypes { set; }
		ICollection<WorkerType.KeyValuePairDTO> MotherWorkerTypes { set; }
		ICollection<RoomHouse.KeyValuePairDTO> RoomHouses { set; }
		ICollection<MaritalState.KeyValuePairDTO> MaritalStates { set; }
		ICollection<StateFile.KeyValuePairDTO> StateFiles { set; }


	}
}
