using System;

namespace Vehicle_Management_System;

public class Vehicle
{
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public virtual void VehicleInformation()
    {
        System.Console.WriteLine($"Marka: {Make}\nModel: {Model}\nÜretim Yılı: {Year}");
    }
}
