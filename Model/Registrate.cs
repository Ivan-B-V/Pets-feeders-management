using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Model
{
	public class Registrate
	{
		public void Registration(User user)
		{
			Services serverInteraction = new Services();

			string requestString = JsonSerializer.Serialize<User>(user);

			serverInteraction.SendRequest(requestString);//eh
		}
	}
}
