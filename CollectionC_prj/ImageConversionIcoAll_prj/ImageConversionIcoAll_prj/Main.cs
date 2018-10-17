using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConversionIcoAll_prj
{
    public partial class Main : Form
    {
        Bitmap srcBitmap = null;//用于保存原图
        Size size;//用于保存目标图标的大小
        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 选择源文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtOpenImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "图片(*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp";//筛选文件格式
            dlg.ValidateNames = true;//文件有效性验证ValidateNames，验证用户输入是否是一个有效的Windows文件名
            dlg.CheckFileExists = true;///验证文件有效性
            dlg.CheckPathExists = true;//验证路径有效性

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbAddress.Text = dlg.FileName;
                srcBitmap = new Bitmap(dlg.FileName);

                this.srcPanel.Refresh();
            }
        }
        /// <summary>
        /// 生成并保存图标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtStart_Click(object sender, EventArgs e)
        {
            if (tbAddress.Text != "" && sizeComb.Text != "")
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "图标(*.ico)|*.ico";
                dlg.CheckPathExists = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(dlg.FileName, FileMode.Create);

                    Icon icon = ConvertBitmap2Ico(srcBitmap);

                    this.Icon = icon;

                    icon.Save(fs);//将Icon保存的指定的输出
                    fs.Close();

                    MessageBox.Show("转换成功");
                }
            }
        }
        /// <summary>
        /// 绘制原图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void srcPanel_Paint(object sender, PaintEventArgs e)
        {
            if (srcBitmap != null)
            {
                Graphics g = e.Graphics;
                //原图的绘制区域
                Rectangle rect = new Rectangle(0, 0, this.srcPanel.Width, this.srcPanel.Height);
                //在规定区域缩放绘制原图
                g.DrawImage(srcBitmap, rect);
            }
        }

        /// <summary>
        /// 实现bitmap到ico的转换
        /// </summary>
        /// <param name="bitmap">原图</param>
        /// <returns>转换后的指定大小的图标</returns>
        private Icon ConvertBitmap2Ico(Bitmap bitmap)
        {
            Bitmap icoBitmap = new Bitmap(bitmap, size);//创建制定大小的原位图

            //获得原位图的图标句柄
            IntPtr hIco = icoBitmap.GetHicon();
            //从图标的指定WINDOWS句柄创建Icon
            Icon icon = Icon.FromHandle(hIco);

            return icon;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            sizeComb.SelectedIndex = 0;
        }

        private void sizeComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sizeComb.SelectedIndex == 0)
            {
                size = new Size(16, 16);
            }
            else if (sizeComb.SelectedIndex == 1)
            {
                size = new Size(32, 32);
            }
            else
            {
                size = new Size(48, 48);
            }
        }
        
    }
}
