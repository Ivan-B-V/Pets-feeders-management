using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace PetsFeeder
{
    public delegate void MyDelegate(Feeder feeder);

    public partial class FeedersListItem : UserControl
    {

        private MyDelegate myDelegate;
        private Feeder _feeder;
        public FeedersListItem()
        {
            InitializeComponent();
        }

        public FeedersListItem(MyDelegate sender)
        {
            InitializeComponent();
            myDelegate = sender;
        }

        public FeedersListItem(MyDelegate sender, Feeder feeder)
        {
            InitializeComponent();
            myDelegate = sender;
            this._feeder = feeder;
            feederName.Text = feeder.Name;
            feederTag.Text = feeder.Tag;
            feederCapacityBar.Value = feeder.AmountOfFeed;
        }

        private void FeedersListItem_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(0, Color.White);
            this.BackColor = Color.Transparent;
        }

        private void FeedersListItem_MouseClick(object sender, MouseEventArgs e)
        {
            myDelegate(_feeder);
        }

        public void UpdateFeederInformation(Feeder feeder)
		{
            this._feeder = feeder;
            feederName.Text = feeder.Name;
            feederTag.Text = feeder.Tag;
            feederCapacityBar.Value = feeder.AmountOfFeed;
        }

		public bool Equals(Feeder feeder)
		{
            if (_feeder.FeederID == feeder.FeederID)
            {
                return true;
            }
            return false;
		}
	}
}
