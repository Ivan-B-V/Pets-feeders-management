using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Entities
{
	public class Feeder
	{
		public int AmountOfFeed { get; set; }
		public string FeederID { get; set; }
		public string Name { get; set; }
		public string OwnerID { get; set; }
		public int PortionSize { get; set; }
		public Schedule Schedule { get; set; }
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

		public Feeder(string id, int amo, string name, string tag)
		{
			FeederID = id;
			AmountOfFeed = amo;
			Name = name;
			Tag = tag;
		}

		public Feeder(Dictionary<string, JsonElement> element)
		{
			AmountOfFeed = element["AmountOfFeed"].GetInt32();
			FeederID = element["FeederID"].GetString();
			OwnerID = element["OwnerID"].GetString();
			PortionSize = element["PortionSize"].GetInt32();
			Tag = element["Tag"].GetString();
			Type = element["Type"].GetString();
			Schedule = JsonSerializer.Deserialize<Schedule>(element["Schedule"].ToString());
			Name = element["Name"].GetString();
		}

		public void Update(Feeder feeder)
		{
			AmountOfFeed = feeder.AmountOfFeed;
			FeederID = feeder.FeederID;
			OwnerID = feeder.OwnerID;
			PortionSize = feeder.PortionSize;
			Tag = feeder.Tag;
			Type = feeder.Type;
			Schedule = feeder.Schedule;
			Name = feeder.Name;
		}

	}
}
