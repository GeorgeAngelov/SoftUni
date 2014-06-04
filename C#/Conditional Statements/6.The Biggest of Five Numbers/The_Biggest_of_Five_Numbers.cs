using System;
    class The_Biggest_of_Five_Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter fist number: ");
            float num1 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter second number: ");
            float num2 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter third number: ");
            float num3 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter forth number: ");
            float num4 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter fifth number: ");
            float num5 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            {
                Console.WriteLine("The biggest number is {0}",num1);
            }
            else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            {
                Console.WriteLine("The biggest number is {0}", num2);
            }
            else if (num3 > num2 && num1 < num3 && num3 > num4 && num3 > num5)
            {
                Console.WriteLine("The biggest number is {0}", num3);
            }
            else if (num4 > num2 && num4 > num3 && num1 < num4 && num4 > num5)
            {
                Console.WriteLine("The biggest number is {0}", num4);
            }
            else if (num5 > num2 && num5 > num3 && num5 > num4 && num1 < num5)
            {
                Console.WriteLine("The biggest number is {0}", num5);
            }
        }
    }
