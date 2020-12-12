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
			if ((login == null) || (password == null) || (passwordRepeat == null))
			{
				_registrationView.ShowMessage("incorrect login or password");
				return;
			}

			if (("".Equals(login)) || ("".Equals(password)) || ("".Equals(passwordRepeat)))
			{
				_registrationView.ShowMessage("login or password not entered");
				return;
			}

			if (("Username".Equals(login)) && ("11111111".Equals(password)) && ("11111111".Equals(passwordRepeat)))
			{
				_registrationView.ShowMessage("login or password not entered");
				return;
			}

			if (password.Equals(passwordRepeat))
			{
				_registrationView.ShowMessage("passwords are not equal");
				return;
			}
			
			string message = userService.Register(login, password);

			_registrationView.ShowMessage(message);
		}
	}
}
