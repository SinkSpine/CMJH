using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionC_prj.Tetris
{
    public partial class Tetris : Form
    {
        public Tetris()
        {
            InitializeComponent();
        }

        private void BtLhTetris_Click(object sender, EventArgs e)
        {
            string i = HelpClass.PsHelp.ObtainPs(@"俄罗斯方块.exe", "俄罗斯方块", "俄罗斯方块游戏");
            if (i != "1")
                MessageBox.Show(i, "未知原因!", MessageBoxButtons.OK);
        }
    }
}
