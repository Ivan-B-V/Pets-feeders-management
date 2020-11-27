namespace PetsFeeder
{
    partial class AdminUsersControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuPanel = new System.Windows.Forms.Panel();
            this.requestsButton = new System.Windows.Forms.Button();
            this.usersBaseButton = new System.Windows.Forms.Button();
            this.usersListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.selectedButtonPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.menuPanel.Controls.Add(this.selectedButtonPanel);
            this.menuPanel.Controls.Add(this.usersBaseButton);
            this.menuPanel.Controls.Add(this.requestsButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 620);
            this.menuPanel.TabIndex = 0;
            // 
            // requestsButton
            // 
            this.requestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestsButton.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsButton.ForeColor = System.Drawing.Color.White;
            this.requestsButton.Location = new System.Drawing.Point(20, 43);
            this.requestsButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.requestsButton.Name = "requestsButton";
            this.requestsButton.Size = new System.Drawing.Size(175, 50);
            this.requestsButton.TabIndex = 0;
            this.requestsButton.Text = "Requests";
            this.requestsButton.UseVisualStyleBackColor = true;
            this.requestsButton.Click += new System.EventHandler(this.requestsButton_Click);
            // 
            // usersBaseButton
            // 
            this.usersBaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBaseButton.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBaseButton.ForeColor = System.Drawing.Color.White;
            this.usersBaseButton.Location = new System.Drawing.Point(19, 99);
            this.usersBaseButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.usersBaseButton.Name = "usersBaseButton";
            this.usersBaseButton.Size = new System.Drawing.Size(175, 50);
            this.usersBaseButton.TabIndex = 1;
            this.usersBaseButton.Text = "Users list";
            this.usersBaseButton.UseVisualStyleBackColor = true;
            this.usersBaseButton.Click += new System.EventHandler(this.usersBaseButton_Click);
            // 
            // usersListPanel
            // 
            this.usersListPanel.AutoScroll = true;
            this.usersListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.usersListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersListPanel.Location = new System.Drawing.Point(200, 0);
            this.usersListPanel.Name = "usersListPanel";
            this.usersListPanel.Size = new System.Drawing.Size(1000, 620);
            this.usersListPanel.TabIndex = 1;
            // 
            // selectedButtonPanel
            // 
            this.selectedButtonPanel.BackColor = System.Drawing.Color.White;
            this.selectedButtonPanel.Location = new System.Drawing.Point(10, 43);
            this.selectedButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.selectedButtonPanel.Name = "selectedButtonPanel";
            this.selectedButtonPanel.Size = new System.Drawing.Size(10, 50);
            this.selectedButtonPanel.TabIndex = 2;
            // 
            // AdminUsersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.usersListPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "AdminUsersControl";
            this.Size = new System.Drawing.Size(1200, 620);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button usersBaseButton;
        private System.Windows.Forms.Button requestsButton;
        private System.Windows.Forms.FlowLayoutPanel usersListPanel;
        private System.Windows.Forms.Panel selectedButtonPanel;
    }
}
