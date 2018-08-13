using Sistema_PANI.Auth;
using Sistema_PANI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PANI.Presenter
{
	public class UserRegisterPresenter : IUserRegisterPresenter
	{
		private readonly IUserRegisterView registeruser;
		private readonly UserServicesClient User;

		public UserRegisterPresenter(IUserRegisterView registeruser)
		{
			this.User = new UserServicesClient();
			this.registeruser = registeruser;
		}

		public async Task<UserDTO> SaveUser()
		{
			return await this.User.RegisterAsync(this.registeruser.User);
		}
	}
}
