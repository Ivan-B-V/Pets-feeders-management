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
    public partial class HelpForm : Form
    {
        Point lastPoint;
        public HelpForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void themeTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.themeTextBox.Text.Equals("Theme"))
            {
                this.themeTextBox.Text = "";
                this.themeTextBox.ForeColor = Color.Black;
            }
        }

        private void themeTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (this.themeTextBox.Text.Equals("") && !this.themeTextBox.Focused)
            {
                this.themeTextBox.Text = "Theme";
                this.themeTextBox.ForeColor = Color.Gray;
            }
        }

        private void messageTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.messageTextBox.Text.Equals("Your message"))
            {
                this.messageTextBox.Text = "";
                this.messageTextBox.ForeColor = Color.Black;
            }
        }

        private void messageTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (this.messageTextBox.Text.Equals("") && !this.messageTextBox.Focused)
            {
                this.messageTextBox.Text = "Your message";
                this.messageTextBox.ForeColor = Color.Gray;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelPanel_MouseDown(object sender, MouseEventArgs e)
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

        private void labelPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
