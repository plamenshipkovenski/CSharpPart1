using System;

class checkPrimality
{
    static void Main()
    {
        byte number = byte.Parse(Console.ReadLine());

        bool isPrime = false;
        for (int i = 2; i < (int)Math.Sqrt((double)number); i++)
        {
            if (number % i != 0)
            {
                isPrime = true;
                break;
            }
        }
        Console.WriteLine("{0} is prime: {1}", number, isPrime);
    }
}
