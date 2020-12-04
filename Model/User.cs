using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class User
	{
		public string Username { get; set; }
		public string Password { get; set; }

		public User()
		{
			Username = "DefaultName";
			Password = "DefaultPassword";
		}

		public User(string login, string password)
		{
			Username = login;
			Password = password;
		}
	}
}
