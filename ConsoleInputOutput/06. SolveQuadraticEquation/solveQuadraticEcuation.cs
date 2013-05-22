using System;

class SolveQuadraticEcuation
{
    static void Main()
    {
        double a = 4;
        double b = 5;
        double c = 3;
        double x1;
        double x2;
        //Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a

        //Calculate the inside of the square root
        double discriminant = (b * b) - 4 * a * c;

        if (discriminant < 0)
        {
            //There is no solution
            x1 = double.NaN;
            x2 = double.NaN;
        }
        else
        {
            //Compute the value of each x
            //if there is only one solution, both x's will be the same
            double sqrt = Math.Sqrt(discriminant);
            x1 = (-b + sqrt) / (2 * a);
            x2 = (-b - sqrt) / (2 * a);
        }
        Console.WriteLine("Roots: \nx1: {0}\nx2: {1}", x1, x2);
    }
}
