using System;
    class Rectangles
    {
        static void Main()
        {
            string buff;
            Console.WriteLine("Въведи дължина: ");
            buff = Console.ReadLine();
            float lenght = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Въведи широчина: ");
            buff = Console.ReadLine();
            float width = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            float Area = width * lenght;
            float Perimeter = 2 * lenght + 2 * width;
            Console.WriteLine("Обиколка: {0}",Perimeter);
            Console.WriteLine("Лице: {0}",Area);
        }
    }
