using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.IViews;
using Model;
using System.Collections;
using Entities;

namespace Presenter
{
	public class LogsUserControlPresenter
	{
		ILogsUserControlView _logsUserControlView;
		UserService userService;
		public LogsUserControlPresenter(ILogsUserControlView logsUserControlView)
		{
			_logsUserControlView = logsUserControlView;
			userService = new UserService();
		}

		public void GetLogs()
		{
			ArrayList logs = userService.GetLogs();

			if (logs == null)
			{
				_logsUserControlView.ShowMessage("shit happens");
				return;
			}	

			foreach(Log log in logs)
			{
				_logsUserControlView.ImportLogs(log.Username, log.Timestamp, log.Data);
			}
		}

	}
}
