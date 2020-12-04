using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenter
{
	public class LoginListener
	{
		public void SignIn(string login, string password)
		{
			if ((login != null) && (password != null))
			{
				if ((!"".Equals(login)) && (!"".Equals(password)))
				{
					if ((!"Username".Equals(login)) && (!"11111111".Equals(password)))
					{
						SignIn signIn = new SignIn();
						User user = new User(login, password);
						User userInfo = signIn.SignInTry(user);

					}
				}

			}
			//show error message
			Console.WriteLine("error");
		}
	}
}
