using System;

    class Circle_Perimeter_and_Area
    {
        static void Main()
        {
            float pi = 3.141592f;
            Console.WriteLine("Inpur radius of the Circle: ");
            string buff = Console.ReadLine();
            float r = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Perimeter = {0:0.00} \nArea = {1:0.00}",2*pi*r,pi*r*r);
        }
    }
