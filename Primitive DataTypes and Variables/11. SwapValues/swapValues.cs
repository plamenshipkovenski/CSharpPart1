using System;

class SwapValues
{
    static void Main()
    {
        long a = 1234567890;
        long b = 9876543210;

        Console.WriteLine("a = {0}; b = {1}", a, b);
        a ^= b;
        b ^= a;
        a ^= b;
        Console.WriteLine("a = {0}; b = {1}", a, b);
    }
}
