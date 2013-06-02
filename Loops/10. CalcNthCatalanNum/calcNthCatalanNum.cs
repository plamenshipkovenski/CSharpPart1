using System;

class CalcNthCatalanNum
{
    private static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Input N >= 0: ");//program works for 0 < N < 15
        int catalanIndex = int.Parse(Console.ReadLine());

        //C(n) = (2 * n)! / (n + 1)! * n!

        int catalanNumber;
        if (catalanIndex == 0 || catalanIndex == 1)
        {
            catalanNumber = 1;
        }
        else
        {
            //reduce formula to : C(n) = 2n * 2n-1 * ... * n+1 / (n+1)!
            int numeratorPart = 1;
            int denominatorPart = Factorial(catalanIndex + 1);

            for (int i = 2 * catalanIndex; i > catalanIndex; i--)
            {
                numeratorPart *= i;
            }
            catalanNumber = numeratorPart / denominatorPart;
        }
        Console.WriteLine(catalanNumber);

    }
}
