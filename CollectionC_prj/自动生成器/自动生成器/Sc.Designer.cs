namespace 自动生成器
{
    partial class Sc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sc));
            this.label1 = new System.Windows.Forms.Label();
            this.CbUname = new System.Windows.Forms.ComboBox();
            this.GbTName = new System.Windows.Forms.GroupBox();
            this.LbName = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbDz = new System.Windows.Forms.TextBox();
            this.BtLj = new System.Windows.Forms.Button();
            this.BtSc = new System.Windows.Forms.Button();
            this.BtSQL = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TbUname = new System.Windows.Forms.TextBox();
            this.BtXdb = new System.Windows.Forms.Button();
            this.GbTName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库名称：";
            // 
            // CbUname
            // 
            this.CbUname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUname.FormattingEnabled = true;
            this.CbUname.Location = new System.Drawing.Point(95, 17);
            this.CbUname.Name = "CbUname";
            this.CbUname.Size = new System.Drawing.Size(139, 20);
            this.CbUname.TabIndex = 1;
            this.CbUname.SelectedIndexChanged += new System.EventHandler(this.CbUname_SelectedIndexChanged);
            // 
            // GbTName
            // 
            this.GbTName.Controls.Add(this.LbName);
            this.GbTName.Location = new System.Drawing.Point(14, 43);
            this.GbTName.Name = "GbTName";
            this.GbTName.Size = new System.Drawing.Size(220, 490);
            this.GbTName.TabIndex = 2;
            this.GbTName.TabStop = false;
            this.GbTName.Text = "数据表名称：";
            // 
            // LbName
            // 
            this.LbName.FormattingEnabled = true;
            this.LbName.ItemHeight = 12;
            this.LbName.Location = new System.Drawing.Point(6, 21);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(206, 460);
            this.LbName.TabIndex = 0;
            this.LbName.SelectedIndexChanged += new System.EventHandler(this.LbName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "文件储存路径：";
            // 
            // TbDz
            // 
            this.TbDz.Location = new System.Drawing.Point(363, 17);
            this.TbDz.Name = "TbDz";
            this.TbDz.ReadOnly = true;
            this.TbDz.Size = new System.Drawing.Size(237, 21);
            this.TbDz.TabIndex = 4;
            // 
            // BtLj
            // 
            this.BtLj.Location = new System.Drawing.Point(270, 52);
            this.BtLj.Name = "BtLj";
            this.BtLj.Size = new System.Drawing.Size(75, 23);
            this.BtLj.TabIndex = 5;
            this.BtLj.Text = "存储路径";
            this.BtLj.UseVisualStyleBackColor = true;
            this.BtLj.Click += new System.EventHandler(this.BtLj_Click);
            // 
            // BtSc
            // 
            this.BtSc.Location = new System.Drawing.Point(351, 52);
            this.BtSc.Name = "BtSc";
            this.BtSc.Size = new System.Drawing.Size(75, 23);
            this.BtSc.TabIndex = 6;
            this.BtSc.Text = "生成实体";
            this.BtSc.UseVisualStyleBackColor = true;
            this.BtSc.Click += new System.EventHandler(this.BtSc_Click);
            // 
            // BtSQL
            // 
            this.BtSQL.Location = new System.Drawing.Point(432, 52);
            this.BtSQL.Name = "BtSQL";
            this.BtSQL.Size = new System.Drawing.Size(75, 23);
            this.BtSQL.TabIndex = 7;
            this.BtSQL.Text = "生成SQL";
            this.BtSQL.UseVisualStyleBackColor = true;
            this.BtSQL.Click += new System.EventHandler(this.BtSQL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(483, 452);
            this.dataGridView1.TabIndex = 8;
            // 
            // TbUname
            // 
            this.TbUname.Location = new System.Drawing.Point(513, 54);
            this.TbUname.Name = "TbUname";
            this.TbUname.Size = new System.Drawing.Size(240, 21);
            this.TbUname.TabIndex = 9;
            this.TbUname.Text = "输入命名空间";
            this.TbUname.MouseEnter += new System.EventHandler(this.TbUname_MouseEnter);
            this.TbUname.MouseLeave += new System.EventHandler(this.TbUname_MouseLeave);
            // 
            // BtXdb
            // 
            this.BtXdb.Location = new System.Drawing.Point(606, 17);
            this.BtXdb.Name = "BtXdb";
            this.BtXdb.Size = new System.Drawing.Size(147, 23);
            this.BtXdb.TabIndex = 10;
            this.BtXdb.Text = "下载通用DBHelp";
            this.BtXdb.UseVisualStyleBackColor = true;
            this.BtXdb.Click += new System.EventHandler(this.BtXdb_Click);
            // 
            // Sc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 545);
            this.Controls.Add(this.BtXdb);
            this.Controls.Add(this.TbUname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtSQL);
            this.Controls.Add(this.BtSc);
            this.Controls.Add(this.BtLj);
            this.Controls.Add(this.TbDz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GbTName);
            this.Controls.Add(this.CbUname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生成器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sc_FormClosing);
            this.Load += new System.EventHandler(this.Sc_Load);
            this.GbTName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbUname;
        private System.Windows.Forms.GroupBox GbTName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbDz;
        private System.Windows.Forms.Button BtLj;
        private System.Windows.Forms.Button BtSc;
        private System.Windows.Forms.Button BtSQL;
        private System.Windows.Forms.ListBox LbName;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TbUname;
        private System.Windows.Forms.Button BtXdb;
    }
}