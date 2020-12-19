using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.IViews;
using Entities;
using Model;

namespace Presenter
{
	public class FeederListControlPresenter
	{
		IFeederListControlView _feederListControlView;
		FeederService feederService;
		public FeederListControlPresenter(IFeederListControlView feederListControlView)
		{
			_feederListControlView = feederListControlView;
			feederService = new FeederService();
		}
		public void Feed(int feederID)
		{
			Feeder newFeeder = feederService.Feed(feederID);
			_feederListControlView.UpdateSelectedFeeder(newFeeder.Name, newFeeder.Tag, newFeeder.AmountOfFeed);
		}
		public void ChangeProperties(int feederID, string name, string tag)
		{
			Feeder newFeeder = feederService.ChangeProperties(feederID, name, tag);
			_feederListControlView.UpdateSelectedFeeder(newFeeder.Name, newFeeder.Tag, newFeeder.AmountOfFeed);
		}
		public void GetFeederData(int feederID)
		{
			Feeder feeder = feederService.GetFeeder(feederID);
			_feederListControlView.UpdateSelectedFeeder(feeder.Name, feeder.Tag, feeder.AmountOfFeed);
		}
	}
}
