using System;
using System.Xml.Schema;
namespace MathCalculation
{
    class Calculation
    {
        const int length = 20;
        const int breadth = 10;
        const int height = 10;
        const double radius = 5;
        const double pi = 3.143;

        //we cannot reassign constant values in constructor
        public Calculation()
        {
            //length = 20;//throws error as it is assigned using const keyword
        }
        public static string Square()
        {
            int areaofsquare = length * length;
            return $"Area of Square: {areaofsquare} cm";
        }

        public static string Rectangle()
        {
            int areaofrect = length * breadth;
            return $"Area of Rectangle: {areaofrect} cm";
        }

        public static string Circle()
        {
            double areaofcircle = pi * radius * radius;
            return $"Area of Circle: {areaofcircle} cm";
        }
        static void Main()
        {
            Console.WriteLine(Square());
            Console.WriteLine(Rectangle());
            Console.WriteLine(Circle());
        }
    }
}