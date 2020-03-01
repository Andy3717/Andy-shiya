using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[99];
            for (int i = 0; i < 99; i++)
            {
                A[i] = i + 2;
            }
            for (int j = 2; j < 99; j++)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (A[i] % j == 0 && A[i] / j > 1)
                    {
                        A[i] = 0;
                    }
                }
            }
            for (int i = 0; i <99; i++)
            {
                if(A[i]!=0)
                {
                    Console.WriteLine("{0}", A[i]);
                }                
            }
            Console.ReadKey();
        }
    }
}
