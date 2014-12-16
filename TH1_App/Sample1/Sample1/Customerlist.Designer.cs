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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerlistSearch_button = new System.Windows.Forms.Button();
            this.CustomerlistEntry_button = new System.Windows.Forms.Button();
            this.CustomerlistBack_button = new System.Windows.Forms.Button();
            this.CustomerlistTop_button = new System.Windows.Forms.Button();
            this.CustomerlistName_label = new System.Windows.Forms.Label();
            this.CustomerlistTel_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.globalDBDataSet = new Sample1.globalDBDataSet();
            this.tBLCLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_CLIENTTableAdapter = new Sample1.globalDBDataSetTableAdapters.TBL_CLIENTTableAdapter();
            this.cLIENTCOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESERVATIONCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNOTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTPOSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTTELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTKANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_Kana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customerlist_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCLIENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customerlist_No,
            this.Customerlist_name,
            this.Customerlist_Kana,
            this.Customerlist_Sex,
            this.Customerlist_Tel,
            this.Customerlist_Post,
            this.Customerlist_Address,
            this.Customerlist_note,
            this.cLIENTCODEDataGridViewTextBoxColumn,
            this.cLIENTNAMEDataGridViewTextBoxColumn,
            this.cLIENTKANADataGridViewTextBoxColumn,
            this.sEXDataGridViewTextBoxColumn,
            this.cLIENTTELDataGridViewTextBoxColumn,
            this.cLIENTPOSTDataGridViewTextBoxColumn,
            this.cLIENTADDRESSDataGridViewTextBoxColumn,
            this.cLIENTNOTEDataGridViewTextBoxColumn,
            this.rESERVATIONCODEDataGridViewTextBoxColumn,
            this.cLIENTCOUNTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLCLIENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(777, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // CustomerlistSearch_button
            // 
            this.CustomerlistSearch_button.Location = new System.Drawing.Point(345, 364);
            this.CustomerlistSearch_button.Name = "CustomerlistSearch_button";
            this.CustomerlistSearch_button.Size = new System.Drawing.Size(75, 23);
            this.CustomerlistSearch_button.TabIndex = 1;
            this.CustomerlistSearch_button.Text = "検索";
            this.CustomerlistSearch_button.UseVisualStyleBackColor = true;
            this.CustomerlistSearch_button.Click += new System.EventHandler(this.CustomerlistSearch_button_Click);
            // 
            // CustomerlistEntry_button
            // 
            this.CustomerlistEntry_button.Location = new System.Drawing.Point(484, 364);
            this.CustomerlistEntry_button.Name = "CustomerlistEntry_button";
            this.CustomerlistEntry_button.Size = new System.Drawing.Size(75, 23);
            this.CustomerlistEntry_button.TabIndex = 2;
            this.CustomerlistEntry_button.Text = "新規登録";
            this.CustomerlistEntry_button.UseVisualStyleBackColor = true;
            this.CustomerlistEntry_button.Click += new System.EventHandler(this.CustomerlistEntry_button_Click);
            // 
            // CustomerlistBack_button
            // 
            this.CustomerlistBack_button.Location = new System.Drawing.Point(82, 425);
            this.CustomerlistBack_button.Name = "CustomerlistBack_button";
            this.CustomerlistBack_button.Size = new System.Drawing.Size(75, 23);
            this.CustomerlistBack_button.TabIndex = 3;
            this.CustomerlistBack_button.Text = "予約一覧へ";
            this.CustomerlistBack_button.UseVisualStyleBackColor = true;
            this.CustomerlistBack_button.Click += new System.EventHandler(this.CustomerlistBack_button_Click);
            // 
            // CustomerlistTop_button
            // 
            this.CustomerlistTop_button.Location = new System.Drawing.Point(484, 425);
            this.CustomerlistTop_button.Name = "CustomerlistTop_button";
            this.CustomerlistTop_button.Size = new System.Drawing.Size(75, 23);
            this.CustomerlistTop_button.TabIndex = 4;
            this.CustomerlistTop_button.Text = "Topへ";
            this.CustomerlistTop_button.UseVisualStyleBackColor = true;
            this.CustomerlistTop_button.Click += new System.EventHandler(this.CustomerlistTop_button_Click);
            // 
            // CustomerlistName_label
            // 
            this.CustomerlistName_label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CustomerlistName_label.Location = new System.Drawing.Point(57, 326);
            this.CustomerlistName_label.Name = "CustomerlistName_label";
            this.CustomerlistName_label.Size = new System.Drawing.Size(100, 23);
            this.CustomerlistName_label.TabIndex = 5;
            this.CustomerlistName_label.Text = "名前";
            // 
            // CustomerlistTel_label
            // 
            this.CustomerlistTel_label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CustomerlistTel_label.Location = new System.Drawing.Point(57, 363);
            this.CustomerlistTel_label.Name = "CustomerlistTel_label";
            this.CustomerlistTel_label.Size = new System.Drawing.Size(100, 23);
            this.CustomerlistTel_label.TabIndex = 6;
            this.CustomerlistTel_label.Text = "電話番号";
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
            // globalDBDataSet
            // 
            this.globalDBDataSet.DataSetName = "globalDBDataSet";
            this.globalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLCLIENTBindingSource
            // 
            this.tBLCLIENTBindingSource.DataMember = "TBL_CLIENT";
            this.tBLCLIENTBindingSource.DataSource = this.globalDBDataSet;
            // 
            // tBL_CLIENTTableAdapter
            // 
            this.tBL_CLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTCOUNTDataGridViewTextBoxColumn
            // 
            this.cLIENTCOUNTDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_COUNT";
            this.cLIENTCOUNTDataGridViewTextBoxColumn.HeaderText = "CLIENT_COUNT";
            this.cLIENTCOUNTDataGridViewTextBoxColumn.Name = "cLIENTCOUNTDataGridViewTextBoxColumn";
            // 
            // rESERVATIONCODEDataGridViewTextBoxColumn
            // 
            this.rESERVATIONCODEDataGridViewTextBoxColumn.DataPropertyName = "RESERVATION_CODE";
            this.rESERVATIONCODEDataGridViewTextBoxColumn.HeaderText = "RESERVATION_CODE";
            this.rESERVATIONCODEDataGridViewTextBoxColumn.Name = "rESERVATIONCODEDataGridViewTextBoxColumn";
            // 
            // cLIENTNOTEDataGridViewTextBoxColumn
            // 
            this.cLIENTNOTEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NOTE";
            this.cLIENTNOTEDataGridViewTextBoxColumn.HeaderText = "CLIENT_NOTE";
            this.cLIENTNOTEDataGridViewTextBoxColumn.Name = "cLIENTNOTEDataGridViewTextBoxColumn";
            // 
            // cLIENTADDRESSDataGridViewTextBoxColumn
            // 
            this.cLIENTADDRESSDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_ADDRESS";
            this.cLIENTADDRESSDataGridViewTextBoxColumn.HeaderText = "CLIENT_ADDRESS";
            this.cLIENTADDRESSDataGridViewTextBoxColumn.Name = "cLIENTADDRESSDataGridViewTextBoxColumn";
            // 
            // cLIENTPOSTDataGridViewTextBoxColumn
            // 
            this.cLIENTPOSTDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_POST";
            this.cLIENTPOSTDataGridViewTextBoxColumn.HeaderText = "CLIENT_POST";
            this.cLIENTPOSTDataGridViewTextBoxColumn.Name = "cLIENTPOSTDataGridViewTextBoxColumn";
            // 
            // cLIENTTELDataGridViewTextBoxColumn
            // 
            this.cLIENTTELDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_TEL";
            this.cLIENTTELDataGridViewTextBoxColumn.HeaderText = "CLIENT_TEL";
            this.cLIENTTELDataGridViewTextBoxColumn.Name = "cLIENTTELDataGridViewTextBoxColumn";
            // 
            // sEXDataGridViewTextBoxColumn
            // 
            this.sEXDataGridViewTextBoxColumn.DataPropertyName = "SEX";
            this.sEXDataGridViewTextBoxColumn.HeaderText = "SEX";
            this.sEXDataGridViewTextBoxColumn.Name = "sEXDataGridViewTextBoxColumn";
            // 
            // cLIENTKANADataGridViewTextBoxColumn
            // 
            this.cLIENTKANADataGridViewTextBoxColumn.DataPropertyName = "CLIENT_KANA";
            this.cLIENTKANADataGridViewTextBoxColumn.HeaderText = "CLIENT_KANA";
            this.cLIENTKANADataGridViewTextBoxColumn.Name = "cLIENTKANADataGridViewTextBoxColumn";
            // 
            // cLIENTNAMEDataGridViewTextBoxColumn
            // 
            this.cLIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn.HeaderText = "CLIENT_NAME";
            this.cLIENTNAMEDataGridViewTextBoxColumn.Name = "cLIENTNAMEDataGridViewTextBoxColumn";
            // 
            // cLIENTCODEDataGridViewTextBoxColumn
            // 
            this.cLIENTCODEDataGridViewTextBoxColumn.DataPropertyName = "CLIENT_CODE";
            this.cLIENTCODEDataGridViewTextBoxColumn.HeaderText = "CLIENT_CODE";
            this.cLIENTCODEDataGridViewTextBoxColumn.Name = "cLIENTCODEDataGridViewTextBoxColumn";
            this.cLIENTCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Customerlist_note
            // 
            this.Customerlist_note.DataPropertyName = "CLIENT_NOTE";
            this.Customerlist_note.HeaderText = "備考";
            this.Customerlist_note.Name = "Customerlist_note";
            // 
            // Customerlist_Address
            // 
            this.Customerlist_Address.DataPropertyName = "CLIENT_ADDRESS";
            this.Customerlist_Address.HeaderText = "住所";
            this.Customerlist_Address.Name = "Customerlist_Address";
            // 
            // Customerlist_Post
            // 
            this.Customerlist_Post.DataPropertyName = "CLIENT_POST";
            this.Customerlist_Post.HeaderText = "郵便番号";
            this.Customerlist_Post.Name = "Customerlist_Post";
            // 
            // Customerlist_Tel
            // 
            this.Customerlist_Tel.DataPropertyName = "CLIENT_TEL";
            this.Customerlist_Tel.HeaderText = "電話番号";
            this.Customerlist_Tel.Name = "Customerlist_Tel";
            // 
            // Customerlist_Sex
            // 
            this.Customerlist_Sex.DataPropertyName = "SEX";
            this.Customerlist_Sex.HeaderText = "性別";
            this.Customerlist_Sex.Name = "Customerlist_Sex";
            this.Customerlist_Sex.Width = 80;
            // 
            // Customerlist_Kana
            // 
            this.Customerlist_Kana.DataPropertyName = "CLIENT_KANA";
            this.Customerlist_Kana.HeaderText = "ふりがな";
            this.Customerlist_Kana.Name = "Customerlist_Kana";
            // 
            // Customerlist_name
            // 
            this.Customerlist_name.DataPropertyName = "CLIENT_NAME";
            this.Customerlist_name.HeaderText = "名前";
            this.Customerlist_name.Name = "Customerlist_name";
            // 
            // Customerlist_No
            // 
            this.Customerlist_No.DataPropertyName = "CLIENT_CODE";
            this.Customerlist_No.HeaderText = "No";
            this.Customerlist_No.Name = "Customerlist_No";
            this.Customerlist_No.ReadOnly = true;
            this.Customerlist_No.Width = 50;
            // 
            // Customerlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 489);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomerlistTel_label);
            this.Controls.Add(this.CustomerlistName_label);
            this.Controls.Add(this.CustomerlistTop_button);
            this.Controls.Add(this.CustomerlistBack_button);
            this.Controls.Add(this.CustomerlistEntry_button);
            this.Controls.Add(this.CustomerlistSearch_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customerlist";
            this.Text = "Customerlist";
            this.Load += new System.EventHandler(this.Customerlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCLIENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CustomerlistSearch_button;
        private System.Windows.Forms.Button CustomerlistEntry_button;
        private System.Windows.Forms.Button CustomerlistBack_button;
        private System.Windows.Forms.Button CustomerlistTop_button;
        private System.Windows.Forms.Label CustomerlistName_label;
        private System.Windows.Forms.Label CustomerlistTel_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private globalDBDataSet globalDBDataSet;
        private System.Windows.Forms.BindingSource tBLCLIENTBindingSource;
        private globalDBDataSetTableAdapters.TBL_CLIENTTableAdapter tBL_CLIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_Kana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customerlist_note;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTKANADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTPOSTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTNOTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESERVATIONCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIENTCOUNTDataGridViewTextBoxColumn;
    }
}