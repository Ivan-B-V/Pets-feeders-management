using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Collections;
using System.Text.Json;

namespace Model
{	
	class CurrentUserData
	{
		private static User _user;
		private static ArrayList logs = new ArrayList();
		private static ArrayList userRequests = new ArrayList();
		public CurrentUserData()
		{
		
		}
		public ArrayList GetUserRequests()
		{
			return userRequests;
		}
		public void ReplaceUserRequests(ArrayResponse response)
		{
			userRequests.Clear();
			foreach (Dictionary<string, JsonElement> element in response.body)
			{
				UserRequest log = new UserRequest(element);
				userRequests.Add(log);
			}
		}
		public void DeleteUserRequest(UserRequest request)
		{
			foreach (UserRequest req in userRequests)
			{
				if (req.UserID.Equals(request.UserID))
				{
					userRequests.Remove(req);
				}
			}
		}
		public ArrayList GetLogs()
		{
			return logs;
		}
		public void ReplaceLogs(ArrayResponse response)
		{
			logs.Clear();
			foreach (Dictionary<string, JsonElement> element in response.body)
			{
				Log log = new Log(element);
				logs.Add(log);
			}
		}
		public void SetCurrentUser(User user)
		{
			_user = user;
		}
		public void AddFeeders(ArrayResponse response)
		{
			ArrayList feeders = new ArrayList();

			foreach (Dictionary<string, JsonElement> element in response.body)
			{
				Feeder feeder = new Feeder(element);
				feeders.Add(feeder);
			}

			_user.AddFeeders(feeders);
		}
		public void ReplaceFeeders(ArrayResponse response)
		{
			_user.DeleteAllFeeders();
			AddFeeders(response);
		}
		public ArrayList GetFeeders()
		{
			return _user.GetFeeders();
		}
		public User GetUser()
		{
			return _user;
		}
		public void UpdateFeeder(Feeder feeder)
		{
			_user.UpdateFeeder(feeder);
		}
	}
}
