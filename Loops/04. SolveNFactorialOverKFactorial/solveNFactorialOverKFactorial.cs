using System;
using System.Numerics;

class SolveNFactorialOverKFactorial
{
    //Write a program that calculates N!/K! for given N and K (1<K<N).

    static void Main()
    {
        Console.Title = "Solve N! / K!";
        int numerator = 0;                         
        int denominator = 0;
        bool hasInput = false;

        //get valid input(1 < K < N)
        while (!hasInput)
        {
            //TO DO: exeption handling
            Console.WriteLine("input N and K (1 < K < N):");
            Console.Write("K: ");
            denominator = int.Parse(Console.ReadLine());
            Console.Write("N: ");
            numerator = int.Parse(Console.ReadLine());
            if ((1 < denominator) && (denominator < numerator))
            {
                hasInput = true;
            }
        }
        BigInteger result = 1;
        for (int i = numerator; i > denominator; i--)// 7! / 4! = 7 * 6 * 5 * 4 * 3 * 2 * 1 / 4 * 3 * 2 * 1 = 7 * 6 * 5
        {
            result *= i;
        }
        Console.WriteLine("{0}! / {1}! = {2}", numerator, denominator, result);
    }
}
