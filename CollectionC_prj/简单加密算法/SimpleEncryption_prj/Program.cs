using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEncryption_prj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************加密********************\n\n输入一个数字,以数字的形式进行加密\n\n");
            int Ypass = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入加密密钥:  ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n加密后的密码为:  ");
            int byKey = Ypass ^ key;
            Console.WriteLine(byKey);
            Console.WriteLine("\n\n\n\n****************加密*****************\n\n请输入密钥 进行解密:  ");
            int key1 = Convert.ToInt32(Console.ReadLine());
            int byKey1 = byKey ^ key1;
            if (Ypass == byKey1)
            {
                Console.WriteLine("\n成功解密!!!! 解密的数字为: \n\n\n");
                Console.WriteLine(Ypass);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n解密失败!!!!  \n\n\n");
                Console.ReadLine();
            }
        }
    }
}
