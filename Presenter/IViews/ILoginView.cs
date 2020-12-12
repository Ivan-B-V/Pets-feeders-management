using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.IViews
{
	public interface ILoginView
	{
		void Confirm(string username);
		void ShowMessage(string message);
	}
}
