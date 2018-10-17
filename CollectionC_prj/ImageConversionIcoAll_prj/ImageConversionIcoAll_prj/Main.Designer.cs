namespace ImageConversionIcoAll_prj
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.BtOpenImg = new System.Windows.Forms.Button();
            this.BtStart = new System.Windows.Forms.Button();
            this.srcPanel = new System.Windows.Forms.Panel();
            this.sizeComb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(12, 12);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(336, 21);
            this.tbAddress.TabIndex = 0;
            // 
            // BtOpenImg
            // 
            this.BtOpenImg.Location = new System.Drawing.Point(354, 10);
            this.BtOpenImg.Name = "BtOpenImg";
            this.BtOpenImg.Size = new System.Drawing.Size(121, 23);
            this.BtOpenImg.TabIndex = 1;
            this.BtOpenImg.Text = "打开图片";
            this.BtOpenImg.UseVisualStyleBackColor = true;
            this.BtOpenImg.Click += new System.EventHandler(this.BtOpenImg_Click);
            // 
            // BtStart
            // 
            this.BtStart.Location = new System.Drawing.Point(12, 226);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(463, 23);
            this.BtStart.TabIndex = 2;
            this.BtStart.Text = "转换";
            this.BtStart.UseVisualStyleBackColor = false;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // srcPanel
            // 
            this.srcPanel.Location = new System.Drawing.Point(12, 39);
            this.srcPanel.Name = "srcPanel";
            this.srcPanel.Size = new System.Drawing.Size(336, 181);
            this.srcPanel.TabIndex = 3;
            this.srcPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.srcPanel_Paint);
            // 
            // sizeComb
            // 
            this.sizeComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeComb.FormattingEnabled = true;
            this.sizeComb.Items.AddRange(new object[] {
            "16,16",
            "32,32",
            "48,48"});
            this.sizeComb.Location = new System.Drawing.Point(354, 39);
            this.sizeComb.Name = "sizeComb";
            this.sizeComb.Size = new System.Drawing.Size(121, 20);
            this.sizeComb.TabIndex = 4;
            this.sizeComb.SelectedIndexChanged += new System.EventHandler(this.sizeComb_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.sizeComb);
            this.Controls.Add(this.srcPanel);
            this.Controls.Add(this.BtStart);
            this.Controls.Add(this.BtOpenImg);
            this.Controls.Add(this.tbAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图片转换ICO";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button BtOpenImg;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.Panel srcPanel;
        private System.Windows.Forms.ComboBox sizeComb;
    }
}