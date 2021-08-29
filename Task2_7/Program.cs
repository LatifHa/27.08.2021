using System;

namespace Task2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 123456;

            int yeni = 0;

            while (x > 0)
            {
                //int qaliq = x % 10;
                yeni = yeni+1;
                x = x / 10;
                Console.WriteLine(yeni);
            }

            
        }
    }
}
