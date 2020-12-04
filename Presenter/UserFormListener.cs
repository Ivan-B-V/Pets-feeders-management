using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenter
{
	public class UserFormListener
	{
		public void ShowFeeders()
		{
			GetFeeders getFeeders = new GetFeeders();
			getFeeders.TryGetFeeders();
		}
		public void AddFeeder(string Name, string Tag, string Type)
		{
			AddFeeder addFeeder = new AddFeeder();
			Feeder feeder = new Feeder(Name, Tag, Type);
			addFeeder.AddFeederTry(feeder);
		}
	}
}
