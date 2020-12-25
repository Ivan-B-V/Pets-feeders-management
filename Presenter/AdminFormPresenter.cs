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
	public class AdminFormPresenter
	{
		IAdminFormView _adminFormView;
		UserService userService;
		FeederService feederService;

		public AdminFormPresenter(IAdminFormView adminFormView)
		{
			_adminFormView = adminFormView;
			userService = new UserService();
			feederService = new FeederService();
		}

		public void LoadLogs()
		{
			string message = userService.LoadLogs();

			if (!"ok".Equals(message.ToLower()))
			{
				_adminFormView.ShowMessage(message);
			}
		}

		public void ShowFeeders()
		{
			ArrayList feeders = feederService.GetFeeders();

			if (feeders == null || feeders.Count == 0)
			{
				_adminFormView.ShowMessage("No feeders found");
				return;
			}
			ArrayList IDs = new ArrayList();
			foreach (Feeder feeder in feeders)
			{
				IDs.Add(feeder.FeederID);
			}
			_adminFormView.ShowFeeders(IDs);
		}

		public void ShowRequests()
		{
			ArrayList requests = userService.GetRequests();

			if (requests == null || requests.Count == 0)
			{
				_adminFormView.ShowMessage("No requests found");
				return;
			}
			ArrayList IDs = new ArrayList();
			foreach (UserRequest request in requests)
			{
				IDs.Add(request.UserID);
			}
			_adminFormView.ShowRequests(IDs);
		}
	}
}
