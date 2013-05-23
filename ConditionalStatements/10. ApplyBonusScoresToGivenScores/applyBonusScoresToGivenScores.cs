using System;

class ApplyBonusScoresToGivenScores
{
    static void Main()
    {
        Console.Write("Input digit [1..9]: ");
        int digit = int.Parse(Console.ReadLine());
        try
        {
            switch (digit)
            {
                case 1:
                case 2:
                case 3:
                    digit *= 10;
                    break;
                case 4:
                case 5:
                case 6:
                    digit *= 100;
                    break;
                case 7:
                case 8:
                case 9:
                    digit *= 1000;
                    break;
                default:
                    string paramName = "digit";
                    string message = "digit value must be in range[1...9]";
                    throw new ArgumentOutOfRangeException(paramName, message);
                    break;
            }
            Console.WriteLine(digit);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }   
    }
}