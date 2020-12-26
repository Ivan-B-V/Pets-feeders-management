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

namespace PetsFeeder
{
    public partial class AdminUsersControl : UserControl
    {
        public AdminUsersControl(ArrayList feederIDs)
        {
            InitializeComponent();
            foreach (string feederID in feederIDs)
            {
                RequestItem requestItem = new RequestItem(feederID);
                usersListPanel.Controls.Add(requestItem);
            }
        }
    }
}
