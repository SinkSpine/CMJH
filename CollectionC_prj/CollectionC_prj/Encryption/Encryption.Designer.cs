namespace CollectionC_prj.Encryption
{
    partial class Encryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encryption));
            this.BtJm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtJm1
            // 
            this.BtJm1.Location = new System.Drawing.Point(13, 13);
            this.BtJm1.Name = "BtJm1";
            this.BtJm1.Size = new System.Drawing.Size(104, 23);
            this.BtJm1.TabIndex = 0;
            this.BtJm1.Text = "理解不了的加密";
            this.BtJm1.UseVisualStyleBackColor = true;
            this.BtJm1.Click += new System.EventHandler(this.BtJm1_Click);
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.BtJm1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Encryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加密";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtJm1;
    }
}