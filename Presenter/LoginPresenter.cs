using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presenter.IViews;
using Entities;
using Model;

namespace Presenter
{
	public class LoginPresenter
	{
		ILoginView _loginView;
		UserService userService;
		public LoginPresenter(ILoginView loginView)
		{
			_loginView = loginView;
			userService = new UserService();
		}

		public void SignIn(string login, string password)
		{
			if ((login == null) || (password == null))
			{
				_loginView.ShowMessage("Incorrect login or password");
				return;
			}
			
			if (("".Equals(login)) || ("".Equals(password)))
			{
				_loginView.ShowMessage("login or password not entered");
				return;
			}
			
			if (("Username".Equals(login)) && ("11111111".Equals(password)))
			{
				_loginView.ShowMessage("login or password not entered");
				return;
			}

			string username = userService.SignIn(login, password);

			if (username == null || "".Equals(username))
			{
				_loginView.ShowMessage("No such user");
				return;
			}

			_loginView.Confirm(username);
		}
	}
}
