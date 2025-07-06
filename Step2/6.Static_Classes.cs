using System;


/// 1. Every member should be static 
/// 2. Instance if you want to call the member
//  3. Cann't pass parameters to the constructor
static class Logger
{
    static string seriesname = "The Summer I Turned Pretty Season 1";
    static string ott = "Amazon Prime";

    static string seriesName {  get; set; }
    static Logger()
    {
        Logger.seriesName = "The Summer I Turned Pretty Season 2";
    }

     static void Actor(string housename, string actorname)
    {
        Console.WriteLine($"[{actorname} Visits {housename}] during summer");
    }

    static void Actor1(string actorname)
    {
        Logger.Actor("Beach House", actorname);
    }

    static void Actor2(string actorname)
    {
        Logger.Actor("LA", actorname);
    }

    static void Actor3(string actorname)
    {
        Logger.Actor("Victoria House", actorname);
    }
    static void Main()
    {
        string str1= Logger.seriesName;
        string str2= Logger.ott;
        Console.WriteLine(str1);
        Console.WriteLine($"The Series Name is: {Logger.seriesname}");
        Console.WriteLine($"The Releasing OTT is: {Logger.ott}");
        Logger.Actor1("Belly");
        Logger.Actor2("Marcus");
        Logger.Actor3("Jermaiah");
    }
}



//using System;

//static class Logger
//{
//    //Fields
//    static string logfile = "application1.txt";
//    static string logFileDescription = "You have logged in the App At July-07-2025 at 9:07PM";
//    static string LogFile { get; set; }

//    static Logger()
//    {
//        Logger.LogFile = "application2.txt";
//    }

//    static void LogMessage(string Level, string Message)
//    {
//        Console.WriteLine($"{DateTime.Now} [{Level} - {Message}]");
//    }

//    static void LogInfo(string Message)
//    {
//        Logger.LogMessage("INFO", Message);
//    }

//    static void LogWarning(string Message)
//    {
//        Logger.LogMessage("Warning", Message);
//    }

//    static void LogError(string Message)
//    {
//        Logger.LogMessage("Error", Message);
//    }

//    static void Main()
//    {
//        string str1 = Logger.logfile;
//        string str2 = Logger.logFileDescription;
//        // Console.WriteLine($"Log file name is {Logger.logfile}");
//        //  Console.WriteLine($"Log file name is {Logger.logFileDescription}");

//        Logger.LogInfo("Application started");
//        Logger.LogWarning("You have entered the wrong password three times. If you enter it incorrectly again, your account will be locked for at least one hour");
//        Logger.LogError("Something is Wrong...Please try again after sometime.");


//        Logger.LogInfo("Application stopped.");

//    }



//}