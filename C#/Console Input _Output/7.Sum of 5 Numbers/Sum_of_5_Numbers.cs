using System;
    class Sum_of_5_Numbers
    {
        static void Main(string[] args)
        {
            float sum = 0;
            string value="";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Entar a Number: ");
                string buff = Console.ReadLine();
                float num = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
                sum = sum + num;
                value = value + " "+buff;
            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("{0} |{1,10}|",value,sum);
        }
    }
