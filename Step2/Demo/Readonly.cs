using System;
namespace ReadOnly
{
    class CollegeRegistration
    {
        readonly string StudentName = "Sebastian";
        readonly string StudentRollNo = "18781A0512";
        readonly int Age;  //We can add field without assigning to a variable
        readonly string FatherName = "Henry";
        readonly string Department = "Computer Science Engineering";
        readonly string DOB = "30-01-2000";

        //We can reassign readonly value in Constructor
        public CollegeRegistration()
        {
             StudentName = "Sebastian Henry"; 
             Department = "Mechanical Engineering";
             Age = 20;
        }

        static void Main()
        {
            CollegeRegistration collegeRegistration = new CollegeRegistration();    
            Console.WriteLine(collegeRegistration.StudentName);
            Console.WriteLine(collegeRegistration.StudentRollNo);
            Console.WriteLine(collegeRegistration.Age);
            Console.WriteLine(collegeRegistration.DOB);
            Console.WriteLine(collegeRegistration.FatherName);
            Console.WriteLine(collegeRegistration.Department);
        }










    }
}
