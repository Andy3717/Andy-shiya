using System;

namespace ConsoleApp1
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double res = double.NaN;
            switch (op)
            {
                case "+":
                    res = num1 + num2;
                    break;
                case "-":
                    res = num1 - num2;
                    break;
                case "*":
                    res = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        res = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            while (!end)
            {
                string Input1 = "";
                string Input2 = "";
                double res = 0;

                Console.WriteLine("请输入第一个数字并按下回车键");
                Input1 = Console.ReadLine();
                double Clean1 = 0;
                while (!double.TryParse(Input1, out Clean1))
                {
                    Console.Write("请输入有效的数字:");
                    Input1 = Console.ReadLine();
                }

                Console.WriteLine("请输入第二个数字并按下回车键");
                Input2 = Console.ReadLine();
                double Clean2 = 0;
                while (!double.TryParse(Input2, out Clean2))
                {
                    Console.Write("请输入有效的数字:");
                    Input2 = Console.ReadLine();
                }

                Console.WriteLine("请选择运算符并按回车键");

                string op = Console.ReadLine();
                res = Calculator.DoOperation(Clean1, Clean2, op);

                if (!double.IsNaN(res))
                    Console.WriteLine("计算结果: {0:0.###}\n", res);
                else
                {
                    Console.WriteLine("此计算过程出现错误\n");
                }

                Console.Write("按n退出程序,或按任意键以继续:");
                if (Console.ReadLine() == "n") 
                    end = true;
                Console.WriteLine("\n"); 
            }
            return;
        }
    }
}
