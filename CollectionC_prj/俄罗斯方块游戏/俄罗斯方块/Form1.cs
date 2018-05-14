using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 俄罗斯方块.Entities;
using 俄罗斯方块.Util;

namespace 俄罗斯方块
{
    public partial class Form1 : Form,Interface.IUIControl
    {
        Controller.GameController controller;
        public Form1()
        {
            InitializeComponent();
            Util.CommonHelper.InitializeEnvironment(this.gamepanel.Width,this.gamepanel.Height);
        }
        /// <summary>
        /// 开始游戏按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //1.从panel上得到一个1个画家对象。这个画家对象只能在面板上画画
            Graphics g = Graphics.FromHwnd(this.gamepanel.Handle);
            //畫背景
            controller = new Controller.GameController(g,this);
            controller.NewGame();
        }

        public void GameOver()
        {
            label1.Text = "游戏结束..";
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            controller.ProcessDialogKey(keyData);
            return base.ProcessDialogKey(keyData);
        }
    }
}
