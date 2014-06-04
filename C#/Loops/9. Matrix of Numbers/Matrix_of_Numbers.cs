using System;
    class Matrix_of_Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter a number [1<=n<=20]: ");
            int n = int.Parse(Console.ReadLine());
            for(int j=1;j<=n;j++)
            {
                Console.WriteLine();
                for(int i =j;i<=n+j;i++)
                {
                    Console.Write(i);
                }
            }
        }
    }
