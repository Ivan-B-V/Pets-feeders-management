using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presenter
{
	class RegistrationListener
	{
		public void Registrate(string login, string password, string passwordRepeat)
		{
			if ((login != null) && (password != null) && (passwordRepeat != null))
			{
				if ((!"".Equals(login)) && (!"".Equals(password)) && (!"".Equals(passwordRepeat)))
				{
					if (password.Equals(passwordRepeat))
					{
						Registrate registrate = new Registrate();
						User user = new User(login, password);

						registrate.Registration(user);//todo: return success code(?)

						//change view if code equals success and return
					}
				}
			}
			//show error message
		}
	
	}
}
