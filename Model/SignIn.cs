using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Model
{
	public class SignIn
	{
		public void SignInTry(User user)
		{
			Services services = new Services();

			string requestString = JsonSerializer.Serialize<User>(user);

			string response = services.GetResponse(requestString);

			Console.WriteLine(response);
		}
	}
}
