using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Entities
{
	public class Schedule
	{
		public string[] Day1 { get; set; }
		public string[] Day2 { get; set; }

		public Schedule()
		{

		}
		public Schedule(ArrayList day1List, ArrayList day2List)
		{
			string[] day1 = new string[day1List.Count];
			int i = 0;
			foreach(string time in day1List)
			{
				day1[i] = time;
				i++;
			}

			string[] day2 = new string[day2List.Count];
			i = 0;
			foreach (string time in day2List)
			{
				day2[i] = time;
				i++;
			}

			Day1 = day1;
			Day2 = day2;
		}
	}
}
