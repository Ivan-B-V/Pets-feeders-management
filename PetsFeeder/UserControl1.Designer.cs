namespace PetsFeeder
{
    partial class UserControl1
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
            this.feederCapacityBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.feederTag = new System.Windows.Forms.Label();
            this.feederName = new System.Windows.Forms.Label();
            this.FeederImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FeederImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // feederCapacityBar
            // 
            this.feederCapacityBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feederCapacityBar.Location = new System.Drawing.Point(153, 116);
            this.feederCapacityBar.Name = "feederCapacityBar";
            this.feederCapacityBar.Size = new System.Drawing.Size(633, 23);
            this.feederCapacityBar.Step = 1;
            this.feederCapacityBar.TabIndex = 14;
            this.feederCapacityBar.Value = 50;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(516, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(322, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "Feed";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // feederTag
            // 
            this.feederTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feederTag.AutoSize = true;
            this.feederTag.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feederTag.Location = new System.Drawing.Point(149, 43);
            this.feederTag.Name = "feederTag";
            this.feederTag.Size = new System.Drawing.Size(53, 21);
            this.feederTag.TabIndex = 12;
            this.feederTag.Text = "@tag";
            // 
            // feederName
            // 
            this.feederName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feederName.AutoSize = true;
            this.feederName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feederName.Location = new System.Drawing.Point(149, 11);
            this.feederName.Name = "feederName";
            this.feederName.Size = new System.Drawing.Size(135, 22);
            this.feederName.TabIndex = 11;
            this.feederName.Text = "Feeder Name";
            // 
            // FeederImageBox
            // 
            this.FeederImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeederImageBox.Location = new System.Drawing.Point(14, 11);
            this.FeederImageBox.Name = "FeederImageBox";
            this.FeederImageBox.Size = new System.Drawing.Size(319, 126);
            this.FeederImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FeederImageBox.TabIndex = 10;
            this.FeederImageBox.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.feederCapacityBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.feederTag);
            this.Controls.Add(this.feederName);
            this.Controls.Add(this.FeederImageBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(851, 150);
            ((System.ComponentModel.ISupportInitialize)(this.FeederImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar feederCapacityBar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label feederTag;
        private System.Windows.Forms.Label feederName;
        private System.Windows.Forms.PictureBox FeederImageBox;
    }
}
