namespace PetsFeeder
{
    partial class FeedersListItem
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
			this.feederNameLabel = new System.Windows.Forms.Label();
			this.feederTagLabel = new System.Windows.Forms.Label();
			this.feederCapacityBar = new System.Windows.Forms.ProgressBar();
			this.feederCapacity = new System.Windows.Forms.Label();
			this.FeederImageBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.FeederImageBox)).BeginInit();
			this.SuspendLayout();
			// 
			// feederNameLabel
			// 
			this.feederNameLabel.AutoSize = true;
			this.feederNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.feederNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.feederNameLabel.Location = new System.Drawing.Point(155, 11);
			this.feederNameLabel.Name = "feederNameLabel";
			this.feederNameLabel.Size = new System.Drawing.Size(128, 24);
			this.feederNameLabel.TabIndex = 6;
			this.feederNameLabel.Text = "Feeder Name";
			// 
			// feederTagLabel
			// 
			this.feederTagLabel.AutoSize = true;
			this.feederTagLabel.BackColor = System.Drawing.Color.Transparent;
			this.feederTagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.feederTagLabel.Location = new System.Drawing.Point(155, 43);
			this.feederTagLabel.Name = "feederTagLabel";
			this.feederTagLabel.Size = new System.Drawing.Size(48, 20);
			this.feederTagLabel.TabIndex = 7;
			this.feederTagLabel.Text = "@tag";
			// 
			// feederCapacityBar
			// 
			this.feederCapacityBar.Enabled = false;
			this.feederCapacityBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.feederCapacityBar.Location = new System.Drawing.Point(159, 116);
			this.feederCapacityBar.Name = "feederCapacityBar";
			this.feederCapacityBar.Size = new System.Drawing.Size(432, 23);
			this.feederCapacityBar.Step = 1;
			this.feederCapacityBar.TabIndex = 9;
			this.feederCapacityBar.Value = 50;
			// 
			// feederCapacity
			// 
			this.feederCapacity.AutoSize = true;
			this.feederCapacity.BackColor = System.Drawing.Color.Transparent;
			this.feederCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.feederCapacity.Location = new System.Drawing.Point(597, 115);
			this.feederCapacity.Name = "feederCapacity";
			this.feederCapacity.Size = new System.Drawing.Size(55, 24);
			this.feederCapacity.TabIndex = 11;
			this.feederCapacity.Text = "123%";
			// 
			// FeederImageBox
			// 
			this.FeederImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.FeederImageBox.BackColor = System.Drawing.Color.Transparent;
			this.FeederImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.FeederImageBox.Image = global::PetsFeeder.Properties.Resources.dog;
			this.FeederImageBox.Location = new System.Drawing.Point(20, 11);
			this.FeederImageBox.Name = "FeederImageBox";
			this.FeederImageBox.Size = new System.Drawing.Size(128, 130);
			this.FeederImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.FeederImageBox.TabIndex = 5;
			this.FeederImageBox.TabStop = false;
			// 
			// FeedersListItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.feederCapacity);
			this.Controls.Add(this.feederCapacityBar);
			this.Controls.Add(this.feederTagLabel);
			this.Controls.Add(this.feederNameLabel);
			this.Controls.Add(this.FeederImageBox);
			this.Name = "FeedersListItem";
			this.Size = new System.Drawing.Size(660, 152);
			this.Load += new System.EventHandler(this.FeedersListItem_Load);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FeedersListItem_MouseClick);
			((System.ComponentModel.ISupportInitialize)(this.FeederImageBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FeederImageBox;
        private System.Windows.Forms.Label feederNameLabel;
        private System.Windows.Forms.Label feederTagLabel;
        private System.Windows.Forms.ProgressBar feederCapacityBar;
		private System.Windows.Forms.Label feederCapacity;
	}
}
