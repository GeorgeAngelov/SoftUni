using System;
    class Calculate_N_over_K_
    {
        static void Main()
        {
            Console.WriteLine("Add number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Add number k: ");
            int k = int.Parse(Console.ReadLine());
            int delimo = 1;
            int delitel = 1;
            for (int i =1;i<=n;i++)
            {
                delimo*=i;
            }
            for(int i=1;i<=k;i++)
            {
                delitel*=i;
            }
            int result = delimo/delitel;
            Console.WriteLine(result);
        }
    }
