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

namespace PetsFeeder
{
    public partial class RegistrationForm : Form, IRegistrationView
    {
        Point lastPoint;
        String passText;
        RegistrationPresenter presenter;
        public RegistrationForm()
        {
            InitializeComponent();
            presenter = new RegistrationPresenter(this);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            passText = this.passwordTextBox1.Text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void signInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void usernameTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text.Equals("Username"))
            {
                this.usernameTextBox.Text = "";
                this.usernameTextBox.ForeColor = Color.Black;
            }
        }

        private void usernameTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (this.usernameTextBox.Text.Equals("") && !this.usernameTextBox.Focused)
            {
                this.usernameTextBox.Text = "Username";
                this.usernameTextBox.ForeColor = Color.Gray;
            }
        }

        private void passwordTextBox1_MouseEnter(object sender, EventArgs e)
        {
            if (this.passwordTextBox1.Text.Equals(this.passText))
            {
                this.passwordTextBox1.Text = "";
            }
        }

        private void passwordTextBox1_MouseLeave(object sender, EventArgs e)
        {
            if (this.passwordTextBox1.Text.Equals("") && !this.passwordTextBox1.Focused)
            {
                this.passwordTextBox1.Text = passText;
            }
        }

        private void passwordTextBox2_MouseEnter(object sender, EventArgs e)
        {
            if (this.passwordTextBox2.Text.Equals(this.passText))
            {
                this.passwordTextBox2.Text = "";
            }
        }

        private void passwordTextBox2_MouseLeave(object sender, EventArgs e)
        {
            if (this.passwordTextBox2.Text.Equals("") && !this.passwordTextBox2.Focused)
            {
                this.passwordTextBox2.Text = passText;
            }
        }

		private void registerButton_Click(object sender, EventArgs e)
		{
            presenter.Register(usernameTextBox.Text, passwordTextBox1.Text, passwordTextBox2.Text);
		}

        public void ShowMessage(string message)
		{
            MessageBox.Show(message);
        }

        public void OpenSignIn()
		{
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
	}
}
