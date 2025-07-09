using InterfaceInheticanceBasics;
using System;

namespace InterfaceInheticanceBasics
{

    interface IGmail
    {
        string EmailId { get; set; }
        string MobileNumber { get; set; }
        string Password { get; set; }

        void ShowDetails();

        string EmailNumber(string EmailId, string MobileNumber);
    }
     interface IChrome
    { 
    
        void EmailPassword(string EmailId, string Password);
    }
}

    interface IFacebook
    {
        void Facebook(string EmailId, string Password);
    }

    
    //class Bgmi: IGmail, IChrome,IFacebook
    //{
    //    //string LoginCredentials(string EmailId, string Password);
    //}

    



//interface Interface1
//{
//    int property1 { get; set; }
//    int Method1();

//    string Method2();
//    string Method3(int a, int b);

//}

//interface Interface3
//{
//    string Method4();

//}

////one interface can inherite from multiple class
//interface Interface2 : Interface1, Interface3
//{
//    string Method5();
//}