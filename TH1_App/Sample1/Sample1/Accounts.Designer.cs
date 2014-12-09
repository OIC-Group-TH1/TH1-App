namespace Sample1
{
    partial class Accounts
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
            this.Acounts_Change = new System.Windows.Forms.Label();
            this.Acounts_Total = new System.Windows.Forms.Label();
            this.Acounts_Staff = new System.Windows.Forms.Label();
            this.Acounts_Name = new System.Windows.Forms.Label();
            this.Acounts_Date = new System.Windows.Forms.Label();
            this.AcountsChange_label = new System.Windows.Forms.Label();
            this.AcountsReceive_label = new System.Windows.Forms.Label();
            this.AcountsTotal_label = new System.Windows.Forms.Label();
            this.AcountsStaff_label = new System.Windows.Forms.Label();
            this.AcountsName_label = new System.Windows.Forms.Label();
            this.AcountsDate_label = new System.Windows.Forms.Label();
            this.AcountsOk_button = new System.Windows.Forms.Button();
            this.AcountsBack_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Accounts_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Recieve = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Acounts_Change
            // 
            this.Acounts_Change.AutoSize = true;
            this.Acounts_Change.Location = new System.Drawing.Point(534, 347);
            this.Acounts_Change.Name = "Acounts_Change";
            this.Acounts_Change.Size = new System.Drawing.Size(35, 12);
            this.Acounts_Change.TabIndex = 33;
            this.Acounts_Change.Text = "label6";
            // 
            // Acounts_Total
            // 
            this.Acounts_Total.AutoSize = true;
            this.Acounts_Total.Location = new System.Drawing.Point(534, 302);
            this.Acounts_Total.Name = "Acounts_Total";
            this.Acounts_Total.Size = new System.Drawing.Size(35, 12);
            this.Acounts_Total.TabIndex = 31;
            this.Acounts_Total.Text = "label4";
            // 
            // Acounts_Staff
            // 
            this.Acounts_Staff.AutoSize = true;
            this.Acounts_Staff.Location = new System.Drawing.Point(514, 31);
            this.Acounts_Staff.Name = "Acounts_Staff";
            this.Acounts_Staff.Size = new System.Drawing.Size(35, 12);
            this.Acounts_Staff.TabIndex = 30;
            this.Acounts_Staff.Text = "label3";
            // 
            // Acounts_Name
            // 
            this.Acounts_Name.AutoSize = true;
            this.Acounts_Name.Location = new System.Drawing.Point(70, 65);
            this.Acounts_Name.Name = "Acounts_Name";
            this.Acounts_Name.Size = new System.Drawing.Size(35, 12);
            this.Acounts_Name.TabIndex = 29;
            this.Acounts_Name.Text = "label2";
            // 
            // Acounts_Date
            // 
            this.Acounts_Date.AutoSize = true;
            this.Acounts_Date.Location = new System.Drawing.Point(70, 31);
            this.Acounts_Date.Name = "Acounts_Date";
            this.Acounts_Date.Size = new System.Drawing.Size(35, 12);
            this.Acounts_Date.TabIndex = 28;
            this.Acounts_Date.Text = "label1";
            // 
            // AcountsChange_label
            // 
            this.AcountsChange_label.AutoSize = true;
            this.AcountsChange_label.Location = new System.Drawing.Point(426, 347);
            this.AcountsChange_label.Name = "AcountsChange_label";
            this.AcountsChange_label.Size = new System.Drawing.Size(35, 12);
            this.AcountsChange_label.TabIndex = 27;
            this.AcountsChange_label.Text = "お釣り";
            // 
            // AcountsReceive_label
            // 
            this.AcountsReceive_label.AutoSize = true;
            this.AcountsReceive_label.Location = new System.Drawing.Point(426, 323);
            this.AcountsReceive_label.Name = "AcountsReceive_label";
            this.AcountsReceive_label.Size = new System.Drawing.Size(37, 12);
            this.AcountsReceive_label.TabIndex = 26;
            this.AcountsReceive_label.Text = "預り金";
            // 
            // AcountsTotal_label
            // 
            this.AcountsTotal_label.AutoSize = true;
            this.AcountsTotal_label.Location = new System.Drawing.Point(426, 302);
            this.AcountsTotal_label.Name = "AcountsTotal_label";
            this.AcountsTotal_label.Size = new System.Drawing.Size(29, 12);
            this.AcountsTotal_label.TabIndex = 25;
            this.AcountsTotal_label.Text = "合計";
            // 
            // AcountsStaff_label
            // 
            this.AcountsStaff_label.AutoSize = true;
            this.AcountsStaff_label.Location = new System.Drawing.Point(449, 31);
            this.AcountsStaff_label.Name = "AcountsStaff_label";
            this.AcountsStaff_label.Size = new System.Drawing.Size(41, 12);
            this.AcountsStaff_label.TabIndex = 24;
            this.AcountsStaff_label.Text = "社員名";
            // 
            // AcountsName_label
            // 
            this.AcountsName_label.AutoSize = true;
            this.AcountsName_label.Location = new System.Drawing.Point(24, 65);
            this.AcountsName_label.Name = "AcountsName_label";
            this.AcountsName_label.Size = new System.Drawing.Size(29, 12);
            this.AcountsName_label.TabIndex = 23;
            this.AcountsName_label.Text = "名前";
            // 
            // AcountsDate_label
            // 
            this.AcountsDate_label.AutoSize = true;
            this.AcountsDate_label.Location = new System.Drawing.Point(24, 31);
            this.AcountsDate_label.Name = "AcountsDate_label";
            this.AcountsDate_label.Size = new System.Drawing.Size(29, 12);
            this.AcountsDate_label.TabIndex = 22;
            this.AcountsDate_label.Text = "日付";
            // 
            // AcountsOk_button
            // 
            this.AcountsOk_button.Location = new System.Drawing.Point(386, 373);
            this.AcountsOk_button.Name = "AcountsOk_button";
            this.AcountsOk_button.Size = new System.Drawing.Size(75, 23);
            this.AcountsOk_button.TabIndex = 20;
            this.AcountsOk_button.Text = "完了";
            this.AcountsOk_button.UseVisualStyleBackColor = true;
            this.AcountsOk_button.Click += new System.EventHandler(this.AcountsOk_button_Click);
            // 
            // AcountsBack_button
            // 
            this.AcountsBack_button.Location = new System.Drawing.Point(495, 373);
            this.AcountsBack_button.Name = "AcountsBack_button";
            this.AcountsBack_button.Size = new System.Drawing.Size(75, 23);
            this.AcountsBack_button.TabIndex = 19;
            this.AcountsBack_button.Text = "戻る";
            this.AcountsBack_button.UseVisualStyleBackColor = true;
            this.AcountsBack_button.Click += new System.EventHandler(this.AcountsBack_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accounts_Type,
            this.Accounts_Value,
            this.Accounts_Number,
            this.Accounts_Day,
            this.Accounts_Total});
            this.dataGridView1.Location = new System.Drawing.Point(26, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(544, 192);
            this.dataGridView1.TabIndex = 18;
            // 
            // Accounts_Type
            // 
            this.Accounts_Type.HeaderText = "タイプ";
            this.Accounts_Type.Name = "Accounts_Type";
            // 
            // Accounts_Value
            // 
            this.Accounts_Value.HeaderText = "料金";
            this.Accounts_Value.Name = "Accounts_Value";
            // 
            // Accounts_Number
            // 
            this.Accounts_Number.HeaderText = "人数";
            this.Accounts_Number.Name = "Accounts_Number";
            // 
            // Accounts_Day
            // 
            this.Accounts_Day.HeaderText = "利用日数";
            this.Accounts_Day.Name = "Accounts_Day";
            // 
            // Accounts_Total
            // 
            this.Accounts_Total.HeaderText = "合計";
            this.Accounts_Total.Name = "Accounts_Total";
            // 
            // Accounts_Recieve
            // 
            this.Accounts_Recieve.Location = new System.Drawing.Point(469, 320);
            this.Accounts_Recieve.Name = "Accounts_Recieve";
            this.Accounts_Recieve.Size = new System.Drawing.Size(100, 19);
            this.Accounts_Recieve.TabIndex = 34;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 445);
            this.Controls.Add(this.Accounts_Recieve);
            this.Controls.Add(this.Acounts_Change);
            this.Controls.Add(this.Acounts_Total);
            this.Controls.Add(this.Acounts_Staff);
            this.Controls.Add(this.Acounts_Name);
            this.Controls.Add(this.Acounts_Date);
            this.Controls.Add(this.AcountsChange_label);
            this.Controls.Add(this.AcountsReceive_label);
            this.Controls.Add(this.AcountsTotal_label);
            this.Controls.Add(this.AcountsStaff_label);
            this.Controls.Add(this.AcountsName_label);
            this.Controls.Add(this.AcountsDate_label);
            this.Controls.Add(this.AcountsOk_button);
            this.Controls.Add(this.AcountsBack_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Accounts";
            this.Text = "Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Acounts_Change;
        private System.Windows.Forms.Label Acounts_Total;
        private System.Windows.Forms.Label Acounts_Staff;
        private System.Windows.Forms.Label Acounts_Name;
        private System.Windows.Forms.Label Acounts_Date;
        private System.Windows.Forms.Label AcountsChange_label;
        private System.Windows.Forms.Label AcountsReceive_label;
        private System.Windows.Forms.Label AcountsTotal_label;
        private System.Windows.Forms.Label AcountsStaff_label;
        private System.Windows.Forms.Label AcountsName_label;
        private System.Windows.Forms.Label AcountsDate_label;
        private System.Windows.Forms.Button AcountsOk_button;
        private System.Windows.Forms.Button AcountsBack_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Total;
        private System.Windows.Forms.TextBox Accounts_Recieve;
    }
}