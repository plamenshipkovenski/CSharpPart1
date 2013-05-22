using System;

class SwapBits
{
    static uint ExtractBitValue(uint number, int bitPosition)
    {
        uint bitValue = 0;
        uint mask = (uint)(1 << bitPosition);
        bitValue = (number & mask) >> bitPosition;
        return bitValue;
    }

    static uint TurnBitOn(uint number, int bitPosition)// 0 to 1
    {
        uint mask =(uint)(1 << bitPosition);
        number = number | mask;
        return number;
    }

    static uint TurnBitOff(uint number, int bitPosition)//1 to 0
    {
        uint mask = (uint)(~(1 << bitPosition));
        number = number & mask;
        return number;
    }

    static void Main()
    {
        //works on unsigned integer
        uint number = 83886136;
        Console.Write("number {0} binary representation: ", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        uint rightBitValue;
        int rightBitPosition;

        uint leftBitValue;
        int leftBitPosition;

        uint consecutiveBitsLenght;

        rightBitPosition = 3;
        leftBitPosition = 24;
        consecutiveBitsLenght = 3;

        for (int i = 0; i < consecutiveBitsLenght; i++)
        { 
            rightBitValue = ExtractBitValue(number, rightBitPosition);
            leftBitValue = ExtractBitValue(number, leftBitPosition);

            if (rightBitValue == leftBitValue)
            {
                rightBitPosition++;
                leftBitPosition++;
                continue;
            }
            else
            {
                if (rightBitValue == 1)
                {
                    //leftBitValue is 0

                    number = TurnBitOff(number, rightBitPosition);
                    number = TurnBitOn(number, leftBitPosition);
                }
                else//rightBitValue == 0
                {
                    //leftBitValue is 1

                    number = TurnBitOn(number, rightBitPosition);
                    number = TurnBitOff(number, leftBitPosition);
                }
                rightBitPosition++;
                leftBitPosition++;
            }
        }
        Console.Write("number {0} binary representation: ", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
