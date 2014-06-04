using System;
    class MinMaxSum_and_Average_of_N_Numbers
    {
        static void Main()
        {
            Console.WriteLine("Input number of number: ");
            int count = int.Parse(Console.ReadLine());
            int br = count;
            float sum = 0f;
            float min=1000f;
            float max = 0f;
            while (count > 0)
            {
                Console.WriteLine("Enter number: ");
                float n = float.Parse(Console.ReadLine());
                sum = sum + n;
                if (min > n)
                    min = n;
                if (max < n)
                    max = n;
                count--;
            }
            Console.WriteLine("-------------------------------------------------------------------");
            float avg=sum/br;
            Console.WriteLine("min: {0}",min);
            Console.WriteLine("max: {0}",max);
            Console.WriteLine("sum: {0}",sum);
            Console.WriteLine("avg: {0:0.00}",avg);
        }
    }
