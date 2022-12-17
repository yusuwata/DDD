namespace DDD
{
    partial class WeatherLatest
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.ttlArea = new System.Windows.Forms.Label();
            this.txtAreaID = new System.Windows.Forms.TextBox();
            this.btnLatest = new System.Windows.Forms.Button();
            this.ttlDate = new System.Windows.Forms.Label();
            this.ttlStatus = new System.Windows.Forms.Label();
            this.ttlTemperture = new System.Windows.Forms.Label();
            this.lblDataDate = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblTemperture = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ttlArea
            // 
            this.ttlArea.AutoSize = true;
            this.ttlArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ttlArea.Location = new System.Drawing.Point(22, 48);
            this.ttlArea.Name = "ttlArea";
            this.ttlArea.Size = new System.Drawing.Size(29, 12);
            this.ttlArea.TabIndex = 0;
            this.ttlArea.Text = "地域";
            // 
            // txtAreaID
            // 
            this.txtAreaID.Location = new System.Drawing.Point(80, 45);
            this.txtAreaID.Name = "txtAreaID";
            this.txtAreaID.Size = new System.Drawing.Size(71, 19);
            this.txtAreaID.TabIndex = 1;
            // 
            // btnLatest
            // 
            this.btnLatest.Location = new System.Drawing.Point(157, 43);
            this.btnLatest.Name = "btnLatest";
            this.btnLatest.Size = new System.Drawing.Size(75, 23);
            this.btnLatest.TabIndex = 2;
            this.btnLatest.Text = "button1";
            this.btnLatest.UseVisualStyleBackColor = true;
            this.btnLatest.Click += new System.EventHandler(this.btnLatest_Click);
            // 
            // ttlDate
            // 
            this.ttlDate.AutoSize = true;
            this.ttlDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ttlDate.Location = new System.Drawing.Point(22, 92);
            this.ttlDate.Name = "ttlDate";
            this.ttlDate.Size = new System.Drawing.Size(29, 12);
            this.ttlDate.TabIndex = 3;
            this.ttlDate.Text = "日時";
            // 
            // ttlStatus
            // 
            this.ttlStatus.AutoSize = true;
            this.ttlStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ttlStatus.Location = new System.Drawing.Point(22, 136);
            this.ttlStatus.Name = "ttlStatus";
            this.ttlStatus.Size = new System.Drawing.Size(29, 12);
            this.ttlStatus.TabIndex = 5;
            this.ttlStatus.Text = "状態";
            // 
            // ttlTemperture
            // 
            this.ttlTemperture.AutoSize = true;
            this.ttlTemperture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ttlTemperture.Location = new System.Drawing.Point(22, 180);
            this.ttlTemperture.Name = "ttlTemperture";
            this.ttlTemperture.Size = new System.Drawing.Size(29, 12);
            this.ttlTemperture.TabIndex = 6;
            this.ttlTemperture.Text = "温度";
            // 
            // lblDataDate
            // 
            this.lblDataDate.AutoSize = true;
            this.lblDataDate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDataDate.Location = new System.Drawing.Point(78, 92);
            this.lblDataDate.Name = "lblDataDate";
            this.lblDataDate.Size = new System.Drawing.Size(73, 12);
            this.lblDataDate.TabIndex = 7;
            this.lblDataDate.Text = "XXXX/XX/XX";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCondition.Location = new System.Drawing.Point(78, 136);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(12, 12);
            this.lblCondition.TabIndex = 8;
            this.lblCondition.Text = "X";
            // 
            // lblTemperture
            // 
            this.lblTemperture.AutoSize = true;
            this.lblTemperture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTemperture.Location = new System.Drawing.Point(78, 180);
            this.lblTemperture.Name = "lblTemperture";
            this.lblTemperture.Size = new System.Drawing.Size(43, 12);
            this.lblTemperture.TabIndex = 9;
            this.lblTemperture.Text = "XX.XXC";
            // 
            // WeatherLatest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 233);
            this.Controls.Add(this.lblTemperture);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblDataDate);
            this.Controls.Add(this.ttlTemperture);
            this.Controls.Add(this.ttlStatus);
            this.Controls.Add(this.ttlDate);
            this.Controls.Add(this.btnLatest);
            this.Controls.Add(this.txtAreaID);
            this.Controls.Add(this.ttlArea);
            this.Name = "WeatherLatest";
            this.Text = "WeatherLatest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ttlArea;
        private System.Windows.Forms.TextBox txtAreaID;
        private System.Windows.Forms.Button btnLatest;
        private System.Windows.Forms.Label ttlDate;
        private System.Windows.Forms.Label ttlStatus;
        private System.Windows.Forms.Label ttlTemperture;
        private System.Windows.Forms.Label lblDataDate;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblTemperture;
    }
}

