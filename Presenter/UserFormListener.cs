using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenter
{
	class UserFormListener
	{
		public void ShowFeeders()
		{

		}
		public void AddFeeder(string Name, string Tag, int Type)
		{
			AddFeeder addFeeder = new AddFeeder();
			Feeder feeder = new Feeder(Name, Tag, Type);
			addFeeder.AddFeederTry(feeder);
		}
	}
}
