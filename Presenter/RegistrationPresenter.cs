using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Presenter.IViews;
using Entities;

namespace Presenter
{
	public class RegistrationPresenter
	{
		IRegistrationView _registrationView;
		UserService userService;
		public RegistrationPresenter(IRegistrationView registrationPresenter)
		{
			_registrationView = registrationPresenter;
			userService = new UserService();
		}
		public void Register(string login, string password, string passwordRepeat)
		{
			if ((login != null) || (password != null) || (passwordRepeat != null))
			{
				if ((!"".Equals(login)) || (!"".Equals(password)) || (!"".Equals(passwordRepeat)))
				{
					if ((!"Username".Equals(login)) && (!"11111111".Equals(password)) && (!"11111111".Equals(passwordRepeat)))
					{
						if (password.Equals(passwordRepeat))
						{
							User user = new User(login, password);
							bool done = userService.Register(user);

							if (done)
							{
								_registrationView.OpenSignIn();
								return;
							}

							_registrationView.ShowMessage("something went wrong");
							return;
						}
						_registrationView.ShowMessage("passwords are not equal");
						return;
					}
				}
				_registrationView.ShowMessage("login or password not entered");
				return;
			}
			_registrationView.ShowMessage("incorrect login or password");
		}
	}
}
