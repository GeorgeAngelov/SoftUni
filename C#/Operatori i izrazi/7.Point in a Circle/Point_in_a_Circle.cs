using System;
    class Point_in_a_Circle
    {
        static void Main()
        {
            float r = 2;
            string buff;
            Console.WriteLine("Въведи координата x: ");
            buff = Console.ReadLine();
            float x = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine("Въведи координата y: ");
            buff = Console.ReadLine();
            float y = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            float c = (float)Math.Sqrt(x*x+y*y);
            if (c < 0)
                c = c * (-1);
            if (c <= r)
            {
                Console.WriteLine("Точката лежи в окръжността!");
            }
            else
            {
                Console.WriteLine("Точката НЕ лежи в окръжността!");
            }
        }
    }
