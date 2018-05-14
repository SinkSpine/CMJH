using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionC_prj.Encryption
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void BtJm1_Click(object sender, EventArgs e)
        {
            string i = HelpClass.PsHelp.ObtainPs(@"SimpleEncryption_prj.exe", "SimpleEncryption_prj", "简单加密算法");
            if (i != "1")
                MessageBox.Show(i, "未知原因!", MessageBoxButtons.OK);
        }
    }
}
