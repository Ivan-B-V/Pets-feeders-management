using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Feeder
	{
		public int AmountOfFeed { get; set; }
		public int FeederID { get; set; }
		public string Name { get; set; }
		public int OwnerID { get; set; }
		public int PortionSize { get; set; }
		public string Schedule { get; set; }
		public string Tag { get; set; }
		public string Type { get; set; }

		public Feeder()
		{
			Name = "DefaultName";
			Tag = "DefaultTag";
			Type = "smart";
		}

		public Feeder(string login, string tag, string type)
		{
			Name = login;
			Tag = tag;
			Type = type;
		}

		public Feeder(Response response)
		{
			/*AmountOfFeed = (int)response.body["AmountOfFeed"];//проверка на null
			FeederID = (int)response.body["FeederID"];
			Name = (string)response.body["Name"];
			OwnerID = (int)response.body["OwnerID"];
			PortionSize = (int)response.body["FeederID"];
			Schedule = (string)response.body["Name"];
			Tag = (string)response.body["OwnerID"];
			Type = (string)response.body["OwnerID"];*/
		}
	}
}
