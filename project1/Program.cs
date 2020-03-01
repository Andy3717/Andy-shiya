using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            while (!end)
            {
                int a, j;
                string Input = "";
                Console.WriteLine("请输入一个非零正整数并按下回车键");
                Input = Console.ReadLine();
                while (!int.TryParse(Input, out a))
                {
                    Console.Write("请输入正整数:");
                    Input = Console.ReadLine();
                }
                while (0 < a)
                {
                    for (j = 2; j <= a; j++)
                    {
                        if (a % j == 0)
                        {
                            Console.WriteLine("{0}", j);
                            break;
                        }
                    }
                    if (a != j)
                        a = a / j;
                    else
                        break;
                }
                Console.Write("按n退出程序,或按任意键以继续:");
                if (Console.ReadLine() == "n")
                    end = true;
            }
        }
    }
}
