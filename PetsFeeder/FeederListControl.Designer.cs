namespace PetsFeeder
{
    partial class FeederListControl
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
            this.feederCustomizationPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SetScheduleButton = new System.Windows.Forms.Button();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.feedButton = new System.Windows.Forms.Button();
            this.FeederImageBox = new System.Windows.Forms.PictureBox();
            this.feederName = new System.Windows.Forms.Label();
            this.feedersListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.feederCustomizationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeederImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // feederCustomizationPanel
            // 
            this.feederCustomizationPanel.BackColor = System.Drawing.Color.MintCream;
            this.feederCustomizationPanel.Controls.Add(this.button2);
            this.feederCustomizationPanel.Controls.Add(this.SetScheduleButton);
            this.feederCustomizationPanel.Controls.Add(this.tagTextBox);
            this.feederCustomizationPanel.Controls.Add(this.feedButton);
            this.feederCustomizationPanel.Controls.Add(this.FeederImageBox);
            this.feederCustomizationPanel.Controls.Add(this.feederName);
            this.feederCustomizationPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.feederCustomizationPanel.Location = new System.Drawing.Point(700, 0);
            this.feederCustomizationPanel.Name = "feederCustomizationPanel";
            this.feederCustomizationPanel.Size = new System.Drawing.Size(250, 670);
            this.feederCustomizationPanel.TabIndex = 10;
            this.feederCustomizationPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(20, 627);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Export/Import schedule\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SetScheduleButton
            // 
            this.SetScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.SetScheduleButton.FlatAppearance.BorderSize = 0;
            this.SetScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetScheduleButton.ForeColor = System.Drawing.Color.White;
            this.SetScheduleButton.Location = new System.Drawing.Point(36, 561);
            this.SetScheduleButton.Name = "SetScheduleButton";
            this.SetScheduleButton.Size = new System.Drawing.Size(178, 60);
            this.SetScheduleButton.TabIndex = 12;
            this.SetScheduleButton.Text = "Set schedule";
            this.SetScheduleButton.UseVisualStyleBackColor = false;
            this.SetScheduleButton.Click += new System.EventHandler(this.SetScheduleButton_Click);
            // 
            // tagTextBox
            // 
            this.tagTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagTextBox.BackColor = System.Drawing.Color.MintCream;
            this.tagTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tagTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tagTextBox.Location = new System.Drawing.Point(55, 198);
            this.tagTextBox.MaxLength = 50;
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(100, 26);
            this.tagTextBox.TabIndex = 11;
            this.tagTextBox.Text = "@myHouse";
            this.tagTextBox.Leave += new System.EventHandler(this.tagTextBox_LostFocus);
            // 
            // feedButton
            // 
            this.feedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.feedButton.FlatAppearance.BorderSize = 0;
            this.feedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedButton.ForeColor = System.Drawing.Color.White;
            this.feedButton.Location = new System.Drawing.Point(45, 243);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(160, 60);
            this.feedButton.TabIndex = 10;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = false;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // FeederImageBox
            // 
            this.FeederImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeederImageBox.Image = global::PetsFeeder.Properties.Resources.dog;
            this.FeederImageBox.Location = new System.Drawing.Point(55, 66);
            this.FeederImageBox.Name = "FeederImageBox";
            this.FeederImageBox.Size = new System.Drawing.Size(128, 126);
            this.FeederImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FeederImageBox.TabIndex = 6;
            this.FeederImageBox.TabStop = false;
            // 
            // feederName
            // 
            this.feederName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feederName.AutoSize = true;
            this.feederName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feederName.Location = new System.Drawing.Point(75, 18);
            this.feederName.Name = "feederName";
            this.feederName.Size = new System.Drawing.Size(100, 42);
            this.feederName.TabIndex = 1;
            this.feederName.Text = "Jack";
            // 
            // feedersListPanel
            // 
            this.feedersListPanel.AutoScroll = true;
            this.feedersListPanel.BackColor = System.Drawing.Color.Transparent;
            this.feedersListPanel.BackgroundImage = global::PetsFeeder.Properties.Resources.shawarmaBig;
            this.feedersListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.feedersListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedersListPanel.Location = new System.Drawing.Point(0, 0);
            this.feedersListPanel.Name = "feedersListPanel";
            this.feedersListPanel.Size = new System.Drawing.Size(700, 670);
            this.feedersListPanel.TabIndex = 11;
            // 
            // FeederListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.feedersListPanel);
            this.Controls.Add(this.feederCustomizationPanel);
            this.Name = "FeederListControl";
            this.Size = new System.Drawing.Size(950, 670);
            this.feederCustomizationPanel.ResumeLayout(false);
            this.feederCustomizationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeederImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel feederCustomizationPanel;
        private System.Windows.Forms.TextBox tagTextBox;
        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.PictureBox FeederImageBox;
        private System.Windows.Forms.Label feederName;
        private System.Windows.Forms.FlowLayoutPanel feedersListPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SetScheduleButton;
    }
}
