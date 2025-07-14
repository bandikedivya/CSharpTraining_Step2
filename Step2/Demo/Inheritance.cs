using System;
using System.Globalization;

namespace Inheritance
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        
        public string MobileNum { get; set; }

        public User(string name, string email, string password, string mobilenum)
        {
            Name = name;
            Email = email;
           
            MobileNum = mobilenum;
        }

        public User(string name, string email, string mobilenum)
        {
            Name = name;
            Email = email;
            MobileNum = mobilenum;
        }

        public void Login()
        {
            Console.WriteLine($"{Name} logged in Successfully");
        }
    }
    public class TCSRegistration : User
    {
        public TCSRegistration(string name, string email, string mobilenum) : base(name, email,  mobilenum)
        {
        }
        public void TCSRegistrationProcess()
        {
            Console.WriteLine($"{Name} Completed TCS Registartion Successfully");
        }
    }
    public class AccentureRegistration : User
    {
        public AccentureRegistration(string name, string email, string mobilenum) : base(name, email, mobilenum)
        {
        }
        public void AccentureRegistrationProcesss()
        {
            Console.WriteLine($"{Name} Completed Accenture Registartion Successfully");
        }
    }
    class Program
    {
        static void Main()
        {
            TCSRegistration tcs = new TCSRegistration("Kim", "kim@gmail.com", "+919876543210");
            tcs.Login();
            tcs.TCSRegistrationProcess();


            //AccentureRegistration accenture = new AccentureRegistration("Kim", "kim@gmail.com", "kim@123", "+919876543210");
            //accenture.Login();
            //accenture.AccentureRegistrationProcesss();


            AccentureRegistration accenture = new AccentureRegistration("Rahul", "rahul@gmail.com","+919123567489");
            accenture.Login();
            accenture.AccentureRegistrationProcesss();
        }
    }
}