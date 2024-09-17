using System;

namespace Employee_Management_System;

public class Manager : Employee
{
    public Manager(string name, int ıd, decimal salary,int numberOfTeams) : base(name, ıd, salary)
    {
        NumberOfTeams=numberOfTeams;
    }

    public int NumberOfTeams { get; set; }

    public override void EmployeeInformation()
    {
        base.EmployeeInformation();
        System.Console.WriteLine($"Takım Sayısı: {NumberOfTeams}");
    }
}
