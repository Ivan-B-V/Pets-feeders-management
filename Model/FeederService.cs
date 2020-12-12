using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections;
using Entities;

namespace Model
{
	public class FeederService
	{
		FeederDAO _feederDAO;
		CurrentUserData _currentUserData;
		public FeederService()
		{
			_feederDAO = new FeederDAO();
			_currentUserData = new CurrentUserData();
		}
		public ArrayList GetFeeders()
		{
			FeedersResponse response = _feederDAO.GetFeeders();

			_currentUserData.ReplaceFeeders(response);

			return _currentUserData.GetFeeders();
		}

		public Feeder Feed(Feeder feeder)
		{
			Response response = _feederDAO.Feed(feeder);

			Feeder newFeeder = new Feeder(response.body);
			_currentUserData.UpdateFeeder(newFeeder);
			
			return newFeeder;
		}

		public bool AddFeeder(Feeder feeder)
		{
			feeder.OwnerID = _currentUserData.GetUser().UserID;
			Response response = _feederDAO.AddFeeder(feeder);

			Feeder newFeeder = new Feeder(response.body);
			_currentUserData.AddFeeder(feeder);

			return true;
		}
	}
}
