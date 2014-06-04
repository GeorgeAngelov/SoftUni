using System;
    class Third_digit_is_7
    {
        static void Main()
        {
            int p = 3;
            string buff;
            Console.WriteLine("Въведи число: ");
            buff = Console.ReadLine();
            int number;
            int.TryParse(buff, out number);
            if ((number / 100) % 10 == 7)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
