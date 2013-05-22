using System;


class findBitOnPosition
{
    static int GetBit(int number, int bitPosition)
    {
        int mask = 1 << bitPosition;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> bitPosition;
        return bit;
    }
    static void Main()
    {
        int number = 500;//111110100
        int position = 3;
        int bitValue = GetBit(number, position);
        bool bitIsOn = 1 == bitValue;
        bool bitIsOff = 0 == bitValue;

        Console.WriteLine(bitIsOn);
    }
}