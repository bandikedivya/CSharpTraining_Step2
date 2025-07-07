using System;

namespace CollegeProject
{
    public class CSEProject
    {
        //static fields
        public static string ProjectLead = "Luke";
        public static string Developer = "Noah";


        //static method
        public static void CallProjectLead()
        {
            Console.WriteLine($"Calling Project Lead: {CSEProject.ProjectLead} ");

        }

        //Non-static member
        //Non-static properties
        public string TeamMember1 {  get; set; }
        public string TeamMember2 { get; set; }

        public CSEProject(string teammember1, string teammember2)
        {
            this.TeamMember1 = teammember1;
            this.TeamMember2 = teammember2;
        }

        public void CallTeamMember1()
        {
            Console.WriteLine($"Calling Teammember1: {this.TeamMember1}");
        }

        public void CallTeamMember2()
        {
            Console.WriteLine($"Calling Teammember2: {this.TeamMember2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Static method calling directly
            CSEProject.CallProjectLead();
            string str = CSEProject.Developer;
            Console.WriteLine($"Developer in my project is: {str}");


            //Non-static method calling through instance
            CSEProject cseproject = new CSEProject("Sophia", "Finn");
            cseproject.CallTeamMember1();
            cseproject.CallTeamMember2();

        }
    }
}