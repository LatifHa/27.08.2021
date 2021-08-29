using System;

namespace Pseudocodetask2_2ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 776532;

            double a1 = a / 1000;
            double a11 = a % 1000;

            double a12 = a11 * 0.001;
            double a10 = a1 - a12;
            Console.WriteLine(a1);
            Console.WriteLine(a11);
            Console.WriteLine(a12);
            Console.WriteLine(a10);

            int sum = 0;
            while (a10>0)
            {
                int qaliq = (int)(a10 % 10);
                int cavab = (int)(a10 / 10);

                sum = sum + qaliq;
                a10 = cavab;       
            }
            Console.WriteLine(sum);
                
                
               








        }
    }
}