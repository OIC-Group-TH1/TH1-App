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
            this.Accounts_Change = new System.Windows.Forms.Label();
            this.Accounts_Alltotal = new System.Windows.Forms.Label();
            this.Accounts_Date = new System.Windows.Forms.Label();
            this.AccountsChange_label = new System.Windows.Forms.Label();
            this.AccountsReceive_label = new System.Windows.Forms.Label();
            this.AccountsTotal_label = new System.Windows.Forms.Label();
            this.AccountsDate_label = new System.Windows.Forms.Label();
            this.AccountsOk_button = new System.Windows.Forms.Button();
            this.AccountsBack_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Accounts_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Recieve = new System.Windows.Forms.TextBox();
            this.AccountsPay_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Accounts_Change
            // 
            this.Accounts_Change.AutoSize = true;
            this.Accounts_Change.Location = new System.Drawing.Point(708, 350);
            this.Accounts_Change.Name = "Accounts_Change";
            this.Accounts_Change.Size = new System.Drawing.Size(35, 12);
            this.Accounts_Change.TabIndex = 33;
            this.Accounts_Change.Text = "label6";
            // 
            // Accounts_Alltotal
            // 
            this.Accounts_Alltotal.AutoSize = true;
            this.Accounts_Alltotal.Location = new System.Drawing.Point(708, 305);
            this.Accounts_Alltotal.Name = "Accounts_Alltotal";
            this.Accounts_Alltotal.Size = new System.Drawing.Size(35, 12);
            this.Accounts_Alltotal.TabIndex = 31;
            this.Accounts_Alltotal.Text = "label4";
            // 
            // Accounts_Date
            // 
            this.Accounts_Date.AutoSize = true;
            this.Accounts_Date.Location = new System.Drawing.Point(70, 62);
            this.Accounts_Date.Name = "Accounts_Date";
            this.Accounts_Date.Size = new System.Drawing.Size(35, 12);
            this.Accounts_Date.TabIndex = 28;
            this.Accounts_Date.Text = "label1";
            // 
            // AccountsChange_label
            // 
            this.AccountsChange_label.AutoSize = true;
            this.AccountsChange_label.Location = new System.Drawing.Point(600, 350);
            this.AccountsChange_label.Name = "AccountsChange_label";
            this.AccountsChange_label.Size = new System.Drawing.Size(35, 12);
            this.AccountsChange_label.TabIndex = 27;
            this.AccountsChange_label.Text = "お釣り";
            // 
            // AccountsReceive_label
            // 
            this.AccountsReceive_label.AutoSize = true;
            this.AccountsReceive_label.Location = new System.Drawing.Point(600, 326);
            this.AccountsReceive_label.Name = "AccountsReceive_label";
            this.AccountsReceive_label.Size = new System.Drawing.Size(37, 12);
            this.AccountsReceive_label.TabIndex = 26;
            this.AccountsReceive_label.Text = "預り金";
            // 
            // AccountsTotal_label
            // 
            this.AccountsTotal_label.AutoSize = true;
            this.AccountsTotal_label.Location = new System.Drawing.Point(600, 305);
            this.AccountsTotal_label.Name = "AccountsTotal_label";
            this.AccountsTotal_label.Size = new System.Drawing.Size(29, 12);
            this.AccountsTotal_label.TabIndex = 25;
            this.AccountsTotal_label.Text = "合計";
            // 
            // AccountsDate_label
            // 
            this.AccountsDate_label.AutoSize = true;
            this.AccountsDate_label.Location = new System.Drawing.Point(24, 62);
            this.AccountsDate_label.Name = "AccountsDate_label";
            this.AccountsDate_label.Size = new System.Drawing.Size(29, 12);
            this.AccountsDate_label.TabIndex = 22;
            this.AccountsDate_label.Text = "日付";
            // 
            // AccountsOk_button
            // 
            this.AccountsOk_button.Location = new System.Drawing.Point(507, 376);
            this.AccountsOk_button.Name = "AccountsOk_button";
            this.AccountsOk_button.Size = new System.Drawing.Size(75, 23);
            this.AccountsOk_button.TabIndex = 20;
            this.AccountsOk_button.Text = "完了";
            this.AccountsOk_button.UseVisualStyleBackColor = true;
            this.AccountsOk_button.Click += new System.EventHandler(this.AcountsOk_button_Click);
            // 
            // AccountsBack_button
            // 
            this.AccountsBack_button.Location = new System.Drawing.Point(669, 376);
            this.AccountsBack_button.Name = "AccountsBack_button";
            this.AccountsBack_button.Size = new System.Drawing.Size(75, 23);
            this.AccountsBack_button.TabIndex = 19;
            this.AccountsBack_button.Text = "戻る";
            this.AccountsBack_button.UseVisualStyleBackColor = true;
            this.AccountsBack_button.Click += new System.EventHandler(this.AcountsBack_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accounts_No,
            this.Accounts_Type,
            this.Accounts_Name,
            this.Accounts_Value,
            this.Accounts_Number,
            this.Accounts_Day,
            this.Accounts_Total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(743, 192);
            this.dataGridView1.TabIndex = 18;
            // 
            // Accounts_No
            // 
            this.Accounts_No.HeaderText = "部屋No";
            this.Accounts_No.Name = "Accounts_No";
            // 
            // Accounts_Type
            // 
            this.Accounts_Type.HeaderText = "タイプ";
            this.Accounts_Type.Name = "Accounts_Type";
            // 
            // Accounts_Name
            // 
            this.Accounts_Name.HeaderText = "宿泊者名";
            this.Accounts_Name.Name = "Accounts_Name";
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
            this.Accounts_Recieve.Location = new System.Drawing.Point(643, 323);
            this.Accounts_Recieve.Name = "Accounts_Recieve";
            this.Accounts_Recieve.Size = new System.Drawing.Size(100, 19);
            this.Accounts_Recieve.TabIndex = 34;
            this.Accounts_Recieve.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Accounts_Recieve_KeyPress);
            // 
            // AccountsPay_button
            // 
            this.AccountsPay_button.Location = new System.Drawing.Point(588, 376);
            this.AccountsPay_button.Name = "AccountsPay_button";
            this.AccountsPay_button.Size = new System.Drawing.Size(75, 23);
            this.AccountsPay_button.TabIndex = 35;
            this.AccountsPay_button.Text = "お支払い";
            this.AccountsPay_button.UseVisualStyleBackColor = true;
            this.AccountsPay_button.Click += new System.EventHandler(this.AccountsPay_button_Click);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.AccountsPay_button);
            this.Controls.Add(this.Accounts_Recieve);
            this.Controls.Add(this.Accounts_Change);
            this.Controls.Add(this.Accounts_Alltotal);
            this.Controls.Add(this.Accounts_Date);
            this.Controls.Add(this.AccountsChange_label);
            this.Controls.Add(this.AccountsReceive_label);
            this.Controls.Add(this.AccountsTotal_label);
            this.Controls.Add(this.AccountsDate_label);
            this.Controls.Add(this.AccountsOk_button);
            this.Controls.Add(this.AccountsBack_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Accounts_Change;
        private System.Windows.Forms.Label Accounts_Alltotal;
        private System.Windows.Forms.Label Accounts_Date;
        private System.Windows.Forms.Label AccountsChange_label;
        private System.Windows.Forms.Label AccountsReceive_label;
        private System.Windows.Forms.Label AccountsTotal_label;
        private System.Windows.Forms.Label AccountsDate_label;
        private System.Windows.Forms.Button AccountsOk_button;
        private System.Windows.Forms.Button AccountsBack_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Accounts_Recieve;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Total;
        private System.Windows.Forms.Button AccountsPay_button;
    }
}