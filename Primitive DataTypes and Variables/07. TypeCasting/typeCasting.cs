using System;

class TypeCasting
{
    //Casting and Type Conversions http://msdn.microsoft.com/en-us/library/ms173105.aspx
    static void Main()
    {
        string str1;
        string str2;
        object obj;
        string str;

        str1 = "Hello";
        str2 = "World";
        obj = str1 + " " + str2;
        str = obj.ToString();

        Console.WriteLine(str);
    }
}
