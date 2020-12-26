using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter;
using Presenter.IViews;

namespace PetsFeeder
{
    public delegate void MyDelegate(string feederID);

    public partial class FeedersListItem : UserControl, IFeederListItemView
    {
        FeederListItemPresenter presenter;
        private MyDelegate myDelegate;
        private string feederID;
        
        public FeedersListItem(MyDelegate sender, string feederID)
        {
            InitializeComponent();
            myDelegate = sender;
            this.feederID = feederID;
            presenter = new FeederListItemPresenter(this);
            presenter.LoadData(this.feederID);
        }

        private void FeedersListItem_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void FeedersListItem_MouseClick(object sender, MouseEventArgs e)
        {
            myDelegate(feederID);
        }

        public void UpdateFeederInformation(string feederName, string feederTag, int feederAmount)
		{ 
            feederNameLabel.Text = feederName;
            feederTagLabel.Text = feederTag;
            feederCapacityBar.Value = feederAmount;
            feederCapacity.Text = feederAmount.ToString() + "%";
        }

		public bool Equals(string feederID)
		{
            if (this.feederID.Equals(feederID))
            {
                return true;
            }
            return false;
		}
	}
}
