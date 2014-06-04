using System;
    class Modify_Bit_at_Given_Position
    {
        static void Main()
        {
            string buff;
            Console.WriteLine("Input a number: ");
            buff = Console.ReadLine();
            int n;
            int.TryParse(buff, out n);
            Console.WriteLine("Set Position: ");
            buff = Console.ReadLine();
            int p;
            int.TryParse(buff, out p);
            Console.WriteLine("Chose bit value: ");
            buff = Console.ReadLine();
            int value;
            int.TryParse(buff, out value);
            if (value == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine(result);
            }
            else
            {
                int mask =  value << p;
                int result = n | mask;
                Console.WriteLine(result);
            }
        }
    }
