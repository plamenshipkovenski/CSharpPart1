using System;

class PrintNumbersWichAreNotDivisibleBy3and7
{
    //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

    static void Main()
    {
        int startInterval = 1;
        Console.Write("input integer: ");
        int endInterval = int.Parse(Console.ReadLine());
        int firstMultipl = 3;
        int secMultipl = 7;
        int divisor = firstMultipl * secMultipl;

        if (startInterval == endInterval)
        {
            Console.WriteLine("empty interval!");
        }
        else
        {
            int currentValue = startInterval;
            do
            {
                bool isNotDivisible = (currentValue % divisor) != 0;
                if (isNotDivisible)
                {
                    Console.WriteLine(currentValue);
                }
                if (startInterval < endInterval)
                {
                    currentValue++;
                }
                else
                {
                    currentValue--;
                }
            } while (currentValue != endInterval);
            Console.WriteLine(endInterval);
        }
    }
}
