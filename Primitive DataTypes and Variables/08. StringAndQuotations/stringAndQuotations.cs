using System;

class StringAndQuotations
{
    static void Main()
    {
        string str1;
        string str2;

        str1 = "The \"use\" of quotations causes difficulties.";
        str2 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("str1: {0}", str1);
        Console.WriteLine("str2: {0}", str2);
    }
}
