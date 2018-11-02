namespace 自动生成器
{
    partial class Login
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtTc = new System.Windows.Forms.Button();
            this.BtLogin = new System.Windows.Forms.Button();
            this.CbYz = new System.Windows.Forms.ComboBox();
            this.TbPwd = new System.Windows.Forms.TextBox();
            this.TbUser = new System.Windows.Forms.TextBox();
            this.TbServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtTc);
            this.groupBox1.Controls.Add(this.BtLogin);
            this.groupBox1.Controls.Add(this.CbYz);
            this.groupBox1.Controls.Add(this.TbPwd);
            this.groupBox1.Controls.Add(this.TbUser);
            this.groupBox1.Controls.Add(this.TbServer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录到服务器";
            // 
            // BtTc
            // 
            this.BtTc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtTc.Location = new System.Drawing.Point(188, 218);
            this.BtTc.Name = "BtTc";
            this.BtTc.Size = new System.Drawing.Size(81, 36);
            this.BtTc.TabIndex = 10;
            this.BtTc.Text = "退出";
            this.BtTc.UseVisualStyleBackColor = true;
            this.BtTc.Click += new System.EventHandler(this.BtTc_Click);
            // 
            // BtLogin
            // 
            this.BtLogin.Location = new System.Drawing.Point(56, 218);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.Size = new System.Drawing.Size(77, 36);
            this.BtLogin.TabIndex = 9;
            this.BtLogin.Text = "登录";
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // CbYz
            // 
            this.CbYz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbYz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CbYz.FormattingEnabled = true;
            this.CbYz.Location = new System.Drawing.Point(108, 76);
            this.CbYz.Name = "CbYz";
            this.CbYz.Size = new System.Drawing.Size(172, 20);
            this.CbYz.TabIndex = 8;
            this.CbYz.SelectedIndexChanged += new System.EventHandler(this.CbYz_SelectedIndexChanged);
            // 
            // TbPwd
            // 
            this.TbPwd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbPwd.Location = new System.Drawing.Point(108, 158);
            this.TbPwd.Name = "TbPwd";
            this.TbPwd.PasswordChar = '*';
            this.TbPwd.Size = new System.Drawing.Size(172, 21);
            this.TbPwd.TabIndex = 7;
            // 
            // TbUser
            // 
            this.TbUser.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbUser.Location = new System.Drawing.Point(108, 115);
            this.TbUser.Name = "TbUser";
            this.TbUser.Size = new System.Drawing.Size(172, 21);
            this.TbUser.TabIndex = 6;
            // 
            // TbServer
            // 
            this.TbServer.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbServer.Location = new System.Drawing.Point(108, 41);
            this.TbServer.Name = "TbServer";
            this.TbServer.Size = new System.Drawing.Size(172, 21);
            this.TbServer.TabIndex = 4;
            this.TbServer.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(30, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "账号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(30, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "身份验证：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器名称:";
            // 
            // Login
            // 
            this.AcceptButton = this.BtLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtTc;
            this.ClientSize = new System.Drawing.Size(386, 329);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbPwd;
        private System.Windows.Forms.TextBox TbUser;
        private System.Windows.Forms.TextBox TbServer;
        private System.Windows.Forms.Button BtTc;
        private System.Windows.Forms.Button BtLogin;
        private System.Windows.Forms.ComboBox CbYz;
    }
}

