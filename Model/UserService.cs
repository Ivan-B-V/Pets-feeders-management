using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Entities;

namespace Model
{
	public class UserService
	{
		UserDAO _userDAO;
		CurrentUserData _currentUserData;
		public UserService()
		{
			_userDAO = new UserDAO();
			_currentUserData = new CurrentUserData();
		}
		public string SignIn(string login, string password)
		{
			User user = new User(login, password);

			Response response = _userDAO.SignIn(user);

			if (response == null)
			{
				return null;
			}

			user = new User(response);

			_currentUserData.SetCurrentUser(user);

			return user.Username;
		}
		public string Register(string login, string password)
		{
			User user = new User(login, password);

			Response response = _userDAO.Register(user);

			if (response == null)
			{
				return "shit happend";
			}
			string message = response.headers["message"];
			return message;
		}
	}
}
