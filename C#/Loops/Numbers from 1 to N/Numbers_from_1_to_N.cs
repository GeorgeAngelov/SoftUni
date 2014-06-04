using System;
class Numbers_from_1_to_N
    {
        static void Main()
        {
            Console.WriteLine("Input a number: ");
            int number = int.Parse(Console.ReadLine());
            int n = 1;
            while (number > 0)
            {
                Console.Write(" {0}",n);
                number--;
                n++;
            }
        }
    }
