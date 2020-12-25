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
			ArrayResponse response = _feederDAO.GetFeeders();

			if (response == null || response.headers == null || response.body == null)
			{
				return null;
			}

			_currentUserData.ReplaceFeeders(response);

			return _currentUserData.GetFeeders();
		}

		public Feeder Feed(int feederID)
		{
			Feeder feeder = GetFeeder(feederID);

			Response response = _feederDAO.Feed(feeder);

			if (response == null || response.body == null)
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

			if (response == null || response.headers == null || response.body == null)
			{
				return "shit happens";
			}	

			string message = response.headers["message"];
			return message;
		}

		public Feeder ChangeProperties(int feederID, string name, string tag)
		{
			Feeder feeder = GetFeeder(feederID);
			feeder.Name = name;
			feeder.Tag = tag;

			Response response = _feederDAO.ChangeProperties(feeder);

			if (response == null)
			{
				return null;
			}

			Feeder newFeeder = new Feeder(response.body);
			_currentUserData.UpdateFeeder(newFeeder);

			return newFeeder;
		}

		public string SetSchedule(int feederID, ArrayList day1, ArrayList day2)
		{
			Schedule schedule = new Schedule(day1, day2);

			Feeder currentFeeder = GetFeeder(feederID);

			if(currentFeeder == null)
			{
				return "wtf?";
			}

			currentFeeder.Schedule = schedule;

			Response response = _feederDAO.ChangeProperties(currentFeeder);

			if (response == null)
			{
				return "shit happens";
			}
			string message = response.headers["message"];

			if ("Ok".Equals(message))//сообщение удачи. Изменить если надо
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

		public Feeder GetFeeder(int feederID)
		{
			ArrayList feeders = _currentUserData.GetFeeders();

			Feeder feeder = null;
			foreach (Feeder item in feeders)
			{
				if (item.FeederID == feederID)
				{
					feeder = item;
					return feeder;
				}
			}

			return null;
		}

		public string ExportSchedule(ArrayList day1, ArrayList day2, string fileName)
		{
			Schedule schedule = new Schedule(day1, day2);

			string result = _feederDAO.ExportSchedule(schedule, fileName);

			return result;
		}

		public bool ImportSchedule(string fileName, out string[] day1, out string[] day2)
		{
			string result = _feederDAO.ImportSchedule(fileName);
			Schedule schedule = null;
			day1 = new string[0];
			day2 = new string[0];
			try
			{
				schedule = JsonSerializer.Deserialize<Schedule>(result);
			}
			catch
			{
				return false;
			}

			if (schedule == null)
			{
				return false;
			}

			day1 = new string[schedule.Day1.Length];
			int i = 0;
			foreach (string element in schedule.Day1)
			{
				day1[i] = element;
				i++;
			}

			day2 = new string[schedule.Day2.Length];
			i = 0;
			foreach (string element in schedule.Day2)
			{
				day2[i] = element;
				i++;
			}

			return true;
		}
		public bool GetSchedule(int feederID, out string[] day1, out string[] day2)
		{
			day1 = new string[5];
			day2 = new string[5];

			Feeder feeder = GetFeeder(feederID);

			if (feeder == null)
			{
				return false;
			}

			Schedule schedule = feeder.Schedule;

			string[] daySchedule = schedule.Day1;
			for (int i = 0; i < daySchedule.Length; i++)
			{
				day1[i] = daySchedule[i];
			}

			daySchedule = schedule.Day1;
			for (int i = 0; i < daySchedule.Length; i++)
			{
				day2[i] = daySchedule[i];
			}

			return true;
		}
	}
}
