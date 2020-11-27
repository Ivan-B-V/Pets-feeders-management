﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetsFeeder
{
    public partial class UserForm : Form
    {
        private Point lastPoint;

        public UserForm()
        {
            InitializeComponent();
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
            contentPanel.Controls.Clear();
            selectedButtonPanel.Height = myFeedersButton.Height;
            selectedButtonPanel.Top = myFeedersButton.Top;
            this.Width = this.MinimumSize.Width;

            FeederListControl feederListControl = new FeederListControl();
            contentPanel.Controls.Add(feederListControl);
        }

        private void viewLogsButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            this.selectedButtonPanel.Height = viewLogsButton.Height;
            this.selectedButtonPanel.Top = viewLogsButton.Top;

            LogsUserControl logsUserControl = new LogsUserControl();
            logsUserControl.hidePanel();
            contentPanel.Controls.Add(logsUserControl);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
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

        /*
        private void testButton_Click(object sender, EventArgs e)
        {
            /*
            if (selectedButtonPanel.Top == myFeedersButton.Top)
            {
                for (int i = 0; i < contentPanel.Controls.Count; i++)
                {
                    if (contentPanel.Controls[i].GetType() == typeof(FeederListControl) )
                    { 
                      
                    }
                }
            }

            contentPanel.Controls.Clear();
            selectedButtonPanel.Height = myFeedersButton.Height;
            selectedButtonPanel.Top = myFeedersButton.Top;
            this.Width = this.MaximumSize.Width;

            FeederListControl feederListControl = new FeederListControl();
            feederListControl.showFeederCustomizationPanel();
            contentPanel.Controls.Add(feederListControl);
        }
    */
    }
}
