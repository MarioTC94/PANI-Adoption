using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Sistema_PANI.Address;
using Sistema_PANI.Adoption;
using Sistema_PANI.Interfaces;
using Sistema_PANI.Presenter;
using System;
using System.Collections.Generic;


namespace Sistema_PANI
{

	public partial class Menu : MetroForm, IMenuView
	{
		private readonly IMenuPresenter menuPresenter;

		public Menu()
		{
			InitializeComponent();
			this.SetDisplayAndValueMembers();
			this.menuPresenter = new MenuPresenter(this);
		}
		public SavePersonDTO Father {
			get {
				return new SavePersonDTO
				{
					BirthDay = FatherBirthDayDateTimePicker.Value,
					Email = FatherEmailTextBox.Text,
					Name = FatherNameTextBox.Text,
					LastName = FatherLastNameTextBox.Text,
					SecondLastName = FatherSecondLastNameTextBox.Text,
					Id = CedulaPadreTextBox.Text,
					JobInformation = this.FatherJobInformation,
					Phone = FatherPhoneTextBox.Text,
					PersonTypeId = 1
				};

			}
			set {
				value = value ?? new SavePersonDTO();
				FatherBirthDayDateTimePicker.Value = value.BirthDay;
				FatherEmailTextBox.Text = value.Email;
				FatherNameTextBox.Text = value.Name;
				FatherLastNameTextBox.Text = value.LastName;
				FatherSecondLastNameTextBox.Text = value.SecondLastName;
				CedulaPadreTextBox.Text = value.Id;
				FatherJobInformation = value.JobInformation;
				FatherPhoneTextBox.Text = value.Phone;
			}
		}
		public SavePersonDTO Mother {
			get {
				return new SavePersonDTO
				{
					BirthDay = MotherBirthDayDateTimePicker.Value,
					Email = MotherEmailTextBox.Text,
					Name = MotherNameTextBox.Text,
					LastName = MotherLastNameTextField.Text,
					SecondLastName = MotherSecondLastNameTextField.Text,
					Id = CedulaMotherTextBox.Text,
					JobInformation = MotherJobInformation,
					Phone = MotherPhoneTextBox.Text,
					PersonTypeId = 2
				};

			}
			set {
				value = value ?? new SavePersonDTO(); 
				MotherBirthDayDateTimePicker.Value = value.BirthDay;
				MotherEmailTextBox.Text = value.Email;
				MotherNameTextBox.Text = value.Name;
				MotherLastNameTextField.Text = value.LastName;
				MotherSecondLastNameTextField.Text = value.SecondLastName;
				CedulaMotherTextBox.Text = value.Id;
				MotherJobInformation = value.JobInformation;
				MotherPhoneTextBox.Text = value.Phone;
			}
		}
		public SaveAdoptionRequestDTO Adoption {
			get {
				return new SaveAdoptionRequestDTO
				{
					ProcessDescripction = ProcessDescriptionTextbox.Text,
					AllDocuments = HasDocumentsRadioButton.Checked,
					FamilyVisit = HasFamilyVisitRadioButton.Checked,
					ParentsInterview = HasParentsInterview.Checked,
					StateFileId = (int) StateFileCombobox.SelectedValue,
					MarriageInformation = Marriage,
					IDKid = IDKidTextbox.Text
				};
			} set {
				value =  value ?? new SaveAdoptionRequestDTO();
				ProcessDescriptionTextbox.Text = value.ProcessDescripction;
				HasDocumentsRadioButton.Checked = value.AllDocuments;
				HasNotDocumentsRadioButton.Checked = !value.AllDocuments;
				HasFamilyVisitRadioButton.Checked = value.FamilyVisit;
				HasNotFamilyVisit.Checked = !value.FamilyVisit;
				HasParentsInterview.Checked = value.ParentsInterview;
				HasNotParentsInterview.Checked = !value.ParentsInterview;
				StateFileCombobox.SelectedValue = value.StateFileId;
				Marriage = value.MarriageInformation;
				IDKidTextbox.Text = value.IDKid;


			}
		}
		public SaveMarriageInformationDTO Marriage {
			get {
				return new SaveMarriageInformationDTO
				{
					MarriageDate = MarriageDateDateTimePicker.Value,
					Father = Father,
					Mother = Mother,
					MaritalStateId = (int) MaritalStateComboBox.SelectedValue,
					RoomHouseId = (int) RoomHouseComboBox.SelectedValue
				};
				} set {
				value = value ?? new SaveMarriageInformationDTO();
					MarriageDateDateTimePicker.Value = value.MarriageDate;
					Father = value.Father;
					Mother = value.Mother;
					MaritalStateComboBox.SelectedValue = value.MarriageDate;
					RoomHouseComboBox.SelectedValue = value.RoomHouseId;
				}
			}
		public SaveJobInformationDTO FatherJobInformation {
			get {
				return new SaveJobInformationDTO
				{
					ActualPosition = FatherActualPositionTextBox.Text,
					AddressCompany = FatherCompanyAddress.Text,
					AnualSalary = Decimal.Parse(FatherAnualSalaryTextBox.Text),
					CompanyName = FatherCompanyAddress.Text,
					Phone = FatherCompanyNumberTextBox.Text,
					WorkerTypeId = (int)FatherWorkerType.SelectedValue
				};
			} set {
				value = value ?? new SaveJobInformationDTO();
				FatherActualPositionTextBox.Text = value.ActualPosition;
				FatherCompanyAddress.Text = value.AddressCompany;
				FatherAnualSalaryTextBox.Text = value.AnualSalary.ToString();
				MotherCompanyNameTextBox.Text = value.CompanyName;
				FatherCompanyNumberTextBox.Text = value.Phone;
				FatherWorkerType.SelectedValue = value.WorkerTypeId;				
			}
		}
		public SaveJobInformationDTO MotherJobInformation {
			get {
				return new SaveJobInformationDTO
				{
					ActualPosition = MotherActualPositionTextBox.Text,
					AddressCompany = MotherCompanyAddress.Text,
					AnualSalary = Decimal.Parse(MotherAnualSalaryTextBox.Text),
					CompanyName = MotherCompanyNameTextBox.Text,
					Phone = MotherPhoneTextBox.Text,
					WorkerTypeId = (int)MotherWorkeTypeComboBox.SelectedValue
				};
			} set {
				value = value ?? new SaveJobInformationDTO();
				MotherActualPositionTextBox.Text = value.ActualPosition;
				MotherCompanyAddress.Text = value.AddressCompany;
				MotherAnualSalaryTextBox.Text = value.AnualSalary.ToString();
				MotherPhoneTextBox.Text = value.Phone;
				MotherCompanyNameTextBox.Text = value.CompanyName;
				MotherWorkeTypeComboBox.SelectedValue = value.WorkerTypeId;

			} }


