using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.IViews
{
	public interface ILogsUserControlView
	{
		void ShowMessage(string message);
		void ImportLogs(string username, string time, string data);
	}
}
