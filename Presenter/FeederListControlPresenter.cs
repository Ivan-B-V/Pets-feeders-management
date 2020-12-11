using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.IViews;
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
		public Feeder Feed(Feeder feeder)
		{
			Feeder newFeeder = feederService.Feed(feeder);
			return newFeeder;
		}
	}
}
