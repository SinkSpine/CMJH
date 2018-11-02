using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自动生成器
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// 窗体一加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            LoginF();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtTc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 身份验证改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbYz_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtTcF();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtLogin_Click(object sender, EventArgs e)
        {
            BtLoginF();
        }

        /// <summary>
        /// 窗体一加载方法
        /// </summary>
        public void LoginF()
        {
            CbYz.Items.Add("Windows身份验证");
            CbYz.Items.Add("SQLServer身份验证");
            CbYz.SelectedIndex = 0;
            TbUser.ReadOnly = true;
            TbPwd.ReadOnly = true;
        }

        /// <summary>
        /// 身份验证方法
        /// </summary>
        public void BtTcF()
        {
            if (CbYz.SelectedIndex == 0)
            {
                TbUser.ReadOnly = true;
                TbPwd.ReadOnly = true;
            }
            else
            {
                TbUser.ReadOnly = false;
                TbPwd.ReadOnly = false;
            }
        }

        /// <summary>
        /// 登陆方法
        /// </summary>
        public void BtLoginF()
        {
            string sql = "SELECT * FROM sysdatabases";
            Model s = m();
            string mess = string.Empty;
            DataTable dt = DBHelp.Qu(s, sql, out mess);
            if (s.CbYz == "Windows身份验证")
            {
                if (dt == null || s.Server.Trim() == "")
                    MessageBox.Show("登录失败！" + mess);
                else
                {
                    MessageBox.Show("登录成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                if (TbServer.Text!="")
                {
                    if (TbUser.Text != "")
                    {
                        if (TbPwd.Text != "")
                        {
                            if (dt != null)
                            {
                                MessageBox.Show("登录成功！");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("登录失败！" + mess);
                            }
                        }
                        else
                        {
                            MessageBox.Show("登录失败！" + mess);
                        }
                    }
                    else
                    {
                        MessageBox.Show("登录失败！" + mess);
                    }
                }
                else
                    MessageBox.Show("登录失败！" + mess);
            }
        } 

        /// <summary>
        /// 赋值
        /// </summary>
        /// <returns></returns>
        public Model m()
        {
            Model m = new Model(); //实体类
            m.Server = TbServer.Text;
            m.CbYz = CbYz.Text;
            m.User = TbUser.Text;
            m.Pwd = TbPwd.Text;
            return m;
        }
    }
}
