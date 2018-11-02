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
            Tetris.Main tetris = new Tetris.Main();
            tetris.ShowDialog();
        }

        private void BtJm_Click(object sender, EventArgs e)
        {
            Encryption.Main encryption = new Encryption.Main();
            encryption.ShowDialog();
        }

        private void BtOverTime_Click(object sender, EventArgs e)
        {
            Overtime.Main main = new Overtime.Main();
            main.ShowDialog();
        }

        private void BtImgToIco_Click(object sender, EventArgs e)
        {
            ImageConversionIcoAll.Main main = new ImageConversionIcoAll.Main();
            main.ShowDialog();
        }

        private void BtEntity_Click(object sender, EventArgs e)
        {
            ProduceEntity.Main main = new ProduceEntity.Main();
            main.ShowDialog();
        }

        private void BtDecompile_Click(object sender, EventArgs e)
        {
            Decompile.Main main = new Decompile.Main();
            main.ShowDialog();
        }

        private void BtJson_Click(object sender, EventArgs e)
        {
            Json.Main main = new Json.Main();
            main.ShowDialog();
        }

        private void BtRegular_Click(object sender, EventArgs e)
        {
            Regular.Main main = new Regular.Main();
            main.ShowDialog();
        }
    }
}
