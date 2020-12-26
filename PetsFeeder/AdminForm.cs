using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter.IViews;
using Presenter;
using System.Collections;

namespace PetsFeeder
{
    public partial class AdminForm : Form, IAdminFormView
    {
        Point lastPoint;
        AdminFormPresenter presenter;

        public AdminForm()
        {
            InitializeComponent();
            presenter = new AdminFormPresenter(this);
            LoadLogs();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void requestsButton_Click(object sender, EventArgs e)
        {
            presenter.ShowRequests();
        }
        public void ShowRequests(ArrayList requestsIDs)
		{
            if (requestsIDs == null)
            {
                return;
            }

            contentPanel.Controls.Clear();
            AdminUsersControl adminUsersControl = new AdminUsersControl(requestsIDs);
            this.contentPanel.Controls.Add(adminUsersControl);
        }

        private void logsButton_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }
        private void LoadLogs()
		{
            presenter.LoadLogs();
            contentPanel.Controls.Clear();
            LogsUserControl logsUserControl = new LogsUserControl();
            this.contentPanel.Controls.Add(logsUserControl);
        }

        private void barPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void barPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (lastPoint == null)
            {
                lastPoint = new Point(e.X, e.Y);
            }
            else
            {
                lastPoint.X = e.X;
                lastPoint.Y = e.Y;
            }
        }

        private void feedersButton_Click(object sender, EventArgs e)
        {
            presenter.ShowFeeders();
        }

        public void ShowFeeders(ArrayList feederIDs)
		{
            if (feederIDs == null)
			{
                return;
			}
            contentPanel.Controls.Clear();

            AdminFeedersControl adminFeedersControl = new AdminFeedersControl(feederIDs);
            contentPanel.Controls.Add(adminFeedersControl);
            
        }

        public void ShowMessage(string message)
		{
            MessageBox.Show(message);
		}

	}
}
