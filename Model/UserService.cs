using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Entities;
using System.Collections;

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

			if (response == null || response.headers == null || response.body == null || response.body.Count == 0)
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

			if (response == null || response.headers == null)
			{
				return "shit happend";
			}
			string message = response.headers["message"];
			return message;
		}
		public string LoadLogs()
		{
			ArrayResponse response = _userDAO.GetLogs(_currentUserData.GetUser());

			if (response == null || response.headers == null || response.body == null)
			{
				return "shit happens";
			}
			
			string message = response.headers["message"];
			if (!"ok".Equals(message.ToLower()))
			{
				return message;
			}

			_currentUserData.ReplaceLogs(response);

			return "OK";
		}
		public ArrayList GetLogs()
		{
			return _currentUserData.GetLogs();
		}
		public ArrayList GetRequests()
		{
			ArrayResponse response = _userDAO.GetUserRequests(_currentUserData.GetUser());

			if (response == null || response.body == null)
			{
				return null;
			}

			_currentUserData.ReplaceUserRequests(response);

			return _currentUserData.GetUserRequests();
		}
		public UserRequest GetRequest(int ID)
		{
			ArrayList requests = _currentUserData.GetUserRequests();

			UserRequest request = null;
			foreach (UserRequest item in requests)
			{
				if (item.UserID == ID)
				{
					request = item;
					return request;
				}
			}

			return null;
		}
	}
}
