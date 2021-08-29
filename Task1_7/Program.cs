using System;

namespace Task1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 99999;
            double b = 88888;
            //10000  -  99999
            //100000 - 999999

            double c = a + b;
            double d;

            if (c>=10000 && c<= 99999)
            {
                d = 500000 + c;
                Console.WriteLine("5reqemli serti");
            }
            else
            {
                d = 5000000 + c;
                Console.WriteLine("5reqemli serti");
            }

            double f = d * 10 + 5;

            Console.WriteLine(f);

            Console.ReadKey();


        }
    }
}
