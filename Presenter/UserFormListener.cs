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
	public class UserFormListener
	{
		IUserView _userView;
		public UserFormListener(IUserView userView)
		{
			_userView = userView;
		}

		public ArrayList ShowFeeders()
		{
			GetFeeders getFeeders = new GetFeeders();
			ArrayList feeders = getFeeders.TryGetFeeders();
			return feeders;
		}
		public void AddFeeder(string Name, string Tag, string Type)//не доделано
		{
			AddFeeder addFeeder = new AddFeeder();
			Feeder feeder = new Feeder(Name, Tag, Type);
			addFeeder.AddFeederTry(feeder);
		}
	}
}
