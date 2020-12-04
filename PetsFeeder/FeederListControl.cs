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
using Model;

namespace PetsFeeder
{
    public partial class FeederListControl : UserControl
    {
        public FeederListControl()
        {
            InitializeComponent();
            FeedersListItem feederform0 = new FeedersListItem(new MyDelegate(func));
            FeedersListItem feederform1 = new FeedersListItem(new MyDelegate(func));
            FeedersListItem feederform2 = new FeedersListItem(new MyDelegate(func));
            FeedersListItem feederform3 = new FeedersListItem(new MyDelegate(func));
            FeedersListItem feederform4 = new FeedersListItem(new MyDelegate(func));
            FeedersListItem feederform5 = new FeedersListItem(new MyDelegate(func));

            feedersListPanel.Controls.Add(feederform0);
            feedersListPanel.Controls.Add(feederform1);
            feedersListPanel.Controls.Add(feederform2);
            feedersListPanel.Controls.Add(feederform3);
            feedersListPanel.Controls.Add(feederform4);
            feedersListPanel.Controls.Add(feederform5);
            feederCustomizationPanel.Hide();
            this.Width = feedersListPanel.Width;
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
        }

        public void showFeederCustomizationPanel(Feeder feeder)
        {
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
    }
}
