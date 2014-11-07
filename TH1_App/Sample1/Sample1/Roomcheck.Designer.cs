namespace Sample1
{
    partial class RoomCheck
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.RoomCheckBack_button = new System.Windows.Forms.Button();
            this.RoomCheckTop_button = new System.Windows.Forms.Button();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Smoke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomNo,
            this.RoomType,
            this.Smoke,
            this.ResName,
            this.Reserve,
            this.number,
            this.Tel});
            this.dataGridView1.Location = new System.Drawing.Point(21, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(593, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // RoomCheckBack_button
            // 
            this.RoomCheckBack_button.Location = new System.Drawing.Point(45, 316);
            this.RoomCheckBack_button.Name = "RoomCheckBack_button";
            this.RoomCheckBack_button.Size = new System.Drawing.Size(91, 31);
            this.RoomCheckBack_button.TabIndex = 2;
            this.RoomCheckBack_button.Text = "戻る";
            this.RoomCheckBack_button.UseVisualStyleBackColor = true;
            // 
            // RoomCheckTop_button
            // 
            this.RoomCheckTop_button.Location = new System.Drawing.Point(483, 316);
            this.RoomCheckTop_button.Name = "RoomCheckTop_button";
            this.RoomCheckTop_button.Size = new System.Drawing.Size(91, 31);
            this.RoomCheckTop_button.TabIndex = 3;
            this.RoomCheckTop_button.Text = "TOPへ";
            this.RoomCheckTop_button.UseVisualStyleBackColor = true;
            // 
            // RoomNo
            // 
            this.RoomNo.HeaderText = "部屋No";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Width = 70;
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "タイプ";
            this.RoomType.Name = "RoomType";
            this.RoomType.Width = 70;
            // 
            // Smoke
            // 
            this.Smoke.HeaderText = "タバコ";
            this.Smoke.Name = "Smoke";
            this.Smoke.Width = 70;
            // 
            // ResName
            // 
            this.ResName.HeaderText = "宿泊者";
            this.ResName.Name = "ResName";
            // 
            // Reserve
            // 
            this.Reserve.HeaderText = "予約可否";
            this.Reserve.Name = "Reserve";
            this.Reserve.Width = 80;
            // 
            // number
            // 
            this.number.HeaderText = "人数";
            this.number.Name = "number";
            this.number.Width = 70;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "電話番号";
            this.Tel.Name = "Tel";
            // 
            // RoomCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 425);
            this.Controls.Add(this.RoomCheckTop_button);
            this.Controls.Add(this.RoomCheckBack_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoomCheck";
            this.Text = "RoomCheck";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button RoomCheckBack_button;
        private System.Windows.Forms.Button RoomCheckTop_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Smoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
    }
}