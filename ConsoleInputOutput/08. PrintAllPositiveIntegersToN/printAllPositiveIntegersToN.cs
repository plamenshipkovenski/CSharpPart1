using System;

class PrintAllPositiveIntegersToN
{
    static void Main()
    {
        Console.Write("Input number: ");
        uint EndNumber = uint.Parse(Console.ReadLine());

        for (int startNumber = 1; startNumber <= EndNumber; startNumber++)
        {
            Console.WriteLine(startNumber);
        }
    }
}
