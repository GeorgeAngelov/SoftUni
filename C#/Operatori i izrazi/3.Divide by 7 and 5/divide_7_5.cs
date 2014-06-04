using System;
    class divide_7_5
    {
        static void Main()
        {
            Console.WriteLine("Въведи число: ");
            string buff=Console.ReadLine();
            int value;
            int.TryParse(buff, out value);
            bool result = value % 7 == 0 && value % 5 == 0;
            Console.WriteLine(result);
        }
    }
