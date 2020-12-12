using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.IViews
{
	public interface IRegistrationView
	{
		void OpenSignIn();
		void ShowMessage(string message);
	}
}
