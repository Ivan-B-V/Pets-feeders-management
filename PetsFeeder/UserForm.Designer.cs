namespace PetsFeeder
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.barPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.addFeederButton = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.selectedButtonPanel = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Button();
            this.myFeedersButton = new System.Windows.Forms.Button();
            this.viewLogsButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.barPanel.SuspendLayout();
            this.accountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // barPanel
            // 
            this.barPanel.AutoSize = true;
            this.barPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.barPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.barPanel.Controls.Add(this.exitButton);
            this.barPanel.Controls.Add(this.searchTextBox);
            this.barPanel.Controls.Add(this.accountPanel);
            this.barPanel.Controls.Add(this.addFeederButton);
            this.barPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barPanel.Location = new System.Drawing.Point(0, 0);
            this.barPanel.MinimumSize = new System.Drawing.Size(0, 80);
            this.barPanel.Name = "barPanel";
            this.barPanel.Size = new System.Drawing.Size(1200, 80);
            this.barPanel.TabIndex = 0;
            this.barPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barPanel_MouseDown);
            this.barPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barPanel_MouseMove);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(1170, 0);
            this.exitButton.MaximumSize = new System.Drawing.Size(30, 40);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(30, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(273, 26);
            this.searchTextBox.MaxLength = 50;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(244, 26);
            this.searchTextBox.TabIndex = 2;
            // 
            // accountPanel
            // 
            this.accountPanel.BackColor = System.Drawing.Color.Transparent;
            this.accountPanel.Controls.Add(this.usernameLabel);
            this.accountPanel.Controls.Add(this.userPictureBox);
            this.accountPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.accountPanel.Location = new System.Drawing.Point(0, 0);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(250, 80);
            this.accountPanel.TabIndex = 1;
            this.accountPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barPanel_MouseDown);
            this.accountPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barPanel_MouseMove);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(83, 18);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(120, 20);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Ivan Buyeuski";
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
            // addFeederButton
            // 
            this.addFeederButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.addFeederButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addFeederButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFeederButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFeederButton.ForeColor = System.Drawing.Color.White;
            this.addFeederButton.Location = new System.Drawing.Point(587, 18);
            this.addFeederButton.Name = "addFeederButton";
            this.addFeederButton.Size = new System.Drawing.Size(155, 39);
            this.addFeederButton.TabIndex = 1;
            this.addFeederButton.Text = "Add feeder";
            this.addFeederButton.UseVisualStyleBackColor = false;
            this.addFeederButton.Click += new System.EventHandler(this.addFeederButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.panelMenu.Controls.Add(this.selectedButtonPanel);
            this.panelMenu.Controls.Add(this.helpButton);
            this.panelMenu.Controls.Add(this.myFeedersButton);
            this.panelMenu.Controls.Add(this.viewLogsButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 80);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 670);
            this.panelMenu.TabIndex = 7;
            // 
            // selectedButtonPanel
            // 
            this.selectedButtonPanel.BackColor = System.Drawing.Color.White;
            this.selectedButtonPanel.Location = new System.Drawing.Point(9, 13);
            this.selectedButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.selectedButtonPanel.Name = "selectedButtonPanel";
            this.selectedButtonPanel.Size = new System.Drawing.Size(10, 50);
            this.selectedButtonPanel.TabIndex = 5;
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.BackColor = System.Drawing.Color.Transparent;
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.White;
            this.helpButton.Location = new System.Drawing.Point(0, 606);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(250, 50);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "Write us";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // myFeedersButton
            // 
            this.myFeedersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myFeedersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.myFeedersButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.myFeedersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myFeedersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myFeedersButton.ForeColor = System.Drawing.Color.White;
            this.myFeedersButton.Location = new System.Drawing.Point(15, 13);
            this.myFeedersButton.Name = "myFeedersButton";
            this.myFeedersButton.Size = new System.Drawing.Size(229, 50);
            this.myFeedersButton.TabIndex = 3;
            this.myFeedersButton.Text = "My feeders";
            this.myFeedersButton.UseVisualStyleBackColor = false;
            this.myFeedersButton.Click += new System.EventHandler(this.myFeedersButton_Click);
            // 
            // viewLogsButton
            // 
            this.viewLogsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.viewLogsButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.viewLogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLogsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogsButton.ForeColor = System.Drawing.Color.White;
            this.viewLogsButton.Location = new System.Drawing.Point(15, 79);
            this.viewLogsButton.Name = "viewLogsButton";
            this.viewLogsButton.Size = new System.Drawing.Size(229, 50);
            this.viewLogsButton.TabIndex = 2;
            this.viewLogsButton.Text = "View logs";
            this.viewLogsButton.UseVisualStyleBackColor = false;
            this.viewLogsButton.Click += new System.EventHandler(this.viewLogsButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.AutoSize = true;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(250, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(950, 670);
            this.contentPanel.TabIndex = 8;
            // 
            // UserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.barPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 750);
            this.MinimumSize = new System.Drawing.Size(950, 750);
            this.Name = "UserForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetsFeeder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barPanel.ResumeLayout(false);
            this.barPanel.PerformLayout();
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barPanel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button myFeedersButton;
        private System.Windows.Forms.Button viewLogsButton;
        private System.Windows.Forms.Button addFeederButton;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel selectedButtonPanel;
        private System.Windows.Forms.Panel contentPanel;
    }
}

