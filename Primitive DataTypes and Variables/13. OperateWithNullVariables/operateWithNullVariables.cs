using System;

class OperateWithNullVariables
{
    static void Main()
    {
        int? num1 = null;
        double? num2 = null;
        Console.WriteLine("____{0}____{1}_____", num1, num2);
        num1 = 5;
        num2 = 5.5;
        Console.WriteLine("____{0}____{1}_____", num1, num2);
        int? num3 = null;
        num1 += num3;
        Console.WriteLine("____{0}____{1}_____", num1, num2);
    }
}
