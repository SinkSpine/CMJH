namespace CollectionC_prj.Tetris
{
    partial class Tetris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris));
            this.BtLhTetris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtLhTetris
            // 
            this.BtLhTetris.Location = new System.Drawing.Point(13, 13);
            this.BtLhTetris.Name = "BtLhTetris";
            this.BtLhTetris.Size = new System.Drawing.Size(115, 23);
            this.BtLhTetris.TabIndex = 0;
            this.BtLhTetris.Text = "老黄的俄罗斯方块";
            this.BtLhTetris.UseVisualStyleBackColor = true;
            this.BtLhTetris.Click += new System.EventHandler(this.BtLhTetris_Click);
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 260);
            this.Controls.Add(this.BtLhTetris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tetris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "俄罗斯方块";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtLhTetris;
    }
}