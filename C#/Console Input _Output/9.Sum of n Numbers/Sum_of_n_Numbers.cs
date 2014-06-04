using System;
class Sum_of_n_Numbers
{
    static void Main()
    {
        Console.WriteLine("Entar a Number: ");
        string buff = Console.ReadLine();
        int num;
        float sum = 0;
        int.TryParse(buff, out num);
        for (int j = 0; j < num; j++)
        {
            Console.WriteLine("Entar a Number: ");
            buff = Console.ReadLine();
            float value = float.Parse(buff, System.Globalization.CultureInfo.InvariantCulture);
            sum = sum + value;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}
