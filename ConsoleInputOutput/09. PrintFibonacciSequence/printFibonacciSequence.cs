using System;
using System.Collections.Generic;
using System.Numerics;

class PrintFibonacciSequence
{
    static void Main()
    {
        BigInteger fib1 = 0;
        BigInteger fib2 = 1;
        int sequenceLenght = 100;
        List<BigInteger> listOfFib = new List<BigInteger>();

        for (int i = 0; i < sequenceLenght; i++)
        {
            if (i == 0 || i == 1)
            {
                if (i == 0)
                {
                    listOfFib.Add(i);
                }
                if (i == 1)
                {
                    listOfFib.Add(i);
                }
            }
            else
            {
                BigInteger fib3 = fib1 + fib2;
                listOfFib.Add(fib3);
                fib1 = fib2;
                fib2 = fib3;
            }
        }
        foreach (var fibNum in listOfFib)
        {
            Console.WriteLine(fibNum);
        }
    }
}
