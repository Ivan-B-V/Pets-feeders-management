namespace PetsFeeder
{
    partial class LogsUserControl
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.exportButton = new System.Windows.Forms.Button();
			this.logsPanel = new System.Windows.Forms.Panel();
			this.flowLogsPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			this.logsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.panel1.Controls.Add(this.exportButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1200, 59);
			this.panel1.TabIndex = 0;
			// 
			// exportButton
			// 
			this.exportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
			this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.exportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exportButton.ForeColor = System.Drawing.Color.White;
			this.exportButton.Location = new System.Drawing.Point(3, 3);
			this.exportButton.Name = "exportButton";
			this.exportButton.Size = new System.Drawing.Size(133, 53);
			this.exportButton.TabIndex = 9;
			this.exportButton.Text = "Export logs";
			this.exportButton.UseVisualStyleBackColor = false;
			this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
			// 
			// logsPanel
			// 
			this.logsPanel.BackgroundImage = global::PetsFeeder.Properties.Resources.advertisingImage;
			this.logsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.logsPanel.Controls.Add(this.flowLogsPanel);
			this.logsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.logsPanel.Location = new System.Drawing.Point(0, 59);
			this.logsPanel.Name = "logsPanel";
			this.logsPanel.Size = new System.Drawing.Size(1200, 561);
			this.logsPanel.TabIndex = 1;
			// 
			// flowLogsPanel
			// 
			this.flowLogsPanel.AutoScroll = true;
			this.flowLogsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLogsPanel.Location = new System.Drawing.Point(0, 0);
			this.flowLogsPanel.Name = "flowLogsPanel";
			this.flowLogsPanel.Size = new System.Drawing.Size(1200, 561);
			this.flowLogsPanel.TabIndex = 0;
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "json";
			this.saveFileDialog.Filter = "Json files(*.json)|*.json";
			// 
			// LogsUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.logsPanel);
			this.Controls.Add(this.panel1);
			this.Name = "LogsUserControl";
			this.Size = new System.Drawing.Size(1200, 620);
			this.panel1.ResumeLayout(false);
			this.logsPanel.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Panel logsPanel;
		private System.Windows.Forms.FlowLayoutPanel flowLogsPanel;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}
