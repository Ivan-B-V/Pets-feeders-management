using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Presenter;
using Presenter.IViews;

namespace PetsFeeder
{
    public partial class FeederListControl : UserControl, IFeederListControlView
    {
        private int selectedFeederID;
        private string selectedFeederName;
        private string selectedFeederTag;
        FeederListControlPresenter presenter;
        public FeederListControl()
        {
            InitializeComponent();
            feederCustomizationPanel.Hide();
            this.Width = feedersListPanel.Width;
            presenter = new FeederListControlPresenter(this);
        }

        public FeederListControl(ArrayList feederIDs)
        {
            InitializeComponent();

            foreach (int feederID in feederIDs)
            {
                FeedersListItem feederform = new FeedersListItem(new MyDelegate(func), feederID);
                feedersListPanel.Controls.Add(feederform);
            }

            feederCustomizationPanel.Hide();
            this.Width = feedersListPanel.Width;
            presenter = new FeederListControlPresenter(this);
        }

        public void SetFeederData(string name, string tag)
		{
            selectedFeederName = name;
            selectedFeederTag = tag;
		}

        public void showFeederCustomizationPanel(int feederID)
        {
            selectedFeederID = feederID;
            presenter.GetFeederData(feederID);
            this.Width = feedersListPanel.Width + feederCustomizationPanel.Width;
            feederCustomizationPanel.Visible = true;
        }

        private void func(int feederID)
        {
            showFeederCustomizationPanel(feederID);
        }

		private void feedButton_Click(object sender, EventArgs e)
        {
            presenter.Feed(selectedFeederID);
		}

		public void UpdateSelectedFeeder(string name, string tag, int amount)
		{
			foreach (FeedersListItem item in feedersListPanel.Controls)
			{
                if (item.Equals(selectedFeederID))
				{
                    item.UpdateFeederInformation(name, tag, amount);
				}
			}
            selectedFeederName = name;
            selectedFeederTag = tag;
            feederName.Text = name;
            tagTextBox.Text = tag;
        }

        private void tagTextBox_LostFocus(object sender, EventArgs e)
        {
            selectedFeederTag = tagTextBox.Text;
            presenter.ChangeProperties(selectedFeederID, selectedFeederName, selectedFeederTag);
        }

        private void SetScheduleButton_Click(object sender, EventArgs e)
        {
            SetScheduleUserControl setSchedule = new SetScheduleUserControl(selectedFeederID);
            setSchedule.Dock = DockStyle.Fill;
            feederCustomizationPanel.Visible = false;
            feedersListPanel.Visible = false;
            this.Controls.Add(setSchedule);
        }
        public void ShowMessage(string message)
		{
            MessageBox.Show(message);
		}
    }
}
