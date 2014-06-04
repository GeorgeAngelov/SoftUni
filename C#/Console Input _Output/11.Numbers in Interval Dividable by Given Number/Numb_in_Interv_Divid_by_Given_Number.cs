using System;
    class Numb_in_Interv_Divid_by_Given_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            string buff = Console.ReadLine();
            int num1;
            int p = 0;
            int.TryParse(buff, out num1);
            Console.WriteLine("Enter a greater number: ");
            buff = Console.ReadLine();
            int num2;
            int.TryParse(buff, out num2);
            for(int i=num1;i<num2+1;i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                    p = p + 1;
                }
            }
            Console.WriteLine("The Number of the numbers between {0} and {1}, that can be devidet to 5 is: {2}",num1,num2,p);
        }
    }
