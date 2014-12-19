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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stafflist_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Kana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stafflist_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLSTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globalDBDataSet4 = new Sample1.globalDBDataSet();
            this.StafflistEntry_button = new System.Windows.Forms.Button();
            this.StafflistTop_button = new System.Windows.Forms.Button();
            this.tBL_STAFFTableAdapter = new Sample1.globalDBDataSet4TableAdapters.TBL_STAFFTableAdapter();
            this.tBLSTAFFBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFKANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFSEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFPOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAFFADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTAFFBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stafflist_Code,
            this.Stafflist_Name,
            this.Stafflist_Kana,
            this.Stafflist_Sex,
            this.Stafflist_age,
            this.Stafflist_Position,
            this.Stafflist_Tel,
            this.Stafflist_Mail,
            this.Stafflist_Day,
            this.Stafflist_Address,
            this.sTAFFCODEDataGridViewTextBoxColumn,
            this.sTAFFNAMEDataGridViewTextBoxColumn,
            this.sTAFFKANADataGridViewTextBoxColumn,
            this.sTAFFSEXDataGridViewTextBoxColumn,
            this.sTAFFAGEDataGridViewTextBoxColumn,
            this.sTAFFPOSITIONDataGridViewTextBoxColumn,
            this.sTAFFTELDataGridViewTextBoxColumn,
            this.sTAFFMAILDataGridViewTextBoxColumn,
            this.sTAFFDAYDataGridViewTextBoxColumn,
            this.sTAFFADDRESSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLSTAFFBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(940, 220);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Stafflist_Code
            // 
            this.Stafflist_Code.DataPropertyName = "STAFF_CODE";
            this.Stafflist_Code.HeaderText = "社員コード";
            this.Stafflist_Code.Name = "Stafflist_Code";
            this.Stafflist_Code.ReadOnly = true;
            this.Stafflist_Code.Width = 90;
            // 
            // Stafflist_Name
            // 
            this.Stafflist_Name.DataPropertyName = "STAFF_NAME";
            this.Stafflist_Name.HeaderText = "名前";
            this.Stafflist_Name.Name = "Stafflist_Name";
            // 
            // Stafflist_Kana
            // 
            this.Stafflist_Kana.DataPropertyName = "STAFF_KANA";
            this.Stafflist_Kana.HeaderText = "フリガナ";
            this.Stafflist_Kana.Name = "Stafflist_Kana";
            // 
            // Stafflist_Sex
            // 
            this.Stafflist_Sex.DataPropertyName = "STAFF_SEX";
            this.Stafflist_Sex.HeaderText = "性別";
            this.Stafflist_Sex.Name = "Stafflist_Sex";
            this.Stafflist_Sex.Width = 70;
            // 
            // Stafflist_age
            // 
            this.Stafflist_age.DataPropertyName = "STAFF_AGE";
            this.Stafflist_age.HeaderText = "年齢";
            this.Stafflist_age.Name = "Stafflist_age";
            this.Stafflist_age.Width = 70;
            // 
            // Stafflist_Position
            // 
            this.Stafflist_Position.DataPropertyName = "STAFF_POSITION";
            this.Stafflist_Position.HeaderText = "役職";
            this.Stafflist_Position.Name = "Stafflist_Position";
            this.Stafflist_Position.Width = 80;
            // 
            // Stafflist_Tel
            // 
            this.Stafflist_Tel.DataPropertyName = "STAFF_TEL";
            this.Stafflist_Tel.HeaderText = "電話番号";
            this.Stafflist_Tel.Name = "Stafflist_Tel";
            // 
            // Stafflist_Mail
            // 
            this.Stafflist_Mail.DataPropertyName = "STAFF_MAIL";
            this.Stafflist_Mail.HeaderText = "メールアドレス";
            this.Stafflist_Mail.Name = "Stafflist_Mail";
            // 
            // Stafflist_Day
            // 
            this.Stafflist_Day.DataPropertyName = "STAFF_DAY";
            this.Stafflist_Day.HeaderText = "入社年月日";
            this.Stafflist_Day.Name = "Stafflist_Day";
            this.Stafflist_Day.Width = 90;
            // 
            // Stafflist_Address
            // 
            this.Stafflist_Address.DataPropertyName = "STAFF_ADDRESS";
            this.Stafflist_Address.HeaderText = "住所";
            this.Stafflist_Address.Name = "Stafflist_Address";
            // 
            // tBLSTAFFBindingSource
            // 
            this.tBLSTAFFBindingSource.DataMember = "TBL_STAFF";
            this.tBLSTAFFBindingSource.DataSource = this.globalDBDataSet4;
            // 
            // globalDBDataSet4
            // 
            this.globalDBDataSet4.DataSetName = "globalDBDataSet4";
            this.globalDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StafflistEntry_button
            // 
            this.StafflistEntry_button.Location = new System.Drawing.Point(700, 330);
            this.StafflistEntry_button.Name = "StafflistEntry_button";
            this.StafflistEntry_button.Size = new System.Drawing.Size(75, 23);
            this.StafflistEntry_button.TabIndex = 1;
            this.StafflistEntry_button.Text = "登録";
            this.StafflistEntry_button.UseVisualStyleBackColor = true;
            this.StafflistEntry_button.Click += new System.EventHandler(this.StafflistEntry_button_Click_1);
            // 
            // StafflistTop_button
            // 
            this.StafflistTop_button.Location = new System.Drawing.Point(865, 330);
            this.StafflistTop_button.Name = "StafflistTop_button";
            this.StafflistTop_button.Size = new System.Drawing.Size(75, 23);
            this.StafflistTop_button.TabIndex = 2;
            this.StafflistTop_button.Text = "Topへ";
            this.StafflistTop_button.UseVisualStyleBackColor = true;
            this.StafflistTop_button.Click += new System.EventHandler(this.StafflistTop_button_Click_1);
            // 
            // tBL_STAFFTableAdapter
            // 
            this.tBL_STAFFTableAdapter.ClearBeforeFill = true;
            // 
            // tBLSTAFFBindingSource1
            // 
            this.tBLSTAFFBindingSource1.DataMember = "TBL_STAFF";
            this.tBLSTAFFBindingSource1.DataSource = this.globalDBDataSet4;
            // 
            // sTAFFCODEDataGridViewTextBoxColumn
            // 
            this.sTAFFCODEDataGridViewTextBoxColumn.DataPropertyName = "STAFF_CODE";
            this.sTAFFCODEDataGridViewTextBoxColumn.HeaderText = "STAFF_CODE";
            this.sTAFFCODEDataGridViewTextBoxColumn.Name = "sTAFFCODEDataGridViewTextBoxColumn";
            this.sTAFFCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTAFFNAMEDataGridViewTextBoxColumn
            // 
            this.sTAFFNAMEDataGridViewTextBoxColumn.DataPropertyName = "STAFF_NAME";
            this.sTAFFNAMEDataGridViewTextBoxColumn.HeaderText = "STAFF_NAME";
            this.sTAFFNAMEDataGridViewTextBoxColumn.Name = "sTAFFNAMEDataGridViewTextBoxColumn";
            // 
            // sTAFFKANADataGridViewTextBoxColumn
            // 
            this.sTAFFKANADataGridViewTextBoxColumn.DataPropertyName = "STAFF_KANA";
            this.sTAFFKANADataGridViewTextBoxColumn.HeaderText = "STAFF_KANA";
            this.sTAFFKANADataGridViewTextBoxColumn.Name = "sTAFFKANADataGridViewTextBoxColumn";
            // 
            // sTAFFSEXDataGridViewTextBoxColumn
            // 
            this.sTAFFSEXDataGridViewTextBoxColumn.DataPropertyName = "STAFF_SEX";
            this.sTAFFSEXDataGridViewTextBoxColumn.HeaderText = "STAFF_SEX";
            this.sTAFFSEXDataGridViewTextBoxColumn.Name = "sTAFFSEXDataGridViewTextBoxColumn";
            // 
            // sTAFFAGEDataGridViewTextBoxColumn
            // 
            this.sTAFFAGEDataGridViewTextBoxColumn.DataPropertyName = "STAFF_AGE";
            this.sTAFFAGEDataGridViewTextBoxColumn.HeaderText = "STAFF_AGE";
            this.sTAFFAGEDataGridViewTextBoxColumn.Name = "sTAFFAGEDataGridViewTextBoxColumn";
            // 
            // sTAFFPOSITIONDataGridViewTextBoxColumn
            // 
            this.sTAFFPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "STAFF_POSITION";
            this.sTAFFPOSITIONDataGridViewTextBoxColumn.HeaderText = "STAFF_POSITION";
            this.sTAFFPOSITIONDataGridViewTextBoxColumn.Name = "sTAFFPOSITIONDataGridViewTextBoxColumn";
            // 
            // sTAFFTELDataGridViewTextBoxColumn
            // 
            this.sTAFFTELDataGridViewTextBoxColumn.DataPropertyName = "STAFF_TEL";
            this.sTAFFTELDataGridViewTextBoxColumn.HeaderText = "STAFF_TEL";
            this.sTAFFTELDataGridViewTextBoxColumn.Name = "sTAFFTELDataGridViewTextBoxColumn";
            // 
            // sTAFFMAILDataGridViewTextBoxColumn
            // 
            this.sTAFFMAILDataGridViewTextBoxColumn.DataPropertyName = "STAFF_MAIL";
            this.sTAFFMAILDataGridViewTextBoxColumn.HeaderText = "STAFF_MAIL";
            this.sTAFFMAILDataGridViewTextBoxColumn.Name = "sTAFFMAILDataGridViewTextBoxColumn";
            // 
            // sTAFFDAYDataGridViewTextBoxColumn
            // 
            this.sTAFFDAYDataGridViewTextBoxColumn.DataPropertyName = "STAFF_DAY";
            this.sTAFFDAYDataGridViewTextBoxColumn.HeaderText = "STAFF_DAY";
            this.sTAFFDAYDataGridViewTextBoxColumn.Name = "sTAFFDAYDataGridViewTextBoxColumn";
            // 
            // sTAFFADDRESSDataGridViewTextBoxColumn
            // 
            this.sTAFFADDRESSDataGridViewTextBoxColumn.DataPropertyName = "STAFF_ADDRESS";
            this.sTAFFADDRESSDataGridViewTextBoxColumn.HeaderText = "STAFF_ADDRESS";
            this.sTAFFADDRESSDataGridViewTextBoxColumn.Name = "sTAFFADDRESSDataGridViewTextBoxColumn";
            // 
            // Stafflist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 467);
            this.Controls.Add(this.StafflistTop_button);
            this.Controls.Add(this.StafflistEntry_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stafflist";
            this.Text = "Staflist";
            this.Load += new System.EventHandler(this.Stafflist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSTAFFBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StafflistEntry_button;
        private System.Windows.Forms.Button StafflistTop_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Kana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stafflist_Address;
        private globalDBDataSet globalDBDataSet4;
        private System.Windows.Forms.BindingSource tBLSTAFFBindingSource;
        private globalDBDataSet4TableAdapters.TBL_STAFFTableAdapter tBL_STAFFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFKANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFSEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFPOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAFFADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBLSTAFFBindingSource1;
    }
}