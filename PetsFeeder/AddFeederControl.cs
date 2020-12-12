using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter;
using Presenter.IViews;

namespace PetsFeeder
{
    public partial class AddFeederControl : UserControl, IAddFeederView
    {
        AddFeederPresenter presenter;
        public AddFeederControl()
        {
            InitializeComponent();
            presenter = new AddFeederPresenter(this);
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
            string type;
            if (smartRadioButton.Checked)
            {
                type = "Smart";
            }
            else
            {
                type = "Not smart";
            }
            presenter.AddFeeder(nameTextBox.Text, tagTextBox.Text, type);
        }

        public void ShowMessage(string message)
		{
            MessageBox.Show(message);
        }
    }
}
