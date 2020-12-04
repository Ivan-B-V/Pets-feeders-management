using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Model
{
	
	public class AddFeeder
	{
		public void AddFeederTry(Feeder feeder)
		{
			Services services = new Services();

			string requestString = JsonSerializer.Serialize<Feeder>(feeder);

			//serverInteraction.GetResponse(requestString);
		}
	}
	
}
