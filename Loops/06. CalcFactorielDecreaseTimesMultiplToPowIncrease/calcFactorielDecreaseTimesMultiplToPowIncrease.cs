using System;
using System.Numerics;

class CalcFactorielDecreaseTimesMultiplToPowIncrease
{
    //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X^1 + 2!/X^2 + … + N!/X^N

    static void Main()
    {
        Console.Title = "Solve: S = 1 + 1!/X^1 + 2!/X^2 + … + N!/X^N";
        int N = 0;
        int X = 0;
        bool hasInput = false;

        Console.WriteLine("Input two integers: X != 0, N >= 1");
        while (!hasInput)
        {
            Console.Write("Input X != 0: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("Input N >= 1: ");
            N = int.Parse(Console.ReadLine());
            bool hasValidX = X != 0;
            bool hasValidN = N >= 1;
            if (hasValidN && hasValidX)
            {
                hasInput = true;
            }
        }
        BigInteger largestFactorial = CalcFactorial(N);

        BigInteger numeratorSum = 0;
        BigInteger numeratorMember = 0;
        BigInteger nFactorialPart = 0;
        BigInteger xRaisedPart = 0;
        int tepmNValue = N;
        for (int pow = 0; pow <= N; pow++)
        {
            nFactorialPart = largestFactorial;
            xRaisedPart = CalcPower(X, pow);
            numeratorMember = nFactorialPart * xRaisedPart;
            numeratorSum += numeratorMember;
            largestFactorial /= tepmNValue;
            if (tepmNValue > 1)
            {  
                tepmNValue--;
            }
        }
        BigInteger denominator = CalcPower(X, N);
        double result = (double)numeratorSum / (double)denominator;
        Console.WriteLine(result);
    }

    private static BigInteger CalcFactorial(int num)
    {
        BigInteger factorial = 1;
        if ((num != 0) && (num != 1))
        {
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }
        }
        return factorial;
    }

    private static BigInteger CalcPower(int num, int pow)
    {
        //works Only for positive pow
        BigInteger result = 1;
        while (pow != 0)
        {
            if ((pow & 1) == 1)
            {
                result *= num;
            }   
            num *= num;
            pow >>= 1;
        }
        return result;
    }
}
