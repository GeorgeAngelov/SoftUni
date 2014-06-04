using System;
    class Random_Numbers_in_Given_Range
    {
        static void Main()
        {
            Console.WriteLine("How many numbers do you want: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter minimum: ");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter maximum: ");
            int max = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(random.Next(min,max+1)+" ");
            }
        }
    }
