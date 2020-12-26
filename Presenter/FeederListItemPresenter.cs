using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.IViews;
using Model;
using Entities;

namespace Presenter
{
	public class FeederListItemPresenter
	{
		IFeederListItemView _feederListItemView;
		FeederService feederService;
		public FeederListItemPresenter(IFeederListItemView feederListItemView)
		{
			_feederListItemView = feederListItemView;
			feederService = new FeederService();
		}

		public void LoadData(string feederID)
		{
			Feeder feeder = feederService.GetFeeder(feederID);
			if (feeder == null)
			{
				return;
			}
			_feederListItemView.UpdateFeederInformation(feeder.Name, feeder.Tag, feeder.AmountOfFeed);
		}
	}
}
