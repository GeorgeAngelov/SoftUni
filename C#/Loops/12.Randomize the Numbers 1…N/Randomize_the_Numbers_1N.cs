using System;
    class Randomize_the_Numbers_1N
    {
        static void Main()
        {
            Console.WriteLine("How many numbers do you want: ");
            int n = int.Parse(Console.ReadLine());
            bool[] printed = new bool[n + 1];
            Random randomNum = new Random();
            int numberForPrint;
            for (int i = 1; i <= n; i++)
            {
                numberForPrint= randomNum.Next(1,n+1);
                if (!printed[numberForPrint])
                {
                    Console.Write(numberForPrint + " ");
                    printed[numberForPrint] = true;
                }
                else 
                {
                    i--;
                }
            }
        }
    }
