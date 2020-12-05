﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter;
using Model;

namespace PetsFeeder
{
    public partial class LoginForm : Form
    {
        Point lastPoint;
        String passText;
        public LoginForm()
        {
            InitializeComponent();
            passText = this.passwordTextBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            RegistrationForm userForm = new RegistrationForm();
            this.Hide();
            userForm.Show();
        }

        private void labelPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
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

        private void signInButton_Click(object sender, EventArgs e)
        {
            LoginListener listener = new LoginListener();
            Console.WriteLine("button clocked ");
            User user = listener.SignIn(usernameTextBox.Text, passwordTextBox.Text);
            
            if(user == null)
			{
                MessageBox.Show("сюда надо впихнуть ошибку");
                return;
			}
            
            /*if (this.usernameTextBox.Text.Equals("admin")) 
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
                return;
            }*/
            UserForm userForm = new UserForm(user);
            userForm.Show();
            this.Hide();
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

        private void passwordTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (this.passwordTextBox.Text.Equals(this.passText))
            {
                this.passwordTextBox.Text = "";
            }
        }

        private void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (this.passwordTextBox.Text.Equals("") && !this.passwordTextBox.Focused)
            {
                this.passwordTextBox.Text = passText;
            }
        }
	}
}
