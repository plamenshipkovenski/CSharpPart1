using System;

class CheckIfPointIsWithinCircleAndOutOfRectangle
{
    static void Main()
    {
        int pointX = 3;
        int pointY = 0;

        int circleCenterX = 1;
        int circleCenterY = 1;
        int circleRadius = 3;

        int rectTopLeftX = -1;
        int rectTopLeftY = 1;
        int rectWidth = 6;
        int rectHeight = 2;
        int rectBottomRightX = rectTopLeftX + rectWidth;
        int rectBottomRightY = rectTopLeftY - rectHeight;

        bool isOutOfRect = (pointX < rectTopLeftX || rectBottomRightX < pointX) || 
                            (pointY < rectBottomRightY || rectTopLeftY < pointY);
        bool isWithinCircle = circleRadius * circleRadius >=
                                (pointX - circleCenterX) * (pointX - circleCenterX) +
                                (pointY - circleCenterY) * (pointY - circleCenterY);
        bool bothConditionsMatches = isOutOfRect && isWithinCircle;

        //Console.WriteLine(isWithinCircle);
        //Console.WriteLine(isOutOfRect);
        Console.WriteLine(bothConditionsMatches);
    }
}
