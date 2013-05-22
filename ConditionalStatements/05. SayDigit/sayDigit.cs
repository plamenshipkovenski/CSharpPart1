﻿using System;

class SayDigit
{
    static string GetDigitName(byte digit)
    {
        string name;
        switch (digit)
        {
            case 0 :
                name = "zero";
                break;
            case 1:
                name = "one";
                break;
            case 2:
                name = "two";
                break;
            case 3:
                name = "three";
                break;
            case 4 :
                name = "four";
                break;
            case 5:
                name = "five";
                break;
            case 6:
                name = "six";
                break;
            case 7:
                name = "seven";
                break;
            case 8:
                name = "eight";
                break;
            case 9 :
                name = "nine";
                break;
            default:
                name = "unknown";
                break;
        }
        return name;
    }
    static void Main()
    {
        Console.WriteLine("Input digit: ");
        byte digit = byte.Parse(Console.ReadLine());

        string name = GetDigitName(digit);
        Console.WriteLine(name);
    }
}
