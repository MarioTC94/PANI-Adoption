using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PANI.Presenter
{
	public interface IReportAdoptionPresenter
	{
		void FilterAdoptionSource(string filter);

		Task<int> DeleteAdoptionProcess(int id);
	}
}
