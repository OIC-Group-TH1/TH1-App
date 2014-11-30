namespace Sample1
{
    partial class Stafflist
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
            this.Stafflist_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StafflistEntry_button = new System.Windows.Forms.Button();
            this.StafflistTop_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stafflist_Code,
            this.Stafflist_Name,
            this.Stafflist_Sex,
            this.Stafflist_age,
            this.Stafflist_Position,
            this.Stafflist_Tel,
            this.Stafflist_Mail,
            this.Stafflist_Day,
            this.Stafflist_Address});
            this.dataGridView1.Location = new System.Drawing.Point(1, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(818, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Stafflist_Code
            // 
            this.Stafflist_Code.HeaderText = "社員コード";
            this.Stafflist_Code.Name = "Stafflist_Code";
            this.Stafflist_Code.Width = 90;
            // 
            // Stafflist_Name
            // 
            this.Stafflist_Name.HeaderText = "名前";
            this.Stafflist_Name.Name = "Stafflist_Name";
            // 
            // Stafflist_Sex
            // 
            this.Stafflist_Sex.HeaderText = "性別";
            this.Stafflist_Sex.Name = "Stafflist_Sex";
            this.Stafflist_Sex.Width = 70;
            // 
            // Stafflist_age
            // 
            this.Stafflist_age.HeaderText = "年齢";
            this.Stafflist_age.Name = "Stafflist_age";
            this.Stafflist_age.Width = 70;
            // 
            // Stafflist_Position
            // 
            this.Stafflist_Position.HeaderText = "役職";
            this.Stafflist_Position.Name = "Stafflist_Position";
            this.Stafflist_Position.Width = 80;
            // 
            // Stafflist_Tel
            // 
            this.Stafflist_Tel.HeaderText = "電話番号";
            this.Stafflist_Tel.Name = "Stafflist_Tel";
            // 
            // Stafflist_Mail
            // 
            this.Stafflist_Mail.HeaderText = "メールアドレス";
            this.Stafflist_Mail.Name = "Stafflist_Mail";
            // 
            // Stafflist_Day
            // 
            this.Stafflist_Day.HeaderText = "入社年月日";
            this.Stafflist_Day.Name = "Stafflist_Day";
            this.Stafflist_Day.Width = 90;
            // 
            // Stafflist_Address
            // 
            this.Stafflist_Address.HeaderText = "住所";
            this.Stafflist_Address.Name = "Stafflist_Address";
            // 
            // StafflistEntry_button
            // 
            this.StafflistEntry_button.Location = new System.Drawing.Point(527, 358);
            this.StafflistEntry_button.Name = "StafflistEntry_button";
            this.StafflistEntry_button.Size = new System.Drawing.Size(75, 23);
            this.StafflistEntry_button.TabIndex = 1;
            this.StafflistEntry_button.Text = "登録";
            this.StafflistEntry_button.UseVisualStyleBackColor = true;
            this.StafflistEntry_button.Click += new System.EventHandler(this.StafflistEntry_button_Click);
            // 
            // StafflistTop_button
            // 
            this.StafflistTop_button.Location = new System.Drawing.Point(734, 358);
            this.StafflistTop_button.Name = "StafflistTop_button";
            this.StafflistTop_button.Size = new System.Drawing.Size(75, 23);
            this.StafflistTop_button.TabIndex = 4;
            this.StafflistTop_button.Text = "Topへ";
            this.StafflistTop_button.UseVisualStyleBackColor = true;
            this.StafflistTop_button.Click += new System.EventHandler(this.StafflistTop_button_Click);
            // 
            // Stafflist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 460);
            this.Controls.Add(this.StafflistTop_button);
            this.Controls.Add(this.StafflistEntry_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stafflist";
            this.Text = "fff";
            this.Load += new System.EventHandler(this.Stafflist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Address;
        private System.Windows.Forms.Button StafflistEntry_button;
        private System.Windows.Forms.Button StafflistTop_button;
    }
}