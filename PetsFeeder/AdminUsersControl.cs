using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsFeeder
{
    public partial class AdminUsersControl : UserControl
    {

        UserItemAdmin userItemAdmin = new UserItemAdmin();

        public AdminUsersControl()
        {
            InitializeComponent();
            requestsButton_Click(requestsButton, new EventArgs());
        }


        private void requestsButton_Click(object sender, EventArgs e)
        {
            usersListPanel.Controls.Clear();
            userItemAdmin.addButton.Visible = true;
            for (int i = 0; i < 10; i++)
            {
                this.usersListPanel.Controls.Add(userItemAdmin);
            }
            this.selectedButtonPanel.Height = this.requestsButton.Height;
            this.selectedButtonPanel.Top = this.requestsButton.Top;
        }

        private void usersBaseButton_Click(object sender, EventArgs e)
        {
            usersListPanel.Controls.Clear();
            userItemAdmin.addButton.Hide();
            for (int i = 0; i < 10; i++)
            {
                this.usersListPanel.Controls.Add(userItemAdmin);
            }
            this.selectedButtonPanel.Height = this.usersBaseButton.Height;
            this.selectedButtonPanel.Top = this.usersBaseButton.Top;
        }
    }
}
