using System;
using System.Globalization;
using System.Text;
using System.Threading;

class UseInfoAboutCompanyAndManager
{
    static void Main()
    {
        string companyName = "Rakia.LTD";
        string companyAdress = "Sungurlare sity, blvd \"Main boulevard\" 34";
        string companyPhoneNum = "+359/66-666";
        string companyWebSite = "https://www.rakia.net";
        string managerFirstName = "Petar";
        string managerLastName = "Grozdanoff";
        string companyManager = managerFirstName + " " + managerLastName;
        byte managerAge = 42;
        string managerPhoneNum  = "+359/77-777";

        Console.Title = "This is not a joke";
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 70;
            Console.WriteLine(@"
        Dear {0},

        You have been randomly choosen by {1} to visit us

    at {2} and be a part of 

    our ""Every month head off competition""!!!For more info

    visit: {3}

    Best Regards! {4}                    {5:D}
    ", "Lucky Customer", companyName, companyAdress, companyWebSite, companyManager, DateTime.Now);
        Console.WriteLine("{0, -10}{1, 60}",companyName, "Manager");
        Console.WriteLine("{0, 10}{1, 29}", companyAdress, companyManager);
        Console.WriteLine("{0, -10}{1, 59}", companyPhoneNum, managerPhoneNum);
    }
}
