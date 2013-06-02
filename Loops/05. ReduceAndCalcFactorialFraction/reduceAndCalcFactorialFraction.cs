using System;
using System.Numerics;

class ReduceAndCalcFactorialFraction
{
    //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

    static void Main()
    {
        int N = 0;
        int K = 0;
        bool hasInput = false;

        //get valid input(1 < N < K)
        while (!hasInput)
        {
            //TO DO: exeption handling
            Console.WriteLine("input N and K (1 < N < K):");
            Console.Write("N: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("K: ");
            K = int.Parse(Console.ReadLine());
            if ((1 < N) && (N < K))
            {
                hasInput = true;
            }
        }
        BigInteger result = 1;
        //N! = N * (N - 1) * (N - 2) * ... * 2 * 1
        //K! / (K - N)! = K * (K - 1) * (K - 2) *...* (K - N + 1)
        //1.....x?......y?......N
        //http://forums.academy.telerik.com/27909/c%23-%D0%B4%D0%BE%D0%BC%D0%B0%D1%88%D0%BD%D0%BE-loops-5-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0

        if (N < K - N + 1)//case: no duplicate values 
        {
            //solve (1 * .....* N] * [K-N+1 * ....... * N]
            for (int i = 2; i <= N; i++)
            {
                result *= i;
            }
            for (int i = K - N + 1; i <= K; i++)
            {
                result *= i;
            }
        }
        else//case: there is duplicate values in range [(K-N+1)...N] 
        {
            //solve (1....K-N+1)[(K-N+1)^2...N^2](N....K]
            for (int i = 2; i < K - N + 1; i++)
            {
                result *= i;
            }
            for (int i = K - N + 1; i <= N; i++)
            {
                result *= i * i;
            }
            for (int i = N + 1; i <= K; i++)
            {
                result *= i;
            }
        }
        Console.WriteLine("N! * K! / (K - N)! = {0}", result);
    }
}
