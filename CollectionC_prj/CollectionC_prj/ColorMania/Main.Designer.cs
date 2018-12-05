namespace CollectionC_prj.ColorMania
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
            this.BtStartOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtStartOne
            // 
            this.BtStartOne.Location = new System.Drawing.Point(12, 12);
            this.BtStartOne.Name = "BtStartOne";
            this.BtStartOne.Size = new System.Drawing.Size(75, 23);
            this.BtStartOne.TabIndex = 3;
            this.BtStartOne.Text = "ColorMania";
            this.BtStartOne.UseVisualStyleBackColor = true;
            this.BtStartOne.Click += new System.EventHandler(this.BtStartOne_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.BtStartOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "颜色吸取器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtStartOne;
    }
}