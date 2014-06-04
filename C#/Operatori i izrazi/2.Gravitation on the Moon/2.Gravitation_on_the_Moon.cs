using System;
    class Gravitation_on_the_Moon
    {
        static void Main()
        {
            string buff;
            Console.WriteLine("Въведи тегло: ");
            buff=Console.ReadLine();
            float weight = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            weight *= 0.17f;
            Console.WriteLine("Теглто на луната ще е: {0}", weight);
        }
    }
