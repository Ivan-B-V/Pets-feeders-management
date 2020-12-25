using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Entities
{
	public class UserRequest
	{
		public int UserID { get; set; } 
		public string Username { get; set; }

		public UserRequest()
		{

		}
		public UserRequest(Dictionary<string, JsonElement> element)
		{
			UserID = element["UserID"].GetInt32();
			Username = element["Username"].GetString();
		}
	}
}
