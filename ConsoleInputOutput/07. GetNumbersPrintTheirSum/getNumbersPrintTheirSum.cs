using System;
using System.Collections.Generic;
using System.Numerics;

class GetNumbersPrintTheirSum
{
    static void Main()
    {
        Console.Write("How many numbers do you want to sum: ");
        int n = int.Parse(Console.ReadLine());
        List<long> listOfNumbers = new List<long>(n);
        BigInteger sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Input number: ");
            long inputNumber = long.Parse(Console.ReadLine());
            listOfNumbers.Add(inputNumber);
        }
        foreach (var num in listOfNumbers)
        {
            sum += num;
        }
        Console.WriteLine("Sum Of these numbers is: {0}", sum);
    }
}
