using System;

class CalcTrailingZerosOfFactorial
{
    static void Main()
    {
        Console.Write("Input N >= 0: ");
        int largestFactor = int.Parse(Console.ReadLine());

        int sumOfTrailingZeros = 0;

        if (largestFactor < 5)
        {
            sumOfTrailingZeros = 0;
        }
        else
        {
            double pow = 1;

            while ((int)Math.Pow(5, pow) <= largestFactor)
            {
                sumOfTrailingZeros += largestFactor / (int)Math.Pow(5, pow) ;
                pow++;
            }
        }
        Console.WriteLine("{0}! has {1} trailing zeros", largestFactor, sumOfTrailingZeros);
    }
}
