using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsFeeder
{
    public partial class AdminForm : Form
    {
        Point lastPoint;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            AdminUsersControl adminUsersControl = new AdminUsersControl();
            this.contentPanel.Controls.Add(adminUsersControl);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            HelpUserControl helpUserControl = new HelpUserControl();
            contentPanel.Controls.Add(helpUserControl);
        }

        private void logsButton_Click(object sender, EventArgs e)
        {
          
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
    }
}
