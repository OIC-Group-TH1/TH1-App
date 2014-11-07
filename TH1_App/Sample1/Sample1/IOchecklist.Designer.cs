namespace Sample1
{
    partial class IOchecklist
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
            this.IOchecklist_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOchecklist_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOchecklist_Smoke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOchecklist_ResName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOchecklist_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOchecklist_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOchecklist_In = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IOchecklist_Out = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IOchecklistTop_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IOchecklist_No,
            this.IOchecklist_Type,
            this.IOchecklist_Smoke,
            this.IOchecklist_ResName,
            this.IOchecklist_Number,
            this.IOchecklist_Tel,
            this.IOchecklist_In,
            this.IOchecklist_Out});
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(665, 167);
            this.dataGridView1.TabIndex = 1;
            // 
            // IOchecklist_No
            // 
            this.IOchecklist_No.HeaderText = "部屋No";
            this.IOchecklist_No.Name = "IOchecklist_No";
            this.IOchecklist_No.Width = 70;
            // 
            // IOchecklist_Type
            // 
            this.IOchecklist_Type.HeaderText = "タイプ";
            this.IOchecklist_Type.Name = "IOchecklist_Type";
            this.IOchecklist_Type.Width = 70;
            // 
            // IOchecklist_Smoke
            // 
            this.IOchecklist_Smoke.HeaderText = "タバコ";
            this.IOchecklist_Smoke.Name = "IOchecklist_Smoke";
            this.IOchecklist_Smoke.Width = 70;
            // 
            // IOchecklist_ResName
            // 
            this.IOchecklist_ResName.HeaderText = "宿泊者";
            this.IOchecklist_ResName.Name = "IOchecklist_ResName";
            // 
            // IOchecklist_Number
            // 
            this.IOchecklist_Number.HeaderText = "人数";
            this.IOchecklist_Number.Name = "IOchecklist_Number";
            this.IOchecklist_Number.Width = 70;
            // 
            // IOchecklist_Tel
            // 
            this.IOchecklist_Tel.HeaderText = "電話番号";
            this.IOchecklist_Tel.Name = "IOchecklist_Tel";
            // 
            // IOchecklist_In
            // 
            this.IOchecklist_In.HeaderText = "C.I";
            this.IOchecklist_In.Name = "IOchecklist_In";
            this.IOchecklist_In.Width = 70;
            // 
            // IOchecklist_Out
            // 
            this.IOchecklist_Out.HeaderText = "C.O";
            this.IOchecklist_Out.Name = "IOchecklist_Out";
            this.IOchecklist_Out.Width = 70;
            // 
            // IOchecklistTop_button
            // 
            this.IOchecklistTop_button.Location = new System.Drawing.Point(581, 302);
            this.IOchecklistTop_button.Name = "IOchecklistTop_button";
            this.IOchecklistTop_button.Size = new System.Drawing.Size(75, 23);
            this.IOchecklistTop_button.TabIndex = 2;
            this.IOchecklistTop_button.Text = "Topへ";
            this.IOchecklistTop_button.UseVisualStyleBackColor = true;
            // 
            // IOchecklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 367);
            this.Controls.Add(this.IOchecklistTop_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IOchecklist";
            this.Text = "IOchecklist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOchecklist_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOchecklist_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOchecklist_Smoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOchecklist_ResName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOchecklist_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn IOchecklist_Tel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IOchecklist_In;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IOchecklist_Out;
        private System.Windows.Forms.Button IOchecklistTop_button;
    }
}