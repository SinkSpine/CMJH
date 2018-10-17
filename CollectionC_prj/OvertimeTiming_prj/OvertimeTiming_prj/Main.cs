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

namespace OvertimeTiming_prj
{
    public partial class Main : Form
    {
        //定义全局变量
        public int currentCount = 0;
        //定义Timer类
        System.Threading.Timer threadTimer;
        //定义委托
        public delegate void SetControlValue(object value);
        //加班开始时间
        public DateTime startTime = DateTime.Now;

        public Main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 开始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_Start_Click(object sender, EventArgs e)
        {
            //立即开始计时,时间间隔1000毫秒
            threadTimer.Change(0, 1000);
            startTime = DateTime.Now;
            var lbstarttime = startTime;
            LbStartTime.Text = lbstarttime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitTimer();
        }

        /// <summary>
        /// 初始化Timer类
        /// </summary>
        private void InitTimer()
        {
            threadTimer = new System.Threading.Timer(new TimerCallback(TimerUp), null, Timeout.Infinite, 1000);
        }
        /// <summary>
        /// 定时到点执行的事件
        /// </summary>
        /// <param name="value"></param>
        private void TimerUp(object value)
        {
            currentCount += 1;
            this.Invoke(new SetControlValue(SetLabelValue), currentCount);
        }
        /// <summary>
        /// 给label赋值
        /// </summary>
        /// <param name="value"></param>
        private void SetLabelValue(object value)
        {
            var NowDateTime = DateTime.Now;
            NowDateTime.AddMilliseconds(Convert.ToDouble(value));
            this.LbTime.Text = NowDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void BtStop_Click(object sender, EventArgs e)
        {
            threadTimer.Change(Timeout.Infinite, 1000);
            var StopTime = DateTime.Now;
            LbStopTime.Text = DateDiff(startTime, StopTime);

        }

        //计算两个时间差
        private string DateDiff(DateTime StartTime, DateTime StopTime)
        {
            string result = string.Empty;
            try
            {
                TimeSpan ts1 = new TimeSpan(StartTime.Ticks);
                TimeSpan ts2 = new TimeSpan(StopTime.Ticks);
                TimeSpan ts = ts1.Subtract(ts2).Duration();
                result = "加班" + ts.Days.ToString() + "天"
                + ts.Hours.ToString() + "小时"
                + ts.Minutes.ToString() + "分钟"
                + ts.Seconds.ToString() + "秒";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return result + " 啊哈哈哈 嗝";
        }
    }
}
