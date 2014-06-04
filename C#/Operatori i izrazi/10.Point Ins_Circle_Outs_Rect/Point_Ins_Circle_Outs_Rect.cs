using System;
    class Point_Ins_Circle_Outs_Rect
    {
        static void Main()
        {
            bool inK;
            bool outR;
            float r = 2.5f;
            string buff;
            Console.WriteLine("Въведи координата x: ");
            buff = Console.ReadLine();
            float x = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            x = x++;
            Console.WriteLine("Въведи координата y: ");
            buff = Console.ReadLine();
            float y = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            y = y++;
            float c = (float)Math.Sqrt(x * x + y * y);
            if (c < 0)
                c = c * (-1);
            if (c <= r)
            {
                inK = true;                 ///In Circle
            }
            else 
            {
                inK = false;
            }
            if ((x >= -2 && x <= 4) && (y >= -2 && y <= 0))
            {
                outR = false;                 ///Out Rectangle
            }
            else
            {
                outR = true;
            }
          if(inK==true && outR==true)
            {
                Console.WriteLine("Точката е в Окръжността и извън четириъгълника!");
            }
            else
            {
                Console.WriteLine("Точката е в четириълника или извън окръжността!");
            }
        }
    }
