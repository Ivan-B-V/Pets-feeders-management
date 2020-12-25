namespace PetsFeeder
{
    partial class RequestItem
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
			this.usernameLabel = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.userPictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.usernameLabel.Location = new System.Drawing.Point(141, 22);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(87, 24);
			this.usernameLabel.TabIndex = 1;
			this.usernameLabel.Text = "StpdUser";
			// 
			// addButton
			// 
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.addButton.FlatAppearance.BorderSize = 0;
			this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addButton.ForeColor = System.Drawing.Color.White;
			this.addButton.Location = new System.Drawing.Point(821, 20);
			this.addButton.Margin = new System.Windows.Forms.Padding(10);
			this.addButton.MaximumSize = new System.Drawing.Size(120, 40);
			this.addButton.MinimumSize = new System.Drawing.Size(120, 40);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(120, 40);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "Add";
			this.addButton.UseVisualStyleBackColor = false;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// removeButton
			// 
			this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.removeButton.FlatAppearance.BorderSize = 0;
			this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.removeButton.ForeColor = System.Drawing.Color.White;
			this.removeButton.Location = new System.Drawing.Point(821, 88);
			this.removeButton.Margin = new System.Windows.Forms.Padding(10);
			this.removeButton.MaximumSize = new System.Drawing.Size(120, 40);
			this.removeButton.MinimumSize = new System.Drawing.Size(120, 40);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(120, 40);
			this.removeButton.TabIndex = 3;
			this.removeButton.Text = "Remove";
			this.removeButton.UseVisualStyleBackColor = false;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// userPictureBox
			// 
			this.userPictureBox.Image = global::PetsFeeder.Properties.Resources.userImage;
			this.userPictureBox.Location = new System.Drawing.Point(22, 22);
			this.userPictureBox.MaximumSize = new System.Drawing.Size(100, 100);
			this.userPictureBox.Name = "userPictureBox";
			this.userPictureBox.Size = new System.Drawing.Size(100, 100);
			this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userPictureBox.TabIndex = 0;
			this.userPictureBox.TabStop = false;
			// 
			// RequestItem
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.userPictureBox);
			this.MinimumSize = new System.Drawing.Size(780, 148);
			this.Name = "RequestItem";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.Size = new System.Drawing.Size(950, 148);
			((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button removeButton;
        public System.Windows.Forms.Button addButton;
    }
}
