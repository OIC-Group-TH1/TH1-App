namespace Sample1
{
    partial class Top_page
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Yoyaku_button = new System.Windows.Forms.Button();
            this.Kokyaku_button = new System.Windows.Forms.Button();
            this.Room_button = new System.Windows.Forms.Button();
            this.Syain_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Yoyaku_button
            // 
            this.Yoyaku_button.Location = new System.Drawing.Point(58, 22);
            this.Yoyaku_button.Name = "Yoyaku_button";
            this.Yoyaku_button.Size = new System.Drawing.Size(266, 68);
            this.Yoyaku_button.TabIndex = 0;
            this.Yoyaku_button.Text = "予約管理";
            this.Yoyaku_button.UseVisualStyleBackColor = true;
            this.Yoyaku_button.Click += new System.EventHandler(this.Yoyaku_button_Click);
            // 
            // Kokyaku_button
            // 
            this.Kokyaku_button.Location = new System.Drawing.Point(58, 111);
            this.Kokyaku_button.Name = "Kokyaku_button";
            this.Kokyaku_button.Size = new System.Drawing.Size(266, 65);
            this.Kokyaku_button.TabIndex = 1;
            this.Kokyaku_button.Text = "顧客管理";
            this.Kokyaku_button.UseVisualStyleBackColor = true;
            this.Kokyaku_button.Click += new System.EventHandler(this.Kokyaku_button_Click);
            // 
            // Room_button
            // 
            this.Room_button.Location = new System.Drawing.Point(58, 198);
            this.Room_button.Name = "Room_button";
            this.Room_button.Size = new System.Drawing.Size(266, 65);
            this.Room_button.TabIndex = 2;
            this.Room_button.Text = "客室状況管理";
            this.Room_button.UseVisualStyleBackColor = true;
            this.Room_button.Click += new System.EventHandler(this.Room_button_Click);
            // 
            // Syain_button
            // 
            this.Syain_button.Location = new System.Drawing.Point(58, 282);
            this.Syain_button.Name = "Syain_button";
            this.Syain_button.Size = new System.Drawing.Size(266, 65);
            this.Syain_button.TabIndex = 3;
            this.Syain_button.Text = "社員管理";
            this.Syain_button.UseVisualStyleBackColor = true;
            this.Syain_button.Click += new System.EventHandler(this.Syain_button_Click);
            // 
            // Top_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 386);
            this.Controls.Add(this.Syain_button);
            this.Controls.Add(this.Room_button);
            this.Controls.Add(this.Kokyaku_button);
            this.Controls.Add(this.Yoyaku_button);
            this.Name = "Top_page";
            this.Text = "ホテルOIC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Yoyaku_button;
        private System.Windows.Forms.Button Kokyaku_button;
        private System.Windows.Forms.Button Room_button;
        private System.Windows.Forms.Button Syain_button;

    }
}

