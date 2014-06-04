using System;
    class Fibonacci_Numbers
    {
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
           return a;
        }
        static void Main()
        {
            Console.WriteLine("Enter the last member of the sequense, you want: ");
            string buff = Console.ReadLine();
            Console.WriteLine("-----------------------------------------------------");
            int n;
            int.TryParse(buff, out n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
