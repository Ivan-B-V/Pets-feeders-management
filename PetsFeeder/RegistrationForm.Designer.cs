namespace PetsFeeder
{
    partial class RegistrationForm
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
			System.Windows.Forms.Label label1;
			this.labelPanel = new System.Windows.Forms.Panel();
			this.exitButton = new System.Windows.Forms.Button();
			this.passwordTextBox1 = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.passwordTextBox2 = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.registerButton = new System.Windows.Forms.Button();
			this.signInButton = new System.Windows.Forms.Button();
			appLabel = new System.Windows.Forms.Label();
			passwordLabel = new System.Windows.Forms.Label();
			loginLabel = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			this.labelPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// appLabel
			// 
			appLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			appLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			appLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			appLabel.Location = new System.Drawing.Point(70, 20);
			appLabel.Name = "appLabel";
			appLabel.Size = new System.Drawing.Size(380, 80);
			appLabel.TabIndex = 0;
			appLabel.Text = "Registration";
			appLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPanel_MouseDown);
			appLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPanel_MouseMove);
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			passwordLabel.Location = new System.Drawing.Point(74, 216);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new System.Drawing.Size(97, 24);
			passwordLabel.TabIndex = 23;
			passwordLabel.Text = "Password:";
			// 
			// loginLabel
			// 
			loginLabel.AutoSize = true;
			loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			loginLabel.Location = new System.Drawing.Point(74, 138);
			loginLabel.Name = "loginLabel";
			loginLabel.Size = new System.Drawing.Size(57, 24);
			loginLabel.TabIndex = 22;
			loginLabel.Text = "Login";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			label1.Location = new System.Drawing.Point(74, 296);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(174, 24);
			label1.TabIndex = 26;
			label1.Text = "Re-enter password:";
			// 
			// labelPanel
			// 
			this.labelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.labelPanel.Controls.Add(this.exitButton);
			this.labelPanel.Controls.Add(appLabel);
			this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelPanel.Location = new System.Drawing.Point(0, 0);
			this.labelPanel.Name = "labelPanel";
			this.labelPanel.Size = new System.Drawing.Size(520, 120);
			this.labelPanel.TabIndex = 3;
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
			this.exitButton.Location = new System.Drawing.Point(485, 0);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(31, 40);
			this.exitButton.TabIndex = 1;
			this.exitButton.Text = "X";
			this.exitButton.UseVisualStyleBackColor = false;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// passwordTextBox1
			// 
			this.passwordTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox1.Location = new System.Drawing.Point(121, 250);
			this.passwordTextBox1.MaxLength = 100;
			this.passwordTextBox1.Name = "passwordTextBox1";
			this.passwordTextBox1.PasswordChar = 'x';
			this.passwordTextBox1.Size = new System.Drawing.Size(295, 19);
			this.passwordTextBox1.TabIndex = 21;
			this.passwordTextBox1.Text = "11111111";
			this.passwordTextBox1.UseSystemPasswordChar = true;
			this.passwordTextBox1.Leave += new System.EventHandler(this.passwordTextBox1_MouseLeave);
			this.passwordTextBox1.MouseEnter += new System.EventHandler(this.passwordTextBox1_MouseEnter);
			this.passwordTextBox1.MouseLeave += new System.EventHandler(this.passwordTextBox1_MouseLeave);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::PetsFeeder.Properties.Resources.lockIcon;
			this.pictureBox2.Location = new System.Drawing.Point(78, 241);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(37, 39);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 20;
			this.pictureBox2.TabStop = false;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ForeColor = System.Drawing.Color.Gray;
			this.usernameTextBox.Location = new System.Drawing.Point(121, 172);
			this.usernameTextBox.MaxLength = 100;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(295, 22);
			this.usernameTextBox.TabIndex = 19;
			this.usernameTextBox.Text = "Username";
			this.usernameTextBox.Leave += new System.EventHandler(this.usernameTextBox_MouseLeave);
			this.usernameTextBox.MouseEnter += new System.EventHandler(this.usernameTextBox_MouseEnter);
			this.usernameTextBox.MouseLeave += new System.EventHandler(this.usernameTextBox_MouseLeave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::PetsFeeder.Properties.Resources.userIcon;
			this.pictureBox1.Location = new System.Drawing.Point(78, 163);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(37, 39);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// passwordTextBox2
			// 
			this.passwordTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox2.Location = new System.Drawing.Point(121, 330);
			this.passwordTextBox2.MaxLength = 100;
			this.passwordTextBox2.Name = "passwordTextBox2";
			this.passwordTextBox2.PasswordChar = 'x';
			this.passwordTextBox2.Size = new System.Drawing.Size(295, 19);
			this.passwordTextBox2.TabIndex = 25;
			this.passwordTextBox2.Text = "11111111";
			this.passwordTextBox2.UseSystemPasswordChar = true;
			this.passwordTextBox2.Leave += new System.EventHandler(this.passwordTextBox2_MouseLeave);
			this.passwordTextBox2.MouseEnter += new System.EventHandler(this.passwordTextBox2_MouseEnter);
			this.passwordTextBox2.MouseLeave += new System.EventHandler(this.passwordTextBox2_MouseLeave);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::PetsFeeder.Properties.Resources.lockIcon;
			this.pictureBox3.Location = new System.Drawing.Point(78, 321);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(37, 39);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 24;
			this.pictureBox3.TabStop = false;
			// 
			// registerButton
			// 
			this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.registerButton.ForeColor = System.Drawing.Color.White;
			this.registerButton.Location = new System.Drawing.Point(73, 376);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(366, 50);
			this.registerButton.TabIndex = 27;
			this.registerButton.Text = "Send registration request";
			this.registerButton.UseVisualStyleBackColor = false;
			this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
			// 
			// signInButton
			// 
			this.signInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signInButton.ForeColor = System.Drawing.Color.White;
			this.signInButton.Location = new System.Drawing.Point(180, 432);
			this.signInButton.Name = "signInButton";
			this.signInButton.Size = new System.Drawing.Size(127, 50);
			this.signInButton.TabIndex = 28;
			this.signInButton.Text = "Sign in";
			this.signInButton.UseVisualStyleBackColor = false;
			this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(520, 500);
			this.Controls.Add(this.signInButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(label1);
			this.Controls.Add(this.passwordTextBox2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(passwordLabel);
			this.Controls.Add(loginLabel);
			this.Controls.Add(this.passwordTextBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.labelPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "RegistrationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegistrationForm";
			this.Load += new System.EventHandler(this.RegistrationForm_Load);
			this.labelPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox passwordTextBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button signInButton;
    }
}