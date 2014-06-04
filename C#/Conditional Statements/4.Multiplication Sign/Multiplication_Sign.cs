using System;
    class Multiplication_Sign
    {
        static void Main()
        {
            Console.WriteLine("Enter number 1: ");
            float num1 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter number 2: ");
            float num2 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter number 3: ");
            float num3 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            if (num1 > 0 && num2>0)
            {
                if (num3 > 0 || num3 == 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            else if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("0");
            }
            else if (num1 < 0 && num2 < 0)
            {
                if (num3 > 0 || num3 == 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            else if ((num1 < 0 && num2 > 0) || (num1 > 0 && num2 < 0))
            {
                if (num3 > 0 || num3 == 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            else if ((num1 == 0 && num2 > 0) || (num1 > 0 && num2 == 0))
            {
                if (num3 > 0 || num3 == 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            else if ((num1 == 0 && num2 < 0) || (num1 < 0 && num2 == 0))
            {
                if (num3 > 0 || num3 == 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
