using System;

class SetBitAtPosition
{
    static int TurnOnBit(int number, int bitPositionToChange, int newBitValue)
    {
        int mask = 1 << bitPositionToChange;
        number = number | mask;
        return number;
    }
    static int TurnOffBit(int number, int bitPositionToChange, int newBitValue)
    {
        int mask = ~ (1 << bitPositionToChange);
        number = number & mask;
        return number;
    }
    static void Main()
    {
        int number;
        int bitPositionToChange;
        int newBitValue;

        Console.Title = "program to change bit on given position";

        Console.Write("Input number: ");
        number = int.Parse(Console.ReadLine());
        Console.Write("Input position of bit that you want to change: ");
        bitPositionToChange = int.Parse(Console.ReadLine());
        Console.Write("Input new bit value: ");
        newBitValue = int.Parse(Console.ReadLine());

        Console.Write("number {0} binary representation: ", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        if (newBitValue == 0 || newBitValue == 1)
        {
            if (newBitValue == 0)
            {
                number = TurnOffBit(number, bitPositionToChange, newBitValue);
            }
            if(newBitValue == 1)
            {
                number = TurnOnBit(number, bitPositionToChange, newBitValue);
            }
        }
        Console.Write("number {0} binary representation: ", number);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
