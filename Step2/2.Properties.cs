using System;

class StudentResume
{
    string filename = "Dev_Resume.docs";
    string filelocation = @"D:\Students\Resumes";
    string filesize = "2Kb";
    string createdDate = "Mar-01-2025";
    DateTime createdDateTime = DateTime.Now;


    //Attributes or Accessors
    string FileName {  get; set; }
    string FileLocation {  get; set; }
    string FileSize { get; set; }   
    string CreatedDate { get; set; }
    
    

    static void Main()
    {
        StudentResume studentResume = new StudentResume();
        studentResume.FileName = "Mohan_Resume.docs";
        studentResume.FileLocation = "C:\\Downloads\\Resume";
        studentResume.FileSize = "15kb";
        studentResume.CreatedDate = "July-04-25";

        Console.WriteLine($"File Name is {studentResume.FileName}, File Location is {studentResume.FileLocation}");


    }

}