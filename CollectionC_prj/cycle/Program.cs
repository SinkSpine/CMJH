using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle
{
    class Program
    {
        /// <summary>
        /// 循环输出0-20
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
