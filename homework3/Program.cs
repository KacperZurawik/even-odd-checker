using System;
using System.Threading;

namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAppRunning = true;
            
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Wyjście");
            string menuOption = Console.ReadLine();


            while (isAppRunning)
            { 
                switch (menuOption)
                {
                    case "1":
                        Console.Clear();
                        CheckEvenOdd();
                    break;

                    case "2":
                        isAppRunning = false;
                        break;
                }
            }
        }

        public static void CheckEvenOdd()
        {
            int number, remainder;
            Console.Write("Podaj jakąś liczbę: \t");

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                remainder = number % 2;

                if (remainder == 0)
                    Console.WriteLine("{0} jest liczbą parzystą.", number);
                else
                    Console.WriteLine("{0} jest liczbą nieparzystą", number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Nieprawidłowa wartość. Musisz podać liczbę całkowitą!");
            }

            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}
