using System;
    class Sum_of_3_Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number 1:");
            string buff = Console.ReadLine();
            float num1 = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Input number 2:");
            buff = Console.ReadLine();
            float num2 = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Input number 3:");
            buff = Console.ReadLine();
            float num3 = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("The sum of the numbers is: {0}",num1+num2+num3);
        }
    }
