using System;

namespace _02.CalcPerimeterAndAreaOfCircle
{
    class CalcPerimeterAndAreaOfCircle
    {
        static void Main()
        {
            Console.Title = "Calculate area and perimeter of circle";
            Console.Write("Input radius: ");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius);

            Console.WriteLine("Area: {0}\nPerimeter: {1}", circle.CalcArea(circle.Radius), circle.CalcPerimeter(circle.Radius));
        }
    }
}
