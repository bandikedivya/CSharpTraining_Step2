using System;
using System.Data;
using System.Xml.Linq;

abstract class Manufacturer
{
    public string EmpName { get; set; }
    public int HoursWorked { get; set; }
    public double HourlyRate { get; set; }
    public abstract void Location();

    public abstract void GetSalary();

    public void EmpDetails()
    {
        Console.WriteLine($"Employee Name: {EmpName}");
        Console.WriteLine($"Hours Worked: {HoursWorked}");
        Console.WriteLine($"Hourly Rate: {HourlyRate}");
    }

    public virtual double CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }


    class PermanentEmp : Manufacturer
    {
        public override double CalculateSalary()
        {
            double baseSalary = HoursWorked * HourlyRate;
            double bonus = baseSalary * 0.2; // 20% bonus
            return baseSalary + bonus;
        }

        public override void GetSalary()
        {
            Console.WriteLine("Salary Credited");
        }

        public override void Location()
        {
            Console.WriteLine("My Location is Hyd");
        }

    }
    class ContractEmployee : Manufacturer
    {
        public override double CalculateSalary()
        {
            double baseSalary = HoursWorked * HourlyRate;
            double deductions = baseSalary * 0.1; // 10% deductions
            return baseSalary - deductions;
        }

        public override void GetSalary()
        {
            Console.WriteLine("Salary Credited");
        }

        public override void Location()
        {
            Console.WriteLine("My Location is Bng");
        }
    }

    class Program
    {
        static void Main()
        {
            //Manufacturer manufacturer = new Manufacturer();
            Manufacturer pcompany = new PermanentEmp()
            {
                EmpName = "Justin",
                HourlyRate = 2,
                HoursWorked = 10

            };
            
            pcompany.Location();
            pcompany.GetSalary();
            pcompany.EmpDetails();
            Console.WriteLine($"Salary is: {pcompany.CalculateSalary()}");

            Manufacturer contract = new ContractEmployee()
            {
                EmpName = "Marcus",
                HourlyRate = 5,
                HoursWorked = 15
            };
            
            contract.Location();
            contract.GetSalary();
            contract.EmpDetails();
            Console.WriteLine($"Salary is: {contract.CalculateSalary()}");
        }
    }
}
