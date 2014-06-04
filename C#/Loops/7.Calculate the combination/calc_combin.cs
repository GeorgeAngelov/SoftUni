using System;
    class calc_combin
    {
        static void Main()
        {
            Console.WriteLine("Add number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Add number k: ");
            int k = int.Parse(Console.ReadLine());
            int delimo = 1;
            int Kfact = 1;
            int NminusK=n-k;
            int delitel=1;
            for (int i = 1; i <= n; i++)
            {
                delimo *= i;
            }
            for(int i=1;i<=k;i++)
            {
                Kfact *= i;
            }
            for (int i = 1; i <= NminusK; i++)
            {
                delitel *= i;
            }
            float result = delimo / (Kfact * delitel);
            Console.WriteLine(result);
        }
    }
