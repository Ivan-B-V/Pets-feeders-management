using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.Json;

namespace Model
{
	public class User
	{
		public int UserID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public int[] UserFeeders { get; set; }

		private ArrayList feeders;

		public User()
		{
			UserID = 0;
			Username = "DefaultName";
			Password = "DefaultPassword";
			feeders = new ArrayList();
		}

		public User(string login, string password)
		{
			UserID = 0;
			Username = login;
			Password = password;
			feeders = new ArrayList();
		}

		public User(Response response)
		{
			char[] useless = { '[', ']' };
			char[] separator = { ',' };
			//проверка на null

			UserID = response.body["UserID"].GetInt32();
			Username = response.body["Username"].GetString();
			Password = response.body["Password"].GetString();

			string str = response.body["UserFeeders"].ToString();
			str = str.Trim(useless);
			
			string[] idsString = str.Split(separator);

			int len = idsString.Length;

			int[] arr = new int[len];
			for (int i = 0; i < len; i++)
			{
				arr[i] = int.Parse(idsString[i]);
			}
			UserFeeders = arr;

			feeders = new ArrayList();
		}

		public void AddFeeders(FeedersResponse response)
		{
			feeders.Clear();

			int len = response.body.Length;

			foreach (Dictionary<string, JsonElement> element in response.body)
			{
				Feeder feeder = new Feeder(element);
				feeders.Add(feeder);
			}
		}

		public ArrayList GetFeeders()
		{
			return feeders;
		}

		public void UpdateFeeder(Feeder feeder)
		{
			foreach (Feeder current in feeders)
			{
				if ((current.FeederID == feeder.FeederID) && (current.OwnerID == feeder.OwnerID))
				{
					current.AmountOfFeed = feeder.AmountOfFeed;
				}
			}
		}
	}
}
