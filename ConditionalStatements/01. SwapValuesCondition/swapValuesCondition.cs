using System;

class SwapValuesCondition
{
    static void Main()
    {
        Console.Title = "Swap values if first number is bigger";
        Console.WriteLine("Please input:");
        Console.Write("first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("second number: ");
        int secondNum = int.Parse(Console.ReadLine());

        bool hasSwapCondition = firstNum > secondNum;
        if (hasSwapCondition)
        {
            firstNum ^= secondNum;
            secondNum ^= firstNum;
            firstNum ^= secondNum;
        }
        Console.WriteLine("first number value: {0}\nsecond number value: {1}", firstNum, secondNum);
    }
}
