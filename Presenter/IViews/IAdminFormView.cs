using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Presenter.IViews
{
	public interface IAdminFormView
	{
		void ShowMessage(string message);
		void ShowFeeders(ArrayList IDs);
		void ShowRequests(ArrayList requestsIDs);
	}
}
