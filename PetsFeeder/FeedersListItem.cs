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
    public delegate void MyDelegate(bool isClick);

    public partial class FeedersListItem : UserControl
    {

        private MyDelegate d;
        public FeedersListItem()
        {
            InitializeComponent();
        }

        public FeedersListItem(MyDelegate sender)
        {
            InitializeComponent();
            d = sender;
        }

        private void FeedersListItem_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(0, Color.White);
            this.BackColor = Color.Transparent;
        }

        private void FeedersListItem_MouseClick(object sender, MouseEventArgs e)
        {
            d(true);
        }
    }
}
