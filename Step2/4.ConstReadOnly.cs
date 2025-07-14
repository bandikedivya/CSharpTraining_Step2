// Constand and Readonly are the keywords in c#, which is used to make values static position


using System;

class ConstReadOnly

{

    const int a = 10; // For constant, we must assign a value
                      //const int i;  ---gives compile time error

    const string name = "Jermaiah";

    readonly string releasedate = "16-June-2025"; //Readonly can or can not assign a value. It can be reassigned to another value only in constructor.

    readonly double b; // it is not assigned to a value

    public ConstReadOnly()
    {
        // a = 14; //throws error, as it is assigned to a value by using const keyword
        //name = "marcus";  // throws error, as it is assigned to a value by using const keyword

       releasedate = "16-July-2025 ";
    }
    static void Main()
    {
       ConstReadOnly constReadOnly = new ConstReadOnly();
        Console.WriteLine(a); //10
        Console.WriteLine(name); //Jermaiah
        Console.WriteLine(constReadOnly.releasedate); // 16-June-2025
        Console.WriteLine(constReadOnly.b); //0, as it not assigned to a value.

    }
}