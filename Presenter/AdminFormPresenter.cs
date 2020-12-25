using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.IViews;
using Model;

namespace Presenter
{
	public class AdminFormPresenter
	{
		IAdminFormView _adminFormView;
		UserService userService;

		public AdminFormPresenter(IAdminFormView adminFormView)
		{
			_adminFormView = adminFormView;
			userService = new UserService();
		}

		public void LoadLogs()
		{
			string message = userService.LoadLogs();

			if (!"ok".Equals(message.ToLower()))
			{
				_adminFormView.ShowMessage(message);
			}
		}
	}
}
