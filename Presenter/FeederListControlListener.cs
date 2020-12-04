using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenter
{
	public class FeederListControlListener
	{
		public Feeder Feed(Feeder feeder)
		{
			Feed feed = new Feed();
			Feeder newFeeder = feed.FeedTry(feeder);
			return newFeeder;
		}
	}
}
