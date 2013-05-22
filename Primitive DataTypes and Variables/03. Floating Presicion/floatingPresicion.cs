using System;

class FloatingPresicion

            /*Write a program that safely compares
             * floating-point numbers
             * with precision of 0.000001.
             * Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true*/
    {
        static void Main()
        {
            double expected = 0.0000003;
            double actual = 0.0000001;
            
            //for a precision of 6
            int precision = 6;
            expected *= Math.Pow(10, (double)precision);
            long integralExpected = (long)Math.Truncate(expected);
            actual *= Math.Pow(10, (double)precision); ;
            long integralActual = (long)Math.Truncate(actual);

            bool areEquals;
            if (integralExpected.Equals(integralActual))
            {
                areEquals = true;
            }
            else
            {
                areEquals = false;
            }
            Console.WriteLine(areEquals);
        }
    }
