namespace CollectionC_prj
{
    partial class CollectionC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionC));
            this.btCycle = new System.Windows.Forms.Button();
            this.BtFk = new System.Windows.Forms.Button();
            this.BtJm = new System.Windows.Forms.Button();
            this.BtOverTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCycle
            // 
            this.btCycle.Location = new System.Drawing.Point(12, 13);
            this.btCycle.Name = "btCycle";
            this.btCycle.Size = new System.Drawing.Size(75, 23);
            this.btCycle.TabIndex = 0;
            this.btCycle.Text = "循环";
            this.btCycle.UseVisualStyleBackColor = true;
            this.btCycle.Click += new System.EventHandler(this.btCycle_Click);
            // 
            // BtFk
            // 
            this.BtFk.Location = new System.Drawing.Point(93, 13);
            this.BtFk.Name = "BtFk";
            this.BtFk.Size = new System.Drawing.Size(75, 23);
            this.BtFk.TabIndex = 1;
            this.BtFk.Text = "俄罗斯方块";
            this.BtFk.UseVisualStyleBackColor = true;
            this.BtFk.Click += new System.EventHandler(this.BtFk_Click);
            // 
            // BtJm
            // 
            this.BtJm.Location = new System.Drawing.Point(174, 13);
            this.BtJm.Name = "BtJm";
            this.BtJm.Size = new System.Drawing.Size(75, 23);
            this.BtJm.TabIndex = 2;
            this.BtJm.Text = "加密";
            this.BtJm.UseVisualStyleBackColor = true;
            this.BtJm.Click += new System.EventHandler(this.BtJm_Click);
            // 
            // BtOverTime
            // 
            this.BtOverTime.Location = new System.Drawing.Point(255, 13);
            this.BtOverTime.Name = "BtOverTime";
            this.BtOverTime.Size = new System.Drawing.Size(75, 23);
            this.BtOverTime.TabIndex = 3;
            this.BtOverTime.Text = "加班计时器";
            this.BtOverTime.UseVisualStyleBackColor = true;
            this.BtOverTime.Click += new System.EventHandler(this.BtOverTime_Click);
            // 
            // CollectionC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.BtOverTime);
            this.Controls.Add(this.BtJm);
            this.Controls.Add(this.BtFk);
            this.Controls.Add(this.btCycle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CollectionC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "程序集";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CollectionC_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCycle;
        private System.Windows.Forms.Button BtFk;
        private System.Windows.Forms.Button BtJm;
        private System.Windows.Forms.Button BtOverTime;
    }
}

