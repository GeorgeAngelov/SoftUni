using System;

    class Quadratic_Equation
    {
        static void Main()
        {
            Console.WriteLine("Enter coefficient a: ");
            string buff = Console.ReadLine();
            float a = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter coefficient b: ");
            buff = Console.ReadLine();
            float b = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Enter coefficient c: ");
            buff = Console.ReadLine();
            float c = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("----------------------------------------------------------------");
            calc(a,b,c);
           
        }
        static void calc(float a, float b, float c)
        {
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("There are no real roots!");
            }
            else if (D == 0)
            {
                double x = (-b) / 2 * a;
                Console.WriteLine("The equation has only one root: x={0}", x);
            }
            else
            {
                double x1 = ((-b) - (Math.Sqrt(D))) / 2 * a;
                double x2 = ((-b) + (Math.Sqrt(D))) / 2 * a;
                Console.WriteLine("The roots of the equation:");
                Console.WriteLine("x1= {0}",x1);
                Console.WriteLine("x2= {0}",x2);
            }
        }
    }
