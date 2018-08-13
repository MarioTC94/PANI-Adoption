using Sistema_PANI.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PANI.Presenter
{
	public interface IUserLoginPresenter
	{
		Task<UserDTO> LoginUser();
	}
}
