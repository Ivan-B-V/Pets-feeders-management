using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Presenter.IViews
{
	public interface IUserView
	{
		void ShowFeeders(ArrayList feeder);
		void ShowMessage(string message);
	}
}
