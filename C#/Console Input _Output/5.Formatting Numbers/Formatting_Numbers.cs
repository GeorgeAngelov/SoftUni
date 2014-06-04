using System;
    class Formatting_Numbers
    {
        static void Main()
        {
            Console.WriteLine("Input number 1(0<=Num<=500):");
            string buff = Console.ReadLine();
            int num1; 
            int.TryParse(buff, out num1);
            string binary = Convert.ToString(num1,2);
            binary = binary.PadLeft(10, '0');
            if(num1>500 || num1<0)
            {
                Console.WriteLine("Wrong number!");
            }
            Console.WriteLine("Input number 2:");
            buff = Console.ReadLine();
            float num2 = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Input number 3:");
            buff = Console.ReadLine();
            float num3 = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("The numbers -->  |{0,-10:X}|{1:10}|{2,10:0.00}|{3,-10:0.000}|", num1, binary, num2, num3);
        }
    }
