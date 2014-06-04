using System;
class Extract_Bit_from_Integer
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
            int nRight = n >> p;
            int bit = nRight & 1;
            Console.WriteLine("The bit is : {0}", bit);
        }
    }
