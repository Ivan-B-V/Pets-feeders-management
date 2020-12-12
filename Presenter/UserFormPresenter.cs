using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections;
using Presenter.IViews;
using Entities;

namespace Presenter
{
	public class UserFormPresenter
	{
		IUserView _userView;
		FeederService feederService;
		public UserFormPresenter(IUserView userView)
		{
			_userView = userView;
			feederService = new FeederService();
		}
		public void ShowFeeders()
		{
			ArrayList feeders = feederService.GetFeeders();
			
			if (feeders == null || feeders.Count == 0)
			{
				_userView.ShowMessage("No feeders found");
				return;
			}
			_userView.ShowFeeders(feeders);
		}
	}
}
