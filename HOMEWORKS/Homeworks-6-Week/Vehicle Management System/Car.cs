using System;

namespace Vehicle_Management_System;

public class Car : Vehicle
{
    public Car(string make, string model, int year, int numberOfDoors) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }
    public int NumberOfDoors { get; set; }

    public override void VehicleInformation()
    {
        base.VehicleInformation();
        System.Console.WriteLine($"Kapı Sayısı: {NumberOfDoors}");
    }
}
