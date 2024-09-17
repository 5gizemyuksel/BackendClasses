using System;

namespace Employee_Management_System;

public class Developer : Employee
{
    public Developer(string name, int ıd, decimal salary, string programmingLanguage) : base(name, ıd, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public string ProgrammingLanguage { get; set; }

    public override void EmployeeInformation()
    {
        base.EmployeeInformation();
        System.Console.WriteLine($"Programlama Dili: {ProgrammingLanguage}");
    }
}
