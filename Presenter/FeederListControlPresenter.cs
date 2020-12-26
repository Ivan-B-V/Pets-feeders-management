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
		public void Feed(string feederID)
		{
			Feeder newFeeder = feederService.Feed(feederID);
			if (newFeeder == null)
			{
				_feederListControlView.ShowMessage("shit happend");
				return;
			}
			_feederListControlView.UpdateSelectedFeeder(newFeeder.Name, newFeeder.Tag, newFeeder.AmountOfFeed);
		}
		public void ChangeProperties(string feederID, string name, string tag)
		{
			Feeder newFeeder = feederService.ChangeProperties(feederID, name, tag);
			_feederListControlView.UpdateSelectedFeeder(newFeeder.Name, newFeeder.Tag, newFeeder.AmountOfFeed);
		}
		public void GetFeederData(string feederID)
		{
			Feeder feeder = feederService.GetFeeder(feederID);
			_feederListControlView.UpdateSelectedFeeder(feeder.Name, feeder.Tag, feeder.AmountOfFeed);
		}
	}
}
