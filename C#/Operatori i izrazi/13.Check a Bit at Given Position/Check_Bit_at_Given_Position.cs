using System;

    class Check_Bit_at_Given_Position
    {
        static void Main()
        {
            bool result;
            string buff;
            Console.WriteLine("Input a number: ");
            buff = Console.ReadLine();
            int n;
            int.TryParse(buff, out n);
            Console.WriteLine("Set Position: ");
            buff = Console.ReadLine();
            int p;
            int.TryParse(buff, out p);
            int nRight = n >> p;
            int bit = nRight & 1;
            if (bit == 1)
            {
                result = true;
            }
            else 
            {
                result = false;
            }
            Console.WriteLine(result);
        }
    }
