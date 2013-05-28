using System;
using System.Text;
using System.Threading;

class PronounceNumber
{
    private static char GetOnes(string input)
    { 
        return input[input.Length - 1];
    }

    private static char GetTens(string input)
    {
        return input[input.Length - 2]; 
    }

    private static char GetHundreds(string input){ return input[input.Length - 3]; }

    private static string SayDigit(char digit)
    {
        string digitName = "";
        switch (digit)
        {
            case '0': digitName = "zero"; break;
            case '1': digitName = "one"; break;
            case '2': digitName = "two"; break;
            case '3': digitName = "three"; break;
            case '4': digitName = "four"; break;
            case '5': digitName = "five"; break;
            case '6': digitName = "six"; break;
            case '7': digitName = "seven"; break;
            case '8': digitName = "eight"; break;
            case '9': digitName = "nine"; break;
            default: Console.WriteLine("There is no such digit!"); break;
        }
        return digitName;
    }

    private static string SaySpecialTens(string input)
    {
        char ones = GetOnes(input);
        string specialName = "";

        switch (ones)
        {
            case '0': specialName = "ten"; break;
            case '1': specialName = "eleven"; break;
            case '2': specialName = "twelve"; break;
            case '3': specialName = "thirteen"; break;
            case '4': specialName = "fourteen"; break;
            case '5': specialName = "fifteen"; break;
            case '6': specialName = "sixteen"; break;
            case '7': specialName = "seventeen"; break;
            case '8': specialName = "eighteen"; break;
            case '9': specialName = "nineteen"; break;
            default: Console.WriteLine("there is some mistake in 'SaySpecialCases' method");
                break;
        }
        return specialName;
    }

    private static string SayTens(string input)
    {
        char tens = GetTens(input);
        char ones = GetOnes(input);
        string tensName = "";
        switch (tens)
	    {
            case '0': tensName = "ten"; break;
            case '2': tensName = "twenty"; break;
            case '3': tensName = "thirty"; break;
            case '4': tensName = "forty"; break;
            case '5': tensName = "fifty"; break;
            case '6': tensName = "sixty"; break;
            case '7': tensName = "seventy"; break;
            case '8': tensName = "eighty"; break;
            case '9': tensName = "ninety"; break;
            default: Console.WriteLine("something is wrong with 'SayTens' method");
                break;
	    }
        return tensName;
    }

    private static string AssemblyNumberName(string input)
    {
        StringBuilder numberName = new StringBuilder();
        bool numberIsOneDigit = input.Length == 1;
        if (numberIsOneDigit)
        {
            return numberName.Append(SayDigit(GetOnes(input))).ToString();
        }
        bool isThreeDigit = input.Length == 3;
        //set hundreds name
        if (isThreeDigit)
        {
            bool isfullCentury = (GetTens(input) == '0') && (GetOnes(input) == '0');
            if (isfullCentury)
            {
                return numberName.Append(SayDigit(GetHundreds(input)) + " hundred").ToString();
            }
            else
            {
                numberName.Append(SayDigit(GetHundreds(input)) + " hundred and");
            }
        }
        //set tens name
        bool isTwoOrMoreDigits = input.Length >= 2;
        if (isTwoOrMoreDigits)
        {
            bool hasSpecialCase = GetTens(input) == '1';
            if (hasSpecialCase)
            {
                if (isThreeDigit)
                {
                    return numberName.Append(" " + SaySpecialTens(input)).ToString();
                }
                else
                {
                    return numberName.Append(SaySpecialTens(input)).ToString();
                }
            }
            else
            {
                bool lastDigitIsZero = GetOnes(input) == '0';
                if (lastDigitIsZero)
	            {
                    if (isThreeDigit)
                    {
                        return numberName.Append(" " + SayTens(input)).ToString();
                    }
                    else
                    {
                        return numberName.Append(SayTens(input)).ToString();
                    }
	            }
                else
	            {
                    bool isTwoDigit = input.Length == 2;
                    if (isTwoDigit)
                    {
                        numberName.Append(SayTens(input));
                    }
                    else
                    {
                        numberName.Append(" " + SayTens(input));
                    }
                }
            }
            //set ones name
            numberName.Append(" " + SayDigit(GetOnes(input)));
        }
        return numberName.ToString();
    }

    private static void PronounceNumbersInRange(int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            string number = i.ToString();
            string numberName = AssemblyNumberName(number);
            Console.WriteLine(numberName);
            Thread.Sleep(250);
        }
    }

    static void Main()
    {
        Console.Title = "Pronounce number[0...999]";
        Console.Write("Input number in range[0...999]: ");
        string input = Console.ReadLine();
        Console.WriteLine(AssemblyNumberName(input));
        //PronounceNumbersInRange(9, 199);
    }
}
