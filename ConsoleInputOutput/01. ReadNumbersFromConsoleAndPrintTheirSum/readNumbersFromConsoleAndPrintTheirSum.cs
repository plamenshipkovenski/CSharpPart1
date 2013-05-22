using System;

class ReadNumbersFromConsoleAndPrintTheirSum
{
    static void Main()
    {
        int inputInteger;
        int components = 3;
        long sum = 0;

        for (int i = 0; i < components; i++)
        {
            Console.Write("Input integer: ");
            inputInteger = int.Parse(Console.ReadLine());
            sum += inputInteger;
        }
        Console.WriteLine("Sum of those {0} components is: {1}", components, sum);
    }
}
