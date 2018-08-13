using Sistema_PANI.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_PANI.View
{
	public interface IUserRegisterView
	{
		UserDTO User { get; }

		DialogResult ShowView();
	}
}
