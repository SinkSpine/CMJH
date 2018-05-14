using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionC_prj.FormLibrary
{
    public partial class Cycle : Form
    {
        public Cycle()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string i = HelpClass.PsHelp.ObtainPs(@"cycle.exe", "cycle");
            if (i != "1")
                MessageBox.Show(i, "未知原因!", MessageBoxButtons.OK);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            tb1.Text = "for(int i = 0;i <= 20; i++)"
                + "\r\n"
                + "{"
                + "\r\n"
                + "    Console.WriteLine(i.ToString())"
                + "\r\n"
                + "}"
                + "\r\n"
                + "Console.ReadLine";

        }
    }
}
