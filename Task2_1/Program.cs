using System;

namespace Task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            int a = 123456;

            while (a > 0)
            {
                int cavab = a / 10;
                int qaliq = a % 10;
                //Console.WriteLine(cavab);
                //Console.WriteLine(qaliq);

                sum = sum + qaliq;
                a = cavab;
            }

            Console.WriteLine(sum);

            //Console.WriteLine(a / 10);

            //// 7/10 = 0(7)

            //int cavab = a / 10;
            //int qaliq = a % 10;

            //int cavab2 = cavab / 10;
            //int qaliq2 = cavab % 10;

            //int cavab3 = cavab2 / 10;
            //int qaliq3 = cavab2 % 10;

            //int cavab4 = cavab3 / 10;
            //int qaliq4 = cavab3 % 10;

            //Console.WriteLine(cavab);
            //Console.WriteLine(qaliq);

            //Console.WriteLine(cavab2);
            //Console.WriteLine(qaliq2);

            //Console.WriteLine(cavab3);
            //Console.WriteLine(qaliq3);

            //Console.WriteLine(cavab4);
            //Console.WriteLine(qaliq4);

        }
    }
}
