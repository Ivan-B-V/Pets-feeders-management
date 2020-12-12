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
		public void Feed(Feeder feeder)
		{
			Feeder newFeeder = feederService.Feed(feeder);
			_feederListControlView.UpdateSelectedFeeder(newFeeder);
		}
		public void ChangeProperties(Feeder feeder)
		{
			Feeder newFeeder = feederService.ChangeProperties(feeder);
			_feederListControlView.UpdateSelectedFeeder(newFeeder);
		}
	}
}
