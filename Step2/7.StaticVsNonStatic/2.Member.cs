using System;
namespace StaticAndNonStaticInstatiate
{
    public static class StaticRestaurantLogger
    {
       public static int ChefList = 0;


        /// <summary>
        ///  Log message is for print the Message as well as increase +1 the value
        ///  Example : Incase EmployeesList is 2 then it will return 3
        /// </summary>
        /// <param name="message"></param>
        /// 
        public static void Joinedrestaurant(string message)
        {
            Console.WriteLine($"{message} Joined Restaurant on {DateTime.Now}");
            ChefList = ChefList + 1;
        }
        public static int GetChefListCount()
        {
            return ChefList; // returns the latest chef list count
        }

    }
    public  class NonStaticRestaurantLogger
    {
        public static int ChefList = 0;


        /// <summary>
        ///  Log message is for print the Message as well as increase +1 the value
        ///  Example : Incase EmployeesList is 2 then it will return 3
        /// </summary>
        /// <param name="message"></param>
        /// 
        public void Joinedrestaurant(string message)
        {
            Console.WriteLine($"{message} Joined Restaurant on {DateTime.Now}");
            ChefList = ChefList + 1;
        }
        public  int GetChefListCount()
        {
            return ChefList; // returns the latest chef list count
        }

    }
    class Program
    {
        static void Main()
        {
            StaticRestaurantLogger.Joinedrestaurant("Master1 ");
            StaticRestaurantLogger.Joinedrestaurant("Master2 ");
            StaticRestaurantLogger.Joinedrestaurant("Master3 ");
            StaticRestaurantLogger.GetChefListCount();
            Console.WriteLine($"Total number of Chefs joined in my restaurant: {StaticRestaurantLogger.GetChefListCount()} ");


            NonStaticRestaurantLogger nonStaticRestaurantLogger = new NonStaticRestaurantLogger();
            nonStaticRestaurantLogger.Joinedrestaurant("Master1 ");
            nonStaticRestaurantLogger.Joinedrestaurant("Master2 ");
            nonStaticRestaurantLogger.Joinedrestaurant("Master3 ");
            Console.WriteLine($"Total number of Chefs joined in my restaurant:{nonStaticRestaurantLogger.GetChefListCount()}");






        }
    }
}