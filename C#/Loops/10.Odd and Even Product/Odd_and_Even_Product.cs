using System;
    class Odd_and_Even_Product
    {
        static void Main()
        {
            Console.WriteLine("How many numbers do you want: ");
            int br=int.Parse(Console.ReadLine());
            int sumOdd = 1;
            int sumEven = 1;
            for (int i = 1; i <= br; i++)
            {
                Console.WriteLine("Enter number: ");
                int currNum = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven *= currNum;
                }
                else
                {
                    sumOdd *= currNum;
                }
            }
            Console.WriteLine("------------------------------------------------------------");
            if (sumOdd == sumEven)
            {
                Console.WriteLine("YES and the product is {0}", sumEven);
            }
            else
            {
                Console.WriteLine("NO!");
                Console.WriteLine(" odd_product= {0} \n even_product= {1}",sumOdd,sumEven);
            }
        }
    }
