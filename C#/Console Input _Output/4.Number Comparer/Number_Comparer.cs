using System;
    class Number_Comparer
    {
        static void Main()
        {
            Console.WriteLine("Input number 1:");
            string buff = Console.ReadLine();
            float num1 = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Input number 2:");
            buff = Console.ReadLine();
            float num2 = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("The greater number is: {0}",Math.Max(num1,num2));
        }
    }
