using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Presenter.IViews;
using Model;

namespace Presenter
{
	public class AddFeederPresenter
	{
		IAddFeederView _addFeederView;
		FeederService feederService;
		public AddFeederPresenter(IAddFeederView addFeederView)
		{
			_addFeederView = addFeederView;
			feederService = new FeederService();
		}
		public void AddFeeder(string Name, string Tag, string Type)
		{
			Feeder feeder = new Feeder(Name, Tag, Type);
			bool done = feederService.AddFeeder(feeder);

			if (done)
			{
				_addFeederView.ShowMessage("Feeder successfully added");
				return;
			}

			_addFeederView.ShowMessage("Something went wrong");
		}
	}
}
