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
		public CurrentUserData()
		{

		}

		public void SetCurrentUser(User user)
		{
			_user = user;
		}
		public void AddFeeder(Feeder feeder)//??
		{
			
		}
		public void AddFeeders(ArrayList feeders)
		{
			_user.AddFeeders(feeders);
		}
		public void AddFeeders(FeedersResponse response)
		{
			ArrayList feeders = new ArrayList();

			int len = response.body.Length;

			foreach (Dictionary<string, JsonElement> element in response.body)
			{
				Feeder feeder = new Feeder(element);
				feeders.Add(feeder);
			}

			_user.AddFeeders(feeders);
		}
		public void ReplaceFeeders(FeedersResponse response)
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
