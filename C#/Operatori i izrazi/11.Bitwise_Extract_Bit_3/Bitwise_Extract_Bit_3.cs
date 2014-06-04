using System;
    class Bitwise_Extract_Bit_3
    {
        static void Main()
        {
            string buff;
            Console.WriteLine("Input a number: ");
            buff = Console.ReadLine();
            int n;
            int.TryParse(buff, out n);
            int nRight = n >> 3;
            int bit = nRight & 1;
            Console.WriteLine("The bit is : {0}",bit);
        }
    }
