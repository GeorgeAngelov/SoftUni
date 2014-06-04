using System;
    class The_Biggest_of_3_Numbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter fist number: ");
            float num1 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter second number: ");
            float num2 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter third number: ");
            float num3 = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The biggest number is : {0}",num1);
                }
                else if (num1 < num3)
                {
                    Console.WriteLine("The biggest number is : {0}", num3);
                }
                else
                {
                    Console.WriteLine("Num1 = Num3 and the value {0} is the biggest",num1);
                }
            }
            else if (num1 < num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("The biggest number is : {0}", num2);
                }
                else if (num2 < num3)
                {
                    Console.WriteLine("The biggest number is : {0}", num3);
                }
                else
                {
                    Console.WriteLine("Num3 = Num2 and the value {0} is the biggest",num2);
                }
            }
            else if (num1 == num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Num1 = Num2: and the value {0} is the biggest", num1);
                }
                else if (num1 < num3)
                {
                    Console.WriteLine("The biggest number is : {0}", num3);
                }
                else
                {
                    Console.WriteLine("Num1 = Num2 = Num3 and the value {0} is the biggest",num2);
                }
            }
        }
    }
