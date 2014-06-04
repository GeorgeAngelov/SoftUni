using System;
using System.Numerics;

    class Catalan_Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter number [1<n<100]: ");
            int n = int.Parse(Console.ReadLine());
            int tempDelimo = 2 * n;
            BigInteger delimo = 1;
            BigInteger firstDelit = 1;
            BigInteger secDelit = 1;
            for (int i = 1; i <= tempDelimo; i++)
            {
                delimo *= i;
            }
            for (int i = 1; i <= (n+1); i++)
            {
                firstDelit *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                secDelit *= i;
            }
            BigInteger sum = delimo / (firstDelit * secDelit);
            Console.WriteLine(sum);
        }
    }
