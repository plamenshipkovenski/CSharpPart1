using System;

class ExtractBitFromInteger
{
    static int ExtractBitValue(int number, int bitPosition)
    {
        int bitValue = 0;
        int mask = 1 << bitPosition;

        bitValue = (number & mask) >> bitPosition;
        return bitValue;
    }
    static void Main()
    {
        int number;
        int bitPosition;
        int bitValue;

        Console.Title = "Extract bit from integer";
        Console.Write("Input number: ");
        number = int.Parse(Console.ReadLine());
        Console.Write("Input position of bit you want to check: ");
        bitPosition = int.Parse(Console.ReadLine());

        bitValue = ExtractBitValue(number, bitPosition);
        Console.WriteLine("number {0} has bit value {1} on position {2}", number, bitValue, bitPosition);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
