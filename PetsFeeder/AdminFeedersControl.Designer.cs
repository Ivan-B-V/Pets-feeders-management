
namespace PetsFeeder
{
	partial class AdminFeedersControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.flowFeedersPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
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
			// AdminFeedersControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowFeedersPanel);
			this.Name = "AdminFeedersControl";
			this.Size = new System.Drawing.Size(1200, 620);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowFeedersPanel;
	}
}
