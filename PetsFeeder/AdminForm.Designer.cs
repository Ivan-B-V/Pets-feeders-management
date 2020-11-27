namespace PetsFeeder
{
    partial class AdminForm
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
            this.barPanel = new System.Windows.Forms.Panel();
            this.logsButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.barPanel.SuspendLayout();
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // barPanel
            // 
            this.barPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.barPanel.Controls.Add(this.logsButton);
            this.barPanel.Controls.Add(this.helpButton);
            this.barPanel.Controls.Add(this.usersButton);
            this.barPanel.Controls.Add(this.accountPanel);
            this.barPanel.Controls.Add(this.exitButton);
            this.barPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barPanel.Location = new System.Drawing.Point(0, 0);
            this.barPanel.Name = "barPanel";
            this.barPanel.Size = new System.Drawing.Size(1200, 80);
            this.barPanel.TabIndex = 0;
            this.barPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barPanel_MouseDown);
            this.barPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barPanel_MouseMove);
            // 
            // logsButton
            // 
            this.logsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logsButton.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsButton.ForeColor = System.Drawing.Color.White;
            this.logsButton.Location = new System.Drawing.Point(553, 12);
            this.logsButton.Name = "logsButton";
            this.logsButton.Size = new System.Drawing.Size(133, 53);
            this.logsButton.TabIndex = 6;
            this.logsButton.Text = "LOGS";
            this.logsButton.UseVisualStyleBackColor = true;
            this.logsButton.Click += new System.EventHandler(this.logsButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(404, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(133, 53);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersButton.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.Location = new System.Drawing.Point(256, 12);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(133, 53);
            this.usersButton.TabIndex = 4;
            this.usersButton.Text = "USERS";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // accountPanel
            // 
            this.accountPanel.BackColor = System.Drawing.Color.Transparent;
            this.accountPanel.Controls.Add(this.username);
            this.accountPanel.Controls.Add(this.userPictureBox);
            this.accountPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.accountPanel.Location = new System.Drawing.Point(0, 0);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(250, 80);
            this.accountPanel.TabIndex = 3;
            this.accountPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barPanel_MouseDown);
            this.accountPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barPanel_MouseMove);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Futura Bk BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(83, 18);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(131, 19);
            this.username.TabIndex = 1;
            this.username.Text = "The best admin";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.userPictureBox.Image = global::PetsFeeder.Properties.Resources.astronavt_meduza_square;
            this.userPictureBox.Location = new System.Drawing.Point(15, 15);
            this.userPictureBox.MaximumSize = new System.Drawing.Size(50, 50);
            this.userPictureBox.MinimumSize = new System.Drawing.Size(50, 50);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(50, 50);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(1170, 0);
            this.exitButton.MaximumSize = new System.Drawing.Size(30, 40);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1200, 620);
            this.contentPanel.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.barPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.barPanel.ResumeLayout(false);
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button logsButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Panel contentPanel;
    }
}