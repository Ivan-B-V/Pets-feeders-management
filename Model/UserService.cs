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
		public User SignIn(User user)
		{
			Response response = _userDAO.SignIn(user);

			if (response == null)
			{
				return null;
			}

			User userInfo = new User(response);

			_currentUserData.SetCurrentUser(userInfo);

			return userInfo;
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
