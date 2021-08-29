using System;

namespace Task1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             11) 4 dene 5 reqemli eded verilib.Her
 I ededin ustune III ededi gel.
II ededin usutune IV eeddi gel. 
    Sonra cavablari vur birbirine. 
            Alinan neticeden III ededin 3 % -ni cix.

             */

            double a = 11111;
            double b = 22222;
            double c = 33333;
            double d = 44444;


            double sum_a_c = a + c;
            double sum_b_d = b + d;



            double multiply = sum_a_c * sum_b_d;

            double c03 = c * 3 / 100;

            double t = multiply - c03;

            Console.WriteLine(t);

            Console.ReadKey();
        }
    }
}
