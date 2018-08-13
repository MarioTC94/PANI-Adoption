using Sistema_PANI.Auth;
using System.Windows.Forms;

namespace Sistema_PANI.View
{
	public interface IUserLoginView
	{
		string Email { get; }
		string Password { get; }


		DialogResult ShowViewForLogin();
	}
}
