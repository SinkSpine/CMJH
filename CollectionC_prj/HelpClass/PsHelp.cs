using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelpClass
{
    public class PsHelp
    {
        /// <summary>
        /// 启动控制台程序
        /// </summary>
        /// <param name="filename">控制台程序Name</param>
        /// <param name="ConsoleName">控制台程序文件夹Name</param>
        /// <returns></returns>
        public static string ObtainPs(string filename, string ConsoleName)
        {
            try
            {
                //获取绝对路径
                string path = PathHelp.Path(filename, ConsoleName).ToString();
                //启动控制台exe程序
                System.Diagnostics.Process.Start(path);
                return "1";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// 启动exe程序
        /// </summary>
        /// <param name="filename">exe程序Name</param>
        /// <param name="ConsoleName">exe程序文件夹Name</param>
        /// <returns></returns>
        public static string ObtainPs(string filename,string folder, string ConsoleName)
        {
            try
            {
                //获取绝对路径
                string path = PathHelp.Path(filename,folder, ConsoleName).ToString();
                //启动exe程序
                System.Diagnostics.Process.Start(path);
                return "1";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
