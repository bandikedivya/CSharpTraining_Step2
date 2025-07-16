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
        //readonly fields with declared without assigning value
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
           

            Console.WriteLine($"Calling constant value and The Student Roll No: {StudentRollNo}");
            Console.WriteLine($"Calling constant value and The Student DOB: {DOB}");

            CollegeRegistration student1 = new CollegeRegistration();
            Console.WriteLine($"Calling readonly value and The Student's Updated Name: {student1.StudentName}");
            Console.WriteLine($"Calling readonly value and The Age of the Student: {student1.Age}");
            Console.WriteLine($"Calling readonly value and The Father Name: {student1.FatherName}");
            Console.WriteLine($"Calling readonly value and The Student's Department: {student1.Department}");



        }
    }
}
