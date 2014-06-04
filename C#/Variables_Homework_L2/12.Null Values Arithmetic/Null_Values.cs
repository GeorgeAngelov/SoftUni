using System;
    class Null_Values
    {
        static void Main()
        {
            int? var1 = 0;
            if (var1 == 0)
            {
                var1 = null;
            }
            double? var2 = 0;
            if (var2 ==0)
            {
                var2=null;
            }
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            var1 = var1 + 5;
            var2 = var2 + 2.5;
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            var1 = 5;
            var2 = 5.5;
            Console.WriteLine(var1);
            Console.WriteLine(var2);
        }
    }