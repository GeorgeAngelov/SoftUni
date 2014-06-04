using System;
class Trapezoids
    {
        static void Main()
        {
            string buff;
            Console.WriteLine("Input base1:");
            buff = Console.ReadLine();
            float baseA = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Input base2:");
            buff = Console.ReadLine();
            float baseB = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Input height:");
            buff = Console.ReadLine();
            float height = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            float Area = ((baseA + baseB) * height) / 2;
            Console.WriteLine("The Area fo the given Trapezoid is: {0}",Area);
        }
    }
