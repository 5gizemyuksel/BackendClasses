namespace Employee_Management_System;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Gizem", 05, 60000);
        employee.EmployeeInformation();

        System.Console.WriteLine("********************");
        System.Console.WriteLine();
        System.Console.WriteLine();

        Manager manager = new Manager("Gizem", 05, 60000, 50);
        manager.EmployeeInformation();

        System.Console.WriteLine("********************");
        System.Console.WriteLine();
        System.Console.WriteLine();

        Developer developer = new Developer("Gizem", 05, 60000, "C#");
        developer.EmployeeInformation();

        System.Console.WriteLine("********************");
        System.Console.WriteLine();
        System.Console.WriteLine();

        Intern ıntern = new Intern("Gizem", 05, 60000);
        ıntern.EmployeeInformation();






    }
}
