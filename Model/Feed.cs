using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Feed
	{
		public Feeder FeedTry(Feeder feeder)
		{
			Services servises = Services.GetInstance();
			Response response = servises.Feed(feeder);
			Feeder newFeeder = new Feeder(response.body);
			servises.userInfo.UpdateFeeder(newFeeder);

			return newFeeder;
		}
	}
}
