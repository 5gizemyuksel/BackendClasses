using System;

namespace Employee_Management_System;

public class Employee
{
    public Employee(string name, int ıd, decimal salary)
    {
        Name = name;
        Id = ıd;
        Salary = salary;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary { get; set; }

    public virtual void EmployeeInformation()
    {
        System.Console.WriteLine($"İsim: {Name}\nKimlik Numarası: {Id}\nMaaş: {Salary}");
    }


}
