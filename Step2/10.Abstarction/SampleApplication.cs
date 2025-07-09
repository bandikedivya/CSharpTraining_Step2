using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace SampleApplication
{
    // Rule + method Implementation
    abstract class BankApp
    {
        public string CustomerName { get; set; }
        public string CustomerEmailID { get; set; }
        public abstract void Login();
        public abstract void Logout();



        //public void CustomerDetails(string name, string email)
        //{
        //    //this.CustomerName = name;
        //    //this.CustomerEmailID = email;
        //    Console.WriteLine($"Customer Name is: {name} and Customer Email ID is: {email}");
        //}


        public void ShowCustomerDetails()
        {
            Console.WriteLine($"[Customer Name]: {CustomerName} , [Customer Email ID] : {CustomerEmailID}");
        }

        //public void ShowEmail()
        //{
        //    Console.WriteLine($"Customer Email ID is: {CustomerEmailID}");
        //}





        //Concrete Method(Normal Method)
        //Derived Class (Child Class) - Both are same
        // Should use "override" keyword when we want to abstract the dervied class from abstract class
        class CreditCard : BankApp
        {
            public override void Login()
            {
                Console.WriteLine("Customer has logged in to the Bank App and Viewed Credit Card Option");
            }

            public override void Logout()
            {
                Console.WriteLine("Customer has logged out from the Bank App");
            }


            //Direct Methods
            public void ShowCreditCardOptions()
            {
                Console.WriteLine("Welcome to Credit Card Options, Check your Credit Score and Apply");
            }

            public void AppliedCreditCard()
            {
                Console.WriteLine("You have applied for Credit Card, Your application is being processed. Thank you for applying Credit Card..");
            }
        }



        class DebitCard : BankApp
        {
            public override void Login()
            {
                Console.WriteLine("Customer has logged in to the Bank App and Viewd Debit Card Option");
            }

            public override void Logout()
            {
                Console.WriteLine("Customer has logged out from the Bank App");
            }

            public void ShowDebitCardOptions()
            {
                Console.WriteLine("Welcome to Debit Card Options, Apply and Complete KYC Online to get Debit Card..");
            } 
            public void ApplyDebitCard()
            {
                Console.WriteLine("You have applied for Debit Card, Your application is being processed. Thank you for applying Debit Card..");
            }
        }
        //1. For Abstract class, we cannot create instance,
        //2. But Abstarct class , we can refer to the child or derived class
        class Program
        {
            static void Main()
            {
                BankApp app = new CreditCard()
                {
                    CustomerName = "Justin",
                    CustomerEmailID = "justin1234@gmail.com"
                };
                
                app.Login();
                app.ShowCustomerDetails();
                CreditCard appCreditCard = new CreditCard();
                appCreditCard.ShowCreditCardOptions();
                appCreditCard.AppliedCreditCard();
                app.Logout();


                //app.CustomerName = "Divya";
                //app.CustomerEmailID = "12345";
                //app.CustomerDetails("abc", "1234");



                //app.ShowCustomerDetails();

                BankApp debitcard = new DebitCard()

                {
                    CustomerName = "Jermaiah",
                    CustomerEmailID = "jermaiah@gmail.com"

                };
                
                debitcard.Login();

                debitcard.ShowCustomerDetails();
                DebitCard debit = new DebitCard();
                debit.ShowDebitCardOptions();
                debit.ApplyDebitCard();

                debitcard.Logout();
                

               

            }
        }
    }
}




//using System;

//namespace VehicleConfigurationSystem
//{


//    // Rule +  methodImplemention
//    abstract class Vechile
//    {
//        public string FuelType { get; set; }
//        public int Capacity { get; set; }

//        public abstract void Start();

//        public abstract void Stop();

//        public abstract void Engine();


//        //Concrete methods
//        public void ShowDetails()
//        {
//            Console.WriteLine($"Fuel Type: {FuelType}");
//            Console.WriteLine($"Capacity: {Capacity} passengers");
//        }

//    }


//    //Derive Class  or Child Class

//    class Car : Vechile
//    {
//        public override void Start()
//        {

//            Console.WriteLine("Car is starting with a key ignition.");
//        }

//        public override void Stop()
//        {
//            //throw new NotImplementedException();
//            Console.WriteLine("Car has stopped .");
//        }

//        public override void Engine()
//        {
//            Console.WriteLine("Car engine is a 4-cylinder petrol engine.");
//        }


//        public void CarPurcahseDateandTime()
//        {
//            Console.WriteLine("12-06-2024:12:35:00");
//        }

//    }



//    class Bike : Vechile
//    {
//        public override void Engine()
//        {
//            //throw new NotImplementedException();
//        }

//        public override void Start()
//        {
//            //throw new NotImplementedException();
//        }

//        public override void Stop()
//        {
//            //   throw new NotImplementedException();
//        }
//    }

//    class Program
//    {
//        public static void Main()
//        {

//        }
//    }


//}