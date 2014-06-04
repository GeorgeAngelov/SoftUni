using System;
    class Comp_Floats
    {
        static void Main()
        {
            bool result;
            float eps = 0.000001f;
            double num1 = 6.01;
            double num2 = 5.3;
            double buff;
            buff = num1 - num2;
            if (buff < eps)
            {
                result = true;
                Console.WriteLine("Ravni li sa chislata: {0}",result);
            }
            else
            {
                result = false;
                Console.WriteLine("Ravni li sa chislata: {0}",result);
            }
            num1 = 5.00000001;
            num2 = 5.00000003;
            buff = num1 - num2;
            if (buff < eps)
            {
                result = true;
                Console.WriteLine("Ravni li sa chislata: {0}", result);
            }
            else
            {
                result = false;
                Console.WriteLine("Ravni li sa chislata: {0}", result);
            }
            num1 = 5.00000005;
            num2 = 5.00000001;
            buff = num1 - num2;
            if (buff < eps)
            {
                result = true;
                Console.WriteLine("Ravni li sa chislata: {0}", result);
            }
            else
            {
                result = false;
                Console.WriteLine("Ravni li sa chislata: {0}", result);
            }
            num1 = -0.0000001;
            num2 = 0.00000007;
            buff = num1 - num2;
            if (buff < eps)
            {
                result = true;
                Console.WriteLine("Ravni li sa chislata: {0}", result);
            }
            else
            {
                result = false;
                Console.WriteLine("Ravni li sa chislata: {0}", result);
            }
            num1 = -4.999998;
            num2 = -4.999999;
            buff = num1 - num2;
            if (buff < eps)
            {
                result = true;
                Console.WriteLine("Ravni li sa chislata: {0}", result);
            }
            else
            {
                result = false;
                Console.WriteLine("Ravni li sa chislata: {0}", result);
            }
            num1 = 4.999999;
            num2 = 4.999998;
            buff = num1 - num2;
            if (buff < eps)
            {
                result = true;
                Console.WriteLine("Ravni li sa chislata: {0}", result);
            }
            else
            {
                result = false;
                Console.WriteLine("Ravni li sa chislata: {0}", result);
            }
        }
    }
