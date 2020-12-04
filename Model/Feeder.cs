using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
	public class Feeder
	{
		public string Name { get; set; }
		public string Tag { get; set; }
		public int Type { get; set; }

		public Feeder()
		{
			Name = "DefaultName";
			Tag = "DefaultTag";
			Type = 1;
		}

		public Feeder(string login, string tag, int type)
		{
			Name = login;
			Tag = tag;
			Type = type;
		}
	}
}
