using System;

namespace ArraysAndObjects.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            City bakuInfo = new City
            {
                cityName = "Baki",
                temprature = 32.5
            };

            City genceInfo = new City
            {
                cityName = "Gence",
                temprature = 22
            };

            int a = 3;
            int[] arr = new int[1];


            City[] seherler = new City[2];

            seherler[0] = bakuInfo;
            seherler[1] = genceInfo;









            ////int[] numbers = { 11, 22, 43, 4, 5 };
            //int[] numbers = new int[5];
            //numbers[0] = 23;
            //numbers[4] = 22;


            //int elementSayi = numbers.Length;

            //int cem = 1;

            //for (int i = 0; i < elementSayi; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine(cem);

            //string soz = "Salam";
            //string[] sozler = new string[4];

            //sozler[0] = "alma";
            //sozler[1] = "gilas";
            //sozler[2] = "qarpiz";


            //for (int i = 0; i < sozler.Length; i++)
            //{
            //    Console.WriteLine(sozler[i]);
            //}
        }
    }

    class City
    {
        public string cityName;
        public double temprature;
    }
}
