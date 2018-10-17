using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionC_prj.Overtime
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtStartOne_Click(object sender, EventArgs e)
        {
            string i = HelpClass.PsHelp.ObtainPs(@"OvertimeTiming_prj.exe", "OvertimeTiming_prj", "OvertimeTiming_prj");
            if (i != "1")
                MessageBox.Show(i, "未知原因!", MessageBoxButtons.OK);
        }
    }
}
