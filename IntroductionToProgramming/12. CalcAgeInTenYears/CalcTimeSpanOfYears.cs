using System;

namespace _12.CalcAgeInTenYears
{
    internal class CalcTimeSpanOfYears
    {
        //http://pastebin.com/AWaCtYyC
        private static int ConvertDaysToYears(TimeSpan ofDays)
        {
            //TO DO: solve leap years
            const int tottalDays = 365;
            int years = (int)ofDays.TotalDays / tottalDays;

            return years;
        }

        public static void Main()
        {
            PrintInitialMessage();
            const int day = 1;
            const int month = 1;
            int inputYears = GetInput();
            var timeSpanOfDays = CalcTimeDistance(
                years: inputYears,
                month: month,
                day: day);
            int timeSpanOfYears = ConvertDaysToYears(
                ofDays: timeSpanOfDays);
            FinalPrint(timeSpanOfYears);            
        }

        private static void FinalPrint(int years)
        {
            string effect = "";
            string value = "";
            if (years == 0)
            {
                effect = "no effect on";
            }
            if (years > 0)
            {
                effect = "added " + years;
                value = "to";
            }
            if (years < 0)
            {
                effect = "substract" + years;
            }
            Console.WriteLine("This program has {0} years {1} your age", effect, value);
        }

        private static void PrintInitialMessage()
        {
            Console.Write("How years old are you? : \n");
        }

        private static int GetInput()
        {
            //TO DO: exepiton handling
            bool hasInput = false;
            string input;
            var inputYear = new int();
            while (!hasInput)
            {
                try
                {
                    input = Console.ReadLine();
                    if (input != null)
                    {
                        try
                        {
                            inputYear = int.Parse(input);
                            hasInput = true;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.Write("Please, retype your age here: ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("jfl;sa37578374");
                    }
                    //trow exeption IndexOutOfRangeExeption
                    //max value = 996
                    //min value = -2007
                }
                finally
                {
                }
            }
            return inputYear;
        }

        private static TimeSpan CalcTimeDistance(int years, int month, int day)
        {
            const int value = 10;
            int startValue = DateTime.Now.Year;
            int startPointMonth = DateTime.Now.Month;
            int startPointDay = DateTime.Now.Day;
            int backTimeYear = startValue - years;

            DateTime leftPointYear = new DateTime(
                backTimeYear,
                month,
                day);
            DateTime yearNow = new DateTime(
                startValue,
                startPointMonth,
                startPointDay);

            DateTime futureYear = yearNow.AddYears(value);

            TimeSpan timeDistanceInDays = futureYear - leftPointYear;
            return timeDistanceInDays;
        }    
    }
}
