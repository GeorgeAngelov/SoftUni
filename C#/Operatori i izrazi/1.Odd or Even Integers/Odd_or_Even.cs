using System;
    class Odd_or_Even
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Въведи число: ");
            string buff = Console.ReadLine();
            int.TryParse(buff, out n);
            bool isEven = n % 2 == 0;
            Console.WriteLine(isEven);
        }
    }
