namespace Sample1
{
    partial class reservelist
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
            this.Reservelist_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservelist_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservelist_Smoke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservelist_ResName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservelist_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservelist_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservelist_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservelist_Reserve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ReservelistBack_button = new System.Windows.Forms.Button();
            this.ReservelistTop_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reservelist_No,
            this.Reservelist_Type,
            this.Reservelist_Smoke,
            this.Reservelist_ResName,
            this.Reservelist_address,
            this.Reservelist_Tel,
            this.Reservelist_Number,
            this.Reservelist_Reserve});
            this.dataGridView1.Location = new System.Drawing.Point(22, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(593, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // Reservelist_No
            // 
            this.Reservelist_No.HeaderText = "部屋No";
            this.Reservelist_No.Name = "Reservelist_No";
            this.Reservelist_No.Width = 70;
            // 
            // Reservelist_Type
            // 
            this.Reservelist_Type.HeaderText = "タイプ";
            this.Reservelist_Type.Name = "Reservelist_Type";
            this.Reservelist_Type.Width = 70;
            // 
            // Reservelist_Smoke
            // 
            this.Reservelist_Smoke.HeaderText = "タバコ";
            this.Reservelist_Smoke.Name = "Reservelist_Smoke";
            this.Reservelist_Smoke.Width = 70;
            // 
            // Reservelist_ResName
            // 
            this.Reservelist_ResName.HeaderText = "宿泊者";
            this.Reservelist_ResName.Name = "Reservelist_ResName";
            // 
            // Reservelist_address
            // 
            this.Reservelist_address.HeaderText = "住所";
            this.Reservelist_address.Name = "Reservelist_address";
            // 
            // Reservelist_Tel
            // 
            this.Reservelist_Tel.HeaderText = "電話番号";
            this.Reservelist_Tel.Name = "Reservelist_Tel";
            // 
            // Reservelist_Number
            // 
            this.Reservelist_Number.HeaderText = "人数";
            this.Reservelist_Number.Name = "Reservelist_Number";
            this.Reservelist_Number.Width = 70;
            // 
            // Reservelist_Reserve
            // 
            this.Reservelist_Reserve.HeaderText = "予約可否";
            this.Reservelist_Reserve.Name = "Reservelist_Reserve";
            this.Reservelist_Reserve.Width = 80;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 19);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // ReservelistBack_button
            // 
            this.ReservelistBack_button.Location = new System.Drawing.Point(45, 316);
            this.ReservelistBack_button.Name = "ReservelistBack_button";
            this.ReservelistBack_button.Size = new System.Drawing.Size(91, 31);
            this.ReservelistBack_button.TabIndex = 2;
            this.ReservelistBack_button.Text = "戻る";
            this.ReservelistBack_button.UseVisualStyleBackColor = true;
            // 
            // ReservelistTop_button
            // 
            this.ReservelistTop_button.Location = new System.Drawing.Point(483, 316);
            this.ReservelistTop_button.Name = "ReservelistTop_button";
            this.ReservelistTop_button.Size = new System.Drawing.Size(91, 31);
            this.ReservelistTop_button.TabIndex = 3;
            this.ReservelistTop_button.Text = "Topへ";
            this.ReservelistTop_button.UseVisualStyleBackColor = true;
            // 
            // reservelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 425);
            this.Controls.Add(this.ReservelistTop_button);
            this.Controls.Add(this.ReservelistBack_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "reservelist";
            this.Text = "Reservelist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ReservelistBack_button;
        private System.Windows.Forms.Button ReservelistTop_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservelist_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservelist_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservelist_Smoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservelist_ResName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservelist_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservelist_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservelist_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservelist_Reserve;
    }
}