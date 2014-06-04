using System;
    class Exchange_If_Greater
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            float num1 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter a number: ");
            float num2 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            if (num1 > num2)
            {
                float buff = num2;
                num2 = num1;
                num1 = buff;
            }
            Console.WriteLine("result: {0} {1}",num1,num2);
        }
    }
