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
		CurrentUserData _currentUserData;
		public FeederService()
		{
			_currentUserData = new CurrentUserData();
		}
		public ArrayList GetFeeders()
		{
			Services services = Services.GetInstance();

			FeedersResponse response = services.FeedersRequest();

			_currentUserData.ReplaceFeeders(response);

			return _currentUserData.GetFeeders();
		}

		public Feeder Feed(Feeder feeder)
		{
			Services servises = Services.GetInstance();

			Response response = servises.Feed(feeder);

			Feeder newFeeder = new Feeder(response.body);
			_currentUserData.UpdateFeeder(newFeeder);
			

			return newFeeder;
		}

		public void AddFeeder(Feeder feeder)
		{
			Services services = Services.GetInstance();

			string requestString = JsonSerializer.Serialize<Feeder>(feeder);

			//serverInteraction.GetResponse(requestString);
		}
	}
}
