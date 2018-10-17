using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionC_prj.ImageConversionIcoAll
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtStartOne_Click(object sender, EventArgs e)
        {
            string i = HelpClass.PsHelp.ObtainPs(@"ImageConversionIcoAll_prj.exe", "ImageConversionIcoAll_prj", "ImageConversionIcoAll_prj");
            if (i != "1")
                MessageBox.Show(i, "未知原因!", MessageBoxButtons.OK);
        }
    }
}
