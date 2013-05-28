using System;

class PrintNumbersFromOneToN
{
    private static void GetValidInput(ref long maxValue, ref bool hasInput)
    {
        do
        {
            try
            {
                string input = Console.ReadLine();
                maxValue = long.Parse(input);
                hasInput = true;
                //hasInput = long.TryParse(input, out maxValue);
                if (input == string.Empty)
                {
                    Console.WriteLine("You have input an empty string");
                    Console.Write("input positive number: ");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("enter an integer number in range \n[{0}...{1}]", long.MinValue, long.MaxValue);
                hasInput = false;
            }
            catch (OverflowException of)
            {
                hasInput = false;
                Console.WriteLine(of.Message);
                Console.WriteLine("enter number in range\n[{0}...{1}]", long.MinValue, long.MaxValue);
            }
        } while (!hasInput);
    }

    private static void PrintNums(long maxValue)
    {
        if (maxValue >= 1)
        {
            for (int currentValue = 1; currentValue <= maxValue; currentValue++)
            {
                Console.WriteLine(currentValue);
            }
        }
        else
        {
            for (int currentValue = 1; currentValue >= maxValue; currentValue--)
            {
                Console.WriteLine(currentValue);
            }
        }
    }

    static void Main()
    {
        long maxValue = 0;
        bool hasInput = false;
        Console.Write("input number: ");
        GetValidInput(ref maxValue, ref hasInput);
        PrintNums(maxValue);
    }
}
