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
			if ((login != null) || (password != null))
			{
				if ((!"".Equals(login)) || (!"".Equals(password)))
				{
					if ((!"Username".Equals(login)) && (!"11111111".Equals(password)))
					{
						User user = new User(login, password);
						User userInfo = userService.SignIn(user);

						if (userInfo == null)
						{
							_loginView.ShowMessage("No such user");
							return;
						}

						_loginView.Confirm(userInfo.Username);
						return;
					}
				}
				_loginView.ShowMessage("login or password not entered");
				return;
			}
			_loginView.ShowMessage("Incorrect login or password");
		}
	}
}
