namespace PetsFeeder
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.Label appLabel;
			System.Windows.Forms.Label passwordLabel;
			System.Windows.Forms.Label loginLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.labelPanel = new System.Windows.Forms.Panel();
			this.exitButton = new System.Windows.Forms.Button();
			this.loginPanel = new System.Windows.Forms.Panel();
			this.registerLabel = new System.Windows.Forms.Label();
			this.signInButton = new System.Windows.Forms.Button();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			appLabel = new System.Windows.Forms.Label();
			passwordLabel = new System.Windows.Forms.Label();
			loginLabel = new System.Windows.Forms.Label();
			this.labelPanel.SuspendLayout();
			this.loginPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// appLabel
			// 
			appLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			appLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			appLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			appLabel.Location = new System.Drawing.Point(79, 19);
			appLabel.Name = "appLabel";
			appLabel.Size = new System.Drawing.Size(272, 74);
			appLabel.TabIndex = 0;
			appLabel.Text = "iFeeder";
			appLabel.Click += new System.EventHandler(this.label1_Click);
			appLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPanel_MouseDown);
			appLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPanel_MouseMove);
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			passwordLabel.Location = new System.Drawing.Point(27, 103);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new System.Drawing.Size(92, 24);
			passwordLabel.TabIndex = 17;
			passwordLabel.Text = "Password";
			// 
			// loginLabel
			// 
			loginLabel.AutoSize = true;
			loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			loginLabel.Location = new System.Drawing.Point(27, 25);
			loginLabel.Name = "loginLabel";
			loginLabel.Size = new System.Drawing.Size(57, 24);
			loginLabel.TabIndex = 16;
			loginLabel.Text = "Login";
			// 
			// labelPanel
			// 
			this.labelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.labelPanel.Controls.Add(this.exitButton);
			this.labelPanel.Controls.Add(appLabel);
			this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelPanel.Location = new System.Drawing.Point(0, 0);
			this.labelPanel.Name = "labelPanel";
			this.labelPanel.Size = new System.Drawing.Size(438, 117);
			this.labelPanel.TabIndex = 2;
			this.labelPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPanel_MouseDown);
			this.labelPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPanel_MouseMove);
			// 
			// exitButton
			// 
			this.exitButton.BackColor = System.Drawing.Color.Transparent;
			this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.exitButton.FlatAppearance.BorderSize = 0;
			this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.exitButton.Location = new System.Drawing.Point(404, 3);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(31, 40);
			this.exitButton.TabIndex = 1;
			this.exitButton.Text = "X";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// loginPanel
			// 
			this.loginPanel.BackgroundImage = global::PetsFeeder.Properties.Resources.shawarmaBig;
			this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.loginPanel.Controls.Add(this.registerLabel);
			this.loginPanel.Controls.Add(passwordLabel);
			this.loginPanel.Controls.Add(loginLabel);
			this.loginPanel.Controls.Add(this.signInButton);
			this.loginPanel.Controls.Add(this.passwordTextBox);
			this.loginPanel.Controls.Add(this.pictureBox2);
			this.loginPanel.Controls.Add(this.usernameTextBox);
			this.loginPanel.Controls.Add(this.pictureBox1);
			this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loginPanel.Location = new System.Drawing.Point(0, 117);
			this.loginPanel.Name = "loginPanel";
			this.loginPanel.Size = new System.Drawing.Size(438, 345);
			this.loginPanel.TabIndex = 3;
			// 
			// registerLabel
			// 
			this.registerLabel.AutoSize = true;
			this.registerLabel.BackColor = System.Drawing.Color.Transparent;
			this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.registerLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.registerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.registerLabel.Location = new System.Drawing.Point(12, 310);
			this.registerLabel.Name = "registerLabel";
			this.registerLabel.Size = new System.Drawing.Size(190, 20);
			this.registerLabel.TabIndex = 18;
			this.registerLabel.Text = "Don\'t have an account?";
			this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
			// 
			// signInButton
			// 
			this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.signInButton.ForeColor = System.Drawing.Color.White;
			this.signInButton.Location = new System.Drawing.Point(28, 194);
			this.signInButton.Name = "signInButton";
			this.signInButton.Size = new System.Drawing.Size(143, 50);
			this.signInButton.TabIndex = 15;
			this.signInButton.Text = "Sign in";
			this.signInButton.UseVisualStyleBackColor = false;
			this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.Location = new System.Drawing.Point(74, 137);
			this.passwordTextBox.MaxLength = 100;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = 'x';
			this.passwordTextBox.Size = new System.Drawing.Size(295, 19);
			this.passwordTextBox.TabIndex = 14;
			this.passwordTextBox.Text = "11111111";
			this.passwordTextBox.UseSystemPasswordChar = true;
			this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_MouseLeave);
			this.passwordTextBox.MouseEnter += new System.EventHandler(this.passwordTextBox_MouseEnter);
			this.passwordTextBox.MouseLeave += new System.EventHandler(this.passwordTextBox_MouseLeave);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::PetsFeeder.Properties.Resources.lockIcon;
			this.pictureBox2.Location = new System.Drawing.Point(31, 128);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(37, 39);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.ForeColor = System.Drawing.Color.Gray;
			this.usernameTextBox.Location = new System.Drawing.Point(74, 59);
			this.usernameTextBox.MaxLength = 100;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(295, 22);
			this.usernameTextBox.TabIndex = 12;
			this.usernameTextBox.Text = "Username";
			this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_MouseLeave);
			this.usernameTextBox.MouseEnter += new System.EventHandler(this.usernameTextBox_MouseEnter);
			this.usernameTextBox.MouseLeave += new System.EventHandler(this.usernameTextBox_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PetsFeeder.Properties.Resources.userIcon;
			this.pictureBox1.Location = new System.Drawing.Point(31, 50);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 39);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(438, 462);
			this.Controls.Add(this.loginPanel);
			this.Controls.Add(this.labelPanel);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginForm";
			this.labelPanel.ResumeLayout(false);
			this.loginPanel.ResumeLayout(false);
			this.loginPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}