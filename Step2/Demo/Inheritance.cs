using System;


namespace UserCompanyRegistartion
{
    public class User //Parent or base class
    {

        //These are public properties for name, email, and mobile number, allowing both reading and writing.
        public string Name { get; set; }       
        public string Email { get; set; }        

        public string MobileNum { get; set; }

        // Constructor for creating User objects and initializing the above properties with values passed in.
        public User(string name, string email, string mobilenum)          
        {
            Name = name;
            Email = email;
            MobileNum = mobilenum;
        }
        //A method of base class that prints a login-success message.
        public void Login()
        {
            Console.WriteLine($"{Name} logged in Successfully");
        }
    }



    //Derived Class 1:

    //Declares a class TCSRegistration that inherits from User(base class), gaining all its properties and methods.
    public class TCSRegistration : User
    {

        //A constructor for TCSRegistration that calls the base class constructor (: base(...)) to set inherited properties.
        public TCSRegistration(string name, string email, string mobilenum) : base(name, email,  mobilenum)
        {
        }

        //Derived class direct method that prints a registration completion message.
        public void TCSRegistrationProcess()
        {
            Console.WriteLine($"{Name} Completed TCS Registartion Successfully");
        }
    }

    //Derived class 2:

    //Similar to TCSRegistration, this class also inherits from User.
    public class AccentureRegistration : User
    {

        //Again, calls the base constructor to initialize properties.
        public AccentureRegistration(string name, string email, string mobilenum) : base(name, email, mobilenum)
        {
        }

        //Direct method which prints a registration completion successful,
        public void AccentureRegistrationProcesss()
        {
            Console.WriteLine($"{Name} Completed Accenture Registartion Successfully");
        }
    }
    class Program
    {
        //This is the program's starting point.
        static void Main()
        {
            Console.WriteLine("*****************User Registration********************");
            TCSRegistration tcs = new TCSRegistration("Sophia", "sophia@gmail.com", "+919876543210");
            tcs.Login();  //inherited method
            tcs.TCSRegistrationProcess();   //own method


            //AccentureRegistration accenture = new AccentureRegistration("Sophia", "sophia@gmail.com", "+919876543210");
            //accenture.Login();
            //accenture.AccentureRegistrationProcesss();


            AccentureRegistration accenture = new AccentureRegistration("Rahul", "rahul@gmail.com","+919123567489");
            accenture.Login(); //inherited method
            accenture.AccentureRegistrationProcesss();   //own method
        }
    }
}