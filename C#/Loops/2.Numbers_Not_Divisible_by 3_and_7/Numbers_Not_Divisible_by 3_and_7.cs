using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a pasitive number: ");
            int number=int.Parse(Console.ReadLine());
            int n=1;
            while(n<=number)
            {
                if(n%3!=0 && n%7!=0)
                {
                    Console.Write(" {0}",n);
                }
            n++;
            }
        }
    }
