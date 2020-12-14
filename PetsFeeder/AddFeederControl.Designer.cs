namespace PetsFeeder
{
    partial class AddFeederControl
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tagLabel = new System.Windows.Forms.Label();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.smartRadioButton = new System.Windows.Forms.RadioButton();
            this.notSmartRadioButton = new System.Windows.Forms.RadioButton();
            this.FeederImageBox = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.FeederImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BackColor = System.Drawing.Color.MintCream;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.nameTextBox.Location = new System.Drawing.Point(237, 147);
            this.nameTextBox.MaxLength = 20;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(331, 40);
            this.nameTextBox.TabIndex = 15;
            this.nameTextBox.Text = "Jack";
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_MouseLeave);
            this.nameTextBox.MouseEnter += new System.EventHandler(this.nameTextBox_MouseEnter);
            this.nameTextBox.MouseLeave += new System.EventHandler(this.nameTextBox_MouseLeave);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(48, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(160, 60);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(18, 147);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(217, 39);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Enter name:";
            // 
            // tagLabel
            // 
            this.tagLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagLabel.AutoSize = true;
            this.tagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagLabel.Location = new System.Drawing.Point(90, 202);
            this.tagLabel.Name = "tagLabel";
            this.tagLabel.Size = new System.Drawing.Size(144, 39);
            this.tagLabel.TabIndex = 18;
            this.tagLabel.Text = "Set tag:";
            // 
            // tagTextBox
            // 
            this.tagTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tagTextBox.BackColor = System.Drawing.Color.MintCream;
            this.tagTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tagTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagTextBox.ForeColor = System.Drawing.Color.Gray;
            this.tagTextBox.Location = new System.Drawing.Point(237, 202);
            this.tagTextBox.MaxLength = 20;
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(331, 40);
            this.tagTextBox.TabIndex = 17;
            this.tagTextBox.Text = "@tag";
            this.tagTextBox.Leave += new System.EventHandler(this.tagTextBox_MouseLeave);
            this.tagTextBox.MouseEnter += new System.EventHandler(this.tagTextBox_MouseEnter);
            this.tagTextBox.MouseLeave += new System.EventHandler(this.tagTextBox_MouseLeave);
            // 
            // smartRadioButton
            // 
            this.smartRadioButton.AutoSize = true;
            this.smartRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartRadioButton.Location = new System.Drawing.Point(658, 147);
            this.smartRadioButton.Name = "smartRadioButton";
            this.smartRadioButton.Size = new System.Drawing.Size(86, 29);
            this.smartRadioButton.TabIndex = 19;
            this.smartRadioButton.TabStop = true;
            this.smartRadioButton.Text = "Smart";
            this.smartRadioButton.UseVisualStyleBackColor = true;
            // 
            // notSmartRadioButton
            // 
            this.notSmartRadioButton.AutoSize = true;
            this.notSmartRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notSmartRadioButton.Location = new System.Drawing.Point(658, 202);
            this.notSmartRadioButton.Name = "notSmartRadioButton";
            this.notSmartRadioButton.Size = new System.Drawing.Size(122, 29);
            this.notSmartRadioButton.TabIndex = 20;
            this.notSmartRadioButton.TabStop = true;
            this.notSmartRadioButton.Text = "Not smart";
            this.notSmartRadioButton.UseVisualStyleBackColor = true;
            // 
            // FeederImageBox
            // 
            this.FeederImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeederImageBox.Image = global::PetsFeeder.Properties.Resources.dog;
            this.FeederImageBox.Location = new System.Drawing.Point(3, 3);
            this.FeederImageBox.Name = "FeederImageBox";
            this.FeederImageBox.Size = new System.Drawing.Size(128, 126);
            this.FeederImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FeederImageBox.TabIndex = 13;
            this.FeederImageBox.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "HH : mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Futura Bk BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(426, 319);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 33);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // AddFeederControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.notSmartRadioButton);
            this.Controls.Add(this.smartRadioButton);
            this.Controls.Add(this.tagLabel);
            this.Controls.Add(this.tagTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.FeederImageBox);
            this.Name = "AddFeederControl";
            this.Size = new System.Drawing.Size(950, 670);
            ((System.ComponentModel.ISupportInitialize)(this.FeederImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox FeederImageBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label tagLabel;
        private System.Windows.Forms.TextBox tagTextBox;
        private System.Windows.Forms.RadioButton smartRadioButton;
        private System.Windows.Forms.RadioButton notSmartRadioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
