namespace Sample1
{
    partial class Calendar
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.CalendarTop_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(60, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TabStop = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // CalendarTop_button
            // 
            this.CalendarTop_button.Location = new System.Drawing.Point(233, 244);
            this.CalendarTop_button.Name = "CalendarTop_button";
            this.CalendarTop_button.Size = new System.Drawing.Size(91, 29);
            this.CalendarTop_button.TabIndex = 1;
            this.CalendarTop_button.Text = "Topへ";
            this.CalendarTop_button.UseVisualStyleBackColor = true;
            this.CalendarTop_button.Click += new System.EventHandler(this.CalendarTop_button_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 303);
            this.Controls.Add(this.CalendarTop_button);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Calendar";
            this.Text = "カレンダー";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button CalendarTop_button;
    }
}