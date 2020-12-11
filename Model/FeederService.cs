using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections;

namespace Model
{
	public class FeederService
	{
		public ArrayList GetFeeders()
		{
			Services services = Services.GetInstance();

			FeedersResponse response = services.FeedersRequest();

			services.userInfo.AddFeeders(response);

			return services.userInfo.GetFeeders();
		}

		public Feeder Feed(Feeder feeder)
		{
			Services servises = Services.GetInstance();
			Response response = servises.Feed(feeder);
			Feeder newFeeder = new Feeder(response.body);
			servises.userInfo.UpdateFeeder(newFeeder);

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
