using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections;
using Presenter.IViews;

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
		public ArrayList ShowFeeders()
		{
			ArrayList feeders = feederService.GetFeeders();
			return feeders;
		}
		public void AddFeeder(string Name, string Tag, string Type)//не доделано
		{
			Feeder feeder = new Feeder(Name, Tag, Type);
			feederService.AddFeeder(feeder);
		}
	}
}
