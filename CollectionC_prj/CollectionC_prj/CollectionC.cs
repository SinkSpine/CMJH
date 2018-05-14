using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionC_prj
{
    public partial class CollectionC : Form
    {
        public CollectionC()
        {
            InitializeComponent();
        }

        private void btCycle_Click(object sender, EventArgs e)
        {
            FormLibrary.Cycle cycle = new FormLibrary.Cycle();
            cycle.ShowDialog();
        }

        private void CollectionC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确定要退出吗?", "退出", MessageBoxButtons.YesNo))
            {
                e.Cancel = true;
            }
        }

        private void BtFk_Click(object sender, EventArgs e)
        {
            Tetris.Tetris tetris = new Tetris.Tetris();
            tetris.ShowDialog();
        }

        private void BtJm_Click(object sender, EventArgs e)
        {
            Encryption.Encryption encryption = new Encryption.Encryption();
            encryption.ShowDialog();
        }
    }
}
