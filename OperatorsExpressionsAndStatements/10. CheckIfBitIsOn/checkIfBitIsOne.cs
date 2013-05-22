using System;

class CheckIfBitIsOne
{
    static void Main()
    {
        int number = 5;
        int position = 1;
        int mask = 1 << position;
        int bitValue = (number & mask) >> position;
        bool bitIsOn = bitValue == 1;
        Console.WriteLine(bitIsOn);
    }
}
