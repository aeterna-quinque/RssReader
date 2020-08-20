namespace RssReader
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.TimeButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.PathButton = new System.Windows.Forms.Button();
            this.CurrTimeLabel = new System.Windows.Forms.Label();
            this.CurrTimeBox = new System.Windows.Forms.TextBox();
            this.CurrSiteBox = new System.Windows.Forms.TextBox();
            this.CurrentPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 12);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(504, 544);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.Text = "";
            this.OutputBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.OutputBox_LinkClicked);
            // 
            // RefreshButton
            // 
            this.RefreshButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshButton.Location = new System.Drawing.Point(522, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(148, 41);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // TimeButton
            // 
            this.TimeButton.Location = new System.Drawing.Point(525, 130);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(148, 23);
            this.TimeButton.TabIndex = 3;
            this.TimeButton.Text = "Change";
            this.TimeButton.UseVisualStyleBackColor = true;
            this.TimeButton.Click += new System.EventHandler(this.TimeButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(522, 88);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(116, 13);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "Time interval (seconds)";
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(525, 104);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(148, 20);
            this.TimeBox.TabIndex = 5;
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(525, 209);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(148, 20);
            this.PathBox.TabIndex = 8;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(522, 193);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(49, 13);
            this.PathLabel.TabIndex = 7;
            this.PathLabel.Text = "Rss path";
            // 
            // PathButton
            // 
            this.PathButton.Location = new System.Drawing.Point(525, 235);
            this.PathButton.Name = "PathButton";
            this.PathButton.Size = new System.Drawing.Size(148, 23);
            this.PathButton.TabIndex = 6;
            this.PathButton.Text = "Change";
            this.PathButton.UseVisualStyleBackColor = true;
            this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
            // 
            // CurrTimeLabel
            // 
            this.CurrTimeLabel.AutoSize = true;
            this.CurrTimeLabel.Location = new System.Drawing.Point(522, 311);
            this.CurrTimeLabel.Name = "CurrTimeLabel";
            this.CurrTimeLabel.Size = new System.Drawing.Size(105, 13);
            this.CurrTimeLabel.TabIndex = 9;
            this.CurrTimeLabel.Text = "Current Time Interval";
            // 
            // CurrTimeBox
            // 
            this.CurrTimeBox.Location = new System.Drawing.Point(525, 327);
            this.CurrTimeBox.Name = "CurrTimeBox";
            this.CurrTimeBox.Size = new System.Drawing.Size(148, 20);
            this.CurrTimeBox.TabIndex = 10;
            // 
            // CurrSiteBox
            // 
            this.CurrSiteBox.Location = new System.Drawing.Point(525, 371);
            this.CurrSiteBox.Name = "CurrSiteBox";
            this.CurrSiteBox.Size = new System.Drawing.Size(148, 20);
            this.CurrSiteBox.TabIndex = 12;
            // 
            // CurrentPathLabel
            // 
            this.CurrentPathLabel.AutoSize = true;
            this.CurrentPathLabel.Location = new System.Drawing.Point(522, 355);
            this.CurrentPathLabel.Name = "CurrentPathLabel";
            this.CurrentPathLabel.Size = new System.Drawing.Size(62, 13);
            this.CurrentPathLabel.TabIndex = 11;
            this.CurrentPathLabel.Text = "Current Site";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 568);
            this.Controls.Add(this.CurrSiteBox);
            this.Controls.Add(this.CurrentPathLabel);
            this.Controls.Add(this.CurrTimeBox);
            this.Controls.Add(this.CurrTimeLabel);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.PathButton);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.OutputBox);
            this.Name = "Form1";
            this.Text = "RssReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button PathButton;
        private System.Windows.Forms.Label CurrTimeLabel;
        private System.Windows.Forms.TextBox CurrTimeBox;
        private System.Windows.Forms.TextBox CurrSiteBox;
        private System.Windows.Forms.Label CurrentPathLabel;
    }
}

