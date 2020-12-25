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
    public delegate void MyDelegate(int feederID);

    public partial class FeedersListItem : UserControl, IFeederListItemView
    {
        FeederListItemPresenter presenter;
        private MyDelegate myDelegate;
        private int feederID;
        private string feederName;
        private string feederTag;
        private int feederAmount;
        private string stringCapacity;
        
        public FeedersListItem(MyDelegate sender, int feederID)
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
            this.feederName = feederName;
            this.feederTag = feederTag;
            this.feederAmount = feederAmount;
            this.stringCapacity = feederAmount.ToString();
            feederNameLabel.Text = feederName;
            feederTagLabel.Text = feederTag;
            feederCapacityBar.Value = feederAmount;
            feederCapacity.Text = feederAmount.ToString() + "%";
        }

		public bool Equals(int feederID)
		{
            if (this.feederID == feederID)
            {
                return true;
            }
            return false;
		}
	}
}
