using System;

class FileDetailsConstructors
{
    string filename = "Student1_Resume.docx";
    string filelocation = @"D:\Students\Resumes";
    string filesize = "2Kb";
    string createddate = "Mar-01-2024";

    DateTime createdDateTime = DateTime.Now;

    public FileDetailsConstructors()
    {

        Console.WriteLine("File object created");

        this.filename = "Employee1_Salary.pdf";
        this.filelocation = @"C:\Employees\Salaries";
        this.filesize = "1Kb";
        this.createddate = "Jan-01-2025";
        this.createdDateTime = DateTime.Now;


        Console.WriteLine(this.filename);
        Console.WriteLine(this.filelocation);
        Console.WriteLine(this.filesize);
        Console.WriteLine(this.createddate);
    }

    public FileDetailsConstructors(string filename,string filelocation, string filesize, string createddate)
    {

        Console.WriteLine("File object created");

        this.filename = "Employee1_Salary.pdf";
        this.filelocation = @"C:\Employees\Salaries";
        this.filesize = "1Kb";
        this.createddate = "Jan-01-2025";
        this.createdDateTime = DateTime.Now;


        Console.WriteLine(this.filename);
        Console.WriteLine(this.filelocation);
        Console.WriteLine(this.filesize);
        Console.WriteLine(this.createddate);
    }
    static void Main()
    {
        FileDetailsConstructors fileDetailsConstructors = new FileDetailsConstructors();
        fileDetailsConstructors.filename = "Divya_Resume.docs";
        Console.WriteLine($"Filename is: {fileDetailsConstructors.filename}");
        FileDetailsConstructors fileDetailsConstructors1 = 
            new FileDetailsConstructors("Justin_Resume.docs", "c:\\", "3kb", "Mar-04-22");
    }
}