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
            this.FeederImageBox = new System.Windows.Forms.PictureBox();
            this.feederName = new System.Windows.Forms.Label();
            this.feederTag = new System.Windows.Forms.Label();
            this.feederCapacityBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.FeederImageBox)).BeginInit();
            this.SuspendLayout();
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
            // feederName
            // 
            this.feederName.AutoSize = true;
            this.feederName.BackColor = System.Drawing.Color.Transparent;
            this.feederName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feederName.Location = new System.Drawing.Point(155, 11);
            this.feederName.Name = "feederName";
            this.feederName.Size = new System.Drawing.Size(135, 22);
            this.feederName.TabIndex = 6;
            this.feederName.Text = "Feeder Name";
            // 
            // feederTag
            // 
            this.feederTag.AutoSize = true;
            this.feederTag.BackColor = System.Drawing.Color.Transparent;
            this.feederTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feederTag.Location = new System.Drawing.Point(155, 43);
            this.feederTag.Name = "feederTag";
            this.feederTag.Size = new System.Drawing.Size(53, 21);
            this.feederTag.TabIndex = 7;
            this.feederTag.Text = "@tag";
            // 
            // feederCapacityBar
            // 
            this.feederCapacityBar.Enabled = false;
            this.feederCapacityBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.feederCapacityBar.Location = new System.Drawing.Point(159, 116);
            this.feederCapacityBar.Name = "feederCapacityBar";
            this.feederCapacityBar.Size = new System.Drawing.Size(442, 23);
            this.feederCapacityBar.Step = 1;
            this.feederCapacityBar.TabIndex = 9;
            this.feederCapacityBar.Value = 50;
            // 
            // FeedersListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.feederCapacityBar);
            this.Controls.Add(this.feederTag);
            this.Controls.Add(this.feederName);
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
        private System.Windows.Forms.Label feederName;
        private System.Windows.Forms.Label feederTag;
        private System.Windows.Forms.ProgressBar feederCapacityBar;
    }
}
