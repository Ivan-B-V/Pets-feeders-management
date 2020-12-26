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
			this.usersListPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// usersListPanel
			// 
			this.usersListPanel.AutoScroll = true;
			this.usersListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.usersListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.usersListPanel.Location = new System.Drawing.Point(0, 0);
			this.usersListPanel.Name = "usersListPanel";
			this.usersListPanel.Size = new System.Drawing.Size(1200, 620);
			this.usersListPanel.TabIndex = 1;
			// 
			// AdminUsersControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.usersListPanel);
			this.Name = "AdminUsersControl";
			this.Size = new System.Drawing.Size(1200, 620);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel usersListPanel;
    }
}
