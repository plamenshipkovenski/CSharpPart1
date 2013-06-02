using System;
using System.Collections.Generic;
using System.Numerics;

class CalcSumOfFirstNFibonacciMembers
{
    static void Main()
    {
        Console.Title = "Calculate sum of first N fibonacci members";
        int fibSequenceLength = 0;
        bool hasInput = false;
        Console.WriteLine("Input N (N >= 0): ");
        ValidateInput(ref fibSequenceLength, ref hasInput);
            
        BigInteger sum = 1;
        if(fibSequenceLength > 2)
        {
            BigInteger beforePreviousFib = 0;
            BigInteger previousfib = 1;
            BigInteger currentFib = 0;
            for (int index = 2; index <= fibSequenceLength; index++)// assume start index = 0
            {
                currentFib = previousfib + beforePreviousFib;
                sum += currentFib;
                beforePreviousFib = previousfib;
                previousfib = currentFib;
            }
        }
        else if (fibSequenceLength == 0 || fibSequenceLength == 1)
        {
            sum = 0;
        }
        Console.WriteLine("Sum of first {0} members of fibonacci members is {1}", fibSequenceLength, sum);
    }

    private static void ValidateInput(ref int fibSequenceLength, ref bool hasInput)
    {
        do
        {
            try
            {
                string input = Console.ReadLine();
                fibSequenceLength = int.Parse(input);
                int maxSequenceCount = 1000000;
                if (fibSequenceLength < 0 || maxSequenceCount < fibSequenceLength)
                {
                    throw new ArgumentOutOfRangeException();
                }
                hasInput = true;
                if (input == string.Empty)
                {
                    Console.WriteLine("You have input an empty string");
                    Console.Write("input positive integer: ");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("enter an integer number in range \n[{0}...{1}]", 0, 1000000);
                hasInput = false;
            }
            catch (OverflowException of)
            {
                hasInput = false;
                Console.WriteLine(of.Message);
                Console.WriteLine("enter number in range\n[{0}...{1}]", 0, 1000000);
            }
            catch (ArgumentOutOfRangeException negat)
            {
                Console.WriteLine(negat.Message);
                Console.WriteLine("enter an integer number in range \n[{0}...{1}]", 0, 1000000);
            }
        } while (!hasInput);
    }
}