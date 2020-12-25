﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Presenter;
using System.Collections;
using Presenter.IViews;
using System.Threading;

namespace PetsFeeder
{
    public partial class UserForm : Form, IUserView
    {
        private Point lastPoint;
        UserFormPresenter presenter;

        public UserForm()
        {
            InitializeComponent();
            presenter = new UserFormPresenter(this);
        }

        public UserForm(string username)
        {
            InitializeComponent();
            usernameLabel.Text = username;
            presenter = new UserFormPresenter(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = this.MinimumSize.Width;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addFeederButton_Click(object sender, EventArgs e)
        {
            AddFeederControl addFeederControl = new AddFeederControl();
            addFeederControl.Dock = DockStyle.Fill;
            this.Width = this.MaximumSize.Width;
            contentPanel.Controls.Clear();
            this.contentPanel.Controls.Add(addFeederControl);
        }

        private void myFeedersButton_Click(object sender, EventArgs e)
        {
            presenter.ShowFeeders();
        }

        private void viewLogsButton_Click(object sender, EventArgs e)
        {
            presenter.LoadLogs();
            
            contentPanel.Controls.Clear();
            this.selectedButtonPanel.Height = viewLogsButton.Height;
            this.selectedButtonPanel.Top = viewLogsButton.Top;
            
            LogsUserControl logsUserControl = new LogsUserControl();
            logsUserControl.Width = contentPanel.Width;
            contentPanel.Controls.Add(logsUserControl);
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

        private void barPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ShowFeeders(ArrayList feederIDs)
		{
            if (feederIDs == null)
            {
                return;
            }

            contentPanel.Controls.Clear();

            FeederListControl feederListControl = new FeederListControl(feederIDs);

            contentPanel.Controls.Add(feederListControl);

            selectedButtonPanel.Height = myFeedersButton.Height;
            selectedButtonPanel.Top = myFeedersButton.Top;
            this.Width = this.MinimumSize.Width;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

		private void searchTextBox_TextChanged(object sender, EventArgs e)
		{
            
		}
	}
}
