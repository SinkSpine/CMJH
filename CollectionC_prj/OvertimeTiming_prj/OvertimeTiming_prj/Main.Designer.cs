namespace OvertimeTiming_prj
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Bt_Start = new System.Windows.Forms.Button();
            this.LbTime = new System.Windows.Forms.Label();
            this.BtStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbStartTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbStopTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bt_Start
            // 
            this.Bt_Start.Location = new System.Drawing.Point(12, 106);
            this.Bt_Start.Name = "Bt_Start";
            this.Bt_Start.Size = new System.Drawing.Size(124, 23);
            this.Bt_Start.TabIndex = 0;
            this.Bt_Start.Text = "开始加班";
            this.Bt_Start.UseVisualStyleBackColor = true;
            this.Bt_Start.Click += new System.EventHandler(this.Bt_Start_Click);
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.Location = new System.Drawing.Point(78, 39);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(0, 12);
            this.LbTime.TabIndex = 1;
            // 
            // BtStop
            // 
            this.BtStop.Location = new System.Drawing.Point(149, 106);
            this.BtStop.Name = "BtStop";
            this.BtStop.Size = new System.Drawing.Size(124, 23);
            this.BtStop.TabIndex = 2;
            this.BtStop.Text = "下班";
            this.BtStop.UseVisualStyleBackColor = true;
            this.BtStop.Click += new System.EventHandler(this.BtStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "开始时间:";
            // 
            // LbStartTime
            // 
            this.LbStartTime.AutoSize = true;
            this.LbStartTime.Location = new System.Drawing.Point(78, 13);
            this.LbStartTime.Name = "LbStartTime";
            this.LbStartTime.Size = new System.Drawing.Size(0, 12);
            this.LbStartTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "结束累计:";
            // 
            // LbStopTime
            // 
            this.LbStopTime.AutoSize = true;
            this.LbStopTime.Location = new System.Drawing.Point(78, 72);
            this.LbStopTime.Name = "LbStopTime";
            this.LbStopTime.Size = new System.Drawing.Size(0, 12);
            this.LbStopTime.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 141);
            this.Controls.Add(this.LbStopTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbStartTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtStop);
            this.Controls.Add(this.LbTime);
            this.Controls.Add(this.Bt_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加班计时器";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Start;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Button BtStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbStopTime;
    }
}

