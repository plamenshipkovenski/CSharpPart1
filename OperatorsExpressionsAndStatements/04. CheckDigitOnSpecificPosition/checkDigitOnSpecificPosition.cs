using System;

class checkDigitOnSpecificPosition
{
    static int ExtractDigitFromPosition(int number, int position)
    {
        int reminder = 0;
        for (int i = 0; i < position; i++)
        {
            reminder = number % 10;
            number /= 10;
        }
        return reminder;
    }
    static void Main()
    {
        int number = 1732;
        int position = 3;// assume that most right digit position is 1
        int extractedDigit = ExtractDigitFromPosition(number, position);
        int digitToCompareWith = 7;
        bool areEquals = extractedDigit == digitToCompareWith;
        Console.WriteLine(areEquals);
    }
}