﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_PANI.View
{
	public interface IReportAdoptionView
	{
		ICollection<dynamic> GridAdoptionSource { set; }
		void ShowView();
	}
}
