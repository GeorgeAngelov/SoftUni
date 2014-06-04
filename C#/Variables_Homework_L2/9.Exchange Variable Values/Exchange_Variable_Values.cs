using System;
    class Exchange_Variable_Values
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int buff;
            Console.WriteLine("a= {0} and b= {1}",a,b);
            buff = a;
            a = b;
            b = buff;
            Console.WriteLine("a= {0} and b= {1}", a, b);
        }
    }
