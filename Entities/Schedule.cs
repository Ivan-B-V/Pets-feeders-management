using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
	public class Schedule
	{
		public string[] Day1 { get; set; }
		public string[] Day2 { get; set; }

		public Schedule(string[] day1, string[] day2)
		{
			Day1 = day1;
			Day2 = day2;
		}
	}
}
