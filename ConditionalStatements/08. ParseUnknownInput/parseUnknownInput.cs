using System;

class ParseUnknownInput
{
    static void Main()
    {
        Console.Write("Input variable (type: int, or double, or string): ");
        string input = Console.ReadLine();

        double number;

        bool isNumber = double.TryParse(input, out number);

        switch (isNumber)
        {
            case true:
                number += 1;
                Console.WriteLine(number);
                break;
            case false:
                input += "*";
                Console.WriteLine(input);
                break;
            default:
                Console.WriteLine("never goes here because all cases(true, false) are included");
                break;
        }
    }
}