		//Catalogos de la cual se muestran en los ComboBox
		public ICollection<ProvinceDTO> Provinces {
			set {
				this.ProvincesComboBox.DataSource = value;
			}
		}

		public ICollection<CountyDTO> Counties {
			set {
				this.CountiesComboBox.DataSource = value;
			}
		}

		public ICollection<Address.KeyValuePairDTO> Districts {
			set {
				this.DistrictsComboBox.DataSource = value;
			}
		}

		public ICollection<WorkerType.KeyValuePairDTO> FatherWorkerTypes {
			set {
				this.FatherWorkerType.DataSource = value;
			}
		}

		public ICollection<WorkerType.KeyValuePairDTO> MotherWorkerTypes {
			set {
				this.MotherWorkeTypeComboBox.DataSource = value;
			}
		}

		public ICollection<RoomHouse.KeyValuePairDTO> RoomHouses {

			set {
				this.RoomHouseComboBox.DataSource = value;
			}
		}

		public ICollection<MaritalState.KeyValuePairDTO> MaritalStates {
			set {
				this.MaritalStateComboBox.DataSource = value;
			}
		}

		public ICollection<StateFile.KeyValuePairDTO> StateFiles {
			set {
				this.StateFileCombobox.DataSource = value;
			}
		}

		private void SetDisplayAndValueMembers(){
			this.CountiesComboBox.DisplayMember = "Description";
			this.DistrictsComboBox.DisplayMember = "Description";
			this.ProvincesComboBox.DisplayMember = "Description";
			this.StateFileCombobox.DisplayMember = "Description";
			this.MotherWorkeTypeComboBox.DisplayMember = "Description";
			this.FatherWorkerType.DisplayMember = "Description";
			this.RoomHouseComboBox.DisplayMember = "Description";
			this.MaritalStateComboBox.DisplayMember = "Description";

			this.CountiesComboBox.ValueMember = "Id";
			this.DistrictsComboBox.ValueMember = "Id";
			this.ProvincesComboBox.ValueMember = "Id";
			this.StateFileCombobox.ValueMember = "Id";
			this.MotherWorkeTypeComboBox.ValueMember = "Id";
			this.FatherWorkerType.ValueMember = "Id";
			this.RoomHouseComboBox.ValueMember = "Id";
			this.MaritalStateComboBox.ValueMember = "Id";
		}

		private void HandleProvinceChange(object sender, EventArgs e)
		{
			var provinceId = (int)ProvincesComboBox.SelectedValue;
			this.menuPresenter.HandleProvinceChange(provinceId);
		}

		private void HandleCountyChange(object sender, EventArgs e)
		{
			var provinceId = (int)ProvincesComboBox.SelectedValue;
			var countyId = (int)CountiesComboBox.SelectedValue;

			this.menuPresenter.HandleCountyChange(provinceId, countyId);
		}

		private void HandleSubmitAdoptionRequest(object sender, EventArgs e)
		{
			try
			{
				this.menuPresenter.SaveAdoptionRequest();
				MetroMessageBox.Show(this, "Saved");
			}
			catch (Exception ex) {
				MetroMessageBox.Show(this, $"Error: {ex.Message}");
			}
		}
	}

}
