using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Entities
{
	public class Log
	{
		public string Data { get; set; }
		public string Timestamp { get; set; }
		public string Username { get; set; }

		public Log()
		{

		}
		public Log(Dictionary<string, JsonElement> element)
		{
			Data = element["Data"].GetString();
			Timestamp = element["Timestamp"].GetString();
			Username = element["Username"].GetString();
		}
	}
}
