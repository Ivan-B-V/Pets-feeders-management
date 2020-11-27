namespace PetsFeeder
{
    partial class HelpForm
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
            System.Windows.Forms.Label themeTextLabel;
            System.Windows.Forms.Label messageTextLabel;
            this.labelPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.themeTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            appLabel = new System.Windows.Forms.Label();
            themeTextLabel = new System.Windows.Forms.Label();
            messageTextLabel = new System.Windows.Forms.Label();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appLabel
            // 
            appLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            appLabel.AutoSize = true;
            appLabel.Font = new System.Drawing.Font("Futura Md BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            appLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            appLabel.Location = new System.Drawing.Point(12, 9);
            appLabel.Name = "appLabel";
            appLabel.Size = new System.Drawing.Size(400, 77);
            appLabel.TabIndex = 0;
            appLabel.Text = "iFeeder help";
            appLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPanel_MouseDown);
            appLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelPanel_MouseMove);
            // 
            // labelPanel
            // 
            this.labelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.labelPanel.Controls.Add(this.exitButton);
            this.labelPanel.Controls.Add(appLabel);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(600, 117);
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
            this.exitButton.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitButton.Location = new System.Drawing.Point(569, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(31, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // themeTextLabel
            // 
            themeTextLabel.AutoSize = true;
            themeTextLabel.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            themeTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            themeTextLabel.Location = new System.Drawing.Point(25, 130);
            themeTextLabel.Name = "themeTextLabel";
            themeTextLabel.Size = new System.Drawing.Size(82, 25);
            themeTextLabel.TabIndex = 23;
            themeTextLabel.Text = "Theme:";
            // 
            // themeTextBox
            // 
            this.themeTextBox.BackColor = System.Drawing.Color.White;
            this.themeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.themeTextBox.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.themeTextBox.Location = new System.Drawing.Point(30, 158);
            this.themeTextBox.MaxLength = 100;
            this.themeTextBox.Name = "themeTextBox";
            this.themeTextBox.Size = new System.Drawing.Size(540, 27);
            this.themeTextBox.TabIndex = 24;
            this.themeTextBox.Text = "Theme";
            this.themeTextBox.Leave += new System.EventHandler(this.themeTextBox_MouseLeave);
            this.themeTextBox.MouseEnter += new System.EventHandler(this.themeTextBox_MouseEnter);
            this.themeTextBox.MouseLeave += new System.EventHandler(this.themeTextBox_MouseLeave);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageTextBox.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.messageTextBox.Location = new System.Drawing.Point(30, 225);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(540, 400);
            this.messageTextBox.TabIndex = 25;
            this.messageTextBox.Text = "Your message";
            this.messageTextBox.Leave += new System.EventHandler(this.messageTextBox_MouseLeave);
            this.messageTextBox.MouseEnter += new System.EventHandler(this.messageTextBox_MouseEnter);
            this.messageTextBox.MouseLeave += new System.EventHandler(this.messageTextBox_MouseLeave);
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.Color.White;
            this.sendButton.Location = new System.Drawing.Point(443, 638);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(127, 50);
            this.sendButton.TabIndex = 29;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // messageTextLabel
            // 
            messageTextLabel.AutoSize = true;
            messageTextLabel.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            messageTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            messageTextLabel.Location = new System.Drawing.Point(25, 197);
            messageTextLabel.Name = "messageTextLabel";
            messageTextLabel.Size = new System.Drawing.Size(101, 25);
            messageTextLabel.TabIndex = 30;
            messageTextLabel.Text = "Message:";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(messageTextLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.themeTextBox);
            this.Controls.Add(themeTextLabel);
            this.Controls.Add(this.labelPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "HelpForm";
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel labelPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox themeTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendButton;
    }
}