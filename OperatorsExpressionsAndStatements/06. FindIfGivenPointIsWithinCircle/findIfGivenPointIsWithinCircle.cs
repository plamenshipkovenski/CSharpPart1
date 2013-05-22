using System;

class findIfGivenPointIsWithinCircle
{
    static bool CheckIfPointIsWithinCircle(int pointX,
                                            int pointY,
                                            int circleCenterX,
                                            int circleCenterY,
                                            int circleRadius)
    {
        //In general, x and y must satisfy (x-center_x)^2 + (y - center_y)^2 < radius^2.
        bool isWithinCircle = circleRadius * circleRadius >=  
                                (pointX - circleCenterX) * (pointX - circleCenterX) +   
                                (pointY - circleCenterY) * (pointY - circleCenterY);
        return isWithinCircle;
    }
    static void Main()
    {
        int pointX = 10;
        int pointY = 0;
        int circleCenterX = 0;
        int circleCenterY = 0;
        int circleRadius = 10;

        if (CheckIfPointIsWithinCircle(pointX, pointY, circleCenterX, circleCenterY, circleRadius))
        {
            Console.WriteLine("point P({0}, {1}) is within circle K({2}, {3}, {4})", pointX, pointY, circleCenterX, circleCenterY, circleRadius);
        }
        else
        {
            Console.WriteLine("point P({0}, {1}) is out of circle K({2}, {3}, {4})", pointX, pointY, circleCenterX, circleCenterY, circleRadius);
        }
    }
}
