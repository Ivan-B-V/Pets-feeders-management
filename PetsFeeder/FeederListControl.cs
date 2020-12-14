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
using Entities;

namespace PetsFeeder
{
    public partial class FeederListControl : UserControl, IFeederListControlView
    {
        private Feeder _feeder;
        FeederListControlPresenter presenter;
        public FeederListControl()
        {
            InitializeComponent();
            feederCustomizationPanel.Hide();
            this.Width = feedersListPanel.Width;
            presenter = new FeederListControlPresenter(this);
        }

        public FeederListControl(ArrayList feeders)
        {
            InitializeComponent();

            foreach (Feeder feeder in feeders)
            {
                FeedersListItem feederform = new FeedersListItem(new MyDelegate(func), feeder);
                feedersListPanel.Controls.Add(feederform);
            }

            feederCustomizationPanel.Hide();
            this.Width = feedersListPanel.Width;
            presenter = new FeederListControlPresenter(this);
        }

        public void showFeederCustomizationPanel(Feeder feeder)
        {
            this._feeder = feeder;
            feederName.Text = feeder.Name;
            tagTextBox.Text = feeder.Tag;
            this.Width = feedersListPanel.Width + feederCustomizationPanel.Width;
            feederCustomizationPanel.Visible = true;
        }

        private void func(Feeder feeder)
        {
            //MessageBox.Show(param.ToString());
            showFeederCustomizationPanel(feeder);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

		private void feedButton_Click(object sender, EventArgs e)
        {
            presenter.Feed(_feeder);
		}

		public void UpdateSelectedFeeder(Feeder feeder)
		{
			foreach (FeedersListItem item in feedersListPanel.Controls)
			{
                if (item.Equals(_feeder))
				{
                    item.UpdateFeederInformation(feeder);
				}
			}
            _feeder = feeder;
		}

        private void tagTextBox_LostFocus(object sender, EventArgs e)
        {
            Console.WriteLine("text changed to:" + tagTextBox.Text);
        }

        private void SetScheduleButton_Click(object sender, EventArgs e)
        {
            SetScheduleUserControl setSchedule = new SetScheduleUserControl();
            setSchedule.Dock = DockStyle.Fill;
            feederCustomizationPanel.Visible = false;
            feedersListPanel.Visible = false;
            this.Controls.Add(setSchedule);
        }
    }
}
