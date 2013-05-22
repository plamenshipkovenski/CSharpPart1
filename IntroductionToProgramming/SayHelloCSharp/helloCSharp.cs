using System;

class HelloCSharp
{
    static string greetingReciever = "C#";

    internal static void SayHelloTo(string reciever)
    {
        Console.WriteLine("Hello {0}!", reciever);
    }

    public static void Main()
    {
        SayHelloTo(greetingReciever);
    }
}
