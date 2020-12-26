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
			this.feedersButton = new System.Windows.Forms.Button();
			this.requestsButton = new System.Windows.Forms.Button();
			this.accountPanel = new System.Windows.Forms.Panel();
			this.username = new System.Windows.Forms.Label();
			this.userPictureBox = new System.Windows.Forms.PictureBox();
			this.exitButton = new System.Windows.Forms.Button();
			this.contentPanel = new System.Windows.Forms.Panel();
			this.flowFeedersPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.barPanel.SuspendLayout();
			this.accountPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
			this.contentPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// barPanel
			// 
			this.barPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.barPanel.Controls.Add(this.logsButton);
			this.barPanel.Controls.Add(this.feedersButton);
			this.barPanel.Controls.Add(this.requestsButton);
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
			this.logsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logsButton.ForeColor = System.Drawing.Color.White;
			this.logsButton.Location = new System.Drawing.Point(546, 12);
			this.logsButton.Name = "logsButton";
			this.logsButton.Size = new System.Drawing.Size(133, 53);
			this.logsButton.TabIndex = 6;
			this.logsButton.Text = "LOGS";
			this.logsButton.UseVisualStyleBackColor = true;
			this.logsButton.Click += new System.EventHandler(this.logsButton_Click);
			// 
			// feedersButton
			// 
			this.feedersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.feedersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.feedersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.feedersButton.ForeColor = System.Drawing.Color.White;
			this.feedersButton.Location = new System.Drawing.Point(407, 12);
			this.feedersButton.Name = "feedersButton";
			this.feedersButton.Size = new System.Drawing.Size(133, 53);
			this.feedersButton.TabIndex = 5;
			this.feedersButton.Text = "FEEDERS";
			this.feedersButton.UseVisualStyleBackColor = false;
			this.feedersButton.Click += new System.EventHandler(this.feedersButton_Click);
			// 
			// requestsButton
			// 
			this.requestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.requestsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.requestsButton.ForeColor = System.Drawing.Color.White;
			this.requestsButton.Location = new System.Drawing.Point(256, 12);
			this.requestsButton.Name = "requestsButton";
			this.requestsButton.Size = new System.Drawing.Size(145, 53);
			this.requestsButton.TabIndex = 4;
			this.requestsButton.Text = "REQUESTS";
			this.requestsButton.UseVisualStyleBackColor = true;
			this.requestsButton.Click += new System.EventHandler(this.requestsButton_Click);
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
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.username.ForeColor = System.Drawing.Color.White;
			this.username.Location = new System.Drawing.Point(83, 18);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(132, 20);
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
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
			this.contentPanel.Controls.Add(this.flowFeedersPanel);
			this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new System.Drawing.Point(0, 80);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new System.Drawing.Size(1200, 620);
			this.contentPanel.TabIndex = 1;
			// 
			// flowFeedersPanel
			// 
			this.flowFeedersPanel.AutoScroll = true;
			this.flowFeedersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowFeedersPanel.Location = new System.Drawing.Point(0, 0);
			this.flowFeedersPanel.Name = "flowFeedersPanel";
			this.flowFeedersPanel.Size = new System.Drawing.Size(1200, 620);
			this.flowFeedersPanel.TabIndex = 0;
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
			this.contentPanel.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button requestsButton;
        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Button logsButton;
        private System.Windows.Forms.Panel contentPanel;
		private System.Windows.Forms.Button feedersButton;
		private System.Windows.Forms.FlowLayoutPanel flowFeedersPanel;
	}
}