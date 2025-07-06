
using System;

namespace StaticAndNonStaticInstatiate
{
    public static class StaticClass
    {
        public static void Static()
        {
            // string text = "This is a static class method";
            Console.WriteLine("This is a static class method");
        }
    }
    public class NonStaticClass
    {

        public void NonStaticClassWithNonStaticMethod()
        {
            string text1 = "This is a non static class, non static method which requires instance to call in the main method";
            Console.WriteLine(text1);
        }

        public static void NonStaticClassWithStaticMethod()
        {
            string text2 = "This is a non static class, static method which requires instance to call in the main method";
            Console.WriteLine(text2);
        }
    }
   
    public class MainProgram
    {
        public static void Main()
        {
            StaticClass.Static();


            NonStaticClass nonStaticClass = new NonStaticClass();
            nonStaticClass.NonStaticClassWithNonStaticMethod();

            NonStaticClass.NonStaticClassWithStaticMethod();



            


        }


    }
}