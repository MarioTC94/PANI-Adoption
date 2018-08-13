using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_PANI.Auth;
using Sistema_PANI.View;

namespace Sistema_PANI.Presenter
{
	public class UserLoginPresenter : IUserLoginPresenter
	{
		private readonly UserServicesClient user;
		private readonly IUserLoginView loginview;

		public UserLoginPresenter(IUserLoginView loginview)
		{
			this.loginview = loginview;
			this.user = new UserServicesClient();
		}

		public async Task<UserDTO> LoginUser()
		{
			try
			{
				return await this.user.LoginAsync(loginview.Email, loginview.Password);
			}
			catch (Exception)
			{
				return null;
			}
			
		}
	}
}
