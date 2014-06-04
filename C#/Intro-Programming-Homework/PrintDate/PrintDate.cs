using System;

class PrintDate
    {
        static void Main()
        {
            DateTime time = DateTime.Now;              
            string format = "MMM ddd d HH:mm yyyy";    
            Console.WriteLine(time.ToString(format)); 
        }
    }

