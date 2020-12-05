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
						Register registrate = new Register();
						User user = new User(login, password);

						registrate.Registration(user);

						
					}
				}
			}
			
		}
	
	}
}
