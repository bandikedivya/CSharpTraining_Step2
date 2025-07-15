using System;

namespace ConstAndReadOnly
{
    class CollegeRegistration
    {
        // const fields 
        public const string StudentRollNo = "18781A0512";
        public const string DOB = "30-01-2000";

        // readonly fields
        public readonly string StudentName = "Sebastian";
        public readonly int Age;
        public readonly string FatherName;
        public readonly string Department;

        // Constructor
        // readonly fields (assigned and reassigned via constructor)
        public CollegeRegistration()
        {
            StudentName = "Sebastian Henry";
            FatherName = "Henry";
            Department = "Mechanical Engineering";
            Age = 20;
        }

       
        // Main method
        static void Main()
        {
           

            Console.WriteLine($"Calling constant value: {StudentRollNo}");
            Console.WriteLine($"Calling constant value: {DOB}");

            CollegeRegistration student1 = new CollegeRegistration();
            Console.WriteLine($"Calling readonly value: {student1.StudentName}");
            Console.WriteLine($"Calling readonly value: {student1.Age}");
            Console.WriteLine($"Calling readonly value: {student1.FatherName}");
            Console.WriteLine($"Calling readonly value: {student1.Department}");



        }
    }
}
