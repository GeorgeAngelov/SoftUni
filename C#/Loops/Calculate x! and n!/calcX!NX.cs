using System;
    class calcX_N_factor
    {
        static void Main()
        {
            Console.WriteLine("Add number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Add number x: ");
            int x = int.Parse(Console.ReadLine());
            double sum=1d;
            double faktSum = 1d;
            double tempDell = 1d;
            for (int count=1; count <= n;count++)
            {
                faktSum *= count;
                tempDell = tempDell * n;
                sum += faktSum / tempDell;
            }
            Console.WriteLine("{0:0.00000}",sum);
        }
    }
