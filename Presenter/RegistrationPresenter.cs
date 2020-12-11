using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Presenter.IViews;

namespace Presenter
{
	class RegistrationPresenter
	{
		IRegistrationPresenter _registrationPresenter;
		UserService userService;
		public RegistrationPresenter(IRegistrationPresenter registrationPresenter)
		{
			_registrationPresenter = registrationPresenter;
			userService = new UserService();
		}
		public void Registrate(string login, string password, string passwordRepeat)
		{
			if ((login != null) && (password != null) && (passwordRepeat != null))
			{
				if ((!"".Equals(login)) && (!"".Equals(password)) && (!"".Equals(passwordRepeat)))
				{
					if (password.Equals(passwordRepeat))
					{
						

						
					}
				}
			}
		}
	}
}
