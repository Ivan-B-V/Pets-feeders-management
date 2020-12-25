using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace PetsFeeder
{
	public partial class AdminFeedersControl : UserControl
	{
		public AdminFeedersControl(ArrayList feederIDs)
		{
			InitializeComponent();
			foreach (int feederID in feederIDs)
			{
				FeedersListItem feederform = new FeedersListItem(new MyDelegate(func), feederID);
				flowFeedersPanel.Controls.Add(feederform);
			}
		}
		private void func(int feederID)
		{

		}
	}
}
