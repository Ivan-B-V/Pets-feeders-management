using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections;
using Entities;

namespace Model
{
	public class FeederService
	{
		FeederDAO _feederDAO;
		CurrentUserData _currentUserData;
		public FeederService()
		{
			_feederDAO = new FeederDAO();
			_currentUserData = new CurrentUserData();
		}
		public ArrayList GetFeeders()
		{
			FeedersResponse response = _feederDAO.GetFeeders();

			if (response == null)
			{
				return null;
			}

			_currentUserData.ReplaceFeeders(response);

			return _currentUserData.GetFeeders();
		}

		public Feeder Feed(Feeder feeder)
		{
			Response response = _feederDAO.Feed(feeder);

			if (response == null)
			{
				return null;
			}

			Feeder newFeeder = new Feeder(response.body);
			_currentUserData.UpdateFeeder(newFeeder);
			
			return newFeeder;
		}

		public string AddFeeder(string Name, string Tag, string Type)
		{
			Feeder feeder = new Feeder(Name, Tag, Type);

			feeder.OwnerID = _currentUserData.GetUser().UserID;
			Response response = _feederDAO.AddFeeder(feeder);

			if (response == null)
			{
				return "shit happens";
			}	

			string message = response.headers["message"];
			return message;
		}

		public Feeder ChangeProperties(Feeder feeder)
		{
			Response response = _feederDAO.ChangeProperties(feeder);

			if (response == null)
			{
				return null;
			}

			Feeder newFeeder = new Feeder(response.body);
			_currentUserData.UpdateFeeder(newFeeder);

			return newFeeder;
		}

		public string SetSchedule(int feederID, string[] day1, string[] day2)
		{
			Schedule schedule = new Schedule(day1, day2);
			
			Feeder currentFeeder = null;
			foreach (Feeder feeder in _currentUserData.GetFeeders())
			{
				if(feeder.FeederID == feederID)
				{
					currentFeeder = feeder;
				}
			}

			if(currentFeeder == null)
			{
				return "wtf?";
			}

			currentFeeder.Schedule = schedule;

			Response response = _feederDAO.SetSchedule(currentFeeder);

			if (response == null)
			{
				return "shit happens";
			}
			string message = response.headers["message"];

			if ("ok".Equals(message))//сообщение удачи. Изменить если надо
			{
				foreach (Feeder feeder in _currentUserData.GetFeeders())
				{
					if (feeder.FeederID == feederID)
					{
						feeder.Schedule = schedule;
					}
				}
			}

			return message;
		}
	}
}
