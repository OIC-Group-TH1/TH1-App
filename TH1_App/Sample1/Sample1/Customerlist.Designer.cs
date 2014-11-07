namespace Sample1
{
    partial class Customerlist
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customerlist_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Kana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Search = new System.Windows.Forms.Button();
            this.Customerlist_entry = new System.Windows.Forms.Button();
            this.CustomerlistBack_button = new System.Windows.Forms.Button();
            this.CustomerlistTop_button = new System.Windows.Forms.Button();
            this.Customerlist_label1 = new System.Windows.Forms.Label();
            this.Customerlist_label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customerlist_No,
            this.Customerlist_name,
            this.Customerlist_Kana,
            this.Customerlist_Sex,
            this.Customerlist_Tel,
            this.Customerlist_Post,
            this.Customerlist_Address});
            this.dataGridView1.Location = new System.Drawing.Point(0, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(670, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // Customerlist_No
            // 
            this.Customerlist_No.HeaderText = "No";
            this.Customerlist_No.Name = "Customerlist_No";
            this.Customerlist_No.Width = 50;
            // 
            // Customerlist_name
            // 
            this.Customerlist_name.HeaderText = "名前";
            this.Customerlist_name.Name = "Customerlist_name";
            // 
            // Customerlist_Kana
            // 
            this.Customerlist_Kana.HeaderText = "ふりがな";
            this.Customerlist_Kana.Name = "Customerlist_Kana";
            // 
            // Customerlist_Sex
            // 
            this.Customerlist_Sex.HeaderText = "性別";
            this.Customerlist_Sex.Name = "Customerlist_Sex";
            this.Customerlist_Sex.Width = 80;
            // 
            // Customerlist_Tel
            // 
            this.Customerlist_Tel.HeaderText = "電話番号";
            this.Customerlist_Tel.Name = "Customerlist_Tel";
            // 
            // Customerlist_Post
            // 
            this.Customerlist_Post.HeaderText = "郵便番号";
            this.Customerlist_Post.Name = "Customerlist_Post";
            // 
            // Customerlist_Address
            // 
            this.Customerlist_Address.HeaderText = "住所";
            this.Customerlist_Address.Name = "Customerlist_Address";
            // 
            // Customerlist_Search
            // 
            this.Customerlist_Search.Location = new System.Drawing.Point(345, 364);
            this.Customerlist_Search.Name = "Customerlist_Search";
            this.Customerlist_Search.Size = new System.Drawing.Size(75, 23);
            this.Customerlist_Search.TabIndex = 1;
            this.Customerlist_Search.Text = "検索";
            this.Customerlist_Search.UseVisualStyleBackColor = true;
            // 
            // Customerlist_entry
            // 
            this.Customerlist_entry.Location = new System.Drawing.Point(484, 364);
            this.Customerlist_entry.Name = "Customerlist_entry";
            this.Customerlist_entry.Size = new System.Drawing.Size(75, 23);
            this.Customerlist_entry.TabIndex = 2;
            this.Customerlist_entry.Text = "新規登録";
            this.Customerlist_entry.UseVisualStyleBackColor = true;
            this.Customerlist_entry.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomerlistBack_button
            // 
            this.CustomerlistBack_button.Location = new System.Drawing.Point(82, 425);
            this.CustomerlistBack_button.Name = "CustomerlistBack_button";
            this.CustomerlistBack_button.Size = new System.Drawing.Size(75, 23);
            this.CustomerlistBack_button.TabIndex = 3;
            this.CustomerlistBack_button.Text = "戻る";
            this.CustomerlistBack_button.UseVisualStyleBackColor = true;
            // 
            // CustomerlistTop_button
            // 
            this.CustomerlistTop_button.Location = new System.Drawing.Point(484, 425);
            this.CustomerlistTop_button.Name = "CustomerlistTop_button";
            this.CustomerlistTop_button.Size = new System.Drawing.Size(75, 23);
            this.CustomerlistTop_button.TabIndex = 4;
            this.CustomerlistTop_button.Text = "Topへ";
            this.CustomerlistTop_button.UseVisualStyleBackColor = true;
            // 
            // Customerlist_label1
            // 
            this.Customerlist_label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Customerlist_label1.Location = new System.Drawing.Point(57, 326);
            this.Customerlist_label1.Name = "Customerlist_label1";
            this.Customerlist_label1.Size = new System.Drawing.Size(100, 23);
            this.Customerlist_label1.TabIndex = 5;
            this.Customerlist_label1.Text = "名前";
            this.Customerlist_label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Customerlist_label2
            // 
            this.Customerlist_label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Customerlist_label2.Location = new System.Drawing.Point(57, 363);
            this.Customerlist_label2.Name = "Customerlist_label2";
            this.Customerlist_label2.Size = new System.Drawing.Size(100, 23);
            this.Customerlist_label2.TabIndex = 6;
            this.Customerlist_label2.Text = "電話番号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 364);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 19);
            this.textBox2.TabIndex = 8;
            // 
            // Customerlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 489);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Customerlist_label2);
            this.Controls.Add(this.Customerlist_label1);
            this.Controls.Add(this.CustomerlistTop_button);
            this.Controls.Add(this.CustomerlistBack_button);
            this.Controls.Add(this.Customerlist_entry);
            this.Controls.Add(this.Customerlist_Search);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customerlist";
            this.Text = "Customerlist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_Kana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_Address;
        private System.Windows.Forms.Button Customerlist_Search;
        private System.Windows.Forms.Button Customerlist_entry;
        private System.Windows.Forms.Button CustomerlistBack_button;
        private System.Windows.Forms.Button CustomerlistTop_button;
        private System.Windows.Forms.Label Customerlist_label1;
        private System.Windows.Forms.Label Customerlist_label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}