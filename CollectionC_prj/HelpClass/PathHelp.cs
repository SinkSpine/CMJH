using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelpClass
{
    public class PathHelp
    {
        /// <summary>
        /// 配置路径
        /// </summary>
        /// <param name="filename">控制台程序Name</param>
        /// <param name="ConsoleName">控制台程序文件夹Name</param>
        /// <returns></returns>
        public static string Path(string filename, string ConsoleName) 
        {
            //获取本地文件根目录
            DirectoryInfo PathName = Directory.GetParent(Environment.CurrentDirectory);
            //获取跟目录下控制台exe程序
            string root = PathName.Parent.Parent.FullName + "\\" + ConsoleName + "\\bin\\Debug\\" + filename;
            return root;
        }

        /// <summary>
        /// 配置路径
        /// </summary>
        /// <param name="filename">exe台程序Name</param>
        /// <param name="ConsoleName">exe程序文件夹Name</param>
        /// <returns></returns>
        public static string Path(string filename,string folder, string ConsoleName)
        {
            //获取本地文件根目录
            DirectoryInfo PathName = Directory.GetParent(Environment.CurrentDirectory);
            //获取跟目录下exe程序
            string root = PathName.Parent.Parent.FullName + "\\" + ConsoleName + "\\"+folder+"\\bin\\Debug\\" + filename;
            return root;
        }
    }
}
