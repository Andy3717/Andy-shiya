using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string Input = "";
            Console.WriteLine("请输入数组维数并按下回车键");
            Input = Console.ReadLine();
            int.TryParse(Input, out num);
            int[] array = new int[num];
            int max, min, sum;
            float average;
            Console.WriteLine("请输入数组元素并按下回车键");
            string buf = Console.ReadLine();
            for (int i = 0; i < num; i++)
            {                
                var arr = buf.Split();
                array[i] = int.Parse(arr[i]);
            }
            max = min = sum = array[0];
            for (int i = 1; i < num; i++)
            {
                if (max < array[i])
                    max = array[i];
                if (min > array[i])
                    min = array[i];
                sum += array[i];
            }
            average = (float)sum / num;
            Console.WriteLine("max:{0} min:{1} sum:{2} average:{3}", max,min,sum,average);
            Console.ReadKey();
        }
    }
}
