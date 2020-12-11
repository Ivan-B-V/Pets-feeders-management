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
using Model;

namespace PetsFeeder
{
    public partial class FeederListControl : UserControl, IFeederListControlView
    {
        private Feeder feeder;
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

        public void showFeederCustomizationPanel(ref Feeder feeder)
        {
            this.feeder = feeder;
            feederName.Text = feeder.Name;
            tagTextBox.Text = feeder.Tag;
            this.Width = feedersListPanel.Width + feederCustomizationPanel.Width;
            feederCustomizationPanel.Visible = true;
        }

        private void func(ref Feeder feeder)
        {
            //MessageBox.Show(param.ToString());
            showFeederCustomizationPanel(ref feeder);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

		private void feedButton_Click(object sender, EventArgs e)
		{
            Feeder newFeeder = presenter.Feed(feeder);
            feeder = newFeeder;
		}
	}
}
