using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsFeeder
{
	public partial class LogsListItem : UserControl
	{
		public LogsListItem()
		{
			InitializeComponent();
		}
		public LogsListItem(string username, string time, string data)
		{
			InitializeComponent();
			usernameLabel.Text = username;
			timeLabel.Text = time;
			dataLabel.Text = data;
		}
	}
}
