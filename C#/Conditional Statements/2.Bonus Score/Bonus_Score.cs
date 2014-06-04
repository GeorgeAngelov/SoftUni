using System;
class Bonus_Score
{
    static void Main()
    {
        Console.WriteLine("Enter the score [1..9]: ");
        int Score = int.Parse(Console.ReadLine());
        switch (Score)
        {
            case 1:
            case 2:
            case 3: Score = Score * 10; break;
            case 4:
            case 5:
            case 6: Score = Score * 100; break;
            case 7:
            case 8:
            case 9: Score = Score * 1000; break;
            default: Console.WriteLine("Invalid score!"); break;
        }
        Console.WriteLine("Final Score + Bonus: {0}", Score);
    }
}
