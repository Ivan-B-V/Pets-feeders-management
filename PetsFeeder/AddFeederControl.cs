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
    public partial class AddFeederControl : UserControl
    {
        public AddFeederControl()
        {
            InitializeComponent();
        }

        private void nameTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.nameTextBox.Text.Equals("Jack"))
            {
                this.nameTextBox.Text = "";
                this.nameTextBox.ForeColor = Color.Black;
            }
        }

        private void nameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (this.nameTextBox.Text.Equals("") && !this.nameTextBox.Focused)
            {
                this.nameTextBox.Text = "Jack";
                this.nameTextBox.ForeColor = Color.Gray;
            }
        }

        private void tagTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.tagTextBox.Text.Equals("@tag"))
            {
                this.tagTextBox.Text = "";
                this.tagTextBox.ForeColor = Color.Black;
            }
        }

        private void tagTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (this.tagTextBox.Text.Equals("") && !this.tagTextBox.Focused)
            {
                this.tagTextBox.Text = "@tag";
                this.tagTextBox.ForeColor = Color.Gray;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
